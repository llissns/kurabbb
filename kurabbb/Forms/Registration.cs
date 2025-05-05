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
using static kurabbb.Forms.Autorization;

namespace kurabbb.Forms
{
    public partial class Registration : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var authForm = new Autorization();
            authForm.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)||
            string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Заполните все обязательные поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Проверка уникальности логина и email
                    string checkSql = @"SELECT 1 FROM infhotel.users WHERE login = @login OR email = @mail";
                    using (var checkCmd = new NpgsqlCommand(checkSql, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@login", login);
                        checkCmd.Parameters.AddWithValue("@mail", email);

                        if (checkCmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("Пользователь с таким логином или email уже существует", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    // Вставка пользователя
                    string insertSql = @"
                INSERT INTO infhotel.users (login, password_hash, email, phone, full_name, role_id, is_active)
                VALUES (@login, @password, @email, @phone, @fullName, 3, true)
                RETURNING user_id";

                    int newUserId;
                    using (var insertCmd = new NpgsqlCommand(insertSql, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@login", login);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        insertCmd.Parameters.AddWithValue("@fullName", fullName);

                        newUserId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    // Получаем данные нового пользователя
                    string getUserSql = @"SELECT user_id, full_name, role_id FROM infhotel.users WHERE user_id = @userId";
                    using (var getUserCmd = new NpgsqlCommand(getUserSql, connection))
                    {
                        getUserCmd.Parameters.AddWithValue("@userId", newUserId);
                        using (var reader = getUserCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Autorization.UserSession.CurrentUser = new Autorization.UserInfo
                                {
                                    Id = reader.GetInt32(0),
                                    FullName = reader.GetString(1),
                                    RoleId = reader.GetInt32(2),
                                    Login = login
                                };
                            }
                        }
                    }

                    // Успех — переходим в Main
                    MessageBox.Show("Регистрация успешна!");

                    var mainForm = new Main(Autorization.UserSession.CurrentUser.Id, connectionString);
                    this.Hide();
                    mainForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        
    

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Создаем новую форму авторизации
            Autorization authForm = new Autorization();
            authForm.Show();

            // Закрываем текущую форму регистрации
            this.Close();
        }

        public class UserInfo
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public int RoleId { get; set; }
        }

        public static class UserSession
        {
            public static UserInfo CurrentUser { get; set; }
        }
    }
}

