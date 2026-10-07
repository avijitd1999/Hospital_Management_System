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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btn.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labellndecator4.ForeColor = Color.Red;
            labellndecator1.ForeColor = Color.Black;
            labellndecator2.ForeColor = Color.Black;
            labellndecator3.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labellndecator1.ForeColor = Color.Red;
            labellndecator2.ForeColor = Color.Black;
            labellndecator3.ForeColor = Color.Black;
            labellndecator4.ForeColor = Color.Black;

            btn.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            labellndecator3.ForeColor = Color.Red;
            labellndecator1.ForeColor = Color.Black;
            labellndecator2.ForeColor = Color.Black;
            labellndecator4.ForeColor = Color.Black;

            btn.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labellndecator2.ForeColor = Color.Red;
            labellndecator1.ForeColor = Color.Black;
            labellndecator3.ForeColor = Color.Black;
            labellndecator4.ForeColor = Color.Black;

            btn.Visible = true;
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            String address = textAddress.Text;
            Int64 contact = Convert.ToInt64(textContact.Text);
            int age = Convert.ToInt32(textAge.Text);
            String Gender = comboGender.Text;
            String blood = textBlood.Text;
            String any = textAny.Text;
            int pid = Convert.ToInt32(textPid.Text);



            

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(textBox1.Text);
            String sympt = txtBxSymptoms.Text;
            String diag = txtBxDiagnosis.Text;
            String medicine = txtBxMedicines.Text;
            String ward = comboBxWard.Text;
            String wardType = comboBxWardType.Text;
        }
    }
}
