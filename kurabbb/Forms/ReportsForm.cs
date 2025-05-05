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
    public partial class ReportsForm : Form
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string reportType = reportTypeComboBox.SelectedItem?.ToString();

            if (reportType == "Ежедневный отчет")
            {
                GenerateDailyReport();
            }
            else if (reportType == "Отчет по загрузке")
            {
                int month = (int)monthPicker.Value;
                int year = (int)yearPicker.Value;
                GenerateOccupancyReport(month, year);
            }
        }
        private void GenerateDailyReport()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM infhotel.generate_daily_report()", conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                reportGrid.DataSource = table;
                reportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reportGrid.AllowUserToAddRows = false;
                reportGrid.AllowUserToDeleteRows = false;
                reportGrid.ReadOnly = true;
                reportGrid.RowHeadersVisible = false;
                reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        private void GenerateOccupancyReport(int month, int year)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM infhotel.generate_occupancy_report(@p_month, @p_year)", conn);
                cmd.Parameters.AddWithValue("p_month", month);
                cmd.Parameters.AddWithValue("p_year", year);

                var adapter = new NpgsqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                reportGrid.DataSource = table;
                reportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reportGrid.AllowUserToAddRows = false;
                reportGrid.AllowUserToDeleteRows = false;
                reportGrid.ReadOnly = true;
                reportGrid.RowHeadersVisible = false;
                reportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
        private void reportGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (reportGrid.Columns[e.ColumnIndex].Name == "occupancy_rate" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal occupancy))
                {
                    if (occupancy >= 80)
                        e.CellStyle.BackColor = Color.LightGreen;
                    else if (occupancy <= 50)
                        e.CellStyle.BackColor = Color.LightCoral;
                    else
                        e.CellStyle.BackColor = Color.LightYellow;

                    e.CellStyle.ForeColor = Color.Black;
                }
            }
            reportGrid.CellFormatting += reportGrid_CellFormatting;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

            if (reportGrid.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new ClosedXML.Excel.XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Отчет");

                    // Заголовки
                    for (int i = 0; i < reportGrid.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = reportGrid.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    // Данные
                    for (int i = 0; i < reportGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < reportGrid.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = reportGrid.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Отчет успешно экспортирован!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void reportGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
