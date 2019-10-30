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
    public partial class UpdateCarRent : Form
    {
        public UpdateCarRent()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Menu f1 = new Menu();
            f1.Show();
        }

        private void UpdateCarRent_Load(object sender, EventArgs e)
        {

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
                    string q = "UPDATE CarReg SET Plate=@a2,StartDate=@a3,EndDate=@a4,City=@a5 WHERE ClientId=@a1";
                    SqlCommand cmd = new SqlCommand(q, con);
                    string format = "yyyy-MM-dd";
                    cmd.Parameters.AddWithValue("@a1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@a2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@a3", DateTime.Now.ToString(format));
                    cmd.Parameters.AddWithValue("@a4", DateTime.Now.ToString(format));
                    cmd.Parameters.AddWithValue("@a5", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
