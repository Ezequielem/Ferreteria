using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaLaObra.Ventas;
using SistemaLaObra.Ventas.CobroConTarjeta;
using SistemaLaObra.Ventas.OrdenDeRemito;
using SistemaLaObra.Ventas.RegistrarClienteMayorista;
using SistemaLaObra.Ventas.VentaMostrador;

namespace SistemaLaObra
{
    public partial class IU_RegistrarVenta : Form
    {
        //Instancias
        public Controlador_Venta controlador;
        Validaciones validacion;
        IU_RegistrarClienteMayorista registrarClienteMayorista;
        public IU_MenuPrincipal InterfazContenedora { get; set; }
        List<Entrega> listaEntrega;
        public bool ventaRegistrada = false;

        public IU_RegistrarVenta()
        {
            InitializeComponent();
            controlador = new Controlador_Venta();
            controlador.InterfazVenta = this;
            validacion = new Validaciones();
            listaEntrega = new List<Entrega>();
        }

        private void IU_RegistrarVenta_Load(object sender, EventArgs e)
        {
            controlador.autoCompletarRazonSocial(txt_razonSocial);
            inicializarComponentes();
        }

        public void inicializarComponentes()
        {
            mostrarOpcionPago();
            cbx_formaPago.SelectedIndex = 0;
            btn_detallesEnvioDomicilio.Enabled = false;
            btn_envioDomicilio.Enabled = false;
            ch_cargoEnvio.Enabled = false;
            ch_notaCredito.Enabled = false;
        }

