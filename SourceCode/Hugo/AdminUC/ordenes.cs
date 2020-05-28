using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;

namespace Hugo.AdminUC
{
    public partial class ordenes : UserControl
    {
        public ordenes()
        {
            InitializeComponent();
        }

        private void ordenes_Load(object sender, EventArgs e)
        {
            ordenesHistoryDG.DataSource = apporderDAO.getOrders();
            this.Dock = DockStyle.Fill;
        }
    }
}