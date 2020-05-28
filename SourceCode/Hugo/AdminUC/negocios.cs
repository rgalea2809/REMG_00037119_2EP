using System;
using System.Windows.Forms;
using Hugo.DataAccessObjects;
using Hugo.databaseObjects;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using PieChart = LiveCharts.WinForms.PieChart;

namespace Hugo.AdminUC
{
    public partial class negocios : UserControl
    {
        private PieChart graficoPastel;
        public negocios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            graficoPastel = new PieChart();
            this.Controls.Add(graficoPastel);
            graficoPastel.Parent = tabControl1.TabPages[2];
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
            configPiechart();
        }
        
        private void configPiechart()
        {
            graficoPastel.Top = 20;
            graficoPastel.Left = 20;
            graficoPastel.Width = 400;
            graficoPastel.Height = 400;

            List<conxprod> lista = businessDAO.getPiechartInfo();
            
            SeriesCollection serie = new SeriesCollection();

            for (int i = 0; i < lista.Count; i++)
            {
                serie.Add(new PieSeries {Title = lista[i].nombre, 
                    Values = new ChartValues<int> {lista[i].cantidad}, DataLabels = true});
            }
            graficoPastel.Series = serie;
            graficoPastel.LegendLocation = LegendLocation.Bottom;

        }
    }
}