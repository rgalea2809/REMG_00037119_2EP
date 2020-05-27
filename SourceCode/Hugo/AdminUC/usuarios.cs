using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;

namespace Hugo.AdminUC
{
    public partial class usuarios : UserControl
    {
        public usuarios()
        {
            InitializeComponent();
        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            LoadObjects();
            this.Dock = DockStyle.Fill;
        }
        private void createuserbtn_Click(object sender, EventArgs e)
        {
            if (newUsertb.Text.Equals(" "))
            {
                MessageBox.Show("Por favor ingrese un nombre de Usuario!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                List<Usuario> auxList = appUserDAO.getUsers();
                foreach (var user in auxList)
                {
                    if (user.username == newUsertb.Text)
                    {
                        MessageBox.Show("El nombre de usuario ya existe!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                Usuario u = new Usuario();
                u.fullname = fullnameTB.Text;
                u.username = newUsertb.Text;
                u.password = newUsertb.Text;
                if (adminyes.Checked == true)
                {
                    u.userType = true;
                }
                else
                {
                    u.userType = false;
                }
                appUserDAO.addUser(u);
                LoadObjects();
            }
        }
        private void rmvUserbtn_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario) rmvuserCombobox.SelectedItem;
            appUserDAO.removeUser(u);
            LoadObjects();
        }
        private void LoadObjects()
        {
            //Combobox source
            rmvuserCombobox.DataSource = null;
            rmvuserCombobox.ValueMember = "username"; 
            rmvuserCombobox.DisplayMember = "username";
            rmvuserCombobox.DataSource = appUserDAO.getUsers();
            //Datagrid source
            usersDGV.DataSource = appUserDAO.getUsersDt();
        }
    }
}