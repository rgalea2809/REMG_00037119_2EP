using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;

namespace Hugo.NormalUC
{
    public partial class direcciones : UserControl
    {
        Usuario user;
        public direcciones(Usuario u)
        {
            user = u;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void direcciones_Load(object sender, EventArgs e)
        {
            LoadObjects();
        }

        private void addAddressbtn_Click(object sender, EventArgs e)
        {
            addressDAO.addDireccion(user.idUser, direccionTB.Text);
            LoadObjects();
        }
        
        private void rmvAddressbtn_Click(object sender, EventArgs e)
        {
            addressDAO.removeAddress(Convert.ToInt16(rmvAddressCB.SelectedValue));
            LoadObjects();
        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            addressDAO.modAddress(modtb.Text, Convert.ToInt16(modcb.SelectedValue.ToString()));
            LoadObjects();
        }
        
        private void LoadObjects()
        {
            //RemoveAddressComboBox Items:
            rmvAddressCB.DataSource = null;
            rmvAddressCB.ValueMember = "idAddress"; 
            rmvAddressCB.DisplayMember = "address";
            rmvAddressCB.DataSource = addressDAO.getUserAddress(user);
            
            //ModAddressComboBox items
            modcb.DataSource = null;
            modcb.ValueMember = "idAddress"; 
            modcb.DisplayMember = "address";
            modcb.DataSource = addressDAO.getUserAddress(user);
            
            direccionesDG.DataSource = addressDAO.getUserAddressdt(user);
        }
    }
}