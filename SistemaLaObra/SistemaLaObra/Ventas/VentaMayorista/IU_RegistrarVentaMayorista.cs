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
using SistemaLaObra.Ventas.ActualizarClienteMayorista;
using SistemaLaObra.Ventas.RegistrarClienteMayorista;
using SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista;
using SistemaLaObra.Ventas.VentaMayorista;
using SistemaLaObra.Ventas.CobroConTarjeta;
using SistemaLaObra.Ventas.OrdenDeRemito;

namespace SistemaLaObra
{
    public partial class IU_RegistrarVentaMayorista : Form
    {

        public Controlador_VentaMayorista controlador;
        Validaciones validacion;
        IU_RegistrarClienteMayorista registrarClienteMayorista;
        public IU_MenuPrincipal InterfazContenedora { get; set; }

        public IU_RegistrarVentaMayorista()
        {
            InitializeComponent();

            validacion = new Validaciones();
            controlador = new Controlador_VentaMayorista();
            controlador.InterfazVentaMayorista = this;
        }

        //BOTONES
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
                    if(MessageBox.Show("El cliente no existe, desea registrarlo?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        registrarClienteMayorista = new IU_RegistrarClienteMayorista();
                        registrarClienteMayorista.ShowDialog();
                    }
                }                
            }
            else
            {
                MessageBox.Show("No ingreso razon social del cliente");
            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
           if (!validacion.campoVacio(txt_cantidad.Text))
           {
                if (dgv_articulosDisponibles.Rows.Count != 0)
                {
                    controlador.buscarDatosArticulo(int.Parse(dgv_articulosDisponibles.CurrentRow.Cells[0].Value.ToString()));
                    tomarCantidadArticulo();
                }
                else
                {
                    MessageBox.Show("No tiene un articulo seleccionado");
                }
           }
           else
           {
                MessageBox.Show("No ingreso cantidad solicitada");
           } 
        }

        private void btn_quitarArticulo_Click(object sender, EventArgs e)
        {
            controlador.quitarArticulo();
            mostrarOpcionEnvioDomicilio();
            mostrarOpcionPago();
            mostrarOpcionRegistrarVenta();
        }

        private void btn_envioDomicilio_Click(object sender, EventArgs e)
        {
            tomarOpcionEnvioDomicilio();
        }



        private void btn_registrarVenta_Click(object sender, EventArgs e)
        {
            tomarOpcionRegistrarVenta();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (dgv_productos.Rows.Count != 0)
            {
                controlador.descartarArticulos();
            }
            this.Close();
        }

        private void btn_detallesEnvioDomicilio_Click(object sender, EventArgs e)
        {
            IU_Info formInfo = new IU_Info(controlador.listaEntrega, controlador.listaDetalleLogistica);
            formInfo.ShowDialog();
        }

        //METODOS


        private void tomarRazonSocialCliente()
        {
            controlador.razonSocialCliente(txt_razonSocial.Text);
        }

        private void tomarDescripcionArticulo()
        {
            controlador.articuloSolicitado(txt_descripcion.Text);
        }

        private void tomarCantidadArticulo()
        {
            controlador.cantidadSolicitada(txt_cantidad.Text);
        }

        private void mostrarDatosCliente()
        {
            controlador.cargarDatosClienteMayorista();
        }

        public void mostrarImporteTotal()
        {
            controlador.calcularImporteTotal();
        }

        public void mostrarOpcionEnvioDomicilio()
        {
            if (dgv_productos.RowCount==0)
            {
                btn_envioDomicilio.Enabled = false;
            }
            else
            {
                btn_envioDomicilio.Enabled = true;
            }           
        }

        public void tomarOpcionCobroConTarjeta()
        {
            controlador.registrarCobroConTarjeta();
        }

        private void tomarOpcionEnvioDomicilio()
        {
            controlador.registrarOrdenDeRemito();
        }

