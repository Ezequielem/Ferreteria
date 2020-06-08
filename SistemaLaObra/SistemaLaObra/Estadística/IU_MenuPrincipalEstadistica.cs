using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Soporte.Reportes.Informe_MensualCliente;
using SistemaLaObra.Soporte.Reportes.InformeMensualVentas;
using SistemaLaObra.Soporte.Reportes.InformeTopArticulos;
using SistemaLaObra.Soporte.Reportes.InformeTopClientesXPeriodo;
using SistemaLaObra.Soporte.Reportes.InformeTopEncargadosXPeriodo;
using SistemaLaObra.Soporte.Reportes.InformeAnualVentas;
using SistemaLaObra.Soporte.Reportes;


namespace SistemaLaObra.Estadística
{
    public partial class IU_MenuPrincipalEstadistica : Form
    {
        public IU_MenuPrincipal interfazContenedora { get; set; }
        public IU_ReporteMensualEncargados ReporteMensualEncargados { get; set; }
        public IU_ReporteMensualClientes ReporteMensualClientes { get; set; }
        public IU_ReporteTopArticulos ReporteTopArticulos { get; set; }
        public IU_ReporteTopClientesXPeriodo ReporteTopClientePeriodo { get; set; }
        public IU_ReporteTopEncargadosXPeriodo ReporteTopEncargados { get; set; }
        public IU_ReporteAnualVentas ReporteAnualVentas { get; set; }

        public IU_MenuPrincipalEstadistica()
        {
            InitializeComponent();
        }

        private void btnReporteMensualVentas_Click(object sender, EventArgs e)
        {
            IU_ReporteMensualVentas reporteVentas = new IU_ReporteMensualVentas();
            reporteVentas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteAnualVentas = new IU_ReporteAnualVentas();
            ReporteAnualVentas.ShowDialog();
        }

        private void btn_InformeMensualCliente_Click(object sender, EventArgs e)
        {
            ReporteMensualClientes = new IU_ReporteMensualClientes();
            ReporteMensualClientes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteTopClientePeriodo = new IU_ReporteTopClientesXPeriodo();
            ReporteTopClientePeriodo.ShowDialog();
        }

        private void btn_ReporteMensualEncargados_Click(object sender, EventArgs e)
        {

            ReporteMensualEncargados = new IU_ReporteMensualEncargados();
            ReporteMensualEncargados.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteTopEncargados = new IU_ReporteTopEncargadosXPeriodo();
            ReporteTopEncargados.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ReporteTopArticulos = new IU_ReporteTopArticulos();
            ReporteTopArticulos.ShowDialog();
        }
    }
}
