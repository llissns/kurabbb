namespace kurabbb.Forms
{
    partial class AddRoomForm
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
            this.statusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.capacityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.floorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.typeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.capacityTextBox);
            this.panel1.Controls.Add(this.floorTextBox);
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Controls.Add(this.numberTextBox);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
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
            this.panel1.Size = new System.Drawing.Size(545, 537);
            this.panel1.TabIndex = 0;
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.statusComboBox.BorderRadius = 8;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusComboBox.ItemHeight = 30;
            this.statusComboBox.Location = new System.Drawing.Point(267, 373);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(215, 36);
            this.statusComboBox.TabIndex = 25;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderRadius = 8;
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Location = new System.Drawing.Point(267, 316);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.Size = new System.Drawing.Size(215, 36);
            this.priceTextBox.TabIndex = 24;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.BorderRadius = 8;
            this.capacityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacityTextBox.DefaultText = "";
            this.capacityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.capacityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.capacityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.capacityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacityTextBox.Location = new System.Drawing.Point(267, 259);
            this.capacityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.PlaceholderText = "";
            this.capacityTextBox.SelectedText = "";
            this.capacityTextBox.Size = new System.Drawing.Size(215, 36);
            this.capacityTextBox.TabIndex = 23;
            // 
            // floorTextBox
            // 
            this.floorTextBox.BorderRadius = 8;
            this.floorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.floorTextBox.DefaultText = "";
            this.floorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.floorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.floorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.floorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.floorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.floorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.floorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.floorTextBox.Location = new System.Drawing.Point(267, 202);
            this.floorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.PlaceholderText = "";
            this.floorTextBox.SelectedText = "";
            this.floorTextBox.Size = new System.Drawing.Size(215, 36);
            this.floorTextBox.TabIndex = 22;
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.typeComboBox.BorderRadius = 8;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typeComboBox.ItemHeight = 30;
            this.typeComboBox.Location = new System.Drawing.Point(267, 146);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(215, 36);
            this.typeComboBox.TabIndex = 21;
            // 
            // numberTextBox
            // 
            this.numberTextBox.BorderRadius = 8;
            this.numberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberTextBox.DefaultText = "";
            this.numberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberTextBox.Location = new System.Drawing.Point(267, 86);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.PlaceholderText = "";
            this.numberTextBox.SelectedText = "";
            this.numberTextBox.Size = new System.Drawing.Size(215, 36);
            this.numberTextBox.TabIndex = 20;
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
            this.cancelButton.Location = new System.Drawing.Point(289, 448);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(180, 45);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Отмена";
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
            this.saveButton.Location = new System.Drawing.Point(49, 448);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 45);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(19, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Статус:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Вместимость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Этаж:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тип номера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Номер комнаты:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 56);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление номера";
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 537);
            this.Controls.Add(this.panel1);
            this.Name = "AddRoomForm";
            this.Text = "AddRoomForm";
            this.Load += new System.EventHandler(this.AddRoomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2ComboBox statusComboBox;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox capacityTextBox;
        private Guna.UI2.WinForms.Guna2TextBox floorTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox typeComboBox;
        private Guna.UI2.WinForms.Guna2TextBox numberTextBox;
    }
}