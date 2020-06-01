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

namespace SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista
{
    public partial class IU_CobroConTarjetaMayorista : Form
    {

        //Instancias referencias
        SqlConnection conexion;
        IU_RegistrarVentaMayorista interfazVenta;
        Controlador_TarjetaVentaMayorista controladorT;
        TipoTarjeta tipoTarjeta;
        Controlador_VentaMayorista controladorV;
        Validaciones validacion;
        private List<Tarjeta> listaTarjeta;



        //Inicializador
        public IU_CobroConTarjetaMayorista()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controladorT = new Controlador_TarjetaVentaMayorista(this);
            listaTarjeta = controladorT.TarjetaColeccion;

        }

        private int _cantidadTarjeta;
        private int i = 1;


        //Constructor
        private void IU_CobroConTarjetaMayorista_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void iniciarDatosCobroTarjeta(Controlador_VentaMayorista controladorV)
        {
            float acumulador = 0f;
            this.controladorV = controladorV;
            controladorT.recibirControladorVenta(controladorV);

            if (controladorV.listaEntrega == null)
            {
                lbl_importeFactura.Text = controladorV.venta.ImporteTotal.ToString();
            }
            else
            {
                foreach (var item in controladorV.listaEntrega)
                {
                    acumulador += item.PrecioEntrega;
                }
                lbl_importeFactura.Text = (controladorV.venta.ImporteTotal + acumulador).ToString();
            }

        }

        //Metodos

        public void cargarDatos()
        {
            controladorT.datosTipoTarjeta();
            if (controladorV.InterfazVentaMayorista.cbx_formaPago.SelectedIndex == 1)
            {
                cb_tipoTarjeta.SelectedValue = 1;
                cb_tipoTarjeta.Enabled = false;
            }
            else
            {
                cb_tipoTarjeta.SelectedValue = 2;
                cb_tipoTarjeta.Enabled = false;
            }
        }

        public void validarTipoTarjeta()
        {
            if (cb_tipoTarjeta.SelectedIndex == 1)
            {
                cb_tipoTarjeta.Enabled = false;
                txt_cuotas.Enabled = false;
                txt_interes.Enabled = false;
                lbl_importeTotal.Enabled = false;
                btn_calcular.Enabled = false;

            }

        }

        public void recibirInterfazVenta(IU_RegistrarVentaMayorista interfazV, Controlador_VentaMayorista controladorV)
        {
            this.interfazVenta = interfazV;
            this.controladorV = controladorV;
            controladorT.recibirControladorVenta(this.controladorV);

        }

        public void tomarCantidadTarjeta()
        {
            _cantidadTarjeta = int.Parse(cb_cantidadTarjeta.Text);
        }

        public void tomarImporteTarjeta()
        {
            if (cb_importe.Checked != true)
            {
                float importe = float.Parse(lbl_importeFactura.Text);
                listaTarjeta.ElementAt(controladorT.IndiceTarjeta).ImporteTarjeta = importe;

                //controladorT.importeTarjetaTomado(importe);
            }
            else
            {
                float importe = float.Parse(txt_otroImporte.Text);
                listaTarjeta.ElementAt(controladorT.IndiceTarjeta).ImporteTarjeta = importe;

                //controladorT.importeTarjetaTomado(importe);
            }
        }

        public void tomarNombre()
        {
            string nombre = txt_nombre.Text;
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).Nombre = nombre;

