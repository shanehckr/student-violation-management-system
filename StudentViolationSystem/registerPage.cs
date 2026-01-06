using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentViolationSystem
{


    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();

            surnameField.Text = "Surname";
            surnameField.ForeColor = Color.LightGray;

            fNameField.Text = "First Name";
            fNameField.ForeColor = Color.LightGray;

            initialField.Text = "Middle Initial";
            initialField.ForeColor = Color.LightGray;

            userField.Text = "Username";
            userField.ForeColor = Color.LightGray;

            passField.Text = "Password";
            passField.ForeColor = Color.LightGray;

            confirmPassField.Text = "Confirm Password";
            confirmPassField.ForeColor = Color.LightGray;

            studentIdField.Text = "Student ID";
            studentIdField.ForeColor = Color.LightGray;

            emailField.Text = "Email";
            emailField.ForeColor = Color.LightGray;


            this.ActiveControl = registerLbl;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2")); 
                return builder.ToString();
            }
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            passField.Text = "";
            confirmPassField.Text = "";

        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text == "Surname")
            {
                surnameField.Text = "";
                surnameField.ForeColor = Color.Black;
            }
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text == "")
            {
                surnameField.Text = "Surname";
                surnameField.ForeColor = Color.LightGray;
            }
        }

        private void FnameField_Enter(object sender, EventArgs e)
        {
            if (fNameField.Text == "First Name")
            {
                fNameField.Text = "";
                fNameField.ForeColor = Color.Black;
            }
        }

        private void FnameField_Leave(object sender, EventArgs e)
        {
            if (fNameField.Text == "")
            {
                fNameField.Text = "First Name";
                fNameField.ForeColor = Color.LightGray;
            }
        }

        private void initialField_Enter(object sender, EventArgs e)
        {
            if (initialField.Text == "Middle Initial")
            {
                initialField.Text = "";
                initialField.ForeColor = Color.Black;
            }
        }

        private void initialField_Leave(object sender, EventArgs e)
        {
            if (initialField.Text == "")
            {
                initialField.Text = "Middle Initial";
                initialField.ForeColor = Color.LightGray;
            }
        }

        private void userField_Enter(object sender, EventArgs e)
        {
            if (userField.Text == "Username")
            {
                userField.Text = "";
                userField.ForeColor = Color.Black;
            }
        }

        private void userField_Leave(object sender, EventArgs e)
        {
            if (userField.Text == "")
            {
                userField.Text = "Username";
                userField.ForeColor = Color.LightGray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Password")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Password";
                passField.ForeColor = Color.LightGray;
            }
        }

        private void confirmPassField_Enter(object sender, EventArgs e)
        {
            if (confirmPassField.Text == "Confirm Password")
            {
                confirmPassField.Text = "";
                confirmPassField.ForeColor = Color.Black;
            }
        }

        private void confirmPassField_Leave(object sender, EventArgs e)
        {
            if (confirmPassField.Text == "")
            {
                confirmPassField.Text = "Confirm Password";
                confirmPassField.ForeColor = Color.LightGray;
            }
        }

        private void RegisterPage_Load_1(object sender, EventArgs e)
        {

        }


        private void registerButton_Click(object sender, EventArgs e)
        {
           
            string surname = surnameField.Text.Trim();
            string firstName = fNameField.Text.Trim();
            string middleInitial = initialField.Text.Trim();
            string username = userField.Text.Trim();
            string studentId = studentIdField.Text.Trim();
            string email = emailField.Text.Trim();
            string password = passField.Text;
            string confirmPassword = confirmPassField.Text;

            bool hasEmptyField =
                string.IsNullOrWhiteSpace(surname) || surname == "Surname" ||
                string.IsNullOrWhiteSpace(firstName) || firstName == "First Name" ||
                string.IsNullOrWhiteSpace(username) || username == "Username" ||
                string.IsNullOrWhiteSpace(studentId) || studentId == "Student ID" ||
                string.IsNullOrWhiteSpace(email) || email == "Email" ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword);

            if (hasEmptyField)
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

       
            if (studentId.Length != 9)
            {
                MessageBox.Show("Student ID must be exactly 9 digits.");
                return;
            }

         
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

           
            string fullName =
                string.IsNullOrWhiteSpace(middleInitial) || middleInitial == "M.I."
                    ? $"{surname}, {firstName}"
                    : $"{surname}, {firstName} {middleInitial.ToUpper()}.";

            fullName = fullName.ToUpper();

            
            string connString =
                "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string checkStudentQuery = @"
                        SELECT COUNT(*)
                        FROM studentinfo
                        WHERE student_id = @student_id;
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(checkStudentQuery, conn))
                    {
                        long studentIdValue;

                        if (!long.TryParse(studentId.Trim(), out studentIdValue))
                        {
                            MessageBox.Show("Invalid Student ID format.");
                            return;
                        }

                        cmd.Parameters.Add("@student_id", MySqlDbType.Int64).Value = studentIdValue;

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("Student ID does not exist in our records.");
                            return;
                        }
                    }



                    string checkAccountQuery = @"
                SELECT 1
                FROM accounts
                WHERE student_id = @student_id";

                    using (MySqlCommand cmd = new MySqlCommand(checkAccountQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", studentId);

                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("An account for this student already exists.");
                            return;
                        }
                    }

                    string insertAccountQuery = @"
                INSERT INTO accounts
                (student_id, username, email, password_hash, role)
                VALUES
                (@student_id, @username, @email, @password_hash, @role)";

                    using (MySqlCommand cmd = new MySqlCommand(insertAccountQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", studentId);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password_hash", HashPassword(password));
                        cmd.Parameters.AddWithValue("@role", "student");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account created successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating account: " + ex.Message);
                }
            }
        }



        private void studentIdField_Enter(object sender, EventArgs e)
        {
            if (studentIdField.Text == "Student ID")
            {
                studentIdField.Text = "";
                studentIdField.ForeColor = Color.Black;
            }
        }

        private void studentIdField_Leave(object sender, EventArgs e)
        {
            if (studentIdField.Text == "")
            {
                studentIdField.Text = "Student ID";
                studentIdField.ForeColor = Color.LightGray;
            }
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Email")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.Text = "Email";
                emailField.ForeColor = Color.LightGray;
            }
        }

        private void studentIdField_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void studentIdField_TextChanged(object sender, EventArgs e)
        {
            if (studentIdField.Text == "Student ID") return;

            if (studentIdField.Text.Length > 9)
            {
                MessageBox.Show("Student ID must contain exactly 9 digits.");

                studentIdField.Text = studentIdField.Text.Substring(0, 9);
                studentIdField.SelectionStart = studentIdField.Text.Length;
            }
        }



        private void initialField_KeyPress(object sender, KeyPressEventArgs e)
        {
      
            if (char.IsControl(e.KeyChar))
                return;


            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void initialField_TextChanged(object sender, EventArgs e)
        {
            if (initialField.Text == "Middle Initial") return;

            if (initialField.Text.Length > 1)
            {
                MessageBox.Show("Middle Initial must contain only one letter.");
                initialField.Text = initialField.Text.Substring(0, 1);
                initialField.SelectionStart = initialField.Text.Length;
            }

            initialField.Text = initialField.Text.ToUpper();
            initialField.SelectionStart = initialField.Text.Length;
        }

        private void logInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            this.Close(); 
        }
    }
}





