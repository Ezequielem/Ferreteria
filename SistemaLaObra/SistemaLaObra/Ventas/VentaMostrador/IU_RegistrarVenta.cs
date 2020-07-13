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

        //BOTONES//

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            rb_clienteMayorista.Enabled = false;
            rb_clienteMinorista.Enabled = false;
            IU_CargaArticulo interfaz = new IU_CargaArticulo(controlador);
            interfaz.ShowDialog();
        }

        private void btn_quitarArticulo_Click(object sender, EventArgs e)
        {
            controlador.quitarArticulo();
            mostrarOpcionRegistrarVenta();
            mostrarOpcionEnvioDomicilio();
            if (controlador.venta.ImporteTotal == 0.00f)
            {
                pbx_FormaDePago.Visible = false;
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
                MessageBox.Show("No ingreso razon social del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_detalleTarjeta_Click(object sender, EventArgs e)
        {
            IU_InfoTarjeta formInfo = new IU_InfoTarjeta(controlador.listaTarjeta);
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

        //METODOS//

        public void mostrarImporteTotal()
        {
            controlador.calcularImporteTotal();
        }

        public void mostrarOpcionEnvioDomicilio()
        {
            if (dgv_productos.Rows.Count>0)
            {
                gbx_envio.Enabled = true;
                btn_envioDomicilio.Enabled = true;
            }
            else
            {
                gbx_envio.Enabled = false;
                btn_envioDomicilio.Enabled = false;
            }   
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
            if (lbl_importeTotal.Text != "0.00" && dgv_productos.Rows.Count != 0)
            {
                btn_registrarVenta.Enabled = true;
            }                
            else
            {
                btn_registrarVenta.Enabled = false;
            }                
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
                pbx_FormaDePago.Visible = true;
                cbx_formaPago.Enabled = true;
                cbx_formaPago.ValueMember = "CodigoFormaPago";
                cbx_formaPago.DisplayMember = "Descripcion";
                cbx_formaPago.DataSource = controlador.mostrarSeleccionFormaPago();
            }
            else
            {
                pbx_FormaDePago.Visible = false;
                cbx_formaPago.Enabled = false;
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

        private void inicializarComponentes()
        {
            mostrarOpcionPago();
            cbx_formaPago.SelectedIndex = 0;
            gbx_envio.Enabled = false;
            btn_detallesEnvioDomicilio.Enabled = false;
            btn_envioDomicilio.Enabled = false;
            ch_cargoEnvio.Enabled = false;
            ch_notaCredito.Enabled = false;
            DataGridViewCellStyle fuente = new DataGridViewCellStyle();
            fuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fuente.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            fuente.BackColor = System.Drawing.SystemColors.Control;
            fuente.ForeColor = System.Drawing.SystemColors.WindowText;
            fuente.NullValue = "0";
            fuente.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            fuente.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            fuente.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_productos.ColumnHeadersDefaultCellStyle = fuente;
        }

        //EVENTOS

        private void IU_RegistrarVenta_Load(object sender, EventArgs e)
        {
            controlador.autoCompletarRazonSocial(txt_razonSocial);
            inicializarComponentes();
        }

        private void rb_clienteMinorista_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "REGISTRAR VENTA MINORISTA";
            gb_productos.Enabled = true;
            gb_cliente.Enabled = false;
            txt_razonSocial.Text = "";
        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IU_DetalleArticulo interfaz = new IU_DetalleArticulo();
            interfaz.opcionDetalle(int.Parse(dgv_productos.CurrentRow.Cells[0].Value.ToString()));
            interfaz.ShowDialog();
        }

        private void ch_cargoEnvio_CheckedChanged(object sender, EventArgs e)
        {
            controlador.restablecerImporte_sinCargoEnvio();
        }

        private void ch_notaCredito_CheckedChanged(object sender, EventArgs e)
        {
            controlador.restablecerSaldo_sinNotaCredito();
        }

        private void cbx_formaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_formaPago.SelectedIndex == 0)
            {
                pbx_FormaDePago.Image = Properties.Resources.dinero_32;
                gbx_Tarjeta.Enabled = false;
                btn_cobroTarjeta.Enabled = false;
                btn_cargar.Enabled = true;
                btn_quitarArticulo.Enabled = true;
                gbx_envio.Enabled = true;
                btn_envioDomicilio.Enabled = true;
            }
            else if (cbx_formaPago.SelectedIndex == 1)
            {
                pbx_FormaDePago.Image = Properties.Resources.dinero_32;
                gbx_Tarjeta.Enabled = false;
                btn_cobroTarjeta.Enabled = false;
                btn_cargar.Enabled = true;
                btn_quitarArticulo.Enabled = true;
                gbx_envio.Enabled = true;
                btn_envioDomicilio.Enabled = true;
            }
            else if (cbx_formaPago.SelectedIndex == 2)
            {
                pbx_FormaDePago.Image = Properties.Resources.credito_32;
                gbx_Tarjeta.Enabled = true;
                btn_cobroTarjeta.Enabled = true;
                btn_cargar.Enabled = false;
                btn_quitarArticulo.Enabled = false;
                gbx_envio.Enabled = false;
                btn_envioDomicilio.Enabled = false;
                ch_cargoEnvio.Enabled = false;
                ch_notaCredito.Enabled = false;
            }
            else if (cbx_formaPago.SelectedIndex == 3)
            {
                pbx_FormaDePago.Image = Properties.Resources.cuentaCorrienteGris_32;
                gbx_Tarjeta.Enabled = false;
                btn_cobroTarjeta.Enabled = false;
                btn_cargar.Enabled = true;
                btn_quitarArticulo.Enabled = true;
                gbx_envio.Enabled = true;
                btn_envioDomicilio.Enabled = true;
            }
            else if (cbx_formaPago.SelectedIndex == 4)
            {
                pbx_FormaDePago.Image = Properties.Resources.facturaNCGris_32;
                gbx_envio.Enabled = false;
                btn_envioDomicilio.Enabled = false;
                ch_cargoEnvio.Enabled = false;
                tomarOpcionActualizarNotaCredito();
            }
        }

        private void IU_RegistrarVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgv_productos.Rows.Count != 0 && ventaRegistrada != true)
            {
                controlador.descartarArticulos();
            }
        }

        //VENTA MAYORISTA//
        private void rb_clienteMayorista_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "REGISTRAR VENTA MAYORISTA";

            gb_cliente.Enabled = true;
            txt_razonSocial.Enabled = true;
            btn_buscarDatos.Enabled = true;
            gb_productos.Enabled = false;
            btn_registrarVenta.Enabled = false;
        }
    }
}
