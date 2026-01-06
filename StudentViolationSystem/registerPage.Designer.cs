namespace StudentViolationSystem
{
    partial class RegisterPage
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
            this.logInLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.studentIdField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.registerLbl = new System.Windows.Forms.Label();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.initialField = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.fNameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.logInLink);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.studentIdField);
            this.panel1.Controls.Add(this.emailField);
            this.panel1.Controls.Add(this.registerLbl);
            this.panel1.Controls.Add(this.confirmPassField);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.userField);
            this.panel1.Controls.Add(this.initialField);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.fNameField);
            this.panel1.Controls.Add(this.surnameField);
            this.panel1.Location = new System.Drawing.Point(332, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 516);
            this.panel1.TabIndex = 1;
            // 
            // logInLink
            // 
            this.logInLink.AutoSize = true;
            this.logInLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLink.Location = new System.Drawing.Point(323, 469);
            this.logInLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logInLink.Name = "logInLink";
            this.logInLink.Size = new System.Drawing.Size(54, 20);
            this.logInLink.TabIndex = 11;
            this.logInLink.TabStop = true;
            this.logInLink.Text = "Log In";
            this.logInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Already have an account?";
            // 
            // studentIdField
            // 
            this.studentIdField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.studentIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIdField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdField.Location = new System.Drawing.Point(29, 84);
            this.studentIdField.Name = "studentIdField";
            this.studentIdField.Size = new System.Drawing.Size(433, 29);
            this.studentIdField.TabIndex = 9;
            this.studentIdField.TextChanged += new System.EventHandler(this.studentIdField_TextChanged);
            this.studentIdField.Enter += new System.EventHandler(this.studentIdField_Enter);
            this.studentIdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentIdField_KeyPress);
            this.studentIdField.Leave += new System.EventHandler(this.studentIdField_Leave);
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.emailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(29, 119);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(433, 29);
            this.emailField.TabIndex = 8;
            this.emailField.Enter += new System.EventHandler(this.emailField_Enter);
            this.emailField.Leave += new System.EventHandler(this.emailField_Leave);
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.Location = new System.Drawing.Point(173, 37);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(124, 31);
            this.registerLbl.TabIndex = 7;
            this.registerLbl.Text = "Register";
            // 
            // confirmPassField
            // 
            this.confirmPassField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.confirmPassField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.Location = new System.Drawing.Point(29, 366);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(433, 29);
            this.confirmPassField.TabIndex = 6;
            this.confirmPassField.UseSystemPasswordChar = true;
            this.confirmPassField.Enter += new System.EventHandler(this.confirmPassField_Enter);
            this.confirmPassField.Leave += new System.EventHandler(this.confirmPassField_Leave);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(29, 323);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(433, 29);
            this.passField.TabIndex = 5;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // userField
            // 
            this.userField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(29, 284);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(433, 29);
            this.userField.TabIndex = 4;
            this.userField.Enter += new System.EventHandler(this.userField_Enter);
            this.userField.Leave += new System.EventHandler(this.userField_Leave);
            // 
            // initialField
            // 
            this.initialField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.initialField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialField.Location = new System.Drawing.Point(29, 240);
            this.initialField.Name = "initialField";
            this.initialField.Size = new System.Drawing.Size(433, 29);
            this.initialField.TabIndex = 3;
            this.initialField.TextChanged += new System.EventHandler(this.initialField_TextChanged);
            this.initialField.Enter += new System.EventHandler(this.initialField_Enter);
            this.initialField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initialField_KeyPress);
            this.initialField.Leave += new System.EventHandler(this.initialField_Leave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(161, 412);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(166, 41);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // fNameField
            // 
            this.fNameField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameField.Location = new System.Drawing.Point(29, 197);
            this.fNameField.Name = "fNameField";
            this.fNameField.Size = new System.Drawing.Size(433, 29);
            this.fNameField.TabIndex = 1;
            this.fNameField.Enter += new System.EventHandler(this.FnameField_Enter);
            this.fNameField.Leave += new System.EventHandler(this.FnameField_Leave);
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.surnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.Location = new System.Drawing.Point(29, 157);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(433, 29);
            this.surnameField.TabIndex = 0;
            this.surnameField.TextChanged += new System.EventHandler(this.RegisterPage_Load);
            this.surnameField.Enter += new System.EventHandler(this.surnameField_Enter);
            this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 689);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegisterPage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox initialField;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox fNameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label registerLbl;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox studentIdField;
        private System.Windows.Forms.LinkLabel logInLink;
        private System.Windows.Forms.Label label1;
    }
}