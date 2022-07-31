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
    public partial class SearchStudentr : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;

        public SearchStudentr()
        {
            InitializeComponent();
        }

        private void SearchStudentr_Load(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select NewAdmission.NAID as StudentId, NewAdmission.fname as Full_Name , NewAdmission.mname as MOther_Name, NewAdmission.gender as Gender, NewAdmission.dob as Date_of_Birth, NewAdmission.mobile as Mobile_No, NewAdmission.email as Email, NewAdmission.semester as Semester, NewAdmission.prog as Programming, NewAdmission.sname as School_Name, NewAdmission.duration as Duration, NewAdmission.address as Address, fees.fees as Fees from NewAdmission inner join fees on NewAdmission.NAID=Fees.NAID", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            displayInfo.DataSource = ds.Tables[0];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select * from NewAdmission where NAID= "+txtreg.Text+"", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            displayInfo.DataSource = ds.Tables[0];
        }
    }
}
