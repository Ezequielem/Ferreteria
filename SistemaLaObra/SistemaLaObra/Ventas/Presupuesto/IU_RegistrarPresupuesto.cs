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
    public partial class IU_RegistrarPresupuesto : Form
    {

        Controlador_RegistrarPresupuesto controlador;
        Validaciones validacion;
        public IU_MenuPrincipal InterfazContenedora { get; set; }

        public IU_RegistrarPresupuesto()
        {
            InitializeComponent();
            controlador = new Controlador_RegistrarPresupuesto();
            controlador.InterfazRegistrarPresupuesto = this;
            validacion = new Validaciones();
        }

        private void IU_RegistrarPresupuesto_Load(object sender, EventArgs e)
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            lbl_fecha.Text = dia + "/" + mes + "/" + ano;

            controlador.autoCompletarRazonSocial(txt_razonSocial);
        }

        private void tomarFecha()
        {
            DateTime fecha = DateTime.Now;
            controlador.fechaPresupuesto(fecha);
        }

        private void tomarNombreCliente()
        {
            string nombreCliente = txt_nombreCliente.Text;
            controlador.nombreCliente(nombreCliente);
        }

        private void tomarRazonSocial()
        {
            string razonSocial = txt_razonSocial.Text;
            controlador.razonSocialCliente(razonSocial);
        }

        private void tomarDescripcionArticulo()
        {
            controlador.descripcionArticulo(txt_descripcion.Text);
        }

        private void tomarCantidad()
        {
            string cantidadArticulo = txt_cantidad.Text;
            controlador.cantidadArticuloSolicitado(cantidadArticulo);
        }

        private void mostrarImporteTotal()
        {
            controlador.calcularImporteTotal();
        }

        private void tomarConfirmacionRegistro()
        {
            tomarFecha();
            tomarNombreCliente();
            tomarRazonSocial();
            controlador.registrarPresupuesto();
        }
        
        public void limpiarCampos()
        {
            txt_nombreCliente.Text = "";
            txt_razonSocial.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
        }

        ///----------------------BOTONES------------------------------///
        ///
        private void btn_cargarArticulo_Click(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_cantidad.Text))
            {
                if (dgv_articulosDisponibles.Rows.Count != 0)
                {
                    controlador.buscarDatosArticulos(int.Parse(dgv_articulosDisponibles.CurrentRow.Cells[0].Value.ToString()));
                    tomarCantidad();
                    mostrarImporteTotal();
                    txt_cantidad.Text = "";
                }
                else
                {
                    MessageBox.Show("No tiene un articulo seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No ingreso la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_quitarArticulo_Click(object sender, EventArgs e)
        {
            if (lbl_importeTotal.Text != "0.00")
            {
                controlador.quitarArticulos();
            }
            else
            {
                MessageBox.Show("No se encuentran articulos para quitar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_registrarPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgv_productos.Rows.Count != 0)
            {
                if (!validacion.campoVacio(txt_razonSocial.Text) || !validacion.campoVacio(txt_nombreCliente.Text))
                {
                    if (txt_nombreCliente.Text != "" && txt_razonSocial.Text == "" || txt_nombreCliente.Text == "" && txt_razonSocial.Text != "")
                    {
                        tomarConfirmacionRegistro();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar solamente uno de los siguientes campos: \nNOMBRE CLIENTE \nRAZON SOCIAL", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos unos de los dos campos: \nNOMBRE CLIENTE \nRAZON SOCIAL", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No ha cargado ningun articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------EVENTOS---------------------------------//

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_descripcion.Text))
            {
                tomarDescripcionArticulo();
            }
        }
    }
}
