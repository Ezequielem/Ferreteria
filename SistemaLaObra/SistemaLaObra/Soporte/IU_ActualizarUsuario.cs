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

        Usuario usuario;
        Encargado encargado;
        TipoEncargado tipoEncargado;
        ListaTipoEncargado listaTipoEncargados;
        TipoTelefono tipoTelefono;
        TipoDocumento tipoDocumento;
        Provincia provincia;
        Departamento departamento;
        Localidad localidad;
        Validaciones validaciones;
        int codigoTipoEncargado;

        public IU_ActualizarUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            encargado = new Encargado();
            tipoEncargado = new TipoEncargado();
            listaTipoEncargados = new ListaTipoEncargado();
            tipoTelefono = new TipoTelefono();
            tipoDocumento = new TipoDocumento();
            provincia = new Provincia();
            departamento = new Departamento();
            localidad = new Localidad();
            validaciones = new Validaciones();
        }

        private void btn_buscarUsuario_Click(object sender, EventArgs e)
        {
            if (txt_nombreUsuario.Text !="")
            {
                int codigoUsuario = usuario.obtenerCodigoUsuario(txt_nombreUsuario.Text);
                if (codigoUsuario != 0)
                {
                    usuario.mostrarDatos(codigoUsuario);
                    encargado.mostrarDatos(encargado.obtenerCodigoEncargado(codigoUsuario));
                    mostrarDatosUsuario();
                    btn_actualizarDatos.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No ingreso ningun nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mostrarDatosUsuario()
        {
            //DATOS USUARIO//
            cbx_tipoEncargado.Enabled = true;
            cargarTiposEncargados();
            tipoEncargado.mostrarDatos(listaTipoEncargados.obtenerCodigoTipoEncargado(usuario.CodigoUsuario));
            cbx_tipoEncargado.Text = tipoEncargado.Descripcion;

            //DATOS ENCARGADO//
            gb_datosPersonales.Enabled = true;
            txt_legajo.Text = encargado.Legajo.ToString();
            txt_nombre.Text = encargado.Nombre;
            txt_apellido.Text = encargado.Apellido;
            cargarTipoDocumento();
            tipoDocumento.mostrarDatos(encargado.CodigoTipoDocumento);
            cbx_tipoDocumento.Text = tipoDocumento.Descripcion;
            txt_nroDocumento.Text = encargado.NroDocumento;
            txt_fechaNacimiento.Value = Convert.ToDateTime(encargado.FechaNacimiento);
            cargarTipoTelefono();
            tipoTelefono.mostrarDatos(encargado.CodigoTipoTelefono);
            cbx_tipoTelefono.Text = tipoTelefono.Descripcion;
            txt_nroTelefono.Text = encargado.NroTelefono;

            //DATOS DOMICILIARIOS
            gb_domicilio.Enabled = true;
            txt_calle.Text = encargado.Calle;
            txt_numero.Text = encargado.Numero.ToString();
            txt_depto.Text = encargado.Depto;
            txt_piso.Text = encargado.Piso;
            txt_barrio.Text = encargado.NombreBarrio;
            txt_codigoPostal.Text = encargado.CodigoPostal.ToString();
            cargarProvincias();
            provincia.mostrarDatos(encargado.CodigoProvincia);
            cbx_provincia.Text = provincia.NombreProvincia;
            cargarDepartamentos();
            cbx_departamento.Text = departamento.mostrarNombre(encargado.CodigoDepartamento);
            cargarLocalidades();
            cbx_localidad.Text = localidad.mostrarNombre(encargado.CodigoLocalidad);
        }

        private void cargarTiposEncargados()
        {
            cbx_tipoEncargado.ValueMember = "CodigoTipoEncargado";
            cbx_tipoEncargado.DisplayMember = "Descripcion";
            cbx_tipoEncargado.DataSource = tipoEncargado.mostrarDatosColeccion();
        }

        private void cargarTipoDocumento()
        {
            cbx_tipoDocumento.ValueMember = "CodigoTipoDocumento";
            cbx_tipoDocumento.DisplayMember = "Descripcion";
            cbx_tipoDocumento.DataSource = tipoDocumento.mostrarDatosColeccion();
        }

        private void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = tipoTelefono.mostrarDatosColeccion();
        }

        private void cargarProvincias()
        {
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = provincia.mostrarDatosColeccion();
        }

        private void cargarDepartamentos()
        {
            int codigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = provincia.conocerDepartamento(codigoProvincia);
        }

        private void cargarLocalidades()
        {
            int codigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = departamento.conocerLocalidad(codigoDepartamento);
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

                        usuario.actualizarContraseña(usuario.CodigoUsuario, usuario.Contraseña);
                        listaTipoEncargados.actualizarTipoEncargado(codigoTipoEncargado, usuario.CodigoUsuario);
                        encargado.actualizar(encargado);

                        MessageBox.Show("Los datos se actualizaron exitosamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                if (txt_nuevaContraseña.Text.Equals(txt_confirmarContraseña.Text))
                {
                    usuario.Contraseña = txt_nuevaContraseña.Text;
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

        private void tomarSeleccionTipoDocumento()
        {
            encargado.CodigoTipoDocumento = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroDocumento()
        {
            if (txt_nroDocumento.Text != string.Empty)
            {
                encargado.NroDocumento = txt_nroDocumento.Text;
            }
        }

        private void tomarFechaNacimiento()
        {
            encargado.FechaNacimiento = Convert.ToDateTime(txt_fechaNacimiento.Value.ToString("dd/MM/yyyy"));
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

        private void tomarSeleccionProvincia()
        {
            encargado.CodigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
        }

        private void tomarSeleccionDepartamento()
        {
            encargado.CodigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
        }

        private void tomarSeleccionLocalidad()
        {
            encargado.CodigoLocalidad = int.Parse(cbx_localidad.SelectedValue.ToString());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void gb_datosUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nuevaContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txt_confirmarContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_tipoEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gb_datosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_legajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbx_tipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbx_tipoTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_nroTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txt_calle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_piso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txt_depto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_barrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigoPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbx_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
