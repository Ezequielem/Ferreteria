using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Compras.RegistrarProveedor
{
    public partial class IU_RegistrarProveedor : Form
    {
        //INSTANCIAS
        Controlador_RegistrarProveedor controladorProveedor;
        Validaciones validaciones;


        public IU_RegistrarProveedor()
        {
            InitializeComponent();
            controladorProveedor = new Controlador_RegistrarProveedor();
            validaciones = new Validaciones();
            
        }

        private void IU_RegistrarProveedor_Load(object sender, EventArgs e)
        {
            cargarDatosBanco();
            cargarDatosTiposTelefonos();
            cargarDatosProvincias();
            inicializarListaCombos();
        }

        //METODOS

        public void tomarNumeroCuit()
        {
            controladorProveedor.numeroCuitIngresado(long.Parse(txt_Cuit.Text));
        }

        public void tomarRazonSocial()
        {
            controladorProveedor.razonSocialIngresada(txt_RazonSocial.Text);
        }

        public void tomarBanco()
        {
            controladorProveedor.nombreBancoSeleccionado(cb_Banco.Text);
        }

        public void tomarCuentaCorriente()
        {
            controladorProveedor.cuentaCorrienteIngresada(long.Parse(txt_CuentaCorriente.Text));
        }

        public void tomarTipoTelefono1()
        {
            controladorProveedor.tipoTelefono1Ingresado(cb_TipoTelefonoUno.Text);
        }

        public void tomarNumeroTelefono1()
        {
            controladorProveedor.numeroTelefono1Ingresado(long.Parse(txt_NumeroTelefono.Text));
        }

        public void tomarTipoTelefono2()
        {
            controladorProveedor.tipoTelefono2Ingresado(cb_TipoTelefonoDos.Text);
        }

        public void tomarNumeroTelefono2()
        {
            controladorProveedor.numeroTelefono2Ingresado(long.Parse(txt_NumeroTelefono2.Text));
        }

        public void tomarProvincia()
        {
            controladorProveedor.provinciaSeleccionada(cb_Provincia.Text);
        }

        public void tomarDepartamento()
        {
            controladorProveedor.departamentoSeleccionado(cb_departamento.Text);
        }

        public void tomarLocalidad()
        {
            controladorProveedor.localidadSeleccionada(cb_Localidad.Text);
        }

        public void tomarBarrio()
        {
            controladorProveedor.barrioSeleccionado(txt_Barrio.Text);
        }

        public void tomarCalle()
        {
            controladorProveedor.calleIngresada(txt_Calle.Text);
        }

        public void tomarNumeroDomicilio()
        {
            controladorProveedor.numeroDomicilioIngresado(int.Parse(txt_NumeroCalle.Text));
        }

        public void tomarCodigoPostal()
        {
            controladorProveedor.codigoPostalIngresado(int.Parse(txt_CPostal.Text));
        }

        public void cargarDatosBanco()
        {
           cb_Banco.ValueMember = "CodigoBanco";
           cb_Banco.DisplayMember = "Descripcion";
           cb_Banco.DataSource = controladorProveedor.mostrarDatosBancos();
        }

        public void cargarDatosTiposTelefonos()
        {
            cb_TipoTelefonoUno.ValueMember = "CodigoTipoTelefono";
            cb_TipoTelefonoUno.DisplayMember = "Descripcion";
            cb_TipoTelefonoUno.DataSource = controladorProveedor.mostrarDatosTiposTelefonos();

            cb_TipoTelefonoDos.ValueMember = "CodigoTipoTelefono";
            cb_TipoTelefonoDos.DisplayMember = "Descripcion";
            cb_TipoTelefonoDos.DataSource = controladorProveedor.mostrarDatosTiposTelefonos();
        }

        public void cargarDatosProvincias()
        {
            cb_Provincia.ValueMember = "CodigoProvincia";
            cb_Provincia.DisplayMember = "NombreProvincia";
            cb_Provincia.DataSource = controladorProveedor.mostrarDatosProvincias();
        }

        public void cargarDatosDepartamento()
        {
            int codigoProv = int.Parse(cb_Provincia.SelectedValue.ToString());
            cb_departamento.ValueMember = "CodigoDepartamento";
            cb_departamento.DisplayMember = "NombreDepartamento";
            cb_departamento.DataSource = controladorProveedor.mostrarDatosDepartamento(codigoProv);
        }

        public void cargarDatosLocalidades()
        {
            int codigoDepto = int.Parse(cb_departamento.SelectedValue.ToString());
            cb_Localidad.ValueMember = "CodigoLocalidad";
            cb_Localidad.DisplayMember = "NombreLocalidad";
            cb_Localidad.DataSource = controladorProveedor.mostrarDatosLocalidad(codigoDepto);
        }

        private void inicializarListaCombos()
        {
            cb_Provincia.SelectedValue = 5;
            cb_departamento.SelectedValue = 213;
            cb_Localidad.SelectedValue = 1560;
        }

        private void formularioEnable()
        {
            lbl_Cuit.Enabled = false;
            lbl_RazonSocial.Enabled = true;
            txt_RazonSocial.Enabled = true;
            lbl_Banco.Enabled = true;
            cb_Banco.Enabled = true;
            txt_Barrio.Enabled = true;
            lbl_CuentaCorriente.Enabled = true;
            txt_CuentaCorriente.Enabled = true;
            lbl_TipoTelefono1.Enabled = true;
            lbl_NumTelefono1.Enabled = true;
            cb_TipoTelefonoUno.Enabled = true;
            txt_NumeroTelefono.Enabled = true;
            lbl_TipoTelefono2.Enabled = true;
            lbl_NumeroTelefono2.Enabled = true;
            cb_TipoTelefonoDos.Enabled = true;
            txt_NumeroTelefono2.Enabled = true;
            groupBox1.Enabled = true;
            btn_Registrar.Enabled = true;
            btn_Cancelar.Enabled = true;
        }

        public void opcionConfirmar()
        {
           
            tomarRazonSocial();
            tomarBanco();
            tomarCuentaCorriente();
            tomarTipoTelefono1();
            tomarNumeroTelefono1();
            tomarTipoTelefono2();
            tomarNumeroTelefono2();
            tomarCalle();
            tomarNumeroDomicilio();
            tomarProvincia();
            tomarDepartamento();
            tomarLocalidad();
            tomarCodigoPostal();
            tomarBarrio();
            controladorProveedor.opcionConfirmarTomado();
            MessageBox.Show("Se ha registrado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tomarNumeroCuit();
            bool a=controladorProveedor.verificarExistencia();
            if (a == true)
            {
                MessageBox.Show("El numero de cuit ingresado ya existe","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Cuit.Text = "";
                txt_Cuit.Focus();
            }
            else
            {
                formularioEnable();
                txt_Cuit.Enabled = false;
                button1.Enabled = false;
            }
         
            
        }

        private void cb_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDepartamento();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_RazonSocial.Text == "")
            {
                MessageBox.Show("El campo Razon Social no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_RazonSocial.Focus();
            }
            else if (txt_CuentaCorriente.Text == "")
            {
                MessageBox.Show("El campo Cuenta Corriente no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_CuentaCorriente.Focus();
            }
            else if (txt_NumeroTelefono.Text == "")
            {
                MessageBox.Show("El campo Numero de telefono 1 no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_NumeroTelefono.Focus();
            }
            else if (txt_NumeroTelefono2.Text == "")
            {
                MessageBox.Show("El campo Numero de telefono 2 no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_NumeroTelefono2.Focus();
            }
            else if (txt_Barrio.Text == "")
            {
                MessageBox.Show("El campo Barrio no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Barrio.Focus();
            }
            else if (txt_CPostal.Text == "")
            {
                MessageBox.Show("El campo Codigo Postal no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_CPostal.Focus();
            }
            else if (txt_Calle.Text == "")
            {
                MessageBox.Show("El campo Calle no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Calle.Focus();
            }
            else if (txt_NumeroCalle.Text == "")
            {
                MessageBox.Show("El campo Numero no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_NumeroCalle.Focus();
            }
            else
            {
                opcionConfirmar();

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENTOS

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosLocalidades();
        }

        private void txt_Cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_CuentaCorriente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_NumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_NumeroTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_CPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_NumeroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }
    }
}
