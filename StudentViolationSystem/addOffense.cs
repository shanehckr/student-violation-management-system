using Google.Protobuf.Compiler;
using StudentViolationSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static Mysqlx.Notice.Warning.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace StudentViolationSystem
{
    public partial class addOffense : Form
    {
        public addOffense()
        {
            InitializeComponent();
            this.ActiveControl = studInfoPanel;
            
        }

        private void ClearFields()
        {
            // ComboBoxes
            studentNameCb.SelectedIndex = -1;
            offenseClassCb.SelectedIndex = -1;
            offenseTitleCb.Items.Clear();

            // TextFields
            studentIdField.Clear();
            sectionField.Clear();
            yearLvlField.Clear();
            actionTakenField.Clear();

            // Date (optional: reset to today)
            dateTimePicker.Value = DateTime.Now;
        }

        private void DisableAutoFilledFields()
        {
            studentIdField.ReadOnly = true;
            sectionField.ReadOnly = true;
            yearLvlField.ReadOnly = true;
            actionTakenField.ReadOnly = true;
        }

        private void LoadStudents()
        {
            studentNameCb.Items.Clear();
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();

                string sql = @"SELECT DISTINCT name 
                       FROM studentinfo
                       WHERE student_id <> 1
                       ORDER BY name ASC";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                
                while (dr.Read())
                {
                    studentNameCb.Items.Add(dr["name"].ToString());
                }
            }
        }


        private void LoadOffenseCategory()
        {
            offenseClassCb.Items.Clear();
            offenseClassCb.Items.Add("Major");
            offenseClassCb.Items.Add("Minor");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage newform = new homePage();
            newform.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            offenseRecord newform = new offenseRecord();
            newform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addOffense newform = new addOffense();
            newform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userManagementPage form = new userManagementPage();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addOffense_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadOffenseCategory();
            DisableAutoFilledFields();
        }


        private void logOutText_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                loginPage newform = new loginPage();
                newform.Show();
                this.Hide();
            }
        }

        private void homeNav_Click(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Show();
            this.Hide();
        }

        private void offenseRecNav_Click(object sender, EventArgs e)
        {
            offenseRecord offenseRec = new offenseRecord();
            offenseRec.Show();
            this.Hide();
        }

        private void addOffenseNav_Click(object sender, EventArgs e)
        {
            addOffense addOff = new addOffense();
            addOff.Show();
            this.Hide();
        }

        private void userManagementNav_Click(object sender, EventArgs e)
        {
            userManagementPage userMan = new userManagementPage();
            userMan.Show();
            this.Hide();
        }

        private void homeNav_Click_1(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Show();
            this.Hide();
        }

        private void offenseRecNav_Click_1(object sender, EventArgs e)
        {
            offenseRecord record = new offenseRecord();
            record.Show();
            this.Hide();
        }

        private void userManagementNav_Click_1(object sender, EventArgs e)
        {
            userManagementPage usuer = new userManagementPage();
            usuer.Show();
            this.Hide();
        }

        private void logOutNav_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                loginPage form = new loginPage();
                form.Show();
                this.Hide();
            }
        }

        private void yearLvlTxtField_TextChanged(object sender, EventArgs e)
        {

        }

        private void studIdTxtField_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void studentNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM studentinfo WHERE name = @name";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", studentNameCb.Text);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    studentIdField.Text = dr["student_id"].ToString();
                    sectionField.Text = dr["section"].ToString();
                    yearLvlField.Text = dr["year_level"].ToString();
                }
            }
        }

        private void offenseClassCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                string sql = "SELECT offense_name FROM offenses WHERE category = @cat";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cat", offenseClassCb.Text);

                MySqlDataReader dr = cmd.ExecuteReader();
                offenseTitleCb.Items.Clear();

                while (dr.Read())
                {
                    offenseTitleCb.Items.Add(dr["offense_name"].ToString());
                }
            }
        }

        private void offenseTitleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                string sql = "SELECT default_action FROM offenses WHERE offense_name = @name";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", offenseTitleCb.Text);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    actionTakenField.Text = dr["default_action"].ToString();
                }
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (studentIdField.Text == "" || offenseTitleCb.Text == "" || actionTakenField.Text == "")
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            saveBtn.Enabled = false;

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();

                try
                {
                    string getOffenseId = "SELECT offense_id FROM offenses WHERE offense_name = @name";
                    MySqlCommand getCmd = new MySqlCommand(getOffenseId, con);
                    getCmd.Parameters.AddWithValue("@name", offenseTitleCb.Text);

                    object result = getCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Selected offense does not exist.");
                        saveBtn.Enabled = true;
                        return;
                    }

                    int offenseId = Convert.ToInt32(result);

                    string checkDuplicate = @"SELECT COUNT(*) 
                          FROM violations
                          WHERE student_id = @studentId
                          AND offense_id = @offenseId
                          AND DATE(violation_date) = DATE(@date)";

                    MySqlCommand checkCmd = new MySqlCommand(checkDuplicate, con);
                    checkCmd.Parameters.AddWithValue("@studentId", studentIdField.Text);
                    checkCmd.Parameters.AddWithValue("@offenseId", offenseId);
                    checkCmd.Parameters.AddWithValue("@date", dateTimePicker.Value);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show(
                            "This offense has already been recorded for this student on the selected date.",
                            "Duplicate Record",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        saveBtn.Enabled = true;
                        return;
                    }

                    string insert = @"INSERT INTO violations
                              (student_id, offense_id, violation_date, action_taken)
                              VALUES (@studentId, @offenseId, @date, @action)";

                    MySqlCommand cmd = new MySqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@studentId", studentIdField.Text);
                    cmd.Parameters.AddWithValue("@offenseId", offenseId);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@action", actionTakenField.Text);

                    cmd.ExecuteNonQuery();

                    if (actionTakenField.Text.Trim()
                        .Equals("Parent Notified", StringComparison.OrdinalIgnoreCase))
                    {
                        List<Guardian> guardians = GetStudentGuardians(studentIdField.Text);

                        if (guardians.Count == 0)
                        {
                            MessageBox.Show(
                                "Violation saved, but no guardian email was found for this student.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else
                        {
                            EmailService emailService = new EmailService();

                            foreach (Guardian guardian in guardians)
                            {
                                try
                                {
                                    await emailService.SendParentNotification(
                                        guardian.Email,
                                        guardian.Name,
                                        studentNameCb.Text,
                                        offenseTitleCb.Text,
                                        actionTakenField.Text
                                    );
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(
                                        $"Violation saved but failed to email {guardian.Email}\n\n{ex.Message}",
                                        "Email Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                    );
                                }
                            }
                        }
                    }

                    MessageBox.Show("Violation saved successfully.");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred while saving the violation.\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                finally
                {
                    saveBtn.Enabled = true;
                }
            }
        }


        private List<Guardian> GetStudentGuardians(string studentId)
        {
            List<Guardian> guardians = new List<Guardian>();

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();

                string query = @"SELECT guardian_name, email
                         FROM guardians
                         WHERE student_id = @studentId";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guardians.Add(new Guardian
                        {
                            Name = reader["guardian_name"].ToString(),
                            Email = reader["email"].ToString()
                        });
                    }
                }
            }

            return guardians;
        }

        private void addOffenseLbl_Click(object sender, EventArgs e)
        {

        }

        private void contentHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeNav_Click_2(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Show();
            this.Hide();
        }

        private void offenseRecNav_Click_2(object sender, EventArgs e)
        {
            offenseRecord rec = new offenseRecord();
            rec.Show();
            this.Hide();
        }

        private void userManagementNav_Click_2(object sender, EventArgs e)
        {
            userManagementPage user = new userManagementPage();
            user.Show();
            this.Hide();
        }

        private void logOutNav_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                loginPage form = new loginPage();
                form.Show();
                this.Hide();
            }
        }
    }
}






