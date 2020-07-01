﻿using SistemaLaObra.InicioSesion;
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
        public Usuario Usuario { get; set; }
        public Encargado Encargado { get; set; }
        public TipoEncargado TipoEncargado { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        Validaciones validaciones;
        int codigoTipoEncargado;

        public IU_RegistrarUsuario()
        {
            InitializeComponent();
            Usuario = new Usuario();
            Encargado = new Encargado();
            TipoEncargado = new TipoEncargado();
            TipoTelefono = new TipoTelefono();
            TipoDocumento = new TipoDocumento();
            Provincia = new Provincia();
            Departamento = new Departamento();
            validaciones = new Validaciones();
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (tomarUsuario())
            {
                if (tomarContraseña())
                {
                    //USUARIO//
                    Usuario.CodigoUsuario = Usuario.obtenerUltimoCodigoUsuario() + 1;
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

                            Usuario.crear(Usuario);
                            Usuario.crearEnListaTipoEncargado(Usuario.obtenerCodigoUsuario(Usuario.NombreUsuario), codigoTipoEncargado);

                            Usuario.CodigoUsuario = Usuario.CodigoUsuario;
                            Encargado.CodigoEncargado = Encargado.obtenerUltimoCodigoEncargado() + 1;
                            Encargado.crear(Encargado);
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

        //METODOS

        private bool tomarUsuario()
        {
            if (txt_nombreUsuario.Text != "")
            {
                if (!Usuario.confirmarUsuario(txt_nombreUsuario.Text))
                {
                    Usuario.NombreUsuario = txt_nombreUsuario.Text;
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
                    Usuario.Contraseña = txt_contraseña.Text;
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
            cbx_tipoEncargado.DataSource = TipoEncargado.mostrarDatosColeccion();
        }

        private void tomarSeleccionTipoEncargado()
        {
            codigoTipoEncargado = (int.Parse(cbx_tipoEncargado.SelectedValue.ToString()));
        }

        private void tomarLegajo()
        {
            if (txt_legajo.Text != string.Empty)
            {
                Encargado.Legajo = int.Parse(txt_legajo.Text);
            }
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

        private void cargarTipoDocumento()
        {
            cbx_tipoDocumento.ValueMember = "CodigoTipoDocumento";
            cbx_tipoDocumento.DisplayMember = "Descripcion";
            cbx_tipoDocumento.DataSource = TipoDocumento.mostrarDatosColeccion();
        }

        private void tomarSeleccionTipoDocumento()
        {
            Encargado.CodigoTipoDocumento = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
        }

        private void tomarNroDocumento()
        {
            if(txt_nroDocumento.Text != string.Empty)
            {
                Encargado.NroDocumento = txt_nroDocumento.Text;
            }
        }

        private void tomarFechaNacimiento()
        {
            Encargado.FechaNacimiento = Convert.ToDateTime(txt_fechaNacimiento.Value.ToString("dd/MM/yyyy"));
        }

        private void cargarTipoTelefono()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = TipoTelefono.mostrarDatos();
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
            cbx_provincia.DataSource = Provincia.mostrarDatos();
        }

        private void tomarSeleccionProvincia()
        {
            //Encargado.CodigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
        }

        private void cargarDepartamentos()
        {
            int codigoProvincia = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = Provincia.conocerDepartamento(codigoProvincia);
        }

        private void tomarSeleccionDepartamento()
        {
            //Encargado.CodigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
        }

        private void cargarLocalidades()
        {
            int codigoDepartamento = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = Departamento.conocerLocalidad(codigoDepartamento);
        }

        private void tomarSeleccionLocalidad()
        {
            Encargado.CodigoLocalidad = int.Parse(cbx_localidad.SelectedValue.ToString());
        }    
        
        private void cargarEmpresas()
        {
            cbx_empresa.DisplayMember = "NombreFantasia";
            cbx_empresa.ValueMember = "CodigoMiEmpresa";
            cbx_empresa.DataSource = Encargado.MiEmpresa.mostrarDatos();
        }

        //EVENTOS

        private void IU_RegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarTiposEncargados();
            cargarTipoDocumento();
            cargarTipoTelefono();
            cargarProvincias();
            cargarEmpresas();
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