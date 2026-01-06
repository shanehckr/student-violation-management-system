using MySql.Data.MySqlClient;
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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
            HomePageData();
            this.ActiveControl = homeLbl;

        }

        private void LoadDashboardCounts()
        {
           
            totalStudents.Text = Database.GetCount(
                "SELECT COUNT(DISTINCT student_id) FROM violations"
            ).ToString();

          
            totalOffense.Text = Database.GetCount(
                "SELECT COUNT(*) FROM violations"
            ).ToString();

        
            totalMajorOffense.Text = Database.GetCount(
                @"SELECT COUNT(*) 
          FROM violations v
          JOIN offenses o ON v.offense_id = o.offense_id
          WHERE o.category = 'Major'"
            ).ToString();

            
            totalMinorOffense.Text = Database.GetCount(
                @"SELECT COUNT(*) 
          FROM violations v
          JOIN offenses o ON v.offense_id = o.offense_id
          WHERE o.category = 'Minor'"
            ).ToString();
        }


        private void HomePageData()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            v.violation_date AS 'Date',
                            s.student_id AS 'Student ID',
                            s.name AS 'Name',
                            s.year_level AS 'Year Level',
                            s.section AS 'Section',
                            o.offense_name AS 'Offense Name',
                            o.category AS 'Category',
                            o.default_action AS 'Action Taken'
                       
                        FROM studentinfo s
                        INNER JOIN violations v ON s.student_id = v.student_id
                        INNER JOIN offenses o ON v.offense_id = o.offense_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    homeDataGridView.DataSource = table;
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
            userManagementPage userNav = new userManagementPage();
            userNav.Show();
            this.Hide();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void offenseRecNav_Click_1(object sender, EventArgs e)
        {
            offenseRecord rec = new offenseRecord();
            rec.Show();
            this.Hide();
        }

        private void addOffenseNav_Click_1(object sender, EventArgs e)
        {
            addOffense add = new addOffense();
            add.Show();
            this.Hide();
        }

        private void userManagementNav_Click_1(object sender, EventArgs e)
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

        private void homeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homePage_Shown(object sender, EventArgs e)
        {
            homeDataGridView.ClearSelection();
            homeDataGridView.CurrentCell = null;
        }

        private void homePage_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
