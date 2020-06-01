using SistemaLaObra.Ventas.VentaMayorista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.ActualizarClienteMayorista
{
    public partial class IU_ActualizarClienteMayorista : Form
    {

        //INSTANCIAS
        Validaciones validacion;
        public IU_RegistrarVenta InterfazVenta { get; set; }
        public IU_DatosClienteMayorista InterfazDatosCliente {get;set;}
        Controlador_ActualizarClienteMayorista controlador;

        public IU_ActualizarClienteMayorista()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controlador = new Controlador_ActualizarClienteMayorista();
            controlador.InterfazActualizarCliente = this;
        }

        private void tomarRazonSocial()
        {
            controlador.razonSocialCliente(txt_razonSocial.Text);
        }

        private void tomarCuit()
        {
            controlador.cuitCliente(txt_cuit.Text);
        }

        public void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = controlador.mostrarSeleccionTipoTelefono();
        }

        private void tomarSeleccionTipoTelefono()
        {
            controlador.tipoTelefonoCliente(int.Parse(cbx_tipoTelefono.SelectedValue.ToString()));
        }

        private void tomarNroTelefono()
        {
            controlador.nroTelefonoCliente(txt_nroTelefono.Text);
        }

        public void cargarBancos()
        {
            cbx_banco.ValueMember = "CodigoBanco";
            cbx_banco.DisplayMember = "Descripcion";
            cbx_banco.DataSource = controlador.mostrarSeleccionBanco();
        }

        private void tomarSeleccionBanco()
        {
            controlador.nombreBancoCliente(int.Parse(cbx_banco.SelectedValue.ToString()));
        }

        private void tomarNroCuentaCorriente()
        {
            controlador.nroCtaCteCliente(txt_nroCuentaCorriente.Text);
        }

        private void tomarCalle()
        {
            controlador.calleCliente(txt_calle.Text);
        }

        private void tomarNumero()
        {
            controlador.numeroCliente(int.Parse(txt_numero.Text));
        }

        private void tomarDepto()
        {
            controlador.deptoCliente(txt_depto.Text);
        }

        private void tomarPiso()
        {
            controlador.pisoCliente(txt_piso.Text);
        }

        private void tomarBarrio()
        {
            controlador.barrioCliente(txt_barrio.Text);
        }

        private void tomarCodigoPostal()
        {
            if (txt_codigoPostal.Text != "")
            {
                controlador.codigoPostalCliente(int.Parse(txt_codigoPostal.Text));
            }
            else
            {
                controlador.codigoPostalCliente(0);
            }
        }

        public void cargarProvincias()
        {
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = controlador.mostrarSeleccionProvincia();
        }

        private void tomarSeleccionProvincia()
        {
            controlador.provinciaCliente(int.Parse(cbx_provincia.SelectedValue.ToString()));
        }

        public void cargarDepartamentos()
        {
            int codigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = controlador.mostrarSeleccionDepartamento(codigoProvincia);
        }

        private void tomarSeleccionDepartamento()
        {
            controlador.departamentoCliente(int.Parse(cbx_departamento.SelectedValue.ToString()));
        }

        public void cargarLocalidades()
        {
            int codigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = controlador.mostrarSeleccionLocalidad(codigoDepartamento);
        }

        private void tomarSeleccionLocalidad()
        {
            controlador.localidadCliente(int.Parse(cbx_localidad.SelectedValue.ToString()));
        }

        private void confirmarActualizacion()
        {
            if (txt_nroTelefono.Text != "" && txt_nroCuentaCorriente.Text != "")
            {
                tomarSeleccionTipoTelefono();
                tomarNroTelefono();
                tomarSeleccionBanco();
                tomarNroCuentaCorriente();

                if (txt_calle.Text != "" && txt_numero.Text != "" && txt_barrio.Text != "")
                {
                    tomarCalle();
                    tomarNumero();
                    tomarDepto();
                    tomarPiso();
                    tomarBarrio();
                    tomarCodigoPostal();
                    tomarSeleccionProvincia();
                    tomarSeleccionDepartamento();
                    tomarSeleccionLocalidad();
                    controlador.actualizarDatosCliente();
                    MessageBox.Show("Se actualizaron los datos correctamente","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta ingresar uno o varios datos domiciliarios","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Falta ingresar uno o varios datos principales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {
            confirmarActualizacion();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENTOS
        private void IU_ActualizarClienteMayorista_Load(object sender, EventArgs e)
        {
            tomarRazonSocial();
            controlador.buscarDatosClienteMayorista();
        }

        private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void cbx_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades();
        }

        private void txt_nroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_nroCuentaCorriente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_codigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }    
    }
}
