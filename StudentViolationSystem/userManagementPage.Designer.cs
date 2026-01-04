namespace StudentViolationSystem
{
    partial class userManagementPage
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
            this.userManagementLbl = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.userManagementDataGrid = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.userManagementDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // userManagementLbl
            // 
            this.userManagementLbl.AutoSize = true;
            this.userManagementLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementLbl.Location = new System.Drawing.Point(287, 30);
            this.userManagementLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userManagementLbl.Name = "userManagementLbl";
            this.userManagementLbl.Size = new System.Drawing.Size(225, 29);
            this.userManagementLbl.TabIndex = 7;
            this.userManagementLbl.Text = "User Management";
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(293, 65);
            this.searchField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(727, 30);
            this.searchField.TabIndex = 4;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.Enter += new System.EventHandler(this.searchField_Enter);
            this.searchField.Leave += new System.EventHandler(this.searchField_Leave);
            // 
            // userManagementDataGrid
            // 
            this.userManagementDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userManagementDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userManagementDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.userManagementDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userManagementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userManagementDataGrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.userManagementDataGrid.Location = new System.Drawing.Point(301, 234);
            this.userManagementDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userManagementDataGrid.Name = "userManagementDataGrid";
            this.userManagementDataGrid.RowHeadersVisible = false;
            this.userManagementDataGrid.RowHeadersWidth = 51;
            this.userManagementDataGrid.RowTemplate.Height = 24;
            this.userManagementDataGrid.Size = new System.Drawing.Size(1147, 453);
            this.userManagementDataGrid.TabIndex = 8;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 812);
            this.panel1.TabIndex = 11;
            // 
            // logOutNav
            // 
            this.logOutNav.AutoSize = true;
            this.logOutNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutNav.Location = new System.Drawing.Point(83, 743);
            this.logOutNav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutNav.Name = "logOutNav";
            this.logOutNav.Size = new System.Drawing.Size(82, 25);
            this.logOutNav.TabIndex = 16;
            this.logOutNav.Text = "Log Out";
            this.logOutNav.Click += new System.EventHandler(this.logOutNav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentViolationSystem.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-33, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // userManagementNav
            // 
            this.userManagementNav.AutoSize = true;
            this.userManagementNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagementNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementNav.Location = new System.Drawing.Point(60, 444);
            this.userManagementNav.Name = "userManagementNav";
            this.userManagementNav.Size = new System.Drawing.Size(188, 25);
            this.userManagementNav.TabIndex = 12;
            this.userManagementNav.Text = "User Management";
            // 
            // addOffenseNav
            // 
            this.addOffenseNav.AutoSize = true;
            this.addOffenseNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOffenseNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOffenseNav.Location = new System.Drawing.Point(63, 377);
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
            this.offenseRecNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.offenseRecNav.Location = new System.Drawing.Point(63, 314);
            this.offenseRecNav.Name = "offenseRecNav";
            this.offenseRecNav.Size = new System.Drawing.Size(148, 25);
            this.offenseRecNav.TabIndex = 10;
            this.offenseRecNav.Text = "Offense Record";
            this.offenseRecNav.Click += new System.EventHandler(this.offenseRecNav_Click_1);
            // 
            // homeNav
            // 
            this.homeNav.AutoSize = true;
            this.homeNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeNav.Location = new System.Drawing.Point(69, 249);
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
            this.addOffenseIcon.Location = new System.Drawing.Point(8, 367);
            this.addOffenseIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addOffenseIcon.Name = "addOffenseIcon";
            this.addOffenseIcon.Size = new System.Drawing.Size(47, 43);
            this.addOffenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addOffenseIcon.TabIndex = 8;
            this.addOffenseIcon.TabStop = false;
            // 
            // offenseRecIcon
            // 
            this.offenseRecIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.offenseRecIcon.Image = global::StudentViolationSystem.Properties.Resources.offense_record_icon;
            this.offenseRecIcon.Location = new System.Drawing.Point(8, 304);
            this.offenseRecIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offenseRecIcon.Name = "offenseRecIcon";
            this.offenseRecIcon.Size = new System.Drawing.Size(47, 43);
            this.offenseRecIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offenseRecIcon.TabIndex = 7;
            this.offenseRecIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeIcon.Image = global::StudentViolationSystem.Properties.Resources.home_icon__1_;
            this.homeIcon.Location = new System.Drawing.Point(8, 239);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(47, 43);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 5;
            this.homeIcon.TabStop = false;
            // 
            // userManagementIcon
            // 
            this.userManagementIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userManagementIcon.Image = global::StudentViolationSystem.Properties.Resources.user_management_icon;
            this.userManagementIcon.Location = new System.Drawing.Point(8, 431);
            this.userManagementIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userManagementIcon.Name = "userManagementIcon";
            this.userManagementIcon.Size = new System.Drawing.Size(47, 43);
            this.userManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementIcon.TabIndex = 9;
            this.userManagementIcon.TabStop = false;
            // 
            // userManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userManagementDataGrid);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.userManagementLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userManagementDataGrid)).EndInit();
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
        private System.Windows.Forms.Label userManagementLbl;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.DataGridView userManagementDataGrid;
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
    }
}