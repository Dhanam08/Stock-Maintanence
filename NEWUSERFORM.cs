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
    public partial class NEWUSERFORM : Form
    {
        public NEWUSERFORM()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=STORE;Integrated Security=True");
        private void registerbtn_Click(object sender, EventArgs e)
        {
            string Name = NUnametxtbox.Text;
            string pwd = NUpasswordtxtbox.Text;
            string conpass = NUconpasswordtxtbox.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Login values('" + NUnametxtbox.Text + "','" + NUpasswordtxtbox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERT SUCCESSFULLY....!");
            LOGINFORM lf = new LOGINFORM();
            lf.Show();
            this.Hide();
        }

        private void NEWUSERFORM_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            NUnametxtbox.Clear();
            NUpasswordtxtbox.Clear();
            NUconpasswordtxtbox.Clear();
        }

        private void NUconpasswordtxtbox_TextChanged(object sender, EventArgs e)
        {
            if(NUpasswordtxtbox.Text==NUconpasswordtxtbox.Text)
            {
                label5.Visible = true;
                label5.Text = "Matching";
                label5.ForeColor = Color.Green;
            }
            else
            {
                label5.Visible = true;
                label5.Text = "Mis-Matching";
                label5.ForeColor = Color.Red;
            }
        }
    }
}
