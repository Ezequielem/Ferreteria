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
    public partial class IU_RegistrarUsuario : Form
    {
        Usuario usuario;
        Encargado encargado;
        TipoEncargado tipoEncargado;
        Provincia provincia;
        Departamento departamento;
        TipoTelefono tipoTelefono;
        TipoDocumento tipoDocumento;
        Validaciones validaciones;

        int codigoTipoEncargado;

        public IU_RegistrarUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            encargado = new Encargado();
            tipoEncargado = new TipoEncargado();
            tipoTelefono = new TipoTelefono();
            tipoDocumento = new TipoDocumento();
            provincia = new Provincia();
            departamento = new Departamento();
            validaciones = new Validaciones();
        }

        private bool tomarUsuario()
        {
            if (txt_nombreUsuario.Text != "")
            {
                if (!usuario.confirmarUsuario(txt_nombreUsuario.Text))
                {
                    usuario.NombreUsuario = txt_nombreUsuario.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("El usuario ya existe","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No ingreso nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool tomarContraseña()
        {
            if (txt_contraseña.Text != "")
            {
                if (txt_contraseña.Text.Equals(txt_confirmarContraseña.Text))
                {
                    usuario.Contraseña = txt_contraseña.Text;
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

        private void cargarTiposEncargados()
        {
            cbx_tipoEncargado.ValueMember = "CodigoTipoEncargado";
            cbx_tipoEncargado.DisplayMember = "Descripcion";
            cbx_tipoEncargado.DataSource = tipoEncargado.mostrarDatosColeccion();
        }

        private void tomarSeleccionTipoEncargado()
        {
            codigoTipoEncargado = (int.Parse(cbx_tipoEncargado.SelectedValue.ToString()));
        }

        private void tomarLegajo()
        {
            if (txt_legajo.Text != string.Empty)
            {
                encargado.Legajo = int.Parse(txt_legajo.Text);
            }
        }

        private void tomarNombreEncargado()
        {
            if (txt_nombre.Text != string.Empty)
            {
                encargado.Nombre = txt_nombre.Text;
            }
        }

        private void tomarApellidoEncargado()
        {
            if (txt_apellido.Text != string.Empty)
            {
                encargado.Apellido = txt_apellido.Text;
            }
        }

        private void cargarTipoDocumento()
        {
            cbx_tipoDocumento.ValueMember = "CodigoTipoDocumento";
            cbx_tipoDocumento.DisplayMember = "Descripcion";
            cbx_tipoDocumento.DataSource = tipoDocumento.mostrarDatosColeccion();
        }

        private void tomarSeleccionTipoDocumento()
        {
            encargado.CodigoTipoDocumento = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroDocumento()
        {
            if(txt_nroDocumento.Text != string.Empty)
            {
                encargado.NroDocumento = txt_nroDocumento.Text;
            }
        }

        private void tomarFechaNacimiento()
        {
            encargado.FechaNacimiento = Convert.ToDateTime(txt_fechaNacimiento.Value.ToString("dd/MM/yyyy"));
        }

        private void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = tipoTelefono.mostrarDatosColeccion();
        }

        private void tomarSeleccionTipoTelefono()
        {
            encargado.CodigoTipoTelefono = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroTelefono()
        {
            if (txt_nroTelefono.Text != string.Empty)
            {
                encargado.NroTelefono = txt_nroTelefono.Text;
            }
        }

        private void tomarCalle()
        {
            encargado.Calle = txt_calle.Text;
        }

        private void tomarNumero()
        {
            if (int.Parse(txt_numero.Text) != 0)
            {
                encargado.Numero = int.Parse(txt_numero.Text);
            }
        }

        private void tomarDepto()
        {
            encargado.Depto = txt_depto.Text;
        }

        private void tomarPiso()
        {
            encargado.Piso = txt_piso.Text;
        }

        private void tomarBarrio()
        {
            encargado.NombreBarrio = txt_barrio.Text;
        }

        private void tomarCodigoPostal()
        {
            if (int.Parse(txt_codigoPostal.Text) != 0)
            {
                encargado.CodigoPostal = int.Parse(txt_codigoPostal.Text);
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
            cbx_provincia.DataSource = provincia.mostrarDatosColeccion();
        }

        private void tomarSeleccionProvincia()
        {
           encargado.CodigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
        }

        private void cargarDepartamentos()
        {
            int codigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = provincia.conocerDepartamento(codigoProvincia);
        }

        private void tomarSeleccionDepartamento()
        {
            encargado.CodigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
        }

        private void cargarLocalidades()
        {
            int codigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = departamento.conocerLocalidad(codigoDepartamento);
        }

        private void tomarSeleccionLocalidad()
        {
            encargado.CodigoLocalidad = int.Parse(cbx_localidad.SelectedValue.ToString());
        }

        ////////////////BOTONES/////////////////

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (tomarUsuario())
            {
                if (tomarContraseña())
                {
                    //USUARIO//
                    usuario.CodigoUsuario = usuario.obtenerUltimoCodigoUsuario() + 1;                  
                    tomarSeleccionTipoEncargado();

                    if (txt_legajo.Text != "" && txt_nombre.Text != "" && txt_apellido.Text != "" && txt_nroDocumento.Text != "" && txt_nroTelefono.Text != "")
                    {
                        //ENCARGADO - DATOS PERSONALES//
                        tomarLegajo();
                        tomarNombreEncargado();
                        tomarApellidoEncargado();
                        tomarSeleccionTipoDocumento();
                        tomarNroDocumento();
                        tomarFechaNacimiento();
                        tomarSeleccionTipoTelefono();
                        tomarNroTelefono();

                        if (txt_calle.Text != "" && txt_numero.Text != "" && txt_barrio.Text != "")
                        {
                            //ENCARGADO - DATOS DOMICILIARIOS//
                            tomarCalle();
                            tomarNumero();
                            tomarDepto();
                            tomarPiso();
                            tomarBarrio();
                            tomarCodigoPostal();
                            tomarSeleccionProvincia();
                            tomarSeleccionDepartamento();
                            tomarSeleccionLocalidad();

                            usuario.crear(usuario);
                            usuario.crearEnListaTipoEncargado(usuario.obtenerCodigoUsuario(usuario.NombreUsuario), codigoTipoEncargado);

                            encargado.CodigoUsuario = usuario.CodigoUsuario;
                            encargado.CodigoEncargado = encargado.obtenerUltimoCodigoEncargado() + 1;
                            encargado.crear(encargado);

                            MessageBox.Show("El usuario se a registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////EVENTOS/////////////////

        private void IU_RegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarTiposEncargados();
            cargarTipoDocumento();
            cargarTipoTelefono();
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
    }
}
