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

namespace RentC
{
    public partial class UpdateNewCustomer : Form
    {
        public UpdateNewCustomer()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Menu f1 = new Menu();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string conString = @"Data Source=PELINYIGIT\SQLEXPRESS;Initial Catalog=academy_net;Integrated Security=True";

                SqlConnection con = new SqlConnection(conString);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    string q = "UPDATE Customers SET ClientName=@a2,BirthDate=@a3,ZipCode=@a4 WHERE CustomerID=@a1";
                    SqlCommand cmd = new SqlCommand(q, con);
                    string format = "yyyy-MM-dd";

                    cmd.Parameters.AddWithValue("@a1", textBox2.Text);
                    cmd.Parameters.AddWithValue("@a2", textBox1.Text);
                    cmd.Parameters.AddWithValue("@a3", DateTime.Now.ToString(format));
                    cmd.Parameters.AddWithValue("@a4", textBox5.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
