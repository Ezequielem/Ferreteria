using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte.Reportes
{
    public partial class IU_ReporteMensualEncargados : Form
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public DateTime FechaDesde
        {
            get
            {
                return fechaDesde;
            }

            set
            {
                fechaDesde = value;
            }
        }

        public DateTime FechaHasta
        {
            get
            {
                return fechaHasta;
            }

            set
            {
                fechaHasta = value;
            }
        }

        public IU_ReporteMensualEncargados()
        {
            InitializeComponent();
        }

        public void tomarFechaDesde()
        {
            FechaDesde = dateDesde.Value;
            string a = FechaDesde.ToString("dd/MM/yyyy");
            FechaDesde = Convert.ToDateTime(a);

        }

        public void tomarFechaHasta()
        {
            FechaHasta = dateHasta.Value;
           
        }

        private void IU_ReporteMensualEncargados_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tomarFechaDesde();
            tomarFechaHasta();

            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.Reporte_mensualEncargados' Puede moverla o quitarla según sea necesario.
            this.Reporte_mensualEncargadosTableAdapter.Fill(this.DataSetPrincipal.Reporte_mensualEncargados, FechaDesde, FechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
