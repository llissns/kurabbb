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
    public partial class RoomForm : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        private DataTable allRoomsTable;
        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
            SetupComboBoxes();

            roomsGrid.CellValueChanged += roomsGrid_CellValueChanged;
            roomsGrid.CurrentCellDirtyStateChanged += roomsGrid_CurrentCellDirtyStateChanged;
        }


        private void LoadRooms()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                r.room_id, 
                                r.number AS room_number,
                                rt.name AS room_type,
                                r.status,
                                r.price_per_night
                             FROM infhotel.rooms r
                             JOIN infhotel.room_types rt ON r.type_id = rt.type_id";

                var adapter = new NpgsqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);

                allRoomsTable = table;
                roomsGrid.DataSource = allRoomsTable;

                SetupGrid();
                UpdateStats(allRoomsTable);
            }
        }

        private void SetupGrid()
        {
            roomsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomsGrid.ReadOnly = false;
            roomsGrid.AllowUserToAddRows = false;
            roomsGrid.RowHeadersVisible = false;

            if (roomsGrid.Columns["room_id"] != null)
                roomsGrid.Columns["room_id"].ReadOnly = true;

            var typeList = GetRoomTypeNames();
            var roomTypeCol = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "room_type",
                HeaderText = "Тип номера",
                DataSource = typeList,
                Name = "room_type",
                FlatStyle = FlatStyle.Flat
            };
            ReplaceColumn("room_type", roomTypeCol);

            var statusCol = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "status",
                HeaderText = "Статус",
                DataSource = new[] { "available", "booked" },
                Name = "status",
                FlatStyle = FlatStyle.Flat
            };
            ReplaceColumn("status", statusCol);
        }

        private void ReplaceColumn(string columnName, DataGridViewColumn newColumn)
        {
            int index = roomsGrid.Columns[columnName].Index;
            roomsGrid.Columns.Remove(columnName);
            roomsGrid.Columns.Insert(index, newColumn);
        }


        private void SetupComboBoxes()
        {
            filterTypeCombo.Items.Clear();
            filterTypeCombo.Items.Add("Все");
            filterStatusCombo.Items.Clear();
            filterStatusCombo.Items.Add("Все");

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                // Типы номеров
                var cmdTypes = new NpgsqlCommand("SELECT name FROM infhotel.room_types ORDER BY name", conn);
                using (var reader = cmdTypes.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        filterTypeCombo.Items.Add(reader.GetString(0));
                    }
                }

                // Статусы можно захардкодить, т.к. вариантов немного
                filterStatusCombo.Items.Add("available");
                filterStatusCombo.Items.Add("booked");
            }

            filterTypeCombo.SelectedIndex = 0;
            filterStatusCombo.SelectedIndex = 0;
        }

        private void UpdateStats(DataTable table)
        {
            int total = table.Rows.Count;
            int available = table.AsEnumerable().Count(r => r["status"].ToString() == "available");
            int booked = table.AsEnumerable().Count(r => r["status"].ToString() == "booked");

            statsLabel.Text = $"Всего: {total} | Свободных: {available} | Занятых: {booked}";
        }

        private void ApplyFilters()
        {
            if (allRoomsTable == null) return;

            string searchText = searchBox.Text.Trim().ToLower();
            string selectedType = filterTypeCombo.SelectedItem?.ToString();
            string selectedStatus = filterStatusCombo.SelectedItem?.ToString();

            var filtered = allRoomsTable.AsEnumerable()
                .Where(row =>
                    (string.IsNullOrEmpty(searchText) || row["room_number"].ToString().ToLower().Contains(searchText)) &&
                    (selectedType == "Все" || row["room_type"].ToString() == selectedType) &&
                    (selectedStatus == "Все" || row["status"].ToString() == selectedStatus)
                );

            if (filtered.Any())
            {
                var filteredTable = filtered.CopyToDataTable();
                roomsGrid.DataSource = filteredTable;
                UpdateStats(filteredTable);
            }
            else
            {
                roomsGrid.DataSource = null;
                statsLabel.Text = "Нет данных по выбранным фильтрам.";
            }
        }



        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void filterTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void filterStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadRooms();
            searchBox.Clear();
            filterTypeCombo.SelectedIndex = 0;
            filterStatusCombo.SelectedIndex = 0;
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {

            var addRoomForm = new AddRoomForm();
            if (addRoomForm.ShowDialog() == DialogResult.OK)
            {
                LoadRooms();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            if (roomsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для редактирования.");
                return;
            }

            var row = roomsGrid.SelectedRows[0];
            roomsGrid.CurrentCell = row.Cells[1];
            roomsGrid.BeginEdit(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (roomsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            var row = roomsGrid.SelectedRows[0];
            int roomId = Convert.ToInt32(((DataRowView)row.DataBoundItem)["room_id"]);
            string roomNumber = ((DataRowView)row.DataBoundItem)["room_number"].ToString();

            if (MessageBox.Show($"Удалить номер {roomNumber}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand("DELETE FROM infhotel.rooms WHERE room_id = @room_id", conn);
                    cmd.Parameters.AddWithValue("room_id", roomId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        LoadRooms();
                    }
                    catch (PostgresException ex) when (ex.SqlState == "23503")
                    {
                        MessageBox.Show("Нельзя удалить номер: есть связанные бронирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void roomsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (allRoomsTable == null || e.RowIndex < 0) return;

            var row = roomsGrid.Rows[e.RowIndex];

            try
            {
                int roomId = Convert.ToInt32(row.Cells["room_id"].Value);
                string roomNumber = row.Cells["room_number"].Value.ToString();
                string roomType = row.Cells["room_type"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price_per_night"].Value);

                int typeId = GetRoomTypeIdByName(roomType);
                if (typeId == -1) throw new Exception("Неизвестный тип номера.");

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand(@"
                        UPDATE infhotel.rooms 
                        SET number = @number,
                            type_id = @type_id,
                            status = @status,
                            price_per_night = @price
                        WHERE room_id = @room_id", conn);

                    cmd.Parameters.AddWithValue("number", roomNumber);
                    cmd.Parameters.AddWithValue("type_id", typeId);
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("price", price);
                    cmd.Parameters.AddWithValue("room_id", roomId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                LoadRooms(); // Откат
            }
        }
        private void roomsGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (roomsGrid.IsCurrentCellDirty)
                roomsGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private int GetRoomTypeIdByName(string typeName)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT type_id FROM infhotel.room_types WHERE name = @name", conn);
                cmd.Parameters.AddWithValue("name", typeName);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private string[] GetRoomTypeNames()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT name FROM infhotel.room_types ORDER BY name", conn);
                var reader = cmd.ExecuteReader();
                var list = new List<string>();
                while (reader.Read())
                    list.Add(reader.GetString(0));
                return list.ToArray();
            }
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