        //BOTONES//

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_cantidad.Text))
            {
                if (dgv_articulosDisponibles.Rows.Count != 0)
                {
                    controlador.buscarDatosArticulos(int.Parse(dgv_articulosDisponibles.CurrentRow.Cells[0].Value.ToString()));
                    tomarCantidadArticulo();
                    rb_clienteMayorista.Enabled = false;
                    rb_clienteMinorista.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No tiene un articulo seleccionado","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No ingreso una cantidad","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_quitarArticulo_Click(object sender, EventArgs e)
        {
            controlador.quitarArticulo();
            mostrarOpcionRegistrarVenta();
            mostrarOpcionEnvioDomicilio();
            if (controlador.venta.ImporteTotal == 0.00f)
            {
                cbx_formaPago.Enabled = false;
            }
        }

        private void btn_envioDomicilio_Click(object sender, EventArgs e)
        {
            tomarOpcionEnvioDomicilio();
        }

        private void btn_cobroTarjeta_Click(object sender, EventArgs e)
        {
           tomarOpcionCobroConTarjeta();       
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_detallesEnvioDomicilio_Click(object sender, EventArgs e)
        {
            IU_Info formInfo = new IU_Info(controlador.listaEntrega, controlador.listaDetalleLogistica);
            formInfo.ShowDialog();
        }

        private void btn_registrarVenta_Click(object sender, EventArgs e)
        {
            if (lbl_cargoEnvio.Text != "$ 0.00" && dgv_productos.Rows.Count == 0 && listaEntrega.Count != 0)
            {
                controlador.generarNvoNumeroVentaParaRemito();
                this.Close();
            }
            else
            {
                if (lbl_cargoEnvio.Text != "$ 0.00" && dgv_productos.Rows.Count == 0)
                {
                    controlador.generarNvoNumeroVentaParaRemito();
                    this.Close();
                }
                else
                {
                    tomarOpcionRegistrarVenta();
                }
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void cbx_formaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_formaPago.SelectedIndex == 2)
            {
                btn_cobroTarjeta.Enabled = true;
                txt_descripcion.Enabled = false;
                txt_cantidad.Enabled = false;
                btn_cargar.Enabled = false;
                btn_quitarArticulo.Enabled = false;
                btn_envioDomicilio.Enabled = false;
                ch_cargoEnvio.Enabled = false;
                ch_notaCredito.Enabled = false;
            }
            else if (cbx_formaPago.SelectedIndex== 4)
            {
                btn_envioDomicilio.Enabled = false;
                ch_cargoEnvio.Enabled = false;
                tomarOpcionActualizarNotaCredito();
            }
            else
            {
                btn_cobroTarjeta.Enabled = false;
                txt_descripcion.Enabled = true;
                txt_cantidad.Enabled = true;
                btn_cargar.Enabled = true;
                btn_quitarArticulo.Enabled = true;
                btn_envioDomicilio.Enabled = true;
            }
        }

        private void IU_RegistrarVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgv_productos.Rows.Count != 0 && ventaRegistrada != true)
            {
                controlador.descartarArticulos();
            }
        }

        //METODOS//

        private void tomarDescripcionArticulo()
        {
            controlador.articuloSolicitado(txt_descripcion.Text);
        }

        private void tomarCantidadArticulo()
        {
            controlador.cantidadSolicitada(int.Parse(txt_cantidad.Text));
        }

        public void mostrarImporteTotal()
        {
            controlador.calcularImporteTotal();
        }

        public void mostrarOpcionEnvioDomicilio()
        {
            if (dgv_productos.Rows.Count>0) btn_envioDomicilio.Enabled = true;
            else btn_envioDomicilio.Enabled = false;
        }

        public void tomarOpcionCobroConTarjeta()
        {
            controlador.registrarCobroConTarjeta();
        }

        public void tomarOpcionEnvioDomicilio()
        {
            controlador.registrarOrdenDeRemito();
        }

        public void tomarOpcionActualizarNotaCredito()
        {
            controlador.actualizarNotaDeCredito();
        }

        public void mostrarOpcionRegistrarVenta()
        {
            if (lbl_importeTotal.Text != "0.00" && dgv_productos.Rows.Count != 0) btn_registrarVenta.Enabled = true;
            else btn_registrarVenta.Enabled = false;
        }

        private void tomarOpcionRegistrarVenta()
        {
            controlador.generarNvoNumeroVenta();
        }

        //DESDE EL ACTUALIZAR ENVIO//
        public void opcionRegistrarVenta(Entrega entregaInstanciada)
        {
            gb_productos.Enabled = false;
            btn_envioDomicilio.Enabled = false;
            btn_detallesEnvioDomicilio.Enabled = false;
            rb_clienteMayorista.Enabled = false;
            rb_clienteMinorista.Enabled = false;
            ch_cargoEnvio.Checked = true;
            ch_notaCredito.Enabled = false;
            btn_registrarVenta.Enabled = true;
            
            controlador.procesarSoloEnvio(entregaInstanciada);
        }

        //DESDE EL MENU REGISTRAR ORDEN DE REMITO
        public void opcionRegistrarVenta(List<Entrega> listaEntrega)
        {
            this.listaEntrega = listaEntrega;
            
            gb_productos.Enabled = false;
            btn_envioDomicilio.Enabled = false;
            btn_detallesEnvioDomicilio.Enabled = false;

            rb_clienteMayorista.Enabled = false;
            rb_clienteMinorista.Enabled = false;
            ch_cargoEnvio.Checked = true;
            
            ch_notaCredito.Enabled = false;
            btn_registrarVenta.Enabled = true;

            controlador.procesarSoloEnvio(this.listaEntrega);
        }
     
        public void mostrarOpcionPago()
        {
            if (lbl_importeTotal.Text != "$ 0.00")
            {
                cbx_formaPago.Enabled = true;
                cbx_formaPago.ValueMember = "CodigoFormaPago";
                cbx_formaPago.DisplayMember = "Descripcion";
                cbx_formaPago.DataSource = controlador.mostrarSeleccionFormaPago();
            }
            else
            {
                cbx_formaPago.Enabled = false;
            }
        }

        private void btn_detalleTarjeta_Click(object sender, EventArgs e)
        {
            IU_InfoTarjeta formInfo = new IU_InfoTarjeta(controlador.listaTarjeta);
            formInfo.ShowDialog();

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_descripcion.Text))
            {
                tomarDescripcionArticulo();
            }
        }

        private void ch_cargoEnvio_CheckedChanged(object sender, EventArgs e)
        {
            controlador.restablecerImporte_sinCargoEnvio();
        }

        private void ch_notaCredito_CheckedChanged(object sender, EventArgs e)
        {
            controlador.restablecerSaldo_sinNotaCredito();
        }

        //VENTA MAYORISTA//
        private void rb_clienteMayorista_CheckedChanged(object sender, EventArgs e)
        {
            lbl_cliente.Text = "Venta Mayorista";
            gb_cliente.Enabled = true;
            txt_razonSocial.Enabled = true;
            btn_buscarDatos.Enabled = true;
            gb_productos.Enabled = false;
            btn_registrarVenta.Enabled = false;
        }

        private void btn_buscarDatos_Click(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_razonSocial.Text))
            {
                tomarRazonSocialCliente();
                if (controlador.verificarExistenciaCliente())
                {
                    mostrarDatosCliente();
                }
                else
                {
                    if (MessageBox.Show("El cliente no existe, quiere registrarlo?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        registrarClienteMayorista = new IU_RegistrarClienteMayorista();
                        registrarClienteMayorista.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("No ingreso razon social del cliente","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tomarRazonSocialCliente()
        {
            controlador.razonSocialCliente(txt_razonSocial.Text);
        }

        private void mostrarDatosCliente()
        {
            controlador.cargarDatosClienteMayorista();
        }

        private void rb_clienteMinorista_CheckedChanged(object sender, EventArgs e)
        {
            lbl_cliente.Text = "Venta Minorista";
            gb_productos.Enabled = true;
            gb_cliente.Enabled = false;
            txt_razonSocial.Text = "";
        }

        private void dgv_articulosDisponibles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IU_DetalleArticulo interfaz = new IU_DetalleArticulo();
            interfaz.opcionDetalle(int.Parse(dgv_articulosDisponibles.CurrentRow.Cells[0].Value.ToString()));
            interfaz.ShowDialog();
        }
        //////////////////
    }
}
