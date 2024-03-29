﻿using System;
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

        //BOTONES

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (validaciones.campoVacio(txt_RazonSocial.Text))
            {
                MessageBox.Show("El campo Razon Social no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_RazonSocial.Focus();
            }
            else if (validaciones.campoVacio(txt_nombreFantasia.Text))
            {
                MessageBox.Show("El campo Nombre de fantasía no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nombreFantasia.Focus();
            }
            else if (validaciones.campoVacio(txt_Cuit.Text))
            {
                MessageBox.Show("El campo CUIT no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Cuit.Focus();
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
            else if (controladorProveedor.verificarExistencia(long.Parse(txt_Cuit.Text)))
            {
                MessageBox.Show("El numero de cuit ingresado ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Cuit.Focus();
            }
            else
            {
                opcionConfirmar();
                controladorProveedor.crear();
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void tomarNumeroCuit()
        {
            controladorProveedor.numeroCuitIngresado(txt_Cuit.Text);
        }

        public void tomarRazonSocial()
        {
            controladorProveedor.razonSocialIngresada(txt_RazonSocial.Text);
        }

        public void tomarBanco()
        {
            controladorProveedor.nombreBancoSeleccionado(int.Parse(cb_Banco.SelectedValue.ToString()));
        }

        public void tomarCuentaCorriente()
        {
            controladorProveedor.cuentaCorrienteIngresada(txt_CuentaCorriente.Text);
        }

        public void tomarTipoTelefono1()
        {
            controladorProveedor.tipoTelefono1Ingresado(int.Parse(cb_TipoTelefonoUno.SelectedValue.ToString()));
        }

        public void tomarNumeroTelefono1()
        {
            controladorProveedor.numeroTelefono1Ingresado(txt_NumeroTelefono.Text);
        }

        public void tomarTipoTelefono2()
        {
            controladorProveedor.tipoTelefono2Ingresado(int.Parse(cb_TipoTelefonoDos.SelectedValue.ToString()));
        }

        public void tomarNumeroTelefono2()
        {
            controladorProveedor.numeroTelefono2Ingresado(txt_NumeroTelefono2.Text);
        }

        public void tomarLocalidad()
        {
            controladorProveedor.localidadSeleccionada(int.Parse(cb_Localidad.SelectedValue.ToString()));
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
            controladorProveedor.numeroDomicilioIngresado(txt_NumeroCalle.Text);
        }

        public void tomarCodigoPostal()
        {
            controladorProveedor.codigoPostalIngresado(txt_CPostal.Text);
        }

        public void tomarNombreFantasia()
        {
            controladorProveedor.nombreFantasiaTomado(txt_nombreFantasia.Text);
        }

        public void tomarNombreContacto1()
        {
            controladorProveedor.nombreContacto1Tomado(txt_nombreContacto1.Text);
        }

        public void tomarCargoContacto1()
        {
            controladorProveedor.nombreCargoContacto1Tomado(txt_cargoContacto1.Text);
        }

        public void tomarNombreContacto2()
        {
            controladorProveedor.nombreContacto2Tomado(txt_nombreContacto2.Text);
        }

        public void tomarCargoContacto2()
        {
            controladorProveedor.nombreCargoContacto2Tomado(txt_cargoContacto2.Text);
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

        public void cargarDatosDepartamento(int codigoProv)
        {            
            cb_departamento.ValueMember = "CodigoDepartamento";
            cb_departamento.DisplayMember = "NombreDepartamento";
            cb_departamento.DataSource = controladorProveedor.mostrarDatosDepartamento(codigoProv);
        }

        public void cargarDatosLocalidades(int codigoDepto)
        {             
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

        private void opcionConfirmar()
        {
            tomarNumeroCuit();
            tomarRazonSocial();
            tomarNombreFantasia();
            tomarBanco();
            tomarCuentaCorriente();
            tomarNombreContacto1();
            tomarCargoContacto1();
            tomarNombreContacto2();
            tomarCargoContacto2();
            tomarTipoTelefono1();
            tomarNumeroTelefono1();
            tomarTipoTelefono2();
            tomarNumeroTelefono2();
            tomarCalle();
            tomarNumeroDomicilio();
            tomarLocalidad();
            tomarCodigoPostal();
            tomarBarrio();           
        }

        //EVENTOS

        private void IU_RegistrarProveedor_Load(object sender, EventArgs e)
        {
            txt_Cuit.Focus();
            cargarDatosBanco();
            cargarDatosTiposTelefonos();
            cargarDatosProvincias();
            inicializarListaCombos();
        }

        private void cb_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDepartamento(int.Parse(cb_Provincia.SelectedValue.ToString()));
        }

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosLocalidades(int.Parse(cb_departamento.SelectedValue.ToString()));
        }

        private void txt_Cuit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }
    }
}
