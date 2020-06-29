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
    public partial class IU_ConsultarUbicacion : Form
    {
        public Ubicacion Ubicacion { get; set; }
        public List<Ubicacion> ListaUbicaciones { get; set; }

        public IU_ConsultarUbicacion()
        {
            InitializeComponent();
            Ubicacion = new Ubicacion();
            ListaUbicaciones = new List<Ubicacion>();
        }

        //BOTONES

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_ubicaciones.Rows.Count != 0)
            {
                IU_ActualizarUbicacion interfaz = new IU_ActualizarUbicacion();
                interfaz.opcionActualizarUbicacion(int.Parse(dgv_ubicaciones.CurrentRow.Cells[1].Value.ToString()));
                interfaz.ShowDialog();
                cargarUbicaciones();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            IU_RegistrarUbicacion interfaz = new IU_RegistrarUbicacion();
            interfaz.ShowDialog();
            cargarUbicaciones();
        }

        //METODOS

        public void cargarUbicaciones()
        {
            Cursor.Current = Cursors.WaitCursor;
            ListaUbicaciones.Clear();
            ListaUbicaciones = Ubicacion.mostrarDatos();
            dgv_ubicaciones.Rows.Clear();
            foreach (var item in ListaUbicaciones)
            {
                dgv_ubicaciones.Rows.Add(item.Descripcion, item.CodigoUbicacion);
            }
            Cursor.Current = Cursors.Default;
        }

        public void cargarUbicaciones(List<Ubicacion> lista)
        {
            Cursor.Current = Cursors.WaitCursor;            
            dgv_ubicaciones.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_ubicaciones.Rows.Add(item.Descripcion, item.CodigoUbicacion);
            }
            Cursor.Current = Cursors.Default;
        }

        //EVENTOS

        private void IU_ConsultarUbicacion_Load(object sender, EventArgs e)
        {
            cargarUbicaciones();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (txt_filtro.Text==String.Empty)
            {
                cargarUbicaciones();
            }
            else
            {
                cargarUbicaciones(ListaUbicaciones.Where(x => x.Descripcion.Contains(txt_filtro.Text)).ToList());
            }
        }
    }
}
