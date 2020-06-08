using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.ConsultarVenta
{
    public partial class IU_ConsultarVenta : Form
    {
        public IU_MenuPrincipal InterfazContenedora { get; set; }
        Controlador_ConsultarVenta controlador;
        Validaciones validacion;

        public IU_ConsultarVenta()
        {
            InitializeComponent();
            controlador = new Controlador_ConsultarVenta();
            validacion = new Validaciones();
            controlador.interfazConsultarVenta = this;
            inicializarFechas();
        }

        private void inicializarFechas()
        {
            DateTime fechaActual = DateTime.Now;
            dt_fechaDesde.Value = fechaActual.AddDays(-30);
        }

        private void btn_buscarPeriodoVenta_Click(object sender, EventArgs e)
        {
            dgv_listadoVentas.Rows.Clear();
            tomarFechas();
        }

        private void tomarFechas()
        {
            if (dt_fechaHasta.Value.Date.CompareTo(dt_fechaDesde.Value.Date) != -1)
            {
                controlador.periodoVenta(dt_fechaDesde.Value, dt_fechaHasta.Value);
                if (!controlador.cargarDGV_PeriodoVentas())
                {
                    MessageBox.Show("No se encuentran ventas en el periodo establecido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La fecha HASTA no puede ser inferior a la fecha DESDE","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_buscarVenta_Click(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_nroVenta.Text))
            {
                if (controlador.ventaEstapecifica(int.Parse(txt_nroVenta.Text)))
                {
                    controlador.mostrarDetalleVenta();
                }
                else
                {
                    MessageBox.Show("La venta no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No ingreso un numero de venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_nroVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void dgv_listadoVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    controlador.ventaEstapecifica(int.Parse(dgv_listadoVentas.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    controlador.mostrarDetalleVenta();
                }
            }
        }

        private void IU_ConsultarVenta_Load(object sender, EventArgs e)
        {
            dt_fechaDesde.Value = DateTime.Now;
            dt_fechaHasta.Value = DateTime.Now;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
