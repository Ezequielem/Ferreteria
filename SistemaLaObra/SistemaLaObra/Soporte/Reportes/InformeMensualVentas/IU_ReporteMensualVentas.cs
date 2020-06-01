using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte.Reportes.InformeMensualVentas
{
    public partial class IU_ReporteMensualVentas : Form
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

        public IU_ReporteMensualVentas()
        {
            InitializeComponent();
        }

        private void IU_ReporteMensualVentas_Load(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            tomarFechaDesde();
            tomarFechaHasta();

            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.Reporte_mensualVentas' Puede moverla o quitarla según sea necesario.
            this.reporte_mensualVentasTableAdapter.Fill(this.dataSetPrincipal.Reporte_mensualVentas, FechaDesde, FechaHasta);
            this.reportViewer1.RefreshReport();
        }

       
    }
}
