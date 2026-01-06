namespace StudentViolationSystem
{
    partial class studentView
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
            this.logOutNav = new System.Windows.Forms.Label();
            this.logOutText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schoolNameLbl = new System.Windows.Forms.Label();
            this.studIDText = new System.Windows.Forms.Label();
            this.studNameText = new System.Windows.Forms.Label();
            this.gradeLvlText = new System.Windows.Forms.Label();
            this.sectionText = new System.Windows.Forms.Label();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.logOutNav);
            this.panel1.Controls.Add(this.logOutText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.schoolNameLbl);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 71);
            this.panel1.TabIndex = 0;
            // 
            // logOutNav
            // 
            this.logOutNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutNav.AutoSize = true;
            this.logOutNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutNav.Location = new System.Drawing.Point(1010, 29);
            this.logOutNav.Name = "logOutNav";
            this.logOutNav.Size = new System.Drawing.Size(66, 20);
            this.logOutNav.TabIndex = 17;
            this.logOutNav.Text = "Log Out";
            this.logOutNav.Click += new System.EventHandler(this.logOutNav_Click);
            // 
            // logOutText
            // 
            this.logOutText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutText.AutoSize = true;
            this.logOutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutText.Location = new System.Drawing.Point(1112, 24);
            this.logOutText.Name = "logOutText";
            this.logOutText.Size = new System.Drawing.Size(63, 20);
            this.logOutText.TabIndex = 7;
            this.logOutText.Text = "Log out";
            this.logOutText.Click += new System.EventHandler(this.logOutText_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentViolationSystem.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // schoolNameLbl
            // 
            this.schoolNameLbl.AutoSize = true;
            this.schoolNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolNameLbl.Location = new System.Drawing.Point(89, 24);
            this.schoolNameLbl.Name = "schoolNameLbl";
            this.schoolNameLbl.Size = new System.Drawing.Size(345, 25);
            this.schoolNameLbl.TabIndex = 0;
            this.schoolNameLbl.Text = "Highlands National High School";
            this.schoolNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // studIDText
            // 
            this.studIDText.AutoSize = true;
            this.studIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studIDText.Location = new System.Drawing.Point(69, 110);
            this.studIDText.Name = "studIDText";
            this.studIDText.Size = new System.Drawing.Size(130, 29);
            this.studIDText.TabIndex = 1;
            this.studIDText.Text = "202500567";
            // 
            // studNameText
            // 
            this.studNameText.AutoSize = true;
            this.studNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNameText.Location = new System.Drawing.Point(68, 138);
            this.studNameText.Name = "studNameText";
            this.studNameText.Size = new System.Drawing.Size(264, 29);
            this.studNameText.TabIndex = 2;
            this.studNameText.Text = "DELA CRUZ, JUAN A.";
            // 
            // gradeLvlText
            // 
            this.gradeLvlText.AutoSize = true;
            this.gradeLvlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLvlText.Location = new System.Drawing.Point(71, 165);
            this.gradeLvlText.Name = "gradeLvlText";
            this.gradeLvlText.Size = new System.Drawing.Size(24, 25);
            this.gradeLvlText.TabIndex = 3;
            this.gradeLvlText.Text = "7";
            // 
            // sectionText
            // 
            this.sectionText.AutoSize = true;
            this.sectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionText.Location = new System.Drawing.Point(87, 165);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(26, 25);
            this.sectionText.TabIndex = 4;
            this.sectionText.Text = "A";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.studentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentDataGridView.ColumnHeadersHeight = 27;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentDataGridView.EnableHeadersVisualStyles = false;
            this.studentDataGridView.Location = new System.Drawing.Point(74, 196);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(974, 468);
            this.studentDataGridView.TabIndex = 5;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1094, 689);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.sectionText);
            this.Controls.Add(this.gradeLvlText);
            this.Controls.Add(this.studNameText);
            this.Controls.Add(this.studIDText);
            this.Controls.Add(this.panel1);
            this.Name = "studentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.studentView_Load);
            this.Shown += new System.EventHandler(this.studentView_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label schoolNameLbl;
        private System.Windows.Forms.Label studIDText;
        private System.Windows.Forms.Label studNameText;
        private System.Windows.Forms.Label gradeLvlText;
        private System.Windows.Forms.Label sectionText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logOutText;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.Label logOutNav;
    }
}