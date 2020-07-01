using SistemaLaObra.InicioSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte
{
    public partial class IU_ActualizarUsuario : Form
    {

        public Usuario Usuario { get; set; }
        public Encargado Encargado { get; set; }
        public TipoEncargado TipoEncargado { get; set; }
        public ListaTipoEncargado ListaTipoEncargado { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
        public Localidad Localidad { get; set; }
        Validaciones validaciones;
        int codigoTipoEncargado;

        public IU_ActualizarUsuario()
        {
            InitializeComponent();
            Usuario = new Usuario();
            Encargado = new Encargado();
            TipoEncargado = new TipoEncargado();
            ListaTipoEncargado = new ListaTipoEncargado();
            TipoTelefono = new TipoTelefono();
            TipoDocumento = new TipoDocumento();
            Provincia = new Provincia();
            Departamento = new Departamento();
            Localidad = new Localidad();
            validaciones = new Validaciones();
        }

        public void opcionActualizarUsuario(int id)
        {
            Usuario.mostrarDatos(id);
            Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Usuario.CodigoUsuario));
            btn_actualizarDatos.Enabled = true;
        }

        private void mostrarDatosUsuario()
        {
            //DATOS USUARIO//
            txt_nombreUsuario.Text = Usuario.NombreUsuario;
            cbx_tipoEncargado.Enabled = true;
            cargarTiposEncargados();
            TipoEncargado.mostrarDatos(ListaTipoEncargado.obtenerCodigoTipoEncargado(Usuario.CodigoUsuario));
            cbx_tipoEncargado.Text = TipoEncargado.Descripcion;

            //DATOS ENCARGADO//
            gb_datosPersonales.Enabled = true;
            txt_legajo.Text = Encargado.Legajo.ToString();
            txt_nombre.Text = Encargado.Nombre;
            txt_apellido.Text = Encargado.Apellido;
            cargarTipoDocumento();
            TipoDocumento.mostrarDatos(Encargado.CodigoTipoDocumento);
            cbx_tipoDocumento.Text = TipoDocumento.Descripcion;
            txt_nroDocumento.Text = Encargado.NroDocumento;
            txt_fechaNacimiento.Value = Convert.ToDateTime(Encargado.FechaNacimiento);
            cargarTipoTelefono();
            TipoTelefono.mostrarDatos(Encargado.CodigoTipoTelefono);
            cbx_tipoTelefono.Text = TipoTelefono.Descripcion;
            txt_nroTelefono.Text = Encargado.NroTelefono;

            //DATOS DOMICILIARIOS
            gb_domicilio.Enabled = true;
            txt_calle.Text = Encargado.Calle;
            txt_numero.Text = Encargado.Numero.ToString();
            txt_depto.Text = Encargado.Depto;
            txt_piso.Text = Encargado.Piso;
            txt_barrio.Text = Encargado.NombreBarrio;
            txt_codigoPostal.Text = Encargado.CodigoPostal.ToString();
            cargarProvincias();
            //Provincia.mostrarDatos(Encargado.CodigoProvincia);
            cbx_provincia.Text = Provincia.NombreProvincia;
            cargarDepartamentos();
            //cbx_departamento.Text = Departamento.mostrarNombre(Encargado.CodigoDepartamento);
            cargarLocalidades();
            cbx_localidad.Text = Localidad.mostrarNombre(Encargado.CodigoLocalidad);
        }

        private void cargarTiposEncargados()
        {
            cbx_tipoEncargado.ValueMember = "CodigoTipoEncargado";
            cbx_tipoEncargado.DisplayMember = "Descripcion";
            cbx_tipoEncargado.DataSource = TipoEncargado.mostrarDatosColeccion();
        }

        private void cargarTipoDocumento()
        {
            cbx_tipoDocumento.ValueMember = "CodigoTipoDocumento";
            cbx_tipoDocumento.DisplayMember = "Descripcion";
            cbx_tipoDocumento.DataSource = TipoDocumento.mostrarDatosColeccion();
        }

        private void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = TipoTelefono.mostrarDatos();
        }

        private void cargarProvincias()
        {
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = Provincia.mostrarDatos();
        }

        private void cargarDepartamentos()
        {
            int codigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = Provincia.conocerDepartamento(codigoProvincia);
        }

        private void cargarLocalidades()
        {
            int codigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = Departamento.conocerLocalidad(codigoDepartamento);
        }

        private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void cbx_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades();
        }

        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {
            if (tomarContraseña())
            {
                tomarSeleccionTipoEncargado();
                if (txt_legajo.Text != "" && txt_nombre.Text != "" && txt_apellido.Text != "" && txt_nroDocumento.Text != "" && txt_nroTelefono.Text != "")
                {
                    tomarNombreEncargado();
                    tomarApellidoEncargado();
                    tomarSeleccionTipoDocumento();
                    tomarNroDocumento();
                    tomarFechaNacimiento();
                    tomarSeleccionTipoTelefono();
                    tomarNroTelefono();

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

                        Usuario.actualizarContraseña(Usuario.CodigoUsuario, Usuario.Contraseña);
                        ListaTipoEncargado.actualizarTipoEncargado(codigoTipoEncargado, Usuario.CodigoUsuario);
                        Encargado.actualizar(Encargado);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falta ingresar uno o varios datos domiciliarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Falta ingresar uno o varios datos personales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool tomarContraseña()
        {
            if (txt_nuevaContraseña.Text != "")
            {
                if (txt_nuevaContraseña.Text.Equals(txt_nuevaContraseña.Text))
                {
                    Usuario.Contraseña = txt_nuevaContraseña.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No ingreso contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void tomarSeleccionTipoEncargado()
        {
            codigoTipoEncargado = (int.Parse(cbx_tipoEncargado.SelectedValue.ToString()));
        }

        private void tomarNombreEncargado()
        {
            if (txt_nombre.Text != string.Empty)
            {
                Encargado.Nombre = txt_nombre.Text;
            }
        }

        private void tomarApellidoEncargado()
        {
            if (txt_apellido.Text != string.Empty)
            {
                Encargado.Apellido = txt_apellido.Text;
            }
        }

        private void tomarSeleccionTipoDocumento()
        {
            Encargado.CodigoTipoDocumento = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroDocumento()
        {
            if (txt_nroDocumento.Text != string.Empty)
            {
                Encargado.NroDocumento = txt_nroDocumento.Text;
            }
        }

        private void tomarFechaNacimiento()
        {
            Encargado.FechaNacimiento = Convert.ToDateTime(txt_fechaNacimiento.Value.ToString("dd/MM/yyyy"));
        }

        private void tomarSeleccionTipoTelefono()
        {
            Encargado.CodigoTipoTelefono = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroTelefono()
        {
            if (txt_nroTelefono.Text != string.Empty)
            {
                Encargado.NroTelefono = txt_nroTelefono.Text;
            }
        }

        private void tomarCalle()
        {
            Encargado.Calle = txt_calle.Text;
        }

        private void tomarNumero()
        {
            if (int.Parse(txt_numero.Text) != 0)
            {
                //Encargado.Numero = int.Parse(txt_numero.Text);
            }
        }

        private void tomarDepto()
        {
            Encargado.Depto = txt_depto.Text;
        }

        private void tomarPiso()
        {
            Encargado.Piso = txt_piso.Text;
        }

        private void tomarBarrio()
        {
            Encargado.NombreBarrio = txt_barrio.Text;
        }

        private void tomarCodigoPostal()
        {
            if (int.Parse(txt_codigoPostal.Text) != 0)
            {
                //Encargado.CodigoPostal = int.Parse(txt_codigoPostal.Text);
            }
        }

        private void tomarSeleccionProvincia()
        {
            //Encargado.CodigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
        }

        private void tomarSeleccionDepartamento()
        {
            //Encargado.CodigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
        }

        private void tomarSeleccionLocalidad()
        {
            Encargado.CodigoLocalidad = int.Parse(cbx_localidad.SelectedValue.ToString());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_nroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_nroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_codigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void IU_ActualizarUsuario_Load(object sender, EventArgs e)
        {
            mostrarDatosUsuario();
        }
    }
}
