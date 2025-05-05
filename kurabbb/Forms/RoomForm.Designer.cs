namespace kurabbb.Forms
{
    partial class RoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.statsLabel = new System.Windows.Forms.Label();
            this.roomsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.addRoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterStatusCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.filterTypeCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.statsLabel);
            this.panel1.Controls.Add(this.roomsGrid);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.addRoomButton);
            this.panel1.Controls.Add(this.filterStatusCombo);
            this.panel1.Controls.Add(this.filterTypeCombo);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 550);
            this.panel1.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.BorderRadius = 8;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(12, 481);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 45);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Animated = true;
            this.editButton.BorderRadius = 8;
            this.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(213, 481);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(180, 45);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Изменить";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsLabel.Location = new System.Drawing.Point(12, 426);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(85, 28);
            this.statsLabel.TabIndex = 17;
            this.statsLabel.Text = "Номера";
            // 
            // roomsGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.roomsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.roomsGrid.ColumnHeadersHeight = 4;
            this.roomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.roomsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsGrid.Location = new System.Drawing.Point(12, 62);
            this.roomsGrid.Name = "roomsGrid";
            this.roomsGrid.RowHeadersVisible = false;
            this.roomsGrid.RowHeadersWidth = 51;
            this.roomsGrid.RowTemplate.Height = 24;
            this.roomsGrid.Size = new System.Drawing.Size(776, 272);
            this.roomsGrid.TabIndex = 16;
            this.roomsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomsGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomsGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomsGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomsGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomsGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomsGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.roomsGrid.ThemeStyle.ReadOnly = false;
            this.roomsGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomsGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomsGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomsGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomsGrid.ThemeStyle.RowsStyle.Height = 24;
            this.roomsGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsGrid_CellValueChanged);
            this.roomsGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.roomsGrid_CurrentCellDirtyStateChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Animated = true;
            this.refreshButton.BorderRadius = 8;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(608, 481);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(180, 45);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Animated = true;
            this.addRoomButton.BorderRadius = 8;
            this.addRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRoomButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.addRoomButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addRoomButton.ForeColor = System.Drawing.Color.White;
            this.addRoomButton.Location = new System.Drawing.Point(411, 481);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(180, 45);
            this.addRoomButton.TabIndex = 14;
            this.addRoomButton.Text = "Добавить номер";
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // filterStatusCombo
            // 
            this.filterStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterStatusCombo.BorderRadius = 8;
            this.filterStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterStatusCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterStatusCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterStatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterStatusCombo.ForeColor = System.Drawing.Color.Black;
            this.filterStatusCombo.ItemHeight = 30;
            this.filterStatusCombo.Items.AddRange(new object[] {
            "Все",
            "Свободен",
            "Занят"});
            this.filterStatusCombo.Location = new System.Drawing.Point(245, 349);
            this.filterStatusCombo.Name = "filterStatusCombo";
            this.filterStatusCombo.Size = new System.Drawing.Size(201, 36);
            this.filterStatusCombo.TabIndex = 13;
            this.filterStatusCombo.SelectedIndexChanged += new System.EventHandler(this.filterStatusCombo_SelectedIndexChanged);
            // 
            // filterTypeCombo
            // 
            this.filterTypeCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterTypeCombo.BorderRadius = 8;
            this.filterTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterTypeCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterTypeCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterTypeCombo.ForeColor = System.Drawing.Color.Black;
            this.filterTypeCombo.ItemHeight = 30;
            this.filterTypeCombo.Items.AddRange(new object[] {
            "Стандартный",
            "Семейный",
            "Большой",
            "Молодежный",
            "Мансардный"});
            this.filterTypeCombo.Location = new System.Drawing.Point(12, 349);
            this.filterTypeCombo.Name = "filterTypeCombo";
            this.filterTypeCombo.Size = new System.Drawing.Size(201, 36);
            this.filterTypeCombo.TabIndex = 12;
            this.filterTypeCombo.SelectedIndexChanged += new System.EventHandler(this.filterTypeCombo_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Animated = true;
            this.searchBox.BorderRadius = 8;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(543, 349);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Номер комнаты";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(201, 36);
            this.searchBox.TabIndex = 11;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 56);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номера";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panel1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView roomsGrid;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2Button addRoomButton;
        private Guna.UI2.WinForms.Guna2ComboBox filterStatusCombo;
        private Guna.UI2.WinForms.Guna2ComboBox filterTypeCombo;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.Label statsLabel;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button editButton;
    }
}