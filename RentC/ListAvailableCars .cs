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
    public partial class ListAvailableCars : Form
    {
        //connection String for SQL
        public string conString = "Data Source=PELINYIGIT\\SQLEXPRESS;Initial Catalog=academy_net;Integrated Security=True";

        public ListAvailableCars()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Menu f1 = new Menu();
            f1.Show();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListAvailableCars_Load(object sender, EventArgs e)
        {

        }

        private void dgb1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * From Cars", con);
                    DataTable db = new DataTable();
                    sqlDA.Fill(db);

                    dgb1.DataSource = db;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
