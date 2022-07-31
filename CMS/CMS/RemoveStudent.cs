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
    public partial class RemoveStudent : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;


        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand(" select * from NewAdmission", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            displayInfo.DataSource = ds.Tables[0];
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("These will Delete Your Data","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                myConn.Open();

                cmd = new SqlCommand(" delete from NewAdmission where NAID =" + txtreg.Text + "", myConn);
                DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);


                MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void displayInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
