using System;
using System.Windows.Forms;
using Hugo.databaseObjects;
using Hugo.NormalUC;

namespace Hugo
{
    public partial class normalUserWF : Form
    {
        private Usuario user = new Usuario();
        private UserControl current;
        private direcciones direcciones;
        private ordenesNormal ordenes;
        public normalUserWF(Usuario u)
        {
            current = null;
            user = u;
            direcciones = new direcciones(user);
            ordenes = new ordenesNormal(user);
            InitializeComponent();
        }

        private void direccionesbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(direcciones, 0, 1);
            current = direcciones;
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }

        private void ordenesbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            tableLayoutPanel1.Controls.Add(ordenes, 0, 1);
            current = ordenes;
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }
    }
}