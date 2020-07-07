using SistemaLaObra.InicioSesion;
using SistemaLaObra.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte.UsuariosSistema
{
    public partial class IU_ActualizarUsuario : Form
    {
        public Encargado Encargado { get; set; }
        public TipoDeAcceso TipoDeAcceso { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public List<TipoDeAcceso> ListaTipoDeAccesos { get; set; }
        public TipoDeAcceso_X_Usuario TipoDeAcceso_X_Usuario { get; set; }
        public List<TipoDeAcceso_X_Usuario> ListaTipoDeAccesos_X_Usuarios { get; set; }
        public Usuario Usuario { get; set; }
        Validaciones validaciones;

        public IU_ActualizarUsuario()
        {
            InitializeComponent();
            Encargado = new Encargado();
            TipoDeAcceso = new TipoDeAcceso();
            Provincia = new Provincia();
            Departamento = new Departamento();
            TipoTelefono = new TipoTelefono();
            TipoDocumento = new TipoDocumento();
            ListaTipoDeAccesos = new List<TipoDeAcceso>();
            TipoDeAcceso_X_Usuario = new TipoDeAcceso_X_Usuario();
            ListaTipoDeAccesos_X_Usuarios = new List<TipoDeAcceso_X_Usuario>();
            Usuario = new Usuario();
            validaciones = new Validaciones();
        }

        //BOTONES

        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {

            IU_ValidacionUsuario interfaz = new IU_ValidacionUsuario(Usuario);
            interfaz.ShowDialog();
            if (Usuario.Contraseña.Equals(Encargado.Usuario.Contraseña))
            {
                tomarTipoAccesoPorUsuario();
                if (validaciones.campoVacio(txt_nombreUsuario.Text))
                {
                    MessageBox.Show("Debe ingresar nombre de usuario",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Encargado.Usuario.existe(txt_nombre.Text))
                {
                    MessageBox.Show("El usuario ya existe", "Advertencia!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_contraseña.Text))
                {
                    MessageBox.Show("Debe ingresar contraseña",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!txt_contraseña.Text.Equals(txt_confirmarContraseña.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ListaTipoDeAccesos.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un tipo de acceso",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_legajo.Text))
                {
                    MessageBox.Show("Debe ingresar legajo",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_nombre.Text))
                {
                    MessageBox.Show("Debe ingresar nombre",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_apellido.Text))
                {
                    MessageBox.Show("Debe ingresar apellido",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_nroDocumento.Text))
                {
                    MessageBox.Show("Debe ingresar número de documento",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_nroTelefono.Text))
                {
                    MessageBox.Show("Debe ingresar número de teléfono",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_calle.Text))
                {
                    MessageBox.Show("Debe ingresar calle",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_numero.Text))
                {
                    MessageBox.Show("Debe ingresar número de casa",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validaciones.campoVacio(txt_barrio.Text))
                {
                    MessageBox.Show("Debe ingresar barrio",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    tomarUsuario();
                    tomarContraseña();
                    tomarLegajo();
                    tomarNombreEncargado();
                    tomarApellidoEncargado();
                    tomarSeleccionTipoDocumento();
                    tomarNroDocumento();
                    tomarFechaNacimiento();
                    tomarSeleccionTipoTelefono();
                    tomarNroTelefono();
                    tomarCalle();
                    tomarNumero();
                    tomarDepto();
                    tomarPiso();
                    tomarBarrio();
                    tomarCodigoPostal();
                    tomarSeleccionLocalidad();
                    tomarEmpresa();
                    actualizar();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("La contraseña ingresada no coincide con la del usuario", "Advertencia!!!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //METODOS

        public void opcionActualizarUsuario(int id)
        {
            Encargado.Usuario.mostrarDatos(id);
            Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Encargado.Usuario.CodigoUsuario));
            Encargado.Localidad.mostrarDatos(Encargado.CodigoLocalidad);
            ListaTipoDeAccesos_X_Usuarios = TipoDeAcceso_X_Usuario.mostrarDatos(Encargado.Usuario);
            btn_actualizarDatos.Enabled = true;
        }

        private void mostrarDatosUsuario()
        {
            txt_nombreUsuario.Text = Encargado.Usuario.NombreUsuario;
            for (int i = 0; i < chlbx_tipoDeAcceso.Items.Count; i++)
            {
                var tipoAcceso = (TipoDeAcceso)chlbx_tipoDeAcceso.Items[i];
                if (ListaTipoDeAccesos_X_Usuarios.Where(x => x.CodigoTipoAcceso == tipoAcceso.CodigoTipoAcceso).ToList().Count > 0)
                {
                    chlbx_tipoDeAcceso.SetItemChecked(i, true);
                }
            }
            txt_legajo.Text = Encargado.Legajo.ToString();
            txt_nombre.Text = Encargado.Nombre;
            txt_apellido.Text = Encargado.Apellido;
            cbx_tipoDocumento.SelectedValue = Encargado.CodigoTipoDocumento;
            txt_nroDocumento.Text = Encargado.NroDocumento;
            txt_fechaNacimiento.Value = Encargado.FechaNacimiento;
            cbx_tipoTelefono.SelectedValue = Encargado.CodigoTipoTelefono;
            txt_nroTelefono.Text = Encargado.NroTelefono;
            txt_calle.Text = Encargado.Calle;
            txt_numero.Text = Encargado.Numero.ToString();
            txt_depto.Text = Encargado.Depto;
            txt_piso.Text = Encargado.Piso;
            txt_barrio.Text = Encargado.NombreBarrio;
            txt_codigoPostal.Text = Encargado.CodigoPostal.ToString();
            cbx_provincia.SelectedValue = Encargado.Localidad.Departamento.Provincia.CodigoProvincia;
            cbx_departamento.SelectedValue = Encargado.Localidad.Departamento.CodigoDepartamento;
            cbx_localidad.SelectedValue = Encargado.Localidad.CodigoLocalidad;
            cbx_empresa.SelectedValue = Encargado.CodigoMiEmpresa;
        }

        private void tomarUsuario()
        {
            Encargado.Usuario.NombreUsuario = txt_nombreUsuario.Text;
        }

        private void tomarContraseña()
        {
            Encargado.Usuario.Contraseña = txt_contraseña.Text;
        }

        private void tomarLegajo()
        {
            Encargado.Legajo = int.Parse(txt_legajo.Text);
        }

        private void tomarTipoAccesoPorUsuario()
        {
            foreach (var item in chlbx_tipoDeAcceso.CheckedItems)
            {
                ListaTipoDeAccesos.Clear();
                TipoDeAcceso acceso = (TipoDeAcceso)item;
                ListaTipoDeAccesos.Add(new TipoDeAcceso()
                {
                    CodigoTipoAcceso = acceso.CodigoTipoAcceso,
                    Descripcion = acceso.Descripcion
                });
            }
        }

        private void tomarNombreEncargado()
        {
            Encargado.Nombre = txt_nombre.Text;
        }

        private void tomarApellidoEncargado()
        {
            Encargado.Apellido = txt_apellido.Text;
        }

        private void tomarSeleccionTipoDocumento()
        {
            Encargado.CodigoTipoDocumento = int.Parse(cbx_tipoDocumento.SelectedValue.ToString());
        }

        private void tomarNroDocumento()
        {
            Encargado.NroDocumento = txt_nroDocumento.Text;
        }

        private void tomarFechaNacimiento()
        {
            Encargado.FechaNacimiento = txt_fechaNacimiento.Value;
        }

        private void tomarSeleccionTipoTelefono()
        {
            Encargado.CodigoTipoTelefono = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroTelefono()
        {
            Encargado.NroTelefono = txt_nroTelefono.Text;
        }

        private void tomarCalle()
        {
            Encargado.Calle = txt_calle.Text;
        }

        private void tomarNumero()
        {
            Encargado.Numero = txt_numero.Text;
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
            Encargado.CodigoPostal = txt_codigoPostal.Text;
        }

        private void tomarSeleccionLocalidad()
        {
            Encargado.CodigoLocalidad = int.Parse(cbx_localidad.SelectedValue.ToString());
        }

        public void tomarEmpresa()
        {
            Encargado.CodigoMiEmpresa = int.Parse(cbx_empresa.SelectedValue.ToString());
            Encargado.MiEmpresa.mostrarDatos(Encargado.CodigoMiEmpresa);
        }

        private void actualizar()
        {
            Encargado.Usuario.actualizar(Encargado.Usuario);
            Encargado.actualizar(Encargado);
            for (int i = 0; i < chlbx_tipoDeAcceso.Items.Count; i++)
            {
                var tipoAcceso = (TipoDeAcceso)chlbx_tipoDeAcceso.Items[i];
                bool chequeado = chlbx_tipoDeAcceso.GetItemChecked(i);
                if (chequeado)
                {
                    if (ListaTipoDeAccesos_X_Usuarios.Where(x => x.CodigoTipoAcceso == tipoAcceso.CodigoTipoAcceso).ToList().Count == 0)
                    {
                        TipoDeAcceso_X_Usuario.crear(tipoAcceso, Encargado.Usuario);
                    }
                }
                else
                {
                    if (ListaTipoDeAccesos_X_Usuarios.Where(x => x.CodigoTipoAcceso == tipoAcceso.CodigoTipoAcceso).ToList().Count > 0)
                    {
                        TipoDeAcceso_X_Usuario.borrar(tipoAcceso, Encargado.Usuario);
                    }
                }
            }
        }

        private void cargarEmpresas()
        {
            cbx_empresa.DisplayMember = "NombreFantasia";
            cbx_empresa.ValueMember = "CodigoMiEmpresa";
            cbx_empresa.DataSource = Encargado.MiEmpresa.mostrarDatos();
        }

        private void cargarTiposAccesos()
        {
            chlbx_tipoDeAcceso.DataSource = TipoDeAcceso.mostrarDatos();
            chlbx_tipoDeAcceso.ValueMember = "CodigoTipoAcceso";
            chlbx_tipoDeAcceso.DisplayMember = "Descripcion";
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

        private void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = TipoTelefono.mostrarDatos();
        }

        private void cargarTipoDocumento()
        {
            cbx_tipoDocumento.ValueMember = "CodigoTipoDocumento";
            cbx_tipoDocumento.DisplayMember = "Descripcion";
            cbx_tipoDocumento.DataSource = TipoDocumento.mostrarDatosColeccion();
        }

        //EVENTOS

        private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void cbx_departamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarLocalidades();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            cargarTiposAccesos();
            cargarTipoDocumento();
            cargarTipoTelefono();
            cargarProvincias();
            cargarEmpresas();
            mostrarDatosUsuario();
            txt_nombreUsuario.Focus();
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
