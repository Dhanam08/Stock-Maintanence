using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace STORE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=STORE;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();
            this.Hide();
        }

        private void availbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Avail", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                stockgv.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void newstockbtn_Click(object sender, EventArgs e)
        {
            AvailStockForm af = new AvailStockForm();
            af.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Saless", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count>0)
            {
                stockgv.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void vwrequiredbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ProductName from Avail where Quantity=0", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                stockgv.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LOGINFORM lf=new LOGINFORM();

            lf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
