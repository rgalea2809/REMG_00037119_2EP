using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;

namespace Hugo
{
    public partial class changePwd : Form
    {
        public changePwd()
        {
            InitializeComponent();
        }

        private void changePwd_Load(object sender, EventArgs e)
        {
            LoadObjects();
        }
        private void actualizarPwd_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario) usersCombobox.SelectedItem;
            if (usersCombobox.SelectedValue.Equals(passwordActual.Text))
            {
                if (passwordnueva.Text != passwordActual.Text)
                {
                    appUserDAO.setPassword(passwordnueva.Text, u);
                    LoadObjects();
                }
                else
                {
                    MessageBox.Show("la contraseña Nueva no puede ser igual a la anterior!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        private void LoadObjects()
        {
            usersCombobox.DataSource = null;
            usersCombobox.ValueMember = "password"; 
            usersCombobox.DisplayMember = "username";
            usersCombobox.DataSource = appUserDAO.getUsers();
        }

        private void returnHomebtn_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }
    }
}