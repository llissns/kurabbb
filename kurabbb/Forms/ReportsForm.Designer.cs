namespace kurabbb.Forms
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yearPicker = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.monthPicker = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.exportButton = new Guna.UI2.WinForms.Guna2Button();
            this.reportGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.generateButton = new Guna.UI2.WinForms.Guna2Button();
            this.reportTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.yearPicker);
            this.panel1.Controls.Add(this.monthPicker);
            this.panel1.Controls.Add(this.guna2DateTimePicker1);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.reportGrid);
            this.panel1.Controls.Add(this.generateButton);
            this.panel1.Controls.Add(this.reportTypeComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 545);
            this.panel1.TabIndex = 0;
            // 
            // yearPicker
            // 
            this.yearPicker.BackColor = System.Drawing.Color.Transparent;
            this.yearPicker.BorderRadius = 8;
            this.yearPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yearPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yearPicker.Location = new System.Drawing.Point(12, 395);
            this.yearPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearPicker.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.yearPicker.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(179, 32);
            this.yearPicker.TabIndex = 16;
            this.yearPicker.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.yearPicker.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke;
            this.yearPicker.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // monthPicker
            // 
            this.monthPicker.BackColor = System.Drawing.Color.Transparent;
            this.monthPicker.BorderRadius = 8;
            this.monthPicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.monthPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monthPicker.Location = new System.Drawing.Point(12, 355);
            this.monthPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthPicker.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(179, 32);
            this.monthPicker.TabIndex = 15;
            this.monthPicker.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.monthPicker.UpDownButtonForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.BorderRadius = 8;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(524, 355);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(252, 36);
            this.guna2DateTimePicker1.TabIndex = 14;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 4, 27, 18, 14, 46, 383);
            // 
            // exportButton
            // 
            this.exportButton.Animated = true;
            this.exportButton.BorderRadius = 8;
            this.exportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(596, 488);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(180, 45);
            this.exportButton.TabIndex = 13;
            this.exportButton.Text = "Экспорт в Excel";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // reportGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.reportGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reportGrid.ColumnHeadersHeight = 4;
            this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.reportGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.reportGrid.Location = new System.Drawing.Point(12, 62);
            this.reportGrid.Name = "reportGrid";
            this.reportGrid.RowHeadersVisible = false;
            this.reportGrid.RowHeadersWidth = 51;
            this.reportGrid.RowTemplate.Height = 24;
            this.reportGrid.Size = new System.Drawing.Size(764, 278);
            this.reportGrid.TabIndex = 12;
            this.reportGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.reportGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.reportGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reportGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reportGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reportGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reportGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reportGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.reportGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.reportGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reportGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.reportGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reportGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.reportGrid.ThemeStyle.ReadOnly = false;
            this.reportGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.reportGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reportGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.reportGrid.ThemeStyle.RowsStyle.Height = 24;
            this.reportGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.reportGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.reportGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportGrid_CellContentClick);
            this.reportGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.reportGrid_CellFormatting);
            // 
            // generateButton
            // 
            this.generateButton.Animated = true;
            this.generateButton.BorderRadius = 8;
            this.generateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(390, 488);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(180, 45);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Сформировать отчет";
            this.generateButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.reportTypeComboBox.BorderRadius = 8;
            this.reportTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reportTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.reportTypeComboBox.ItemHeight = 30;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Ежедневный отчет",
            "Отчет по загрузке"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(238, 355);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(252, 36);
            this.reportTypeComboBox.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 56);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчеты";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 545);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown yearPicker;
        private Guna.UI2.WinForms.Guna2NumericUpDown monthPicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button exportButton;
        private Guna.UI2.WinForms.Guna2DataGridView reportGrid;
        private Guna.UI2.WinForms.Guna2Button generateButton;
        private Guna.UI2.WinForms.Guna2ComboBox reportTypeComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}