using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userField.Text = "Username";
            userField.ForeColor = Color.LightGray;

            passField.Text = "Password";
            passField.ForeColor = Color.LightGray;
        }

        private void userField_Enter(object sender, EventArgs e)
        {
            if(userField.Text == "Username")
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterForm newForm = new RegisterForm();
            newForm.Show();
        }
    }
}
