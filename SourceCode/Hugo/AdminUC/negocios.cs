using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;

namespace Hugo.AdminUC
{
    public partial class negocios : UserControl
    {
        public negocios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void negocios_Load(object sender, EventArgs e)
        {
            LoadObjects();
        }
        private void addNegociobtn_Click(object sender, EventArgs e)
        {
            businessDAO.addBusiness(addNegocioTB.Text, negDescrp.Text);
            LoadObjects();
        }
        private void rmvNegociobtn_Click(object sender, EventArgs e)
        {
            businessDAO.removeBusiness(negociosCB.Text, 
                Convert.ToInt16(negociosCB.SelectedValue.ToString()));
            LoadObjects();
        }
        private void LoadObjects()
        {
            negociosCB.DataSource = null;
            negociosCB.ValueMember = "idBusiness"; 
            negociosCB.DisplayMember = "name";
            negociosCB.DataSource = businessDAO.getBusiness();
        }
    }
}