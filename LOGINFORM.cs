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
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=STORE;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NEWUSERFORM nu = new NEWUSERFORM();
            nu.Show();
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //string uname = LFusernametxtbok.Text;
            //string pwd = LFpasswordtxtbox.Text;
            if(LFusernametxtbok.Text !="" && LFpasswordtxtbox.Text !="")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Login where UserName='"+LFusernametxtbok.Text+"' and Password='"+LFpasswordtxtbox.Text+"'",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds=new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("LOGIN SUCCESSFULLY");
                    MainForm mf=new MainForm();
                    mf.Show();
                    this.Hide();

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("PLZ Ener the Input...!");
            }
           
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            LFusernametxtbok.Clear();
            LFpasswordtxtbox.Clear();
        }
    }
}
