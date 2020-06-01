using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.ReporteDeVentas
{
    public partial class IU_ReporteDeVentas : Form
    {
        Validaciones validacion;
        IU_Calendario calendario;
        Reporte reporte;

        public IU_ReporteDeVentas()
        {
            InitializeComponent();
            gbx_fecha.Enabled = false;
            rbtn_hoy.Select();
        }

        private void IU_ReporteDeVentas_Load(object sender, EventArgs e)
        {
            calendario = new IU_Calendario();
            reporte = new Reporte();
            validacion = new Validaciones();
            txt_fechaInicio.ReadOnly = true;
            txt_fechaFin.ReadOnly = true;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            calendario.Close();
            this.Close();
        }

        private void rbtn_entrefechas_Enter(object sender, EventArgs e)
        {
            gbx_fecha.Enabled = true;
            lbl_fechaElegida.Visible = false;
        }

        private void rbtn_fecha_Enter(object sender, EventArgs e)
        {
            gbx_fecha.Enabled = false;
            lbl_fechaElegida.Visible = true;
            

        }

        private void rbtn_hoy_Enter(object sender, EventArgs e)
        {
            gbx_fecha.Enabled = false;
            lbl_fechaElegida.Visible = false;
        }

        private void rbtn_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fecha.Checked == true)
            {
                int xActual = Location.X;
                int yActual = Location.Y;
                calendario.SetDesktopLocation(xActual + 100, yActual + 30);
                DialogResult res = calendario.ShowDialog();

                if (res == DialogResult.OK)
                    lbl_fechaElegida.Text = calendario.fechaSeleccionada;
            }
            else
                calendario.Hide(); 
        }

        private void txt_fechaInicio_Enter(object sender, EventArgs e)
        {
            DialogResult res = calendario.ShowDialog();

            if (res == DialogResult.OK)
                txt_fechaInicio.Text = calendario.fechaSeleccionada;
        }

        private void txt_fechaFin_Enter(object sender, EventArgs e)
        {
            DialogResult res = calendario.ShowDialog();

            if (res == DialogResult.OK)
                txt_fechaFin.Text = calendario.fechaSeleccionada;
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            if (rbtn_hoy.Checked)
            {
                string hoy = DateTime.Today.ToString("yyyy-MM-dd");
                reporte.cargarReporteDia(hoy);
                reporte.tomarFechaInicio(DateTime.Today.ToShortDateString());
                reporte.tomarFechaFin(DateTime.Today.ToShortDateString());
                reporte.cantidadVentasMinoristas();
                reporte.cantidadVentasMayoristas();
                reporte.cantidadVentasTotales();
                reporte.Show();
                this.Close();
            }
            else if (rbtn_fecha.Checked)
            {
                string fecha= Convert.ToDateTime(lbl_fechaElegida.Text).ToString("yyyy-MM-dd");
                reporte.cargarReporteDia(fecha);
                reporte.tomarFechaInicio(lbl_fechaElegida.Text);
                reporte.tomarFechaFin(lbl_fechaElegida.Text);
                reporte.cantidadVentasMinoristas();
                reporte.cantidadVentasMayoristas();
                reporte.cantidadVentasTotales();
                reporte.Show();
                this.Close();
            }
            else if (rbtn_entrefechas.Checked && validacion.fechaMayor(txt_fechaInicio.Text, txt_fechaFin.Text) == false)
            {
                string fecha1=Convert.ToDateTime(txt_fechaInicio.Text).ToString("yyyy-MM-dd");
                string fecha2=Convert.ToDateTime(txt_fechaFin.Text).ToString("yyyy-MM-dd");
                reporte.cargaReporteAcotado(fecha1, fecha2);
                reporte.tomarFechaInicio(txt_fechaInicio.Text);
                reporte.tomarFechaFin(txt_fechaFin.Text);
                reporte.cantidadVentasMinoristas();
                reporte.cantidadVentasMayoristas();
                reporte.cantidadVentasTotales();
                reporte.Show();
                this.Close();
            }
            else
                MessageBox.Show("La fecha de inicio debe ser menor a la de fin");
        }
    }
}
