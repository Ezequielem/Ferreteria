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
    public partial class IU_ActualizarUbicacion : Form
    {
        //INSTANCIAS
        private Ubicacion _ubicacion;
        private List<Ubicacion> _listaUbicaciones;
        private Validaciones validar;

        public Ubicacion Ubicacion
        {
            get
            {
                return _ubicacion;
            }

            set
            {
                _ubicacion = value;
            }
        }

        public List<Ubicacion> ListaUbicaciones
        {
            get
            {
                return _listaUbicaciones;
            }

            set
            {
                _listaUbicaciones = value;
            }
        }

        public IU_ActualizarUbicacion()
        {
            Ubicacion = new Ubicacion();
            ListaUbicaciones = new List<Ubicacion>();
            validar = new Validaciones();
            InitializeComponent();
        }

        //BOTONES

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_nombre.Text))
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la ubicación", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarUbicacion();
                Ubicacion.actualizarDatos(Ubicacion);
                MessageBox.Show(this, "Se ha modificado correctamente la ubicación", "UBICACION", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                btn_actualizar.Enabled = false;
                txt_filtro.Text = "";
                txt_nombre.Text = "";
                buscarUbicaciones();
                cargarDataGrid();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled==false)
            {
                txt_nombre.Text = "";
                txt_filtro.Text = "";
                groupBox1.Enabled = true;
                dgv_ubicaciones.Enabled = true;
                groupBox2.Enabled = false;
                dgv_ubicaciones.Enabled = true;
                btn_actualizar.Enabled = false;
                cargarDataGrid();
            }
            else
            {
                this.Close();
            }            
        }

        //METODOS

        public void buscarUbicaciones()
        {
            ListaUbicaciones.Clear();
            ListaUbicaciones = Ubicacion.mostrarDatos();
        }

        public void cargarDataGrid()
        {
            dgv_ubicaciones.Rows.Clear();
            foreach (var item in ListaUbicaciones)
            {
                dgv_ubicaciones.Rows.Add(item.CodigoUbicacion, item.Descripcion, "seleccionar");
            }
        }

        private void cargarDataGridFiltrado(List<Ubicacion> lista)
        {
            dgv_ubicaciones.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_ubicaciones.Rows.Add(item.CodigoUbicacion, item.Descripcion, "seleccionar");
            }
        }

        public void tomarUbicacion()
        {
            Ubicacion.CodigoUbicacion = int.Parse(dgv_ubicaciones.CurrentRow.Cells[0].Value.ToString());
            Ubicacion.Descripcion = txt_nombre.Text;
        }

        //EVENTOS

        private void IU_ActualizarUbicacion_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btn_actualizar.Enabled = false;            
            buscarUbicaciones();
            cargarDataGrid();     
        }

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string descripcion = txt.Text;
            List<Ubicacion> listaFiltrada = ListaUbicaciones.FindAll(x=>x.Descripcion.Contains(descripcion));
            cargarDataGridFiltrado(listaFiltrada);
        }

        private void dgv_ubicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv_actual = sender as DataGridView;
            if (dgv_actual.CurrentCell.ColumnIndex == 2)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                btn_actualizar.Enabled = true;
                txt_nombre.Text = dgv_actual.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }        
    }
}
