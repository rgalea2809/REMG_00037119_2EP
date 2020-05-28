using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;

namespace Hugo.AdminUC
{
    public partial class productos : UserControl
    {
        public productos()
        {
            InitializeComponent();
            LoadObjects();
        }
        private void productos_Load(object sender, EventArgs e)
        {
            LoadObjects();
            this.Dock = DockStyle.Fill;
        }
        
        private void addProductbtn_Click(object sender, EventArgs e)
        {
            productsDAO.addProduct(addPTB.Text, Convert.ToInt16(addproductCB.SelectedValue));
            LoadObjects();
        }
        private void elimiarproductbtn_Click(object sender, EventArgs e)
        {
            productsDAO.removeProduct(Convert.ToInt16(removproductCB.SelectedValue));
            LoadObjects();
        }

        private void LoadObjects()
        {
            //agregar Productos
            addproductCB.DataSource = null;
            addproductCB.ValueMember = "idBusiness"; 
            addproductCB.DisplayMember = "name";
            addproductCB.DataSource = businessDAO.getBusiness();
            
            //remove Products
            removproductCB.DataSource = null;
            removproductCB.ValueMember = "idProduct";
            removproductCB.DisplayMember = "name";
            removproductCB.DataSource = productsDAO.getProducts();
        }
    }
}