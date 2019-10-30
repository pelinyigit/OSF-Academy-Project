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
    public partial class RegisterNewCarRent : Form
    {

        //connection String for SQL
        public string conString = @"Data Source=PELINYIGIT\SQLEXPRESS;Initial Catalog=academy_net;Integrated Security=True";

        public RegisterNewCarRent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
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
                string q = "insert into CarReg values (@ClientId,@Plate,@StartDate,@EndDate,@City)";
                SqlCommand cmd = new SqlCommand(q,con);
                string format = "yyyy-MM-dd";
                cmd.Parameters.AddWithValue("@ClientId",textBox1.Text);
                cmd.Parameters.AddWithValue("@Plate", textBox2.Text);
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Now.ToString(format));
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Now.ToString(format));
                cmd.Parameters.AddWithValue("@City", textBox4.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfuly");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
