using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurabbb.Forms
{
    public partial class AddBookingForm : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        public AddBookingForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadRooms();
            StatusCombo.Items.AddRange(new[] { "confirmed", "pending", "cancelled" });
            paymentCombo.Items.AddRange(new[] { "paid", "unpaid" });
            StatusCombo.SelectedIndex = 0;
            paymentCombo.SelectedIndex = 1;
        }
        private void LoadUsers()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT user_id, full_name FROM infhotel.users", conn);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                UserCombo.DataSource = dt;
                UserCombo.DisplayMember = "full_name";
                UserCombo.ValueMember = "user_id";
            }
        }

        private void LoadRooms()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT room_id, number FROM infhotel.rooms", conn);
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                RoomCombo.DataSource = dt;
                RoomCombo.DisplayMember = "number";
                RoomCombo.ValueMember = "room_id";
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dtCheckOut.Value <= dtCheckIn.Value)
            {
                MessageBox.Show("Дата выезда должна быть позже даты заезда.");
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
                INSERT INTO infhotel.bookings 
                (user_id, room_id, check_in_date, check_out_date, adults, children, total_price, status, payment_status)
                VALUES 
                (@user, @room, @in, @out, @adults, @children, @price, @status, @payment)", conn);

                cmd.Parameters.AddWithValue("user", UserCombo.SelectedValue);
                cmd.Parameters.AddWithValue("room", RoomCombo.SelectedValue);
                cmd.Parameters.AddWithValue("in", dtCheckIn.Value.Date);
                cmd.Parameters.AddWithValue("out", dtCheckOut.Value.Date);
                cmd.Parameters.AddWithValue("adults", (int)numAdults.Value);
                cmd.Parameters.AddWithValue("children", (int)numChildren.Value);
                cmd.Parameters.AddWithValue("price", decimal.TryParse(txtTotalPrice.Text, out var price) ? price : 0);
                cmd.Parameters.AddWithValue("status", StatusCombo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("payment", paymentCombo.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Бронирование добавлено.");
            DialogResult = DialogResult.OK;
            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
