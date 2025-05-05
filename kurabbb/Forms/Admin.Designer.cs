namespace kurabbb.Forms
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBookings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnRooms = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAbout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(278, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 570);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 20);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.btnBookings);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnRooms);
            this.panel2.Controls.Add(this.buttonAbout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 570);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(84, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Администратор";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::kurabbb.Properties.Resources.user_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 47);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnBookings
            // 
            this.btnBookings.Animated = true;
            this.btnBookings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBookings.BorderRadius = 8;
            this.btnBookings.BorderThickness = 1;
            this.btnBookings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookings.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnBookings.Location = new System.Drawing.Point(6, 377);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(266, 60);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Бронирования";
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnUsers.BorderRadius = 8;
            this.btnUsers.BorderThickness = 1;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnUsers.Location = new System.Drawing.Point(6, 311);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(266, 60);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Animated = true;
            this.btnRooms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnRooms.BorderRadius = 8;
            this.btnRooms.BorderThickness = 1;
            this.btnRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRooms.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnRooms.Location = new System.Drawing.Point(6, 245);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(266, 60);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Номера";
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Animated = true;
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.buttonAbout.BorderRadius = 8;
            this.buttonAbout.BorderThickness = 1;
            this.buttonAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAbout.FillColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAbout.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.buttonAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.buttonAbout.Location = new System.Drawing.Point(6, 179);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(266, 60);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "Отчеты";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Админ";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnBookings;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnRooms;
        private Guna.UI2.WinForms.Guna2Button buttonAbout;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
