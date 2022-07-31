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
    public partial class UpgradeSemester : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;

        public UpgradeSemester()
        {
            InitializeComponent();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Semester Update Warning!","Confirm?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                myConn.Open();

                cmd = new SqlCommand("update NewAdmission set semester='" + cbto.Text + "'where semester= '" + cbfrom.Text + "' ",myConn);
                DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                MessageBox.Show("Upgrade Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upgrade Cancel", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
