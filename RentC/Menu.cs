using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterNewCarRent f2 = new RegisterNewCarRent();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterNewCustomer f3 = new RegisterNewCustomer();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateCarRent f4 = new UpdateCarRent();
            f4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateNewCustomer f5 = new UpdateNewCustomer();
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            ListRents lr = new ListRents();
            lr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            ListAvailableCars lac = new ListAvailableCars();
            lac.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            ListCustomers listCustomers = new ListCustomers();
            listCustomers.Show();
        }
    }
}