            //controladorT.nombreIngresado(nombre);

        }

        public void tomarApellido()
        {
            string apellido = txt_apellido.Text;
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).Apellido = apellido;

            //controladorT.apellidoIngresado(apellido);

        }

        public void datosTipoTarjetaSeleccionado()
        {
            string codigoTipoTarjeta = cb_tipoTarjeta.SelectedValue.ToString();
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).CodigoTipoTarjeta = int.Parse(codigoTipoTarjeta);

            //controladorT.seleccionTipoTarjeta(codigoTipoTarjeta);
        }

        public void datosNomTarjetaSeleccionado()
        {
            string codigoTarjeta = cb_tarjeta.SelectedValue.ToString();
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).CodigoNombreTarjeta = int.Parse(codigoTarjeta);

            //controladorT.seleccionNombreTarjeta(codigoTarjeta);

        }

        public void datosBancoSeleccionado()
        {
            string codigoBanco = cb_Banco.SelectedValue.ToString();
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).CodigoBanco = int.Parse(codigoBanco);
        }

        public void tomarNumeroTarjeta()
        {
            string numeroTarjeta0 = txt_n1.Text.Trim() + txt_n2.Text.Trim() + txt_n3.Text.Trim() + txt_n4.Text.Trim();
            long numeroTarjeta = long.Parse(numeroTarjeta0);
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).NumeroTarjeta = numeroTarjeta;

            //controladorT.numeroTarjetaTomado(numeroTarjeta);
        }

        public void tomarCantidadCuotas()
        {
            string cuotas1 = txt_cuotas.Text;
            int cuota = int.Parse(cuotas1);
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).Cuota = cuota;

            //controladorT.cantidadCuota(cuota);
        }

        public void tomarPorcentajeInteres()
        {
            string interes1 = txt_interes.Text;
            int interes = int.Parse(interes1);
            listaTarjeta.ElementAt(controladorT.IndiceTarjeta).Interes = interes;

            //controladorT.porcentajeInteresTomado(interes);
        }

        public void tomarOpcionCalucular()
        {
            controladorT.opcionCalcularTomado();
        }

        public void opcionRegistrarCobroConTarjeta()
        {
         /*   DialogResult opcion;
            opcion = MessageBox.Show("¿Esta seguro que desea enviar los datos?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (opcion == DialogResult.Cancel)
         */
            tomarImporteTarjeta();
            controladorT.importeTarjetaTomado(listaTarjeta);
            tomarNombre();
            controladorT.nombreIngresado(listaTarjeta);
            tomarApellido();
            controladorT.apellidoIngresado(listaTarjeta);
            datosNomTarjetaSeleccionado();
            controladorT.seleccionNombreTarjeta(listaTarjeta);
            datosBancoSeleccionado();
            controladorT.seleccionBanco(listaTarjeta);
            datosTipoTarjetaSeleccionado();
            controladorT.seleccionTipoTarjeta(listaTarjeta);
            tomarNumeroTarjeta();
            controladorT.numeroTarjetaTomado(listaTarjeta);
            if (cb_tipoTarjeta.Text == "Credito")
            {
                tomarCantidadCuotas();
                controladorT.cantidadCuota(listaTarjeta);
                tomarPorcentajeInteres();
                controladorT.porcentajeInteresTomado(listaTarjeta);
                controladorT.calcularTotal();
            }
        

        }

        public void formularioEnable()
        {
            groupBox1.Enabled = true;
            label6.Enabled = true;
            lbl.Enabled = true;
            label17.Enabled = true;
            lbl_signo_pesos.Enabled = true;
            txt_otroImporte.Enabled = true;
            label5.Enabled = true;
            label19.Enabled = true;
            txt_nombre.Enabled = true;
            label20.Enabled = true;
            txt_apellido.Enabled = true;
            label18.Enabled = true;
            label10.Enabled = true;
            label8.Enabled = true;
            cb_Banco.Enabled = true;
            label11.Enabled = true;
            cb_tarjeta.Enabled = true;
            label22.Enabled = true;
            txt_n1.Enabled = true;
            txt_n2.Enabled = true;
            txt_n3.Enabled = true;
            txt_n4.Enabled = true;
            label7.Enabled = true;
            txt_cuotas.Enabled = true;
            label12.Enabled = true;
            txt_interes.Enabled = true;
            label21.Enabled = true;
            lbl_importeTotal.Enabled = true;
            btn_calcular.Enabled = true;
            btn_aceptar.Enabled = true;
            btn_cerrar.Enabled = true;
            btn_calcular.Enabled = true;
            lbl_importeTotal.Visible = true;
            lbl_importeTotal.Enabled = true;
        }

        public void formularioFormatear()
        {
            txt_otroImporte.Text="";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            controladorT.datosTipoTarjeta();
            txt_n1.Text = "";
            txt_n2.Text = "";
            txt_n3.Text = "";
            txt_n4.Text = "";
            txt_cuotas.Text = "";       
            txt_interes.Text = "";
            lbl_importeTotal.Text = "---";
        }


        public void comparar(TextBox validacion)
       {

            int bandera = 0;
            float acumulador = 0;

            if (listaTarjeta.Count > 1)
            {
                foreach (var item in listaTarjeta)
                {

                    if (item.Nombre != "")
                        bandera = 1;
                }
            }


            decimal numero = Convert.ToDecimal(validacion.Text);
            decimal numeroImporte = Convert.ToDecimal(lbl_importeFactura.Text);


            if (bandera != 1)
            {
                if (numero > numeroImporte)
                {

                    MessageBox.Show("El numero no puede ser mayor que el importe de la factura");
                    txt_otroImporte.Text = "";
                }
            }


            if (listaTarjeta.Count >= 2)
            {
                foreach (var item in listaTarjeta)
                {
                    acumulador = acumulador + item.ImporteTarjeta;
                    if (item.Nombre != "")
                    {
                        decimal importe = Convert.ToDecimal(float.Parse(lbl_importeFactura.Text) - acumulador);
                        if (numero != importe)
                        {
                            numeroImporte = numeroImporte - numero;


                            if (numero > importe)
                            {
                                MessageBox.Show("Este importe supera el valor de la factura");
                                txt_otroImporte.Text = "";
                            }

                        }

                    }
                }
            }
        }



        //Eventos
        private void lbl_importeFactura_Click(object sender, EventArgs e)
        {

        }

        private void lbl_importaFactura_Click(object sender, EventArgs e)
        {

        }

        private void cb_importe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_signo_pesos_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_importe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
                    }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
                MessageBox.Show("El campo Nombre no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txt_apellido.Text == "")
                MessageBox.Show("El campo Apellido no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cb_tipoTarjeta.Text == "Seleccione")
                MessageBox.Show("El campo Tarjeta no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cb_Banco.Text == "Seleccione")
                MessageBox.Show("El campo Banco no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cb_tarjeta.Text == "Seleccione")
                MessageBox.Show("El campo Tipo Tarjeta no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txt_n1.Text == "" || txt_n2.Text == "" || txt_n3.Text == "" || txt_n4.Text == "")
                MessageBox.Show("Los campos numero de tarjeta no pueden quedar vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cb_tipoTarjeta.Text == "Credito" && txt_cuotas.Text == "")
                MessageBox.Show("El campo Cuotas no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cb_tipoTarjeta.Text == "Credito" && txt_interes.Text == "")
                MessageBox.Show("El campo Interés no puede quedar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            else if (_cantidadTarjeta > i)
            {
                if (controladorT.IndiceTarjeta >= 0)
                {
                    opcionRegistrarCobroConTarjeta();
                    controladorT.IndiceTarjeta = i;
                    formularioFormatear();
                    cb_importe.Checked = true;
                    controladorT.calcularDiferenciaCobro(listaTarjeta);
                    lbl.Enabled = false;
                    lbl_importeFactura.Enabled = false;
                    lbl_signo_pesos.Enabled = false;
                    cb_importe.Checked = true;
                    i++;
                    lbl_tarjeta.Visible = true;
                    lbl_tarjeta.Enabled = true;
                    lbl_tarjeta.ForeColor = System.Drawing.Color.Red;
                    lbl_tarjeta.Text = "Tarjeta " + i;
                    cargarDatos();
                    validarTipoTarjeta();

                }
            }

            else
            {

                opcionRegistrarCobroConTarjeta();
                controladorV.tomarRegistroTarjeta(listaTarjeta);
                controladorV.InterfazVentaMayorista.btn_cobroTarjeta.Enabled = false;
                controladorV.InterfazVentaMayorista.cbx_formaPago.Enabled = false;
                controladorV.InterfazVentaMayorista.btn_envioDomicilio.Enabled = false;
                controladorV.InterfazVentaMayorista.ch_cargoEnvio.Enabled = false;
                controladorV.InterfazVentaMayorista.btn_quitarArticulo.Enabled = false;


                this.Hide();
            }
        }

        private void txt_cuotas_TextChanged(object sender, EventArgs e)
        {
            if (txt_cuotas.Text != "")
                validacion.SoloDosDigitos(txt_cuotas);
        }

        private void Cargar_Click(object sender, EventArgs e)
        {

            cb_cantidadTarjeta.Enabled = false;
            btn_cargar.Enabled = false;
            label1.Enabled = false;
            formularioEnable();
            lbl_importeFactura.Enabled = true;
            lbl.Enabled = true;
            lbl_signo_pesos.Enabled = true;
            label17.Enabled = false;
            txt_otroImporte.Enabled = false;
            if (int.Parse(cb_cantidadTarjeta.Text) > 1)
            cb_importe.Checked = true;        
            tomarCantidadTarjeta();
            controladorT.cantidadTarjeta(_cantidadTarjeta);
            controladorT.IndiceTarjeta = 0;
            lbl_tarjeta.Visible = true;
            lbl_tarjeta.Enabled = true;
            lbl_tarjeta.ForeColor = System.Drawing.Color.Red;
            lbl_tarjeta.Text = "Tarjeta " + i;
            validarTipoTarjeta();
           


        }

        private void cb_tipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            controladorT.datosBAnco();
        }

        private void cb_Banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            controladorT.datosNombreTarjeta();
        }

        private void cb_tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_otroImporte_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_otroImporte.Text != "")
                comparar(txt_otroImporte);
        }

        private void cb_importe_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_importe.Checked == true)
            {
                lbl_importeFactura.Enabled = false;
                lbl_signo_pesos.Enabled = false;
                lbl.Enabled = false;

                label17.Enabled = true;
                txt_otroImporte.Enabled = true;

                txt_otroImporte.Focus();
            }
            else
            {
                lbl_importeFactura.Enabled = true;
                lbl_signo_pesos.Enabled = true;
                lbl.Enabled = true;

                label17.Enabled = false;
                txt_otroImporte.Enabled = false;
            }
        }

        private void txt_otroImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloDecimalesConComa(e);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txt_n2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_n3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_n4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_cuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloEnteros(e);
            validacion.soloNumeros(e);
        }

        private void txt_interes_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloEnteros(e);
            validacion.soloNumeros(e);
           
        }

        private void txt_interes_TextChanged(object sender, EventArgs e)
        {
            if (txt_interes.Text!="")
            validacion.SoloDosDigitos(txt_interes);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            tomarOpcionCalucular();
        }
    }
}
