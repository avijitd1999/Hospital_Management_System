using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtPassword.Text;
            if(username == "hms" && pass == "pass")
            {
                //MessageBox.Show("you have entered right username and password");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("wrong user id or pasword"); 
            }
        }
        private void ahh_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

