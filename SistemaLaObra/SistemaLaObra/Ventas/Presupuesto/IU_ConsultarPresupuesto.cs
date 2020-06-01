using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.Presupuesto
{
    public partial class IU_ConsultarPresupuesto : Form
    {

        Validaciones validacion;
        Controlador_ConsultarPresupuesto controlador;
        public IU_MenuPrincipal InterfazContenedora { get; set; }
        IU_ListaPresupuesto interfazListaPresupuesto;

        public IU_ConsultarPresupuesto()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controlador = new Controlador_ConsultarPresupuesto();
            controlador.interfazConsultarPresupuesto = this;
        }

        private string tomarNumeroPresupuesto()
        {
            return txt_numeroPresupuesto.Text;
        }

        //BOTONES//

        private void btn_buscarPresupuesto_Click(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_numeroPresupuesto.Text))
            {
                controlador.numeroPresupuesto(tomarNumeroPresupuesto());
                if (controlador.verificarExistencia())
                {
                    dgv_productos.Rows.Clear();
                    controlador.mostrarDatosPresupuesto();
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El presupuesto no existe, quiere intentar una busqueda avanzada?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        interfazListaPresupuesto = new IU_ListaPresupuesto();
                        interfazListaPresupuesto.Controlador_ConsultarPresupuesto = controlador;
                        interfazListaPresupuesto.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("No ingreso un numero de presupuesto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_iniciarVenta_Click(object sender, EventArgs e)
        {
            if (dgv_productos.Rows.Count != 0)
            {
                controlador.iniciarVenta();
            }
            else
            {
                MessageBox.Show("No tiene un presupuesto cargado para iniciar una venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENTOS//

        private void txt_numeroPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }
    }
}
