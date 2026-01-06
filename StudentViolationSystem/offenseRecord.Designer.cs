namespace StudentViolationSystem
{
    partial class offenseRecord
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
            this.offenseRecLabel = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.offenseRecDataGridView = new System.Windows.Forms.DataGridView();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutNav = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userManagementNav = new System.Windows.Forms.Label();
            this.addOffenseNav = new System.Windows.Forms.Label();
            this.offenseRecNav = new System.Windows.Forms.Label();
            this.homeNav = new System.Windows.Forms.Label();
            this.addOffenseIcon = new System.Windows.Forms.PictureBox();
            this.offenseRecIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.userManagementIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // offenseRecLabel
            // 
            this.offenseRecLabel.AutoSize = true;
            this.offenseRecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecLabel.Location = new System.Drawing.Point(232, 24);
            this.offenseRecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offenseRecLabel.Name = "offenseRecLabel";
            this.offenseRecLabel.Size = new System.Drawing.Size(186, 25);
            this.offenseRecLabel.TabIndex = 2;
            this.offenseRecLabel.Text = "Violation Record";
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(232, 68);
            this.searchField.Margin = new System.Windows.Forms.Padding(2);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(546, 29);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchField.Leave += new System.EventHandler(this.searchField_Leave);
            // 
            // offenseRecDataGridView
            // 
            this.offenseRecDataGridView.AllowUserToAddRows = false;
            this.offenseRecDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offenseRecDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.offenseRecDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.offenseRecDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offenseRecDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.offenseRecDataGridView.ColumnHeadersHeight = 27;
            this.offenseRecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.offenseRecDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.offenseRecDataGridView.EnableHeadersVisualStyles = false;
            this.offenseRecDataGridView.Location = new System.Drawing.Point(231, 190);
            this.offenseRecDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.offenseRecDataGridView.Name = "offenseRecDataGridView";
            this.offenseRecDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.offenseRecDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.offenseRecDataGridView.RowHeadersVisible = false;
            this.offenseRecDataGridView.RowHeadersWidth = 51;
            this.offenseRecDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.offenseRecDataGridView.RowTemplate.Height = 24;
            this.offenseRecDataGridView.Size = new System.Drawing.Size(840, 486);
            this.offenseRecDataGridView.TabIndex = 5;
            this.offenseRecDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offenseRecDataGridView_CellContentClick);
            // 
            // dateFilter
            // 
            this.dateFilter.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter.Location = new System.Drawing.Point(801, 66);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(307, 29);
            this.dateFilter.TabIndex = 12;
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateFilter_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.logOutNav);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userManagementNav);
            this.panel1.Controls.Add(this.addOffenseNav);
            this.panel1.Controls.Add(this.offenseRecNav);
            this.panel1.Controls.Add(this.homeNav);
            this.panel1.Controls.Add(this.addOffenseIcon);
            this.panel1.Controls.Add(this.offenseRecIcon);
            this.panel1.Controls.Add(this.homeIcon);
            this.panel1.Controls.Add(this.userManagementIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 689);
            this.panel1.TabIndex = 13;
            // 
            // logOutNav
            // 
            this.logOutNav.AutoSize = true;
            this.logOutNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutNav.Location = new System.Drawing.Point(68, 614);
            this.logOutNav.Name = "logOutNav";
            this.logOutNav.Size = new System.Drawing.Size(66, 20);
            this.logOutNav.TabIndex = 16;
            this.logOutNav.Text = "Log Out";
            this.logOutNav.Click += new System.EventHandler(this.logOutNav_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentViolationSystem.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-56, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // userManagementNav
            // 
            this.userManagementNav.AutoSize = true;
            this.userManagementNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagementNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementNav.Location = new System.Drawing.Point(57, 414);
            this.userManagementNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userManagementNav.Name = "userManagementNav";
            this.userManagementNav.Size = new System.Drawing.Size(141, 20);
            this.userManagementNav.TabIndex = 12;
            this.userManagementNav.Text = "User Management";
            this.userManagementNav.Click += new System.EventHandler(this.userManagementNav_Click_2);
            // 
            // addOffenseNav
            // 
            this.addOffenseNav.AutoSize = true;
            this.addOffenseNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOffenseNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOffenseNav.Location = new System.Drawing.Point(57, 358);
            this.addOffenseNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addOffenseNav.Name = "addOffenseNav";
            this.addOffenseNav.Size = new System.Drawing.Size(103, 20);
            this.addOffenseNav.TabIndex = 11;
            this.addOffenseNav.Text = "Add Violation";
            this.addOffenseNav.Click += new System.EventHandler(this.addOffenseNav_Click_2);
            // 
            // offenseRecNav
            // 
            this.offenseRecNav.AutoSize = true;
            this.offenseRecNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offenseRecNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecNav.Location = new System.Drawing.Point(56, 304);
            this.offenseRecNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offenseRecNav.Name = "offenseRecNav";
            this.offenseRecNav.Size = new System.Drawing.Size(142, 20);
            this.offenseRecNav.TabIndex = 10;
            this.offenseRecNav.Text = "Violation Record";
            // 
            // homeNav
            // 
            this.homeNav.AutoSize = true;
            this.homeNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeNav.Location = new System.Drawing.Point(58, 246);
            this.homeNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeNav.Name = "homeNav";
            this.homeNav.Size = new System.Drawing.Size(52, 20);
            this.homeNav.TabIndex = 5;
            this.homeNav.Text = "Home";
            this.homeNav.Click += new System.EventHandler(this.homeNav_Click_2);
            // 
            // addOffenseIcon
            // 
            this.addOffenseIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addOffenseIcon.Image = global::StudentViolationSystem.Properties.Resources.add_offense_icon__1_;
            this.addOffenseIcon.Location = new System.Drawing.Point(8, 349);
            this.addOffenseIcon.Name = "addOffenseIcon";
            this.addOffenseIcon.Size = new System.Drawing.Size(42, 42);
            this.addOffenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addOffenseIcon.TabIndex = 8;
            this.addOffenseIcon.TabStop = false;
            // 
            // offenseRecIcon
            // 
            this.offenseRecIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.offenseRecIcon.Image = global::StudentViolationSystem.Properties.Resources.offense_record_icon;
            this.offenseRecIcon.Location = new System.Drawing.Point(8, 294);
            this.offenseRecIcon.Name = "offenseRecIcon";
            this.offenseRecIcon.Size = new System.Drawing.Size(42, 42);
            this.offenseRecIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offenseRecIcon.TabIndex = 7;
            this.offenseRecIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeIcon.Image = global::StudentViolationSystem.Properties.Resources.home_icon__1_;
            this.homeIcon.Location = new System.Drawing.Point(8, 237);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(42, 42);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 5;
            this.homeIcon.TabStop = false;
            // 
            // userManagementIcon
            // 
            this.userManagementIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userManagementIcon.Image = global::StudentViolationSystem.Properties.Resources.user_management_icon;
            this.userManagementIcon.Location = new System.Drawing.Point(8, 404);
            this.userManagementIcon.Name = "userManagementIcon";
            this.userManagementIcon.Size = new System.Drawing.Size(42, 42);
            this.userManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementIcon.TabIndex = 9;
            this.userManagementIcon.TabStop = false;
            // 
            // offenseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1094, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.offenseRecDataGridView);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.offenseRecLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "offenseRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offense Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.offenseRecord_Load);
            this.Shown += new System.EventHandler(this.offenseRecord_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label offenseRecLabel;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.DataGridView offenseRecDataGridView;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logOutNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userManagementNav;
        private System.Windows.Forms.Label addOffenseNav;
        private System.Windows.Forms.Label offenseRecNav;
        private System.Windows.Forms.Label homeNav;
        private System.Windows.Forms.PictureBox addOffenseIcon;
        private System.Windows.Forms.PictureBox offenseRecIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox userManagementIcon;
    }
}