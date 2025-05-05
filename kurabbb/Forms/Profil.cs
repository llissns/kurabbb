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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace kurabbb.Forms
{
    public partial class Profil : Form
    {
        private readonly int userId;
        private readonly string connectionString;
        public Profil(int userId, string connectionString)
        {
            InitializeComponent();
            this.userId = userId;
            this.connectionString = connectionString;
            LoadProfile();
            LoadStatistics();
        }
        private void LoadProfile()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            var cmd = new NpgsqlCommand(@"
            SELECT full_name, email, phone, created_at, last_login
            FROM infhotel.users
            WHERE user_id = @id", conn);
            cmd.Parameters.AddWithValue("id", userId);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtFullName.Text = reader.GetString(0);
                txtEmail.Text = reader.GetString(1);
                txtPhone.Text = reader.GetString(2);
                lblCreatedAt.Text = reader.GetDateTime(3).ToShortDateString();
                lblLastLogin.Text = reader.IsDBNull(4) ? "Нет данных" : reader.GetDateTime(4).ToShortDateString();
            }
        }

        private void LoadStatistics()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            var statsCmd = new NpgsqlCommand(@"
            SELECT COUNT(*), COALESCE(SUM(total_price),0), COALESCE(AVG(total_price),0), MAX(check_in_date)
            FROM infhotel.bookings WHERE user_id = @id", conn);
            statsCmd.Parameters.AddWithValue("id", userId);

            var reader = statsCmd.ExecuteReader();
            if (reader.Read())
            {
                lblTotalBookings.Text = reader.GetInt32(0).ToString();
                lblTotalSpent.Text = $"{reader.GetDecimal(1):N2} ₽";
                lblAvgBooking.Text = $"{reader.GetDecimal(2):N2} ₽";
                lblLastBookingDate.Text = reader.IsDBNull(3) ? "Нет" : reader.GetDateTime(3).ToShortDateString();
            }
            reader.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {

            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            var cmd = new NpgsqlCommand(@"
            UPDATE infhotel.users
            SET full_name = @name,
                email = @mail,
                phone = @phone
            WHERE user_id = @id", conn);

            cmd.Parameters.AddWithValue("name", txtFullName.Text.Trim());
            cmd.Parameters.AddWithValue("mail", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("id", userId);

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Данные обновлены.");
            else
                MessageBox.Show("Не удалось обновить.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblReviewsCount_Click(object sender, EventArgs e)
        {

        }
    }
}
