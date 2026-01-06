using MySql.Data.MySqlClient;
using StudentViolationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentViolationSystem
{
    public partial class userManagementPage : Form
    {
        public userManagementPage()
        {
            InitializeComponent();
            searchField.Text = "Search";
            searchField.ForeColor = Color.Black;

            this.ActiveControl = userManagementLbl;
            UserManagmentTable();
        }

        // Inside offenseRecord class
        public string LoggedInStudentId { get; set; }

        private void UserManagmentTable()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            s.name AS 'Name',
                            a.username AS 'Username',
                            a.email AS 'Email'
                        FROM studentinfo s
                        JOIN accounts a ON s.student_id = a.student_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    userManagementDataGrid.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Failed to load student records.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            homePage form = new homePage();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            offenseRecord form = new offenseRecord();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addOffense form = new addOffense();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userManagementPage form = new userManagementPage();
            form.Show();
            this.Hide();
        }

        private void searchField_Enter(object sender, EventArgs e)
        {
            if (searchField.Text == "Search")
            {
                searchField.Text = "";
                searchField.ForeColor = Color.Black;
            }
        }

        private void searchField_Leave(object sender, EventArgs e)
        {
            if (searchField.Text == "")
            {
                searchField.Text = "Search";
                searchField.ForeColor = Color.Black;
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            SearchUsers(searchField.Text);
        }

       
    private void SearchUsers(string keyword)
        {
            string connectionString = "server=localhost;database=student_violation_monitoring_system_db;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                SELECT
                    s.name AS 'Name',
                    a.username AS 'Username',
                    a.email AS 'Email'
                FROM studentinfo s
                JOIN accounts a ON s.student_id = a.student_id
                WHERE s.name LIKE @search
                   OR a.username LIKE @search
                   OR a.email LIKE @search";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    userManagementDataGrid.DataSource = dt;
                }
            }
        }

    private void userManagementPage_Load(object sender, EventArgs e)
        {
            userManagementDataGrid.ClearSelection();
        }

        private void logOutText_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                loginPage newform = new loginPage();
                newform.Show();
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

        private void addOffenseNav_Click_1(object sender, EventArgs e)
        {
            addOffense addOffense = new addOffense();
            addOffense.Show();
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

        private void userManagementDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userManagementNav_Click_1(object sender, EventArgs e)
        {

        }
    }
}
