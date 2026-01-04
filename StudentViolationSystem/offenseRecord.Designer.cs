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
            this.offenseRecLabel = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.offenseRecDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
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
            this.offenseRecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecLabel.Location = new System.Drawing.Point(212, 22);
            this.offenseRecLabel.Name = "offenseRecLabel";
            this.offenseRecLabel.Size = new System.Drawing.Size(196, 29);
            this.offenseRecLabel.TabIndex = 2;
            this.offenseRecLabel.Text = "Offense Record";
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(216, 64);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(468, 30);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchField.Leave += new System.EventHandler(this.searchField_Leave);
            // 
            // offenseRecDataGridView
            // 
            this.offenseRecDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offenseRecDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.offenseRecDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.offenseRecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offenseRecDataGridView.Location = new System.Drawing.Point(215, 191);
            this.offenseRecDataGridView.Name = "offenseRecDataGridView";
            this.offenseRecDataGridView.RowHeadersWidth = 51;
            this.offenseRecDataGridView.RowTemplate.Height = 24;
            this.offenseRecDataGridView.Size = new System.Drawing.Size(860, 368);
            this.offenseRecDataGridView.TabIndex = 5;
            this.offenseRecDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.offenseRecDataGridView_CellContentClick);
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
            this.panel1.Size = new System.Drawing.Size(200, 660);
            this.panel1.TabIndex = 11;
            // 
            // logOutNav
            // 
            this.logOutNav.AutoSize = true;
            this.logOutNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutNav.Location = new System.Drawing.Point(62, 604);
            this.logOutNav.Name = "logOutNav";
            this.logOutNav.Size = new System.Drawing.Size(82, 25);
            this.logOutNav.TabIndex = 15;
            this.logOutNav.Text = "Log Out";
            this.logOutNav.Click += new System.EventHandler(this.logOutNav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentViolationSystem.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-25, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // userManagementNav
            // 
            this.userManagementNav.AutoSize = true;
            this.userManagementNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagementNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementNav.Location = new System.Drawing.Point(46, 359);
            this.userManagementNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userManagementNav.Name = "userManagementNav";
            this.userManagementNav.Size = new System.Drawing.Size(173, 25);
            this.userManagementNav.TabIndex = 12;
            this.userManagementNav.Text = "User Management";
            this.userManagementNav.Click += new System.EventHandler(this.userManagementNav_Click_1);
            // 
            // addOffenseNav
            // 
            this.addOffenseNav.AutoSize = true;
            this.addOffenseNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOffenseNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOffenseNav.Location = new System.Drawing.Point(47, 306);
            this.addOffenseNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addOffenseNav.Name = "addOffenseNav";
            this.addOffenseNav.Size = new System.Drawing.Size(122, 25);
            this.addOffenseNav.TabIndex = 11;
            this.addOffenseNav.Text = "Add Offense";
            this.addOffenseNav.Click += new System.EventHandler(this.addOffenseNav_Click_1);
            // 
            // offenseRecNav
            // 
            this.offenseRecNav.AutoSize = true;
            this.offenseRecNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offenseRecNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecNav.Location = new System.Drawing.Point(46, 255);
            this.offenseRecNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offenseRecNav.Name = "offenseRecNav";
            this.offenseRecNav.Size = new System.Drawing.Size(162, 25);
            this.offenseRecNav.TabIndex = 10;
            this.offenseRecNav.Text = "Offense Record";
            // 
            // homeNav
            // 
            this.homeNav.AutoSize = true;
            this.homeNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeNav.Location = new System.Drawing.Point(48, 204);
            this.homeNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeNav.Name = "homeNav";
            this.homeNav.Size = new System.Drawing.Size(64, 25);
            this.homeNav.TabIndex = 5;
            this.homeNav.Text = "Home";
            this.homeNav.Click += new System.EventHandler(this.homeNav_Click_1);
            // 
            // addOffenseIcon
            // 
            this.addOffenseIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addOffenseIcon.Image = global::StudentViolationSystem.Properties.Resources.add_offense_icon__1_;
            this.addOffenseIcon.Location = new System.Drawing.Point(6, 298);
            this.addOffenseIcon.Name = "addOffenseIcon";
            this.addOffenseIcon.Size = new System.Drawing.Size(35, 35);
            this.addOffenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addOffenseIcon.TabIndex = 8;
            this.addOffenseIcon.TabStop = false;
            this.addOffenseIcon.Click += new System.EventHandler(this.addOffenseIcon_Click);
            // 
            // offenseRecIcon
            // 
            this.offenseRecIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.offenseRecIcon.Image = global::StudentViolationSystem.Properties.Resources.offense_record_icon;
            this.offenseRecIcon.Location = new System.Drawing.Point(6, 247);
            this.offenseRecIcon.Name = "offenseRecIcon";
            this.offenseRecIcon.Size = new System.Drawing.Size(35, 35);
            this.offenseRecIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offenseRecIcon.TabIndex = 7;
            this.offenseRecIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeIcon.Image = global::StudentViolationSystem.Properties.Resources.home_icon__1_;
            this.homeIcon.Location = new System.Drawing.Point(6, 194);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(35, 35);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 5;
            this.homeIcon.TabStop = false;
            // 
            // userManagementIcon
            // 
            this.userManagementIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userManagementIcon.Image = global::StudentViolationSystem.Properties.Resources.user_management_icon;
            this.userManagementIcon.Location = new System.Drawing.Point(6, 350);
            this.userManagementIcon.Name = "userManagementIcon";
            this.userManagementIcon.Size = new System.Drawing.Size(35, 35);
            this.userManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementIcon.TabIndex = 9;
            this.userManagementIcon.TabStop = false;
            // 
            // dateFilter
            // 
            this.dateFilter.Location = new System.Drawing.Point(848, 64);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(200, 23);
            this.dateFilter.TabIndex = 12;
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateFilter_ValueChanged);
            // 
            // offenseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 660);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.offenseRecDataGridView);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.offenseRecLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "offenseRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offense Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.offenseRecord_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userManagementNav;
        private System.Windows.Forms.Label addOffenseNav;
        private System.Windows.Forms.Label offenseRecNav;
        private System.Windows.Forms.Label homeNav;
        private System.Windows.Forms.PictureBox addOffenseIcon;
        private System.Windows.Forms.PictureBox offenseRecIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox userManagementIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logOutNav;
        private System.Windows.Forms.DateTimePicker dateFilter;
    }
}