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
    public partial class RegisterNewCustomer : Form
    {
        public string conString = @"Data Source=PELINYIGIT\SQLEXPRESS;Initial Catalog=academy_net;Integrated Security=True";

        public RegisterNewCustomer()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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


                SqlConnection con = new SqlConnection(conString);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    string q = "insert into Customers values (@ClientId, @ClientName,@BirthDate,@ZipCode)";
                    SqlCommand cmd = new SqlCommand(q, con);
                    string format = "yyyy-MM-dd";

    
                    cmd.Parameters.AddWithValue("@ClientName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", DateTime.Now.ToString(format));
                    cmd.Parameters.AddWithValue("@ZipCode", textBox5.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added.");
                    Hide();
                    Menu f1 = new Menu();
                    f1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         public void getInfo()
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
