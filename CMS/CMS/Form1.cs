using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPss_Click(object sender, EventArgs e)
        {

        }

        private void tztUN_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtUN.Text))
            //{
            //    e.Cancel = true;
            //    txtUN.Focus();
            //    errorProvider1.SetError(txtUN, "This filed is required!!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtUN, null);
            //}
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtUN.Text;
            String password = txtpss.Text;

            if (username == "student" && password == "student")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                lblhead.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid user ID or PASSWORD!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher teacher = new AddTeacher();
            teacher.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void newAdmission_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void newAdmission_Click_1(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void fEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fee = new Fees();
            fee.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentr ss = new SearchStudentr();
            ss.Show();

        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividual sid = new StudentIndividual();
            sid.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();

        }

        private void rEMOVESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void eXITSYSTEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ? This will Delete Your Unsaved Data","Confirmation Dialog!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                Application.Exit();
            }
           
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
        }

       
    }
}
