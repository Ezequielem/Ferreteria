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
    public partial class IU_DetalleMiEmpresa : Form
    {
        public MiEmpresa MiEmpresa { get; set; }

        public IU_DetalleMiEmpresa()
        {
            InitializeComponent();
        }

        public void opcionDetalle(MiEmpresa empresa)
        {
            MiEmpresa = empresa;           
        }

        private void cargarDatos()
        {
            Cursor.Current = Cursors.WaitCursor;
            MiEmpresa.Localidad.mostrarDatos(MiEmpresa.CodigoLocalidad);
            MiEmpresa.TipoTelefono.mostrarDatos(MiEmpresa.CodigoTipoTelefono);
            MiEmpresa.CondicionIva.mostrarDatos(MiEmpresa.CodigoCondicionIva);
            txt_nombreFantasia.Text = MiEmpresa.NombreFantasia;
            txt_razonSocial.Text = MiEmpresa.RazonSocial;
            txt_cuit.Text = MiEmpresa.Cuit;
            txt_iibb.Text = MiEmpresa.IngresosBrutos;
            txt_fechaInicio.Text = MiEmpresa.FechaInicio.ToShortDateString();
            txt_tipoTel.Text = MiEmpresa.TipoTelefono.Descripcion;
            txt_numeroTel.Text = MiEmpresa.NumeroTelefono;
            txt_email.Text = MiEmpresa.Email;
            txt_paginaWeb.Text = MiEmpresa.PaginaWeb;
            txt_calle.Text = MiEmpresa.Calle;
            txt_numero.Text = MiEmpresa.Numero;
            txt_codigoPostal.Text = MiEmpresa.CodigoPostal;
            txt_barrio.Text = MiEmpresa.Barrio;
            txt_provincia.Text = MiEmpresa.Localidad.Departamento.Provincia.NombreProvincia;
            txt_departamento.Text = MiEmpresa.Localidad.Departamento.NombreDepartamento;
            txt_localidad.Text = MiEmpresa.Localidad.NombreLocalidad;
            txt_condicionIva.Text = MiEmpresa.CondicionIva.Descripcion;
            if (MiEmpresa.Facturacion)
            {
                txt_facturacion.BackColor = Color.Green;
                txt_facturacion.Text = "HABILITADA";
            }
            else
            {
                txt_facturacion.BackColor = Color.Red;
                txt_facturacion.Text = "NO HABILITADA";
            }
            if (MiEmpresa.Navegacion)
            {
                txt_navegacion.BackColor = Color.Green;
                txt_navegacion.Text = "HABILITADA";
            }
            else
            {
                txt_navegacion.BackColor = Color.Red;
                txt_navegacion.Text = "NO HABILITADA";
            }
            Cursor.Current = Cursors.Default;
        }

        private void IU_DetalleMiEmpresa_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
