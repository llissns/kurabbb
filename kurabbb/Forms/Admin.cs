using Guna.UI2.WinForms;
using kurabbb.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.DataVisualization.Charting;
using kurabbb.Classes;
using Npgsql;

namespace kurabbb.Forms
{
    public partial class Admin : Form
    {
        private Form activeForm = null;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void OpenFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ReportsForm());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new RoomForm());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new UserForm());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BookingForm());
        }
    }
}