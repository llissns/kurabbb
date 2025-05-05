namespace kurabbb.Forms
{
    partial class AddBookingForm
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
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.paymentCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StatusCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.numChildren = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numAdults = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RoomCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UserCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.paymentCombo);
            this.panel1.Controls.Add(this.StatusCombo);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.numChildren);
            this.panel1.Controls.Add(this.numAdults);
            this.panel1.Controls.Add(this.dtCheckOut);
            this.panel1.Controls.Add(this.dtCheckIn);
            this.panel1.Controls.Add(this.RoomCombo);
            this.panel1.Controls.Add(this.UserCombo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 682);
            this.panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Animated = true;
            this.cancelButton.BorderRadius = 8;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(289, 590);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(180, 45);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.BorderRadius = 8;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(49, 590);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 45);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // paymentCombo
            // 
            this.paymentCombo.BackColor = System.Drawing.Color.Transparent;
            this.paymentCombo.BorderRadius = 8;
            this.paymentCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.paymentCombo.ForeColor = System.Drawing.Color.Black;
            this.paymentCombo.ItemHeight = 30;
            this.paymentCombo.Location = new System.Drawing.Point(267, 509);
            this.paymentCombo.Name = "paymentCombo";
            this.paymentCombo.Size = new System.Drawing.Size(215, 36);
            this.paymentCombo.TabIndex = 26;
            // 
            // StatusCombo
            // 
            this.StatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.StatusCombo.BorderRadius = 8;
            this.StatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusCombo.ForeColor = System.Drawing.Color.Black;
            this.StatusCombo.ItemHeight = 30;
            this.StatusCombo.Location = new System.Drawing.Point(266, 450);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(216, 36);
            this.StatusCombo.TabIndex = 25;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Animated = true;
            this.txtTotalPrice.BorderRadius = 8;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(266, 387);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(216, 39);
            this.txtTotalPrice.TabIndex = 24;
            // 
            // numChildren
            // 
            this.numChildren.BackColor = System.Drawing.Color.Transparent;
            this.numChildren.BorderRadius = 8;
            this.numChildren.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numChildren.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numChildren.Location = new System.Drawing.Point(332, 333);
            this.numChildren.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numChildren.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(60, 30);
            this.numChildren.TabIndex = 23;
            this.numChildren.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.numChildren.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // numAdults
            // 
            this.numAdults.BackColor = System.Drawing.Color.Transparent;
            this.numAdults.BorderRadius = 8;
            this.numAdults.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numAdults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numAdults.Location = new System.Drawing.Point(143, 333);
            this.numAdults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAdults.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAdults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(60, 30);
            this.numAdults.TabIndex = 22;
            this.numAdults.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.numAdults.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke;
            this.numAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Animated = true;
            this.dtCheckOut.BorderRadius = 8;
            this.dtCheckOut.Checked = true;
            this.dtCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.dtCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckOut.Location = new System.Drawing.Point(266, 264);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(215, 36);
            this.dtCheckOut.TabIndex = 21;
            this.dtCheckOut.Value = new System.DateTime(2025, 5, 1, 15, 2, 44, 819);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Animated = true;
            this.dtCheckIn.BorderRadius = 8;
            this.dtCheckIn.Checked = true;
            this.dtCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.dtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckIn.Location = new System.Drawing.Point(267, 202);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(215, 36);
            this.dtCheckIn.TabIndex = 20;
            this.dtCheckIn.Value = new System.DateTime(2025, 5, 1, 15, 2, 18, 628);
            // 
            // RoomCombo
            // 
            this.RoomCombo.BackColor = System.Drawing.Color.Transparent;
            this.RoomCombo.BorderRadius = 8;
            this.RoomCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomCombo.ForeColor = System.Drawing.Color.Black;
            this.RoomCombo.ItemHeight = 30;
            this.RoomCombo.Location = new System.Drawing.Point(267, 146);
            this.RoomCombo.Name = "RoomCombo";
            this.RoomCombo.Size = new System.Drawing.Size(215, 36);
            this.RoomCombo.TabIndex = 19;
            // 
            // UserCombo
            // 
            this.UserCombo.BackColor = System.Drawing.Color.Transparent;
            this.UserCombo.BorderRadius = 8;
            this.UserCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UserCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserCombo.ForeColor = System.Drawing.Color.Black;
            this.UserCombo.ItemHeight = 30;
            this.UserCombo.Location = new System.Drawing.Point(267, 86);
            this.UserCombo.Name = "UserCombo";
            this.UserCombo.Size = new System.Drawing.Size(215, 36);
            this.UserCombo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Оплата:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Статус:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(19, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Сумма:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(262, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дети:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Взрослые:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата выезда:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата заезда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Клиент:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 56);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление бронирования";
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 682);
            this.Controls.Add(this.panel1);
            this.Name = "AddBookingForm";
            this.Text = "AddBookingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox UserCombo;
        private Guna.UI2.WinForms.Guna2ComboBox RoomCombo;
        private Guna.UI2.WinForms.Guna2ComboBox paymentCombo;
        private Guna.UI2.WinForms.Guna2ComboBox StatusCombo;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown numChildren;
        private Guna.UI2.WinForms.Guna2NumericUpDown numAdults;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckIn;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button saveButton;
    }
}