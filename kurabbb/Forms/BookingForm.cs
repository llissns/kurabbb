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
    public partial class BookingForm : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        public BookingForm()
        {
            InitializeComponent();
            LoadBookings();
            SetupFilters();
        }

        private void LoadBookings()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var query = @"
                SELECT 
                    b.booking_id, 
                    u.full_name AS Клиент,
                    r.number AS Номер,
                    b.check_in_date AS Заезд,
                    b.check_out_date AS Выезд,
                    b.adults AS Взрослые,
                    b.children AS Дети,
                    b.total_price AS Итого,
                    b.status AS Статус,
                    b.payment_status AS Оплата
                    FROM infhotel.bookings b
                    JOIN infhotel.users u ON b.user_id = u.user_id
                    JOIN infhotel.rooms r ON b.room_id = r.room_id
                    ORDER BY b.check_in_date DESC;
                    ";

                var adapter = new NpgsqlDataAdapter(query, conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                bookingsGrid.DataSource = dt;

                labelStats.Text = $"Всего бронирований: {dt.Rows.Count}";
            }
        }
        private void SetupFilters()
        {
            statusFilter.Items.Clear();
            statusFilter.Items.Add("Все");
            statusFilter.Items.Add("confirmed");
            statusFilter.Items.Add("pending");
            statusFilter.Items.Add("cancelled");
            statusFilter.SelectedIndex = 0;

            dateFilter.ValueChanged += (s, e) => FilterByDate();
            statusFilter.SelectedIndexChanged += (s, e) => FilterByStatus();
            searchBox.TextChanged += (s, e) => FilterBySearch();
        }

        private void FilterByDate()
        {
            (bookingsGrid.DataSource as DataTable).DefaultView.RowFilter =
                $"Заезд >= #{dateFilter.Value.Date.ToString("yyyy-MM-dd")}#";
        }

        private void FilterByStatus()
        {
            string status = statusFilter.SelectedItem.ToString();
            if (status == "Все")
                (bookingsGrid.DataSource as DataTable).DefaultView.RowFilter = "";
            else
                (bookingsGrid.DataSource as DataTable).DefaultView.RowFilter = $"Статус = '{status}'";
        }

        private void FilterBySearch()
        {
            string text = searchBox.Text.Replace("'", "''");
            (bookingsGrid.DataSource as DataTable).DefaultView.RowFilter = $"Клиент LIKE '%{text}%'";
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var dt = (bookingsGrid.DataSource as DataTable);
                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        var cmd = new NpgsqlCommand(@"
                        UPDATE infhotel.bookings SET 
                            check_in_date = @in,
                            check_out_date = @out,adults = @a,
                            children = @c,
                            total_price = @price,
                            status = @status,
                            payment_status = @pay
                        WHERE booking_id = @id", conn);

                        cmd.Parameters.AddWithValue("id", row["booking_id"]);
                        cmd.Parameters.AddWithValue("in", row["Заезд"]);
                        cmd.Parameters.AddWithValue("out", row["Выезд"]);
                        cmd.Parameters.AddWithValue("a", row["Взрослые"]);
                        cmd.Parameters.AddWithValue("c", row["Дети"]);
                        cmd.Parameters.AddWithValue("price", row["Итого"]);
                        cmd.Parameters.AddWithValue("status", row["Статус"]);
                        cmd.Parameters.AddWithValue("pay", row["Оплата"]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            LoadBookings();
            MessageBox.Show("Изменения сохранены");
        }
    

        private void addButton_Click(object sender, EventArgs e)
        {

            var form = new AddBookingForm(); // Предполагаем, что такая форма существует
            if (form.ShowDialog() == DialogResult.OK)
                LoadBookings();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (bookingsGrid.SelectedRows.Count == 0) return;

            var id = bookingsGrid.SelectedRows[0].Cells["booking_id"].Value;
            if (MessageBox.Show("Удалить бронирование?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    new NpgsqlCommand($"DELETE FROM infhotel.bookings WHERE booking_id = {id}", conn).ExecuteNonQuery();
                }
                LoadBookings();
            }
        }
    }
}
