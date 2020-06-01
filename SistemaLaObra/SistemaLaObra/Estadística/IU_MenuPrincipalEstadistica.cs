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
        private IU_ReporteMensualVentas iu_reporteVentasMensualVentas;
        private IU_ReporteMensualEncargados _reporteMensualEncargados;
        private IU_ReporteMensualClientes _reporteMensualClientes;
        private IU_ReporteTopArticulos _reporteTopArticulos;
        private IU_ReporteTopClientesXPeriodo _reporteTopClientePeriodo;
        private IU_ReporteTopEncargadosXPeriodo _reporteTopEncargados;
        private IU_ReporteAnualVentas _reporteAnualVentas;


        public IU_MenuPrincipal interfazContenedora { get; set; }

        public IU_ReporteMensualVentas Iu_reporteVentasMensualVentas
        {
            get
            {
                return iu_reporteVentasMensualVentas;
            }

            set
            {
                iu_reporteVentasMensualVentas = value;
            }
        }

        public IU_ReporteMensualEncargados ReporteMensualEncargados
        {
            get
            {
                return _reporteMensualEncargados;
            }

            set
            {
                _reporteMensualEncargados = value;
            }
        }

        public IU_ReporteMensualClientes ReporteMensualClientes
        {
            get
            {
                return _reporteMensualClientes;
            }

            set
            {
                _reporteMensualClientes = value;
            }
        }

        public IU_ReporteTopArticulos ReporteTopArticulos
        {
            get
            {
                return _reporteTopArticulos;
            }

            set
            {
                _reporteTopArticulos = value;
            }
        }

        public IU_ReporteTopClientesXPeriodo ReporteTopClientePeriodo
        {
            get
            {
                return _reporteTopClientePeriodo;
            }

            set
            {
                _reporteTopClientePeriodo = value;
            }
        }

        public IU_ReporteTopEncargadosXPeriodo ReporteTopEncargados
        {
            get
            {
                return _reporteTopEncargados;
            }

            set
            {
                _reporteTopEncargados = value;
            }
        }

        public IU_ReporteAnualVentas ReporteAnualVentas
        {
            get
            {
                return _reporteAnualVentas;
            }

            set
            {
                _reporteAnualVentas = value;
            }
        }

        public IU_MenuPrincipalEstadistica()
        {
            InitializeComponent();
        }

        private void btnReporteMensualVentas_Click(object sender, EventArgs e)
        {
            IU_ReporteMensualVentas reporteVentas = new IU_ReporteMensualVentas();
            reporteVentas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteAnualVentas = new IU_ReporteAnualVentas();
            ReporteAnualVentas.Show();
        }

        private void btn_InformeMensualCliente_Click(object sender, EventArgs e)
        {
            ReporteMensualClientes = new IU_ReporteMensualClientes();
            ReporteMensualClientes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteTopClientePeriodo = new IU_ReporteTopClientesXPeriodo();
            ReporteTopClientePeriodo.Show();
        }

        private void btn_ReporteMensualEncargados_Click(object sender, EventArgs e)
        {

            ReporteMensualEncargados = new IU_ReporteMensualEncargados();
            ReporteMensualEncargados.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteTopEncargados = new IU_ReporteTopEncargadosXPeriodo();
            ReporteTopEncargados.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ReporteTopArticulos = new IU_ReporteTopArticulos();
            ReporteTopArticulos.Show();
        }
    }
}
