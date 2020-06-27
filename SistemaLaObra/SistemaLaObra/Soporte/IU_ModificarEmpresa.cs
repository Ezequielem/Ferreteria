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
        }

        //BOTONES

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void opcionModificarEmpresa(int id)
        {
            MiEmpresa.mostrarDatos(id);
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

        //EVENTOS

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Cursor.Current = Cursors.WaitCursor;
            cargarProvincias();
            cargarTipoTelefono();
            cargarCondicionIva();
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
    }
}
