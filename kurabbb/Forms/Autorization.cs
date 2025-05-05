using kurabbb.Classes;
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
    public partial class Autorization : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        public bool IsAuthorized { get; private set; } = false;
        public Autorization()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT user_id, full_name, email, role_id 
                                 FROM infhotel.users 
                                 WHERE login = @login 
                                 AND password_hash = crypt(@password, password_hash)";

                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Успешная авторизация
                                UserSession.CurrentUser = new UserInfo
                                {
                                    Id = reader.GetInt32(0),
                                    FullName = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    RoleId = reader.GetInt32(3),
                                    Login = login
                                };

                                IsAuthorized = true;

                                UpdateLastLogin(UserSession.CurrentUser.Id);

                                this.Hide();

                                if (UserSession.CurrentUser.RoleId == 1)
                                {
                                    var adminForm = new Admin();
                                    adminForm.Show();
                                }
                                else
                                {
                                    var mainForm = new kurabbb.Main(UserSession.CurrentUser.Id, connectionString);
                                    mainForm.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void UpdateLastLogin(int userId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE infhotel.users SET last_login = CURRENT_TIMESTAMP WHERE user_id = @userId";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        // Класс для хранения информации о пользователе
        public class UserInfo
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public int RoleId { get; set; }
        }

        // Статический класс для хранения сессии
        public static class UserSession
        {
            public static UserInfo CurrentUser { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }
    }
}
