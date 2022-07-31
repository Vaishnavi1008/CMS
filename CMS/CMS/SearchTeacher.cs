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
    public partial class SearchTeacher : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;

        public SearchTeacher()
        {
            InitializeComponent();
        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select * from Teacher", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            displayInfo.DataSource = ds.Tables[0];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select * from Teacher where Tid="+txtreg.Text+"", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            displayInfo.DataSource = ds.Tables[0];
        }
    }
}
