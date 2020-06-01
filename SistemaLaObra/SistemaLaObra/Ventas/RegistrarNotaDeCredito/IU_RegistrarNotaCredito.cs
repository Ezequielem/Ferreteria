using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.RegistrarNotaDeCredito
{
    public partial class IU_RegistrarNotaCredito : Form
    {
        Validaciones validacion;
        public Controlador_NotaCredito controlador;
        public IU_MenuPrincipal InterfazContenedora { get; set; }
        Entrega entregaInstanciada;
        public bool notaCreditoRegistrada = false;

        public IU_RegistrarNotaCredito()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controlador = new Controlador_NotaCredito();
            controlador.InterfazNotaCredito = this;
            entregaInstanciada = new Entrega();
        }

        //Lo que recibe de modificar envio
        public void opcionRegistrarNotaDeCredito(Entrega entregaInstanciada)
        {
            this.entregaInstanciada = entregaInstanciada;
            txt_numeroVenta.Text = entregaInstanciada.Venta.CodigoVenta.ToString();
            tomarNroVenta();
            controlador.procesarDevolucionExcedente(entregaInstanciada);

            this.dgv_productos.Enabled = false;
            txt_numeroVenta.Enabled = false;
            btn_buscarVenta.Enabled = false;
            btn_calcularSaldo.Enabled = false;
            btn_registrarNotaCredito.Enabled = true;
        }

        private void btn_buscarVenta_Click(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_numeroVenta.Text))
            {
                limpiarCampos();
                tomarNroVenta();
            }
            else
            {
                MessageBox.Show("No ingreso un numero de factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tomarNroVenta()
        {
            controlador.nroVenta(int.Parse(txt_numeroVenta.Text));
        }

        private bool tomarDatosCliente()
        {
            if (txt_nombreCliente.Text != "")
            {
                if (txt_dniCliente.Text != "")
                {
                    controlador.datosCliente(txt_nombreCliente.Text, int.Parse(txt_dniCliente.Text));
                    return true;
                }
                else
                {
                    MessageBox.Show("Se requiere que se ingrese el dni del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Se requiere el ingreso del nombre del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void limpiarCampos()
        {
            dgv_productos.Rows.Clear();
            lbl_fechaVenta.Text = String.Empty;
            lbl_horaVenta.Text = String.Empty;
            lbl_vendedor.Text = String.Empty;
            lbl_importeTotal.Text = String.Empty;
            lbl_cantidadTarjetas.Text = String.Empty;
            lbl_interesGenerado.Text = String.Empty;
            lbl_razonSocial.Text = String.Empty;
            lbl_cuit.Text = String.Empty;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private bool validarDataGridView()
        {
            foreach (DataGridViewRow fila in dgv_productos.Rows)
            {
                DataGridViewCheckBoxCell celdaSeleccionada = fila.Cells[6] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celdaSeleccionada.Value))
                {
                    //ACA VALIDAMOS QUE ESTE SELECCIONADA LA FILA Y SE HAYA INGRESADO UNA CANTIDAD A DEVOLVER (NO DE DEVOLVER STOCK)
                    if (fila.Cells[5].Value == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        //ESTAS VALIDACIONES LA HACEMOS PARA ESPECIFICAR EN DETALLE ERROR DEL USUARIO, PERO EN REALIDAD NO SERIA NECESARIO (CON UNA BASTARIA)//

        private bool validarNoSeleccionDeFila()
        {
            foreach (DataGridViewRow fila in dgv_productos.Rows)
            {
                
                if (fila.Cells[5].Value != null)
                {
                    //ACA VALIDAMOS QUE SE HAYA INGRESADO LA CANTIDAD A DEVOLVER Y ESTE SELECCIONADA LA FILA SELECCIONADA
                    DataGridViewCheckBoxCell celdaSeleccionada = fila.Cells[6] as DataGridViewCheckBoxCell;
                    if (!Convert.ToBoolean(celdaSeleccionada.Value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calcularSaldo_Click(object sender, EventArgs e)
        {
            if (validarDataGridView())
            {
                lbl_aviso.Visible = false;
                controlador.articuloSeleccionado(dgv_productos);
                controlador.calcularSubTotal();
            }
            else
            {
                MessageBox.Show("Ah seleccionado articulos sin especificar cuantos va a devolver", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_registrarNotaCredito_Click(object sender, EventArgs e)
        {
            if (entregaInstanciada.PrecioEntrega != 0.0f)
            {
                if (txt_razonSocial.Text != "")
                {
                    controlador.datosClienteMayorista();
                    controlador.registrarNotaCreditoExecedente();
                    this.Close();
                }
                else
                {
                    if (tomarDatosCliente())
                    {
                        controlador.registrarNotaCreditoExecedente();
                        this.Close();
                    }
                }
            }
            else
            {
                if (validarDataGridView())
                {
                    if (validarNoSeleccionDeFila())
                    {
                        if (txt_razonSocial.Text != "")
                        {
                            controlador.datosClienteMayorista();
                            controlador.registrarNotaCredito();
                        }
                        else
                        {
                            if (tomarDatosCliente())
                            {
                                controlador.registrarNotaCredito();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingreso cantidad sin seleccionar el articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ah seleccionado articulos sin especificar cuantos va a devolver", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                btn_registrarNotaCredito.Enabled = false;
                lbl_aviso.Visible = true;
            }
        }

        private void txt_numeroVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_dniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void lbl_detalleFP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validacion.campoVacio(txt_numeroVenta.Text))
            {
                controlador.mostrarDetalleFormaPago();
            }
        }
    }
}
