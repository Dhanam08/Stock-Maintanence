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
    public partial class AvailStockForm : Form
    {
        public AvailStockForm()
        {
            InitializeComponent();
        }
        string product_name;
        int AvailQuantity, product_price;
        int total_price;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=STORE;Integrated Security=True");
        private void salepaybtn_Click(object sender, EventArgs e)
        {
            product_name = prodnametxtbox.Text;
            product_price = int.Parse(prodpricetxtbox.Text);
            AvailQuantity = int.Parse(prodquantxtbox.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Avail values('" + prodnametxtbox.Text + "'," + prodpricetxtbox.Text + "," + prodquantxtbox.Text + "," + totalpricetxtbox.Text + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERT THE NEW STOCK IN AVAILABLE");
        }

        private void prodquantxtbox_TextChanged(object sender, EventArgs e)
        {
            product_price = int.Parse(prodpricetxtbox.Text);
            AvailQuantity = int.Parse(prodquantxtbox.Text);
            total_price = AvailQuantity * product_price;
            totalpricetxtbox.Text = total_price.ToString(); 
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
