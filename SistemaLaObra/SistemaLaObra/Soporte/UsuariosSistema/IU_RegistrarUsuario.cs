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

namespace SistemaLaObra.Soporte
{
    public partial class IU_RegistrarUsuario : Form
    {
        public Encargado Encargado { get; set; }
        public TipoDeAcceso TipoDeAcceso { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public List<TipoDeAcceso> ListaTipoDeAccesos { get; set; }
        public TipoDeAcceso_X_Usuario TipoDeAcceso_X_Usuario { get; set; }
        Validaciones validaciones;

        public IU_RegistrarUsuario()
        {
            InitializeComponent();
            Encargado = new Encargado();
            TipoDeAcceso = new TipoDeAcceso();
            TipoTelefono = new TipoTelefono();
            TipoDocumento = new TipoDocumento();
            Provincia = new Provincia();
            Departamento = new Departamento();
            validaciones = new Validaciones();
            ListaTipoDeAccesos = new List<TipoDeAcceso>();
            TipoDeAcceso_X_Usuario = new TipoDeAcceso_X_Usuario();
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
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
            else if (ListaTipoDeAccesos.Count==0)
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
                registrar();           
                this.Close();
            }          
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

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
            Encargado.TipoDocumento.mostrarDatos(Encargado.CodigoTipoDocumento);
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
            Encargado.TipoTelefono.mostrarDatos(Encargado.CodigoTipoTelefono);
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
            Encargado.Localidad.mostrarDatos(Encargado.CodigoLocalidad);
        }  
        
        private void tomarEmpresa()
        {
            Encargado.CodigoMiEmpresa = int.Parse(cbx_empresa.SelectedValue.ToString());
            Encargado.MiEmpresa.mostrarDatos(Encargado.CodigoMiEmpresa);
        }

        private void tomarTipoAccesoPorUsuario()
        {
            foreach (var item in chlbx_tipoDeAcceso.CheckedItems)
            {
                TipoDeAcceso acceso = (TipoDeAcceso)item;
                ListaTipoDeAccesos.Add(new TipoDeAcceso()
                {
                    CodigoTipoAcceso = acceso.CodigoTipoAcceso,
                    Descripcion=acceso.Descripcion
                });
            }            
        }

        private void registrar()
        {
            Encargado.Usuario.crear(Encargado.Usuario);
            Encargado.Usuario.mostrarDatos(Encargado.Usuario.NombreUsuario);
            Encargado.crear(Encargado);
            foreach (var item in ListaTipoDeAccesos)
            {
                TipoDeAcceso_X_Usuario.crear(item, Encargado.Usuario);
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

        private void inicializarListaCombos()
        {
            cbx_provincia.SelectedValue = 5;
            cbx_departamento.SelectedValue = 213;
            cbx_localidad.SelectedValue = 1560;
        }

        //EVENTOS

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

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            cargarTiposAccesos();
            cargarTipoDocumento();
            cargarTipoTelefono();
            cargarProvincias();
            cargarEmpresas();
            inicializarListaCombos();
            txt_nombreUsuario.Focus();
        }
    }
}
