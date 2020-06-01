using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.RegistrarClienteMayorista
{
    public partial class IU_RegistrarClienteMayorista : Form
    {
        //INSTANCIAS
        Validaciones validacion;
        Controlador_registrarClienteMayorista controlador;

        public IU_RegistrarClienteMayorista()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controlador = new Controlador_registrarClienteMayorista();
        }

        //METODOS
        private void tomarRazonSocial()
        {
            controlador.razonSocialNvoCliente(txt_razonSocial.Text);
        }

        private void tomarCuit()
        {
            controlador.cuitNvoCliente(txt_cuit.Text);
        }

        private void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = controlador.mostrarSeleccionTipoTelefono();
        }

        private void tomarSeleccionTipoTelefono()
        {
            controlador.tipoTelefonoNvoCliente(int.Parse(cbx_tipoTelefono.SelectedValue.ToString()));
        }

        private void tomarNroTelefono()
        {
            controlador.nroTelefonoNvoCliente(txt_nroTelefono.Text);
        }

        private void cargarBancos()
        {
            cbx_banco.ValueMember = "CodigoBanco";
            cbx_banco.DisplayMember = "Descripcion";
            cbx_banco.DataSource = controlador.mostrarSeleccionBanco();
        }

        private void tomarSeleccionBanco()
        {
            controlador.nombreBancoNvoCliente(int.Parse(cbx_banco.SelectedValue.ToString()));
        }

        private void tomarNroCuentaCorriente()
        {
            controlador.nroCtaCteNvoCliente(txt_nroCuentaCorriente.Text);
        }

        private void tomarCalle()
        {
            controlador.calleNvoCliente(txt_calle.Text);
        }

        private void tomarNumero()
        {
            controlador.numeroNvoCliente(int.Parse(txt_numero.Text));
        }

        private void tomarDepto()
        {
            controlador.deptoNvoCliente(txt_depto.Text);
        }

        private void tomarPiso()
        {
            controlador.pisoNvoCliente(txt_piso.Text);
        }

        private void tomarBarrio()
        {
            controlador.barrioNvoCliente(txt_barrio.Text);
        }

        private void tomarCodigoPostal()
        {
            if (txt_codigoPostal.Text != "")
            {
                controlador.codigoPostalNvoCliente(int.Parse(txt_codigoPostal.Text));
            }
            else
            {
                controlador.codigoPostalNvoCliente(0);
            }
        }

        private void inicializarListaCombos()
        {
            cbx_provincia.SelectedValue = 5;
            cbx_departamento.SelectedValue = 213;
            cbx_localidad.SelectedValue = 1560;
        }

        private void cargarProvincias()
        {
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = controlador.mostrarSeleccionProvincia();
        }

        private void tomarSeleccionProvincia()
        {
            controlador.provinciaNvoCliente(int.Parse(cbx_provincia.SelectedValue.ToString()));
        }

        private void cargarDepartamentos()
        {
            int codigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = controlador.mostrarSeleccionDepartamento(codigoProvincia);
        }

        private void tomarSeleccionDepartamento()
        {
            controlador.departamentoNvoCliente(int.Parse(cbx_departamento.SelectedValue.ToString()));
        }

        private void cargarLocalidades()
        {
            int codigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = controlador.mostrarSeleccionLocalidad(codigoDepartamento);
        }

        private void tomarSeleccionLocalidad()
        {
            controlador.localidadNvoCliente(int.Parse(cbx_localidad.SelectedValue.ToString()));
        }

        private void confirmarRegistro()
        {
            if (txt_razonSocial.Text != "" && txt_cuit.Text != "" && txt_nroTelefono.Text != "" && txt_nroCuentaCorriente.Text != "")
            {
                tomarRazonSocial();
                tomarCuit();
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
                    controlador.registrarNvoCliente();
                    MessageBox.Show("Se registro el cliente exitosamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiarCampos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falta ingresar uno o varios datos domiciliarios","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Falta ingresar uno o varios datos principales","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        private void limpiarCampos()
        {
            txt_razonSocial.Text = "";
            txt_cuit.Text = "";
            cbx_tipoTelefono.SelectedIndex = 0;
            txt_nroTelefono.Text = "";
            cbx_banco.SelectedIndex = 0;
            txt_nroCuentaCorriente.Text = "";
            txt_calle.Text = "";
            txt_numero.Text = "";
            txt_depto.Text = "";
            txt_piso.Text = "";
            txt_barrio.Text = "";
            txt_codigoPostal.Text = "";
            cbx_provincia.SelectedIndex = 4;
            cbx_departamento.SelectedIndex = 0;
            cbx_localidad.SelectedIndex = 0;
        }

        //BOTONES
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            confirmarRegistro();
        }

        //EVENTOS
        private void IU_RegistrarClienteMayorista_Load(object sender, EventArgs e)
        {
            cargarTipoTelefono();
            cargarBancos();
            cargarProvincias();
            inicializarListaCombos();
        }

        private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void cbx_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades();
        }

        private void txt_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
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

        private void txt_razonSocial_Leave(object sender, EventArgs e)
        {
            if (controlador.verificarExistencia(txt_razonSocial.Text))
            {
                MessageBox.Show("El cliente existe, por favor actualice sus datos","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_razonSocial.Text = "";
            }
        }
    }
}
