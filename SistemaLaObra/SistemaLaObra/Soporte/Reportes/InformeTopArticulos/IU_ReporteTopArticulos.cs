using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte.Reportes.InformeTopArticulos
{
    public partial class IU_ReporteTopArticulos : Form
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

        public IU_ReporteTopArticulos()
        {
            InitializeComponent();
        }


        private void IU_ReporteTopArticulos_Load(object sender, EventArgs e)
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
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.Reporte_ventasTopArticulosPeriodo' Puede moverla o quitarla según sea necesario.
            this.reporte_ventasTopArticulosPeriodoTableAdapter.Fill(this.dataSetPrincipal.Reporte_ventasTopArticulosPeriodo, FechaDesde, FechaHasta);

            this.reportViewer1.RefreshReport();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
