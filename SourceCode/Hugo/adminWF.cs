using System;
using System.Windows.Forms;
using Hugo.AdminUC;
using Hugo.databaseObjects;

namespace Hugo
{
    public partial class adminWF : Form
    {
        private UserControl current;
        public adminWF()
        {
            InitializeComponent();
            current = usuarios1;
            DoubleBuffered = true;
        }

        private void usersrBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(usuarios1, 0, 1);
            current = usuarios1;
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }
    }
}