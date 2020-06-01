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

namespace SistemaLaObra
{
    public partial class IU_RegistrarVentaMayorista : Form
    {

        Controlador_VentaMayorista controlador;
        Validaciones validacion;
        MenuOpciones menuOpciones;
        Preferencias preferencias;

        public IU_RegistrarVentaMayorista()
        {
            InitializeComponent();

            preferencias = new Preferencias();
            preferencias.leerPreferenciaColorFondo(this);
        }

        private void IU_RegistrarVentaMayorista_Load(object sender, EventArgs e)
        {
            controlador = new Controlador_VentaMayorista();
            validacion = new Validaciones();
            menuOpciones = new MenuOpciones(this);

            controlador.autoCompletarDescripcion(txt_descripcion);
            controlador.autoCompletarRazonSocial(txt_razonSocial);

            cbx_formaPago.SelectedIndex = 0;
        }

        //BOTONES

        private void btn_buscarDatos_Click(object sender, EventArgs e)
        {
            if (txt_razonSocial.Text != "")
            {
                tomarRazonSocialCliente();
                mostrarDatosCliente();
            }
            else
            {
                MessageBox.Show("No ingreso razon social del cliente");
            }
        }

        private void btn_confirmarDatos_Click(object sender, EventArgs e)
        {
            txt_razonSocial.Enabled = false;
            btn_buscarDatos.Enabled = false;
            btn_cargar.Enabled = true;
            cbx_formaPago.Enabled = true;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text != "")
            {
                if (txt_cantidad.Text != "")
                {
                    tomarDescripcionArticulo();
                    tomarCantidadArticulo();
                    if (controlador.verificarDisponibilidad())
                    {
                        mostrarDatosArticulo();
                        mostrarImporteTotal();
                        mostrarOpcionEnvioDomicilio();
                        mostrarOpcionRegistrarVenta();
                        txt_descripcion.Text = "";
                        txt_cantidad.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No ingreso cantidad solicitada");
                }
            }
            else
            {
                MessageBox.Show("No ingreso ninguna descripcion");
            }
        }

        private void btn_quitarArticulo_Click(object sender, EventArgs e)
        {
            if (controlador.quitarArticulo(dgv_productos))
            {
                mostrarImporteTotal();
                mostrarOpcionEnvioDomicilio();
                mostrarOpcionRegistrarVenta();
            }
        }

        private void btn_envioDomicilio_Click(object sender, EventArgs e)
        {
            tomarOpcionEnvioDomicilio();
        }

        private void btn_cobroTarjeta_Click(object sender, EventArgs e)
        {
            if (lbl_importeTotal.Text != "$ 0")
            {
                //Aca llamar al cobro con tarjeta
            }
            else
            {
                MessageBox.Show("No hay importe");
            }
        }

        private void btn_registrarVenta_Click(object sender, EventArgs e)
        {
            tomarOpcionRegistrarVenta();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            controlador.descartarArticulos(dgv_productos);
            this.Close();
        }

        //METODOS CAPTURADORES

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

        //METODOS DE RESULTADO

        public void mostrarDatosCliente()
        {
            controlador.verificarExistenciaCliente(lbl_numeroCliente, lbl_razonSocial, lbl_cuit, lbl_nombreBanco, lbl_ctaCte, lbl_telefono, lbl_domicilio);

            btn_confirmarDatos.Enabled = true;
            btn_actualizarDtosCliente.Enabled = true;
        }

        private void mostrarDatosArticulo()
        {
            controlador.cargarDatosArticulo(dgv_productos);
        }

        private void mostrarImporteTotal()
        {
            controlador.mostrarImporteTotal(lbl_importeTotal);
        }

        private void mostrarOpcionEnvioDomicilio()
        {
            if (lbl_importeTotal.Text != "0,00") btn_envioDomicilio.Enabled = true;
            else btn_envioDomicilio.Enabled = false;
        }

        private void tomarOpcionEnvioDomicilio()
        {

        }

        private void mostrarOpcionRegistrarVenta()
        {
            if (lbl_importeTotal.Text != "0,00") btn_registrarVenta.Enabled = true;
            else btn_registrarVenta.Enabled = false;
        }

        private void tomarOpcionRegistrarVenta()
        {
            controlador.generarNvoNumeroVenta(dgv_productos, lbl_importeTotal, lbl_numeroCliente);
            MessageBox.Show("La venta se registro correctamente");
            controlador.generarFactura(dgv_productos, lbl_importeTotal, lbl_razonSocial, lbl_cuit, lbl_domicilio);
            this.Close();
        }

        private void tomarOpcionPagoCtaCte()
        {

        }

        private void tomarConfirmacionCtaCte()
        {

        }


        /*
        private void mostrarOpcionPagoCtaCte()
        {

        }

        private void mostrarNroCtaCteClienteMay()
        {

        }

        private void mostrarNombreBancoClienteMay()
        {

        }
        
        private void opcionRegistrarVenta()
        {

        }

        private void mostrarConfirmacionCtaCte()
        {

        }

        */


        //EVENTOS

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void cbx_formaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_formaPago.SelectedIndex == 1)
            {
                btn_cobroTarjeta.Enabled = true;
                btn_cargar.Enabled = false;
                btn_quitarArticulo.Enabled = false;
                txt_descripcion.Enabled = false;
                txt_cantidad.Enabled = false;
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
    }
}
