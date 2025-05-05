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
    public partial class AddRoomForm : Form
    {

        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";

        public AddRoomForm()
        {
            InitializeComponent();
            LoadRoomTypes();
            LoadStatuses();
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadRoomTypes()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT type_id, name FROM infhotel.room_types ORDER BY name", conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                typeComboBox.DisplayMember = "name";
                typeComboBox.ValueMember = "type_id";
                typeComboBox.DataSource = dt;
            }
        }

        private void LoadStatuses()
        {
            statusComboBox.Items.Clear();
            statusComboBox.Items.Add("available");
            statusComboBox.Items.Add("booked");
            statusComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(numberTextBox.Text) ||
                typeComboBox.SelectedValue == null ||
                !int.TryParse(floorTextBox.Text, out int floor) ||
                !int.TryParse(capacityTextBox.Text, out int capacity) ||
                !decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"INSERT INTO infhotel.rooms (number, type_id, floor, capacity, price_per_night, status)
                                          VALUES (@number, @type_id, @floor, @capacity, @price_per_night, @status)", conn);

                cmd.Parameters.AddWithValue("number", numberTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("type_id", (int)typeComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("floor", floor);
                cmd.Parameters.AddWithValue("capacity", capacity);
                cmd.Parameters.AddWithValue("price_per_night", price);
                cmd.Parameters.AddWithValue("status", statusComboBox.SelectedItem.ToString());

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Номер успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (PostgresException ex) when (ex.SqlState == "23505") // unique_violation
                {
                    MessageBox.Show("Номер комнаты уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении номера:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

