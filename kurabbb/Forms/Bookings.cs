using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Npgsql;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurabbb.Forms
{
    public partial class Bookings : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        private readonly int roomId;
        private int userId;
        public Bookings(int roomId, int userId)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.userId = userId;
            LoadServices();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            if (dtCheckOut.Value <= dtCheckIn.Value)
            {
                MessageBox.Show("Дата выезда должна быть позже даты заезда.");
                return;
            }
            try
            {
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                // 1. Получаем цену номера
                var priceCmd = new NpgsqlCommand("SELECT price_per_night FROM infhotel.rooms WHERE room_id = @id", conn);
                priceCmd.Parameters.AddWithValue("id", roomId);
                decimal roomPrice = Convert.ToDecimal(priceCmd.ExecuteScalar());

                int nights = (dtCheckOut.Value.Date - dtCheckIn.Value.Date).Days;
                decimal totalPrice = roomPrice * nights;

                // 2. Добавляем стоимость выбранных услуг
                var selectedServiceIds = new List<int>();
                foreach (var item in clbServices.CheckedItems)
                {
                    string serviceName = item.ToString();

                    var serviceCmd = new NpgsqlCommand("SELECT service_id, price FROM infhotel.services WHERE name = @name", conn);
                    serviceCmd.Parameters.AddWithValue("name", serviceName);

                    var reader = serviceCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int serviceId = reader.GetInt32(0);
                        decimal servicePrice = reader.GetDecimal(1);

                        selectedServiceIds.Add(serviceId);
                        totalPrice += servicePrice;
                    }
                    reader.Close();
                }

                //  Проверка на пересечение брони
                var checkCmd = new NpgsqlCommand(@"
                SELECT 1 FROM infhotel.bookings
                WHERE room_id = @room
                AND check_in_date < @out
                AND check_out_date > @in", conn);

                checkCmd.Parameters.AddWithValue("room", roomId);
                checkCmd.Parameters.AddWithValue("in", dtCheckIn.Value.Date);
                checkCmd.Parameters.AddWithValue("out", dtCheckOut.Value.Date);

                var exists = checkCmd.ExecuteScalar();
                if (exists != null)
                {
                    MessageBox.Show("Этот номер уже забронирован на выбранные даты.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // 3. Добавляем пользователя
                var userCmd = new NpgsqlCommand(@"
            INSERT INTO infhotel.users (login, password_hash, email, phone, full_name, role_id)
            VALUES (@login, crypt(@password, gen_salt('bf')), @mail, @phone, @name, 3)
            RETURNING user_id", conn);

                userCmd.Parameters.AddWithValue("login", Guid.NewGuid().ToString());
                userCmd.Parameters.AddWithValue("password", "default123");
                userCmd.Parameters.AddWithValue("mail", email);
                userCmd.Parameters.AddWithValue("phone", string.IsNullOrWhiteSpace(phone) ? (object)DBNull.Value : (object)phone);
                userCmd.Parameters.AddWithValue("name", name);

                int userId = Autorization.UserSession.CurrentUser?.Id ?? Convert.ToInt32(userCmd.ExecuteScalar());

                // 4. Вставляем бронирование с общей стоимостью
                var bookCmd = new NpgsqlCommand(@"
            INSERT INTO infhotel.bookings (user_id, room_id, check_in_date, check_out_date, total_price)
            VALUES (@user, @room, @in, @out, @total)
            RETURNING booking_id", conn);

                bookCmd.Parameters.AddWithValue("user", userId);
                bookCmd.Parameters.AddWithValue("room", roomId);
                bookCmd.Parameters.AddWithValue("in", dtCheckIn.Value.Date);
                bookCmd.Parameters.AddWithValue("out", dtCheckOut.Value.Date);
                bookCmd.Parameters.AddWithValue("total", totalPrice);

                int bookingId = Convert.ToInt32(bookCmd.ExecuteScalar());

                // 5. Связь с услугами
                foreach (var item in clbServices.CheckedItems)
                {
                    string serviceName = item.ToString();

                    // Получаем ID и цену услуги
                    var getServiceCmd = new NpgsqlCommand("SELECT service_id, price FROM infhotel.services WHERE name = @name", conn);
                    getServiceCmd.Parameters.AddWithValue("name", serviceName);

                    var reader = getServiceCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int serviceId = reader.GetInt32(0);
                        decimal servicePrice = reader.GetDecimal(1);
                        reader.Close();

                        var insertLinkCmd = new NpgsqlCommand(@"
                        INSERT INTO infhotel.booking_services (booking_id, service_id, price_at_booking)
                        VALUES (@booking, @service, @price)", conn);

                        insertLinkCmd.Parameters.AddWithValue("booking", bookingId);
                        insertLinkCmd.Parameters.AddWithValue("service", serviceId);
                        insertLinkCmd.Parameters.AddWithValue("price", servicePrice);
                        insertLinkCmd.ExecuteNonQuery();
                    }

                    
                }MessageBox.Show($"Бронирование успешно добавлено!\nСумма: {totalPrice:N2} ₽");
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка бронирования: " + ex.Message);
            }
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            LoadRoomInfo();
            LoadServices();
            ShowBusyDates();
        }


        private void LoadRoomInfo()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT rt.name, r.price_per_night " +
                    "FROM infhotel.rooms r " +
                    "JOIN infhotel.room_types rt ON r.type_id = rt.type_id " +
                    "WHERE r.room_id = @id", conn);

                cmd.Parameters.AddWithValue("id", roomId);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTotalPrice.Text = $"Тип: {reader.GetString(0)}\nЦена за ночь: {reader.GetDecimal(1)} ₽";
                }
            }
        }

        private void LoadServices()
        {      
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT name FROM infhotel.services", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clbServices.Items.Add(reader.GetString(0));
                }
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                if (dtCheckOut.Value <= dtCheckIn.Value)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда.");
                    return;
                }

                var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                // Получаем цену номера
                decimal roomPrice;
                var priceCmd = new NpgsqlCommand("SELECT price_per_night FROM infhotel.rooms WHERE room_id = @id", conn);
                priceCmd.Parameters.AddWithValue("id", roomId);
                roomPrice = Convert.ToDecimal(priceCmd.ExecuteScalar());

                int days = (dtCheckOut.Value.Date - dtCheckIn.Value.Date).Days;
                decimal total = roomPrice * days;

                // Добавляем стоимость услуг
                foreach (var item in clbServices.CheckedItems)
                {
                    var serviceName = item.ToString();
                    var serviceCmd = new NpgsqlCommand("SELECT price FROM infhotel.services WHERE name = @name", conn);
                    serviceCmd.Parameters.AddWithValue("name", serviceName);
                    var servicePrice = Convert.ToDecimal(serviceCmd.ExecuteScalar());
                    total += servicePrice;
                }

                lblTotalPrice.Text = $"Итого: {total:N2} ₽";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка расчёта: " + ex.Message);
            }
        }
        private void DateRangeChanged(object sender, EventArgs e)
        {
            StringBuilder statusBuilder = new StringBuilder();

            if (dtCheckOut.Value <= dtCheckIn.Value)
            {
                statusBuilder.AppendLine("Дата выезда должна быть позже даты заезда.");
                lblBusyDates.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var checkCmd = new NpgsqlCommand(@"
                SELECT 1 FROM infhotel.bookings
                WHERE room_id = @room
                AND check_in_date < @out
                AND check_out_date > @in", conn);

                    checkCmd.Parameters.AddWithValue("room", roomId);
                    checkCmd.Parameters.AddWithValue("in", dtCheckIn.Value.Date);
                    checkCmd.Parameters.AddWithValue("out", dtCheckOut.Value.Date);

                    var exists = checkCmd.ExecuteScalar();

                    if (exists != null)
                    {
                        statusBuilder.AppendLine("Выбранные даты уже заняты. Выберите другие.");
                        lblBusyDates.ForeColor = System.Drawing.Color.DarkRed;
                    }
                    else
                    {
                        statusBuilder.AppendLine("Даты свободны.");
                        lblBusyDates.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }

            // Добавим список занятых дат
            statusBuilder.AppendLine();
            statusBuilder.AppendLine("Занятые даты:");
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
            SELECT check_in_date, check_out_date 
            FROM infhotel.bookings 
            WHERE room_id = @room", conn);

                cmd.Parameters.AddWithValue("room", roomId);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime start = reader.GetDateTime(0);
                    DateTime end = reader.GetDateTime(1);
                    statusBuilder.AppendLine($"• {start:dd.MM.yyyy} — {end:dd.MM.yyyy}");
                }
            }

            lblBusyDates.Text = statusBuilder.ToString();
        }
        private void ShowBusyDates()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            var cmd = new NpgsqlCommand(@"
        SELECT check_in_date, check_out_date 
        FROM infhotel.bookings 
        WHERE room_id = @room", conn);

            cmd.Parameters.AddWithValue("room", roomId);

            var reader = cmd.ExecuteReader();
            string busyText = "Занятые даты:\n";

            while (reader.Read())
            {
                DateTime start = reader.GetDateTime(0);
                DateTime end = reader.GetDateTime(1);
                busyText += $"• {start:dd.MM.yyyy} — {end:dd.MM.yyyy}\n";
            }

            lblBusyDates.Text = busyText;
        }
    }
}
