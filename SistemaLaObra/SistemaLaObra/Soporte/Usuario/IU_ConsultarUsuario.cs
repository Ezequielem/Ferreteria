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
    public partial class IU_ConsultarUsuario : Form
    {
        public Encargado Encargado { get; set; }
        public List<Encargado> ListaEncargados { get; set; }
        public TipoDeAcceso_X_Usuario TipoDeAcceso_X_Usuario { get; set; }        
        public TipoDeAcceso TipoDeAcceso { get; set; }
        IU_DatosUsuario interfazDatosUsuario;

        public IU_ConsultarUsuario()
        {
            InitializeComponent();
            Encargado = new Encargado();
            ListaEncargados = new List<Encargado>();
            TipoDeAcceso_X_Usuario = new TipoDeAcceso_X_Usuario();            
            TipoDeAcceso = new TipoDeAcceso();
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
            ListaEncargados.Clear();
            ListaEncargados = Encargado.mostrarDatos();            
            foreach (var item in ListaEncargados)
            {
                string acceso = string.Empty;
                item.Usuario.mostrarDatos(item.CodigoUsuario);
                foreach (var item1 in TipoDeAcceso_X_Usuario.mostrarDatos(item.Usuario))
                {
                    TipoDeAcceso.mostrarDatos(item1.CodigoTipoAcceso);
                    acceso += TipoDeAcceso.Descripcion + " ";
                }
                dgv_usuarios.Rows.Add(
                    item.Usuario.NombreUsuario, 
                    item.Nombre, 
                    item.Apellido, 
                    acceso, 
                    item.Usuario.CodigoUsuario);
            }
            Cursor.Current = Cursors.Default;
        }

        private void cargarDataGrid(List<Encargado> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_usuarios.Rows.Clear();
            foreach (var item in lista)
            {
                string acceso = string.Empty;
                item.Usuario.mostrarDatos(item.CodigoUsuario);
                foreach (var item1 in TipoDeAcceso_X_Usuario.mostrarDatos(item.Usuario))
                {
                    TipoDeAcceso.mostrarDatos(item1.CodigoTipoAcceso);
                    acceso += TipoDeAcceso.Descripcion + " ";
                }
                dgv_usuarios.Rows.Add(
                    item.Usuario.NombreUsuario,
                    item.Nombre,
                    item.Apellido,
                    acceso,
                    item.Usuario.CodigoUsuario);
            }
            Cursor.Current = Cursors.Default;
        }

        //EVENTOS

        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Encargado.Usuario.mostrarDatos(int.Parse(dgv_usuarios.CurrentRow.Cells[4].Value.ToString()));
            Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Encargado.Usuario.CodigoUsuario));
            Encargado.Localidad.mostrarDatos(Encargado.CodigoLocalidad);
            Encargado.MiEmpresa.mostrarDatos(Encargado.CodigoMiEmpresa);
            Encargado.TipoDocumento.mostrarDatos(Encargado.CodigoTipoDocumento);
            Encargado.TipoTelefono.mostrarDatos(Encargado.CodigoTipoTelefono);
            string acceso = string.Empty;
            foreach (var item in TipoDeAcceso_X_Usuario.mostrarDatos(Encargado.Usuario))
            {
                TipoDeAcceso.mostrarDatos(item.CodigoTipoAcceso);
                acceso += TipoDeAcceso.Descripcion + " ";
            }
            interfazDatosUsuario = new IU_DatosUsuario();
            interfazDatosUsuario.txt_usuario.Text = Encargado.Usuario.NombreUsuario;
            interfazDatosUsuario.txt_tipoEncargado.Text = acceso;
            interfazDatosUsuario.txt_legajo.Text = Encargado.Legajo.ToString();
            interfazDatosUsuario.txt_nombre.Text = Encargado.Nombre;
            interfazDatosUsuario.txt_apellido.Text = Encargado.Apellido;
            interfazDatosUsuario.txt_tipoDocumento.Text = Encargado.TipoDocumento.Descripcion;
            interfazDatosUsuario.txt_nroDocumento.Text = Encargado.NroDocumento;
            interfazDatosUsuario.txt_fechaNacimiento.Text = Encargado.FechaNacimiento.ToString("dd/MM/yyyy");
            interfazDatosUsuario.txt_tipoTelefono.Text = Encargado.TipoTelefono.Descripcion;
            interfazDatosUsuario.txt_nroTelefono.Text = Encargado.NroTelefono;
            interfazDatosUsuario.txt_calle.Text = Encargado.Calle;
            interfazDatosUsuario.txt_numero.Text = Encargado.Numero.ToString();
            interfazDatosUsuario.txt_depto.Text = Encargado.Depto;
            interfazDatosUsuario.txt_piso.Text = Encargado.Piso;
            interfazDatosUsuario.txt_barrio.Text = Encargado.NombreBarrio;
            interfazDatosUsuario.txt_cp.Text = Encargado.CodigoPostal.ToString();
            interfazDatosUsuario.txt_provincia.Text = Encargado.Localidad.Departamento.Provincia.NombreProvincia;
            interfazDatosUsuario.txt_departamento.Text = Encargado.Localidad.Departamento.NombreDepartamento;
            interfazDatosUsuario.txt_localidad.Text = Encargado.Localidad.NombreLocalidad;            
            interfazDatosUsuario.txt_empresa.Text = Encargado.MiEmpresa.NombreFantasia;
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
                ListaEncargados = ListaEncargados.Where(x => x.Usuario.NombreUsuario.Contains(txt_nombreUsuario.Text)).ToList();
                cargarDataGrid(ListaEncargados);
            }
        }

        private void rb_busquedaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            dgv_usuarios.Rows.Clear();
            txt_nombreUsuario.Enabled = true;
        }
    }
}
