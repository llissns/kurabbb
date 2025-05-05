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
    public partial class AddUserForm : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        public AddUserForm()
        {
            InitializeComponent(); LoadRoles();
        }

        private void LoadRoles()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT role_id, name FROM infhotel.roles", conn);
                var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);

                roleCombo.DisplayMember = "name";
                roleCombo.ValueMember = "role_id";
                roleCombo.DataSource = dt;
            }
        }
    

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
                    INSERT INTO infhotel.users (login, password_hash, email, phone, full_name, role_id, is_active)
                    VALUES (@login, crypt(@password, gen_salt('bf')), @mail, @phone, @name, @role, TRUE)", conn);

                cmd.Parameters.AddWithValue("login", loginBox.Text);
                cmd.Parameters.AddWithValue("password", passwordBox.Text);
                cmd.Parameters.AddWithValue("mail", emailBox.Text);
                cmd.Parameters.AddWithValue("phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("name", fullNameBox.Text);
                cmd.Parameters.AddWithValue("role", (int)roleCombo.SelectedValue);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Пользователь успешно добавлен.");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
