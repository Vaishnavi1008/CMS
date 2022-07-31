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
    public partial class StudentIndividual : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;

        public StudentIndividual()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select * from NewAdmission where NAID= " + txtreg.Text + "", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                lblname.Text = ds.Tables[0].Rows[0][1].ToString();
                lblmother.Text = ds.Tables[0].Rows[0][2].ToString();
                lblgen.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelMObile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelemail.Text = ds.Tables[0].Rows[0][6].ToString();
                lblstand.Text = ds.Tables[0].Rows[0][6].ToString();
                labelmedium.Text = ds.Tables[0].Rows[0][7].ToString();
                labelschool.Text = ds.Tables[0].Rows[0][8].ToString();
                labelyear.Text = ds.Tables[0].Rows[0][9].ToString();
                labeladd.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblname.Text = "_______";
                lblmother.Text = "_______";
                lblgen.Text = "_______";
                labelDOB.Text = "_______";
                labelMObile.Text = "_______";
                labelemail.Text = "_______";
                lblstand.Text = "_______";
                labelmedium.Text = "_______";
                labelschool.Text = "_______";
                labelyear.Text = "_______";
                labeladd.Text = "_______";
            }

            



        }

        private void lblgen_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            lblname.Text = "_______";
            lblmother.Text = "_______";
            lblgen.Text = "_______";
            labelDOB.Text = "_______";
            labelMObile.Text = "_______";
            labelemail.Text = "_______";
            lblstand.Text = "_______";
            labelmedium.Text = "_______";
            labelschool.Text = "_______";
            labelyear.Text = "_______";
            labeladd.Text = "_______";

            txtreg.Text = "";
        }

        private void txtreg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

