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
    public partial class IU_ModificarEmpresa : Form
    {
        public MiEmpresa MiEmpresa { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public CondicionIva CondicionIva { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
        public Localidad Localidad { get; set; }
        public List<Provincia> ListaProvincias { get; set; }
        public List<Departamento> ListaDepartamento { get; set; }
        public List<Localidad> ListaLocalidades { get; set; }
        public List<TipoTelefono> ListaTipoTelefono { get; set; }
        public List<CondicionIva> ListaCondicionIva { get; set; }
        Validaciones validacion;

        public IU_ModificarEmpresa()
        {
            InitializeComponent();
            MiEmpresa = new MiEmpresa();
            TipoTelefono = new TipoTelefono();
            CondicionIva = new CondicionIva();
            Provincia = new Provincia();
            Departamento = new Departamento();
            Localidad = new Localidad();
            ListaProvincias = new List<Provincia>();
            ListaDepartamento = new List<Departamento>();
            ListaLocalidades = new List<Localidad>();
            ListaTipoTelefono = new List<TipoTelefono>();
            ListaCondicionIva = new List<CondicionIva>();
            validacion = new Validaciones();
        }

        //BOTONES

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (validacion.campoVacio(txt_nombreFantasia.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un nombre de Fantasía", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_razonSocial.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar una razon Social", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_cuit.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un CUIT", "Advertencia!!!");
            }
            else if (MiEmpresa.Cuit!=txt_cuit.Text && MiEmpresa.existeCUIT(txt_cuit.Text))
            {
                MessageBox.Show("El número de CUIT ingresado ya existe", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_numeroTelefono.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un número de teléfono", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_calle.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar la calle", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_numero.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar el número de calle", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_cp.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar código postal", "Advertencia!!!");
            }
            else if (validacion.campoVacio(txt_barrio.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar el barrio", "Advertencia!!!");
            }
            else
            {
                tomarNombreFantasia();
                tomarRazonSocial();
                tomarCuit();
                tomarIIBB();
                tomarFechaInicio();
                tomarNumeroTel();
                tomarEmail();
                tomarPaginaWeb();
                tomarCalle();
                tomarNumero();
                tomarCodigoPostal();
                tomarNombreBarrio();
                tomarFacturacion();
                tomarNavegacion();
                tomarLocalidad();
                tomarTipoTelefono();
                tomarCondicionIva();
                modificar();
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void opcionModificarEmpresa(int id)
        {
            MiEmpresa.mostrarDatos(id);
            MiEmpresa.Localidad.mostrarDatos(MiEmpresa.CodigoLocalidad);
        }

        public void tomarNombreFantasia()
        {
            MiEmpresa.NombreFantasia = txt_nombreFantasia.Text;
        }

        public void tomarRazonSocial()
        {
            MiEmpresa.RazonSocial = txt_razonSocial.Text;
        }

        public void tomarCuit()
        {
            MiEmpresa.Cuit = txt_cuit.Text;
        }

        public void tomarIIBB()
        {
            MiEmpresa.IngresosBrutos = txt_ingresosBrutos.Text;
        }

        public void tomarFechaInicio()
        {
            MiEmpresa.FechaInicio = dtp_fechaInicio.Value;
        }

        public void tomarNumeroTel()
        {
            MiEmpresa.NumeroTelefono = txt_numeroTelefono.Text;
        }

        public void tomarEmail()
        {
            MiEmpresa.Email = txt_email.Text;
        }

        public void tomarPaginaWeb()
        {
            MiEmpresa.PaginaWeb = txt_paginaWeb.Text;
        }

        public void tomarCalle()
        {
            MiEmpresa.Calle = txt_calle.Text;
        }

        public void tomarNumero()
        {
            MiEmpresa.Numero = txt_numero.Text;
        }

        public void tomarCodigoPostal()
        {
            MiEmpresa.CodigoPostal = txt_cp.Text;
        }

        public void tomarNombreBarrio()
        {
            MiEmpresa.Barrio = txt_barrio.Text;
        }

        public void tomarFacturacion()
        {
            MiEmpresa.Facturacion = chx_facturacion.Checked;
        }

        public void tomarNavegacion()
        {
            MiEmpresa.Navegacion = chx_navegacion.Checked;
        }

        public void tomarLocalidad()
        {
            MiEmpresa.CodigoLocalidad = int.Parse(cbx_localidad.SelectedValue.ToString());
            MiEmpresa.Localidad.mostrarDatos(MiEmpresa.CodigoLocalidad);
        }

        public void tomarTipoTelefono()
        {
            MiEmpresa.CodigoTipoTelefono = int.Parse(cbx_tipoTelefono.SelectedValue.ToString());
            MiEmpresa.TipoTelefono.mostrarDatos(MiEmpresa.CodigoTipoTelefono);
        }

        public void tomarCondicionIva()
        {
            MiEmpresa.CodigoCondicionIva = int.Parse(cbx_condicionIva.SelectedValue.ToString());
            MiEmpresa.CondicionIva.mostrarDatos(MiEmpresa.CodigoCondicionIva);
        }

        private void cargarProvincias()
        {
            ListaProvincias = Provincia.mostrarDatos();
            ListaProvincias = ListaProvincias.OrderBy(x => x.NombreProvincia).ToList();
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = ListaProvincias;
        }

        private void cargarDepartamentos(int codigo)
        {
            ListaDepartamento = Provincia.conocerDepartamento(codigo);
            ListaDepartamento = ListaDepartamento.OrderBy(x => x.NombreDepartamento).ToList();
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = ListaDepartamento;
        }

        private void cargarLocalidades(int codigo)
        {
            ListaLocalidades = Departamento.conocerLocalidad(codigo);
            ListaLocalidades = ListaLocalidades.OrderBy(x => x.NombreLocalidad).ToList();
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = ListaLocalidades;
        }

        private void cargarTipoTelefono()
        {
            ListaTipoTelefono = TipoTelefono.mostrarDatos();
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = ListaTipoTelefono;
        }

        private void cargarCondicionIva()
        {
            ListaCondicionIva = CondicionIva.mostrarDatos();
            cbx_condicionIva.ValueMember = "CodigoCondicionIva";
            cbx_condicionIva.DisplayMember = "Descripcion";
            cbx_condicionIva.DataSource = ListaCondicionIva;
        }

        private void cargarDatos()
        {
            txt_nombreFantasia.Text = MiEmpresa.NombreFantasia;
            txt_razonSocial.Text = MiEmpresa.RazonSocial;
            txt_cuit.Text = MiEmpresa.Cuit;
            txt_ingresosBrutos.Text = MiEmpresa.IngresosBrutos;
            dtp_fechaInicio.Value = MiEmpresa.FechaInicio;
            cbx_tipoTelefono.SelectedValue = MiEmpresa.CodigoTipoTelefono;
            txt_numeroTelefono.Text = MiEmpresa.NumeroTelefono;
            txt_email.Text = MiEmpresa.Email;
            txt_paginaWeb.Text = MiEmpresa.PaginaWeb;
            txt_calle.Text = MiEmpresa.Calle;
            txt_numero.Text = MiEmpresa.Numero;
            txt_cp.Text = MiEmpresa.CodigoPostal;
            txt_barrio.Text = MiEmpresa.Barrio;
            cbx_provincia.SelectedValue = MiEmpresa.Localidad.Departamento.Provincia.CodigoProvincia;
            cbx_departamento.SelectedValue = MiEmpresa.Localidad.Departamento.CodigoDepartamento;
            cbx_localidad.SelectedValue = MiEmpresa.CodigoLocalidad;
            cbx_condicionIva.SelectedValue = MiEmpresa.CodigoCondicionIva;
            chx_facturacion.Checked = MiEmpresa.Facturacion;
            chx_navegacion.Checked = MiEmpresa.Navegacion;
        }

        private void modificar()
        {
            MiEmpresa.modificar(MiEmpresa);
        }

        //EVENTOS

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Cursor.Current = Cursors.WaitCursor;
            cargarProvincias();
            cargarTipoTelefono();
            cargarCondicionIva();
            cargarDatos();
            Cursor.Current = Cursors.Default;
        }

        private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos(int.Parse(cbx_provincia.SelectedValue.ToString()));
        }

        private void cbx_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades(int.Parse(cbx_departamento.SelectedValue.ToString()));
        }

        private void txt_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_ingresosBrutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }
    }
}
