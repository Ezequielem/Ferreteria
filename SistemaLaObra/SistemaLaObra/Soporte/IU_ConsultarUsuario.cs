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
    public partial class IU_ConsultarUsuario : Form
    {
        public Usuario Usuario { get; set; }
        public List<Usuario> ListaUsuarios { get; set; }
        public ListaTipoEncargado ListaTipoEncargado { get; set; }
        public Encargado Encargado { get; set; }
        public TipoEncargado TipoEncargado { get; set; }
        IU_DatosUsuario interfazDatosUsuario;

        public IU_ConsultarUsuario()
        {
            InitializeComponent();
            Usuario = new Usuario();
            ListaUsuarios = new List<Usuario>();
            ListaTipoEncargado = new ListaTipoEncargado();
            Encargado = new Encargado();
            TipoEncargado = new TipoEncargado();
        }

        //BOTONES

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            IU_RegistrarUsuario interfaz = new IU_RegistrarUsuario();
            interfaz.ShowDialog();
            cargarDataGrid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.Rows.Count != 0)
            {
                IU_ActualizarUsuario interfaz = new IU_ActualizarUsuario();
                interfaz.opcionActualizarUsuario(int.Parse(dgv_usuarios.CurrentRow.Cells[4].Value.ToString()));
                interfaz.ShowDialog();
                cargarDataGrid();
            }
        }

        //METODOS

        private void cargarDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_usuarios.Rows.Clear();
            ListaUsuarios.Clear();
            ListaUsuarios = Usuario.mostrarDatos();            
            foreach (var item in ListaUsuarios)
            {
                Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(item.CodigoUsuario));
                TipoEncargado.mostrarDatos(ListaTipoEncargado.obtenerCodigoTipoEncargado(item.CodigoUsuario));

                dgv_usuarios.Rows.Add(item.NombreUsuario, Encargado.Nombre, Encargado.Apellido, TipoEncargado.Descripcion, item.CodigoUsuario);
            }
            Cursor.Current = Cursors.Default;
        }

        private void cargarDataGrid(List<Usuario> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_usuarios.Rows.Clear();
            foreach (var item in lista)
            {
                Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(item.CodigoUsuario));
                TipoEncargado.mostrarDatos(ListaTipoEncargado.obtenerCodigoTipoEncargado(item.CodigoUsuario));

                dgv_usuarios.Rows.Add(item.NombreUsuario, Encargado.Nombre, Encargado.Apellido, TipoEncargado.Descripcion, item.CodigoUsuario);
            }
            Cursor.Current = Cursors.Default;
        }

        //EVENTOS

        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario.mostrarDatos(int.Parse(dgv_usuarios.CurrentRow.Cells[4].Value.ToString()));
            Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Usuario.CodigoUsuario));
            TipoEncargado.mostrarDatos(ListaTipoEncargado.obtenerCodigoTipoEncargado(Usuario.CodigoUsuario));

            interfazDatosUsuario = new IU_DatosUsuario();

            interfazDatosUsuario.lbl_nombreUsuario.Text = Usuario.NombreUsuario;
            interfazDatosUsuario.lbl_tipoEncargado.Text = TipoEncargado.Descripcion;
            interfazDatosUsuario.lbl_legajo.Text = Encargado.Legajo.ToString();
            interfazDatosUsuario.lbl_nombreEncargado.Text = Encargado.Nombre;
            interfazDatosUsuario.lbl_apellidoEncargado.Text = Encargado.Apellido;
            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento.mostrarDatos(Encargado.CodigoTipoDocumento);
            interfazDatosUsuario.lbl_tipoDocumento.Text = tipoDocumento.Descripcion;
            interfazDatosUsuario.lbl_nroDocumento.Text = Encargado.NroDocumento;
            interfazDatosUsuario.lbl_fechaNacimiento.Text = Encargado.FechaNacimiento.ToString("dd/MM/yyyy");
            TipoTelefono tipoTelefono = new TipoTelefono();
            tipoTelefono.mostrarDatos(Encargado.CodigoTipoTelefono);
            interfazDatosUsuario.lbl_tipoTelefono.Text = tipoTelefono.Descripcion;
            interfazDatosUsuario.lbl_nroTelefono.Text = Encargado.NroTelefono;
            interfazDatosUsuario.lbl_calle.Text = Encargado.Calle;
            interfazDatosUsuario.lbl_numero.Text = Encargado.Numero.ToString();
            interfazDatosUsuario.lbl_depto.Text = Encargado.Depto;
            interfazDatosUsuario.lbl_piso.Text = Encargado.Piso;
            interfazDatosUsuario.lbl_barrio.Text = Encargado.NombreBarrio;
            interfazDatosUsuario.lbl_codigoPostal.Text = Encargado.CodigoPostal.ToString();
            Provincia provincia = new Provincia();
            provincia.mostrarDatos(Encargado.CodigoProvincia);
            interfazDatosUsuario.lbl_provincia.Text = provincia.NombreProvincia;
            Departamento departamento = new Departamento();
            interfazDatosUsuario.lbl_departamento.Text = departamento.mostrarNombre(Encargado.CodigoDepartamento);
            Localidad localidad = new Localidad();
            interfazDatosUsuario.lbl_localidad.Text = localidad.mostrarNombre(Encargado.CodigoLocalidad);
            interfazDatosUsuario.ShowDialog();
        }

        private void IU_ConsultarUsuario_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void txt_nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombreUsuario.Text == string.Empty)
            {
                cargarDataGrid();
            }
            else
            {
                ListaUsuarios = ListaUsuarios.Where(x => x.NombreUsuario.Contains(txt_nombreUsuario.Text)).ToList();
                cargarDataGrid(ListaUsuarios);
            }
        }

        private void rb_busquedaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            dgv_usuarios.Rows.Clear();
            txt_nombreUsuario.Enabled = true;
        }
    }
}
