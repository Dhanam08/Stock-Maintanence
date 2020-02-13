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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }
        string product_name;
        int Quantity, product_price;
        int total_price;
        long customer_No;
        int qty, q, qunty;
        SqlConnection con=new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=STORE;Integrated Security=True");
        private void salepaybtn_Click(object sender, EventArgs e)
        {
           
            product_name = prodnametxtbox.Text;
            product_price = int.Parse(prodpricetxtbox.Text);
            //Quantity = int.Parse(prodquantxtbox.Text);
            customer_No = long.Parse(cusnumbertxtbox.Text);
            con.Open();
            
                
               
                if ( qty>=Quantity)
                {
                    MessageBox.Show("YES,YOU CAN PROCEED");
                     SqlCommand cmdd = new SqlCommand("insert into Saless values('" + prodnametxtbox.Text + "'," + prodpricetxtbox.Text + "," + prodquantxtbox.Text + "," + totalpricetxtbox.Text + "," + cusnumbertxtbox.Text + ")", con);
                    int i = cmdd.ExecuteNonQuery();
                    SqlCommand cmdsq=new SqlCommand("select Quantity from Saless where CusMob=" + cusnumbertxtbox.Text + "",con);
                    q = Convert.ToInt32(cmdsq.ExecuteScalar());
                    MessageBox.Show("INSERT SUCESSFULLY");
                    qunty = qty - q;
                    if (qunty >= 0)
                    {

                        SqlCommand cmda = new SqlCommand("update Avail set Quantity=" + qunty + " where ProductName='" + prodnametxtbox.Text + "' ", con);
                        cmda.ExecuteNonQuery();
                        MessageBox.Show("Availability is Updated");

                    }

                    else
                    {
                        MessageBox.Show("Invalid Quantity");
                    }
                }
               
                

            
            else
            {
                MessageBox.Show("INSUFF..DATA");
            }
            
            con.Close();
            
        }

        private void totalpricetxtbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void prodquantxtbox_TextChanged(object sender, EventArgs e)
        {
          
          product_price = int.Parse(prodpricetxtbox.Text);
          Quantity = int.Parse(prodquantxtbox.Text);

          con.Open();
          SqlCommand cmd = new SqlCommand("select Quantity from Avail where ProductName='" + prodnametxtbox.Text + "' ", con);
          qty = Convert.ToInt32(cmd.ExecuteScalar());
          con.Close();
            total_price = Quantity * product_price;
            totalpricetxtbox.Text = total_price.ToString(); 
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
