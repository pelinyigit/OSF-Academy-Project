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
    public partial class ListCustomers : Form
    {
        public string conString = @"Data Source=PELINYIGIT\SQLEXPRESS;Initial Catalog=academy_net;Integrated Security=True";

        public ListCustomers()
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
                
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * From Customers", con);
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

        private void ListCustomers_Load(object sender, EventArgs e)
        {

        }

        private void dgb1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
