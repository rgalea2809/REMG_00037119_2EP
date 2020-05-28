using System;
using System.Windows.Forms;
using Hugo.AdminUC;
using Hugo.databaseObjects;

namespace Hugo
{
    public partial class adminWF : Form
    {
        private UserControl current;
        private usuarios users = new usuarios();
        private negocios business = new negocios();
        private productos products = new productos();
        private ordenes orders = new ordenes();
        public adminWF()
        {
            InitializeComponent();
            current = null;
            DoubleBuffered = true;
        }
        private void usersrBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(users, 0, 1);
            current = users;
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }
        private void businessbtn_Click(object sender, EventArgs e)
        { 
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(business, 0, 1);
            current = business;
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }

        private void productbtn_Click(object sender, EventArgs e)
        { 
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(products, 0, 1);
            current = products;
            tableLayoutPanel1.SetColumnSpan(products, 4);
        }

        private void ordersbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(orders, 0, 1);
            current = orders;
            tableLayoutPanel1.SetColumnSpan(orders, 4);
        }
    }
}