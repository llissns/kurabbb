namespace kurabbb.Forms
{
    partial class UserForm
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
            this.editUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.addUserButton = new Guna.UI2.WinForms.Guna2Button();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.statusfilterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roleFilterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.statsLabel = new System.Windows.Forms.Label();
            this.UsersGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editUserButton);
            this.panel1.Controls.Add(this.addUserButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.statusfilterCombo);
            this.panel1.Controls.Add(this.roleFilterCombo);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.statsLabel);
            this.panel1.Controls.Add(this.UsersGrid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 565);
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
            this.deleteButton.Location = new System.Drawing.Point(12, 501);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 45);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Animated = true;
            this.editUserButton.BorderRadius = 8;
            this.editUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editUserButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.editUserButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editUserButton.ForeColor = System.Drawing.Color.White;
            this.editUserButton.Location = new System.Drawing.Point(211, 501);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(180, 45);
            this.editUserButton.TabIndex = 19;
            this.editUserButton.Text = "Изменить";
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BorderRadius = 8;
            this.addUserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUserButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(408, 501);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(180, 45);
            this.addUserButton.TabIndex = 18;
            this.addUserButton.Text = "Добавить ";
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BorderRadius = 8;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(608, 501);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(180, 45);
            this.refreshButton.TabIndex = 17;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // statusfilterCombo
            // 
            this.statusfilterCombo.BackColor = System.Drawing.Color.Transparent;
            this.statusfilterCombo.BorderRadius = 8;
            this.statusfilterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusfilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusfilterCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusfilterCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusfilterCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusfilterCombo.ForeColor = System.Drawing.Color.Black;
            this.statusfilterCombo.ItemHeight = 30;
            this.statusfilterCombo.Location = new System.Drawing.Point(251, 362);
            this.statusfilterCombo.Name = "statusfilterCombo";
            this.statusfilterCombo.Size = new System.Drawing.Size(201, 36);
            this.statusfilterCombo.TabIndex = 16;
            // 
            // roleFilterCombo
            // 
            this.roleFilterCombo.BackColor = System.Drawing.Color.Transparent;
            this.roleFilterCombo.BorderRadius = 8;
            this.roleFilterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleFilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleFilterCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleFilterCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleFilterCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleFilterCombo.ForeColor = System.Drawing.Color.Black;
            this.roleFilterCombo.ItemHeight = 30;
            this.roleFilterCombo.Location = new System.Drawing.Point(12, 362);
            this.roleFilterCombo.Name = "roleFilterCombo";
            this.roleFilterCombo.Size = new System.Drawing.Size(201, 36);
            this.roleFilterCombo.TabIndex = 15;
            // 
            // searchBox
            // 
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
            this.searchBox.Location = new System.Drawing.Point(587, 362);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Поиск";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(201, 44);
            this.searchBox.TabIndex = 14;
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsLabel.Location = new System.Drawing.Point(12, 448);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(66, 28);
            this.statsLabel.TabIndex = 13;
            this.statsLabel.Text = "label2";
            // 
            // UsersGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.UsersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersGrid.ColumnHeadersHeight = 4;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.UsersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGrid.Location = new System.Drawing.Point(12, 62);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.RowHeadersVisible = false;
            this.UsersGrid.RowHeadersWidth = 51;
            this.UsersGrid.RowTemplate.Height = 24;
            this.UsersGrid.Size = new System.Drawing.Size(776, 277);
            this.UsersGrid.TabIndex = 12;
            this.UsersGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UsersGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.UsersGrid.ThemeStyle.ReadOnly = false;
            this.UsersGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGrid.ThemeStyle.RowsStyle.Height = 24;
            this.UsersGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 56);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователи";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView UsersGrid;
        private System.Windows.Forms.Label statsLabel;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2ComboBox roleFilterCombo;
        private Guna.UI2.WinForms.Guna2Button editUserButton;
        private Guna.UI2.WinForms.Guna2Button addUserButton;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2ComboBox statusfilterCombo;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
    }
}