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
    public partial class offenseRecord : Form
    {

        public offenseRecord()
        {
            InitializeComponent();
            searchField.Text = "Search";
            searchField.ForeColor = Color.Black;

            this.ActiveControl = offenseRecLabel;

            OffenseRecordTable();


        }

        private void OffenseRecordTable(string search = "", DateTime? selectedDate = null)
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
                INNER JOIN offenses o ON v.offense_id = o.offense_id
                WHERE 
                    (s.name LIKE @search OR s.student_id LIKE @search)
            ";

                    // Apply date filter only if enabled
                    if (selectedDate.HasValue)
                    {
                        query += " AND DATE(v.violation_date) = @date";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    if (selectedDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@date", selectedDate.Value.Date);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    offenseRecDataGridView.DataSource = table;
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


        private void textBox1_Enter(object sender, EventArgs e)
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

            if (searchField.Text == "Search")
                return;

            OffenseRecordTable(searchField.Text.Trim());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage newform = new homePage();
            newform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            if (searchField.Text == "Search")
                return;

            DataView dv = offenseRecDataGridView.DataSource as DataView;

            if (dv == null)
            {
                DataTable dt = offenseRecDataGridView.DataSource as DataTable;
                if (dt != null)
                {
                    dv = dt.DefaultView;
                }
            } if (dv != null)
            {
                dv.RowFilter = string.Format("[Name] LIKE '%{0}%'", searchField.Text);
                offenseRecDataGridView.DataSource = dv;
            }
        }
        private void offenseRecord_Load(object sender, EventArgs e)
        {

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
        }

        private void addOffenseNav_Click_1(object sender, EventArgs e)
        {
            addOffense addOffense = new addOffense();
            addOffense.Show();
            this.Hide();
        }

        private void userManagementNav_Click_1(object sender, EventArgs e)
        {
            userManagementPage user = new userManagementPage();
            user.Show();
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

        private void offenseRecDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            DateTime? selectedDate = dateFilter.Checked
        ? dateFilter.Value.Date
        : (DateTime?)null;

            string searchText = searchField.Text == "Search"
                ? ""
                : searchField.Text.Trim();

            OffenseRecordTable(searchText, selectedDate);
        }

        private void homeNav_Click_2(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Show();
            this.Hide();
        }

        private void addOffenseNav_Click_2(object sender, EventArgs e)
        {
            addOffense add = new addOffense();
            add.Show();
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

        private void offenseRecord_Shown(object sender, EventArgs e)
        {
            offenseRecDataGridView.ClearSelection();
        }
        
    }
}

