using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;

namespace Hugo.NormalUC
{
    public partial class ordenesNormal : UserControl
    {
        Usuario user;
        public ordenesNormal(Usuario u)
        {
            user = u;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ordenesNormal_Load(object sender, EventArgs e)
        {
            LoadObjects();
        }

        private void ordenarbtn_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            apporderDAO.createOrder(date, 
                Convert.ToInt16(orderProductCB.SelectedValue.ToString()), 
                Convert.ToInt16(orderAddressCB.SelectedValue.ToString()));
            LoadObjects();
        }

        private void rmvOrderbtn_Click(object sender, EventArgs e)
        {
            apporderDAO.removeUserOrder(Convert.ToInt16(rmvOrder.SelectedValue.ToString()));
            LoadObjects();
        }
        
        private void LoadObjects()
        {
            //CreateOrderCB Items
            orderAddressCB.DataSource = null;
            orderAddressCB.ValueMember = "idAddress"; 
            orderAddressCB.DisplayMember = "address";
            orderAddressCB.DataSource = addressDAO.getUserAddress(user);
            orderProductCB.DataSource = null;
            orderProductCB.ValueMember = "idProduct"; 
            orderProductCB.DisplayMember = "name";
            orderProductCB.DataSource = productsDAO.getProducts();
            
            //rmvOrderCB items
            rmvOrder.DataSource = null;
            rmvOrder.ValueMember = "idOrder"; 
            rmvOrder.DisplayMember = "idOrder";
            rmvOrder.DataSource = apporderDAO.getUserOrdersIDS(user);
            userordersDG1.DataSource = apporderDAO.getUserOrdersdt(user);
            dataGridView1.DataSource=apporderDAO.getUserOrdersdt(user);
        }
    }
}