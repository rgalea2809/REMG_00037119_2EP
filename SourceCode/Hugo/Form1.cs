using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;

namespace Hugo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            userLoginCombobox.DataSource = null;
            userLoginCombobox.ValueMember = "password"; 
            userLoginCombobox.DisplayMember = "username";
            userLoginCombobox.DataSource = appUserDAO.getUsers();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userLoginCombobox.SelectedValue.Equals(passwordloginTextbox.Text))
            {
                Usuario u = (Usuario) userLoginCombobox.SelectedItem;
                if (u.userType)
                {
                    MessageBox.Show("ADMIN");
                }
                else
                {
                    MessageBox.Show("Bienvenido!");
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void goTocp_Click(object sender, EventArgs e)
        {
            changePwd ventana = new changePwd();
            ventana.Show();
            this.Hide();
        }
    }
}