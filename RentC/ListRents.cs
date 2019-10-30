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
    public partial class ListRents : Form
    {
        public string conString = @"Data Source=PELINYIGIT\SQLEXPRESS;Initial Catalog=academy_net;Integrated Security=True";

        public ListRents()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Menu f1 = new Menu();
            f1.Show();
        }

        private void dgb1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * From CarReg", con);
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

        private void ListRents_Load(object sender, EventArgs e)
        {

        }
    }
}