        public void tomarOpcionActualizarNotaCredito()
        {
            controlador.actualizarNotaDeCredito();
        }

        public void mostrarOpcionPago()
        {
            if (lbl_importeTotal.Text != "$0.00")
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

        public void mostrarOpcionRegistrarVenta()
        {
            if (lbl_importeTotal.Text != "0.00") btn_registrarVenta.Enabled = true;
            else btn_registrarVenta.Enabled = false;
        }

        private void tomarOpcionRegistrarVenta()
        {
            controlador.generarNvoNumeroVenta();
            MessageBox.Show("La venta se registro exitosamente");
            this.Close();
        }

        //EVENTOS

        private void IU_RegistrarVentaMayorista_Load(object sender, EventArgs e)
        {            
            controlador.autoCompletarRazonSocial(txt_razonSocial);
            mostrarOpcionPago();
            cbx_formaPago.SelectedIndex = 0;
            txt_descripcion.Enabled = false;
            txt_cantidad.Enabled = false;
            btn_cargar.Enabled = false;
            btn_quitarArticulo.Enabled = false;
            btn_detallesEnvioDomicilio.Enabled = false;
            btn_envioDomicilio.Enabled = false;
            ch_cargoEnvio.Checked = false;
            ch_cargoEnvio.Enabled = false;
            ch_notaCredito.Checked = false;
            ch_notaCredito.Enabled = false;
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
                btn_cargar.Enabled = false;
                btn_quitarArticulo.Enabled = false;
                txt_descripcion.Enabled = false;
                txt_cantidad.Enabled = false;
            }
            else if (cbx_formaPago.SelectedIndex == 4)
            {
                tomarOpcionActualizarNotaCredito();
            }
            else
            {
                btn_cobroTarjeta.Enabled = false;
                btn_cargar.Enabled = true;
                btn_quitarArticulo.Enabled = true; 
                txt_descripcion.Enabled = true;
                txt_cantidad.Enabled = true;
            }
        }

        private void IU_RegistrarVentaMayorista_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgv_productos.Rows.Count != 0)
            {
                controlador.descartarArticulos();
            }
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_descripcion.Text))
            {
                tomarDescripcionArticulo();
            }
        }

        private void btn_cobroTarjeta_Click_1(object sender, EventArgs e)
        {
            tomarOpcionCobroConTarjeta();
        }

        private void btn_detalleTarjeta_Click(object sender, EventArgs e)
        {
            IU_InfoTarjeta formInfo = new IU_InfoTarjeta(controlador.listaTarjeta);
            formInfo.ShowDialog();
        }

        private void ch_cargoEnvio_CheckedChanged(object sender, EventArgs e)
        {
            if (controlador.listaEntrega != null)
            {
                if (ch_cargoEnvio.Checked == false)
                {
                    //controlador.listaEntregaAuxiliar = controlador.listaEntrega;
                    foreach (var item in controlador.listaEntrega)
                    {
                        item.PrecioEntrega = 0;
                    }
                    controlador.actualizarDatosInterfaz();
                    groupBox3.Enabled = false;
                }
                else
                {
                    //controlador.listaEntrega = controlador.listaEntregaAuxiliar;
                    if (controlador.listaEntrega.First().PrecioEntrega == 0)
                    {
                        for (int i = 0; i < controlador.listaEntrega.Count; i++)
                        {
                            controlador.listaEntrega[i].PrecioEntrega = controlador.listaEntregaAuxiliar[i];
                        }
                        controlador.actualizarDatosInterfaz();
                        groupBox3.Enabled = true;
                    }
                    else
                    {
                        controlador.actualizarDatosInterfaz();
                        groupBox3.Enabled = true;
                    }
                }
            }
        }

        private void ch_notaCredito_CheckedChanged(object sender, EventArgs e)
        {
            controlador.restablecerSaldo_sinNotaCredito();
        }
    }
}
