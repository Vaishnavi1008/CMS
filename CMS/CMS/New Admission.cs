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
    public partial class New_Admission : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;
        
        
        public New_Admission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String mname = txtMname.Text;
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
            int mobile = int.Parse(txtMob.Text);
            String email = txtEmail.Text;
            String semester = CbSem.Text;
            String program = CBProgram.Text;
            String sname = txtSchool.Text;
            String duration = CBDuration.Text;
            String address = richAddress.Text;

            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();
           
            cmd = new SqlCommand("insert into NewAdmission (fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,address) values('" + name + "','" + mname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + address + "')",myConn);
            
             DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);
            
            myConn.Close();
            MessageBox.Show("Data Saved . Remember the  Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            richAddress.Clear();
            txtMname.Clear();
            rdFemale.Checked = false;
            rdMale.Checked = false;
            txtMob.Clear();
            txtEmail.Clear();
            txtSchool.Clear();
            CBProgram.ResetText();
            CbSem.ResetText();
            CBDuration.ResetText();

        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select max (NAID) from NewAdmission", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            Int64 abc = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
            lblid.Text = (abc+1).ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void New_Admission_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void lblAdmssion_Click(object sender, EventArgs e)
        {

        }
    }
}
