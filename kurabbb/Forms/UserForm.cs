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
    public partial class UserForm : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        private DataTable usersTable;
        public UserForm()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT u.user_id, u.login, u.email, u.phone, u.full_name, 
                      r.name AS role, u.is_active 
                      FROM infhotel.users u 
                      JOIN infhotel.roles r ON u.role_id = r.role_id";
                var adapter = new NpgsqlDataAdapter(query, conn);
                usersTable = new DataTable();
                adapter.Fill(usersTable);
                UsersGrid.DataSource = usersTable;

                UsersGrid.Columns["user_id"].Visible = false;
                UsersGrid.Columns["login"].HeaderText = "Логин";
                UsersGrid.Columns["email"].HeaderText = "Email";
                UsersGrid.Columns["phone"].HeaderText = "Телефон";
                UsersGrid.Columns["full_name"].HeaderText = "ФИО";
                UsersGrid.Columns["role"].HeaderText = "Роль";
                UsersGrid.Columns["is_active"].HeaderText = "Активен";

                statsLabel.Text = $"Всего пользователей: {usersTable.Rows.Count}";
            }
        }
        
        private void DeleteUser()
        {
            if (UsersGrid.SelectedRows.Count > 0)
            {
                var row = UsersGrid.SelectedRows[0];
                int userId = Convert.ToInt32(row.Cells["user_id"].Value);

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand("DELETE FROM infhotel.users WHERE user_id = @id", conn);
                    cmd.Parameters.AddWithValue("id", userId);
                    cmd.ExecuteNonQuery();
                }
                LoadUsers();
            }
        }



        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            roleFilterCombo.Items.AddRange(new[] { "Все", "admin", "manager", "client" });
            statusfilterCombo.Items.AddRange(new[] { "Все", "Активен", "Неактивен" });

            searchBox.TextChanged += (s, ev) => ApplyFilters();
            roleFilterCombo.SelectedIndexChanged += (s, ev) => ApplyFilters();
            statusfilterCombo.SelectedIndexChanged += (s, ev) => ApplyFilters();
        }
        private void refreshButton_Click(object sender, EventArgs e) => LoadUsers();
        private void editUserButton_Click(object sender, EventArgs e)
        {

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in UsersGrid.Rows)
                {
                    if (row.IsNewRow || row.Cells["user_id"].Value == null)
                        continue;

                    int userId = Convert.ToInt32(row.Cells["user_id"].Value);
                    string login = row.Cells["login"].Value?.ToString();
                    string email = row.Cells["email"].Value?.ToString();
                    string phone = row.Cells["phone"].Value?.ToString();
                    string fullName = row.Cells["full_name"].Value?.ToString();
                    string role = row.Cells["role"].Value?.ToString();
                    bool isActive = Convert.ToBoolean(row.Cells["is_active"].Value);

                    // Получаем role_id по названию роли
                    int roleId = GetRoleIdByName(role, conn);
                    if (roleId == 0)
                    {
                        MessageBox.Show($"Роль \"{role}\" не найдена.");
                        continue;
                    }

                    var cmd = new NpgsqlCommand(@"
                    UPDATE infhotel.users SET 
                    login = @login,
                    email = @mail,
                    phone = @phone,
                    full_name = @name,
                    role_id = @role_id,
                    is_active = @active
                    WHERE user_id = @id", conn);

                    cmd.Parameters.AddWithValue("login", login);
                    cmd.Parameters.AddWithValue("mail", email);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.Parameters.AddWithValue("name", fullName);
                    cmd.Parameters.AddWithValue("role_id", roleId);
                    cmd.Parameters.AddWithValue("active", isActive);
                    cmd.Parameters.AddWithValue("id", userId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Изменения успешно сохранены.");
                LoadUsers();
            }
        }
        private int GetRoleIdByName(string roleName, NpgsqlConnection conn)
        {
            var cmd = new NpgsqlCommand("SELECT role_id FROM infhotel.roles WHERE name = @name", conn);
            cmd.Parameters.AddWithValue("name", roleName);
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }
        private void deleteButton_Click(object sender, EventArgs e) => DeleteUser();

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void ApplyFilters()
        {
            if (usersTable == null) return;

            string filter = "";
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                filter += $"full_name LIKE '%{searchBox.Text}%' OR login LIKE '%{searchBox.Text}%'";
            }

            if (roleFilterCombo.SelectedItem?.ToString() != "Все" && roleFilterCombo.SelectedItem != null)
            {
                if (filter != "") filter += " AND ";
                filter += $"role = '{roleFilterCombo.SelectedItem}'";
            }

            if (statusfilterCombo.SelectedItem?.ToString() != "Все" && statusfilterCombo.SelectedItem != null)
            {
                if (filter != "") filter += " AND ";
                bool isActive = statusfilterCombo.SelectedItem.ToString() == "Активен";
                filter += $"is_active = {isActive}";
            }

            usersTable.DefaultView.RowFilter = filter;
        }
    }
}
