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
    public partial class Fees : Form
    {
        SqlConnection myConn;
        SqlCommand cmd;
        SqlDataAdapter DA;

        public Fees()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            if (textBox1.Text != "")
            {
                myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                myConn.Open();

                cmd = new SqlCommand("select fname,mname,duration from NewAdmission where NAID= " + textBox1.Text + "", myConn);
                DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                if(ds.Tables[0].Rows.Count !=0)
                {
                    lblname.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblmother.Text = ds.Tables[0].Rows[0][1].ToString();
                    lbldura.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    lblname.Text = "________";
                    lblmother.Text = "________";
                    lbldura.Text = "________";
                }
            }
            else
            {
                textBox1.Text = "";
                txtFees.Text = "";
                lblname.Text = "________";
                lblmother.Text = "________";
                lbldura.Text = "________";
            }
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConn.Open();

            cmd = new SqlCommand("select * from fees where NAID= " + textBox1.Text + "", myConn);
            DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);


            if (ds.Tables[0].Rows.Count==0)
            {
                myConn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=college;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                myConn.Open();

                cmd = new SqlCommand("insert into fees (NAID,fees) values(" + textBox1.Text + "," + txtFees.Text + ")", myConn);
                DA = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                DA.Fill(ds1);

                if (MessageBox.Show("Fees Submition Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    textBox1.Text = "";
                    txtFees.Text = "";
                    lblname.Text = "________";
                    lblmother.Text = "________";
                    lbldura.Text = "________";

                }
            }
            else
            {
                MessageBox.Show("Fees Already Submitted.");
                textBox1.Text = "";
                txtFees.Text = "";
                lblname.Text = "________";
                lblmother.Text = "________";
                lbldura.Text = "________";

            }
            
        }
    }
}
