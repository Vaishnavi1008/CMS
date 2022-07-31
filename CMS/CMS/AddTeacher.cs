using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class AddTeacher : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;

        public AddTeacher()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void CBDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void CBProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
          
            String gender = "";
            bool isChecked = rdFemale.Checked;
            if (isChecked)
            {
                gender = rdFemale.Text;
            }
            else
            {
                gender = rdMale.Text;
            }
            String dob = dtPicker.Text;
            Int64 mobile = Int64.Parse(txtMob.Text);
            String email = txtEmail.Text;
            String semester = CbSem.Text;
            String program = CBProgram.Text;
            String sname = txtSchool.Text;
            String duration = CBDuration.Text;
            String address = richAddress.Text;

            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("insert into Teacher(fname,gender,dob,mobile,email,semester,prog,sname,duration,address) values('" + name + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + address + "')", myConn);

            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            myConn.Close();

            MessageBox.Show("Data Saved.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
    }
}
