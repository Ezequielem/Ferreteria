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
    public partial class IU_ActualizarMarca : Form
    {
        //INSTANCIAS
        private Marca _marca;
        private List<Marca> _listaMarca;
        private Validaciones validar;

        public Marca Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public List<Marca> ListaMarca
        {
            get
            {
                return _listaMarca;
            }

            set
            {
                _listaMarca = value;
            }
        }

        public IU_ActualizarMarca()
        {
            Marca = new Marca();
            ListaMarca = new List<Marca>();
            validar = new Validaciones();
            InitializeComponent();
        }

        //BOTONES

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_nombre.Text))
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la marca", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarMarca();
                Marca.actualizar(Marca);
                MessageBox.Show(this, "Se ha modificado correctamente la marca", "MARCA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                btn_actualizar.Enabled = false;
                txt_filtro.Text = "";
                txt_nombre.Text = "";
                buscarMarcas();
                cargarDataGrid();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                txt_nombre.Text = "";
                txt_filtro.Text = "";
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                btn_actualizar.Enabled = false;
                cargarDataGrid();
            }
            else
            {
                this.Close();
            }
        }

        //METODOS

        public void buscarMarcas()
        {
            ListaMarca.Clear();
            ListaMarca = Marca.mostrarDatos();
        }

        public void cargarDataGrid()
        {
            dgv_marcas.Rows.Clear();
            foreach (var item in ListaMarca)
            {
                dgv_marcas.Rows.Add(item.CodigoMarca, item.Descripcion, "seleccionar");
            }
        }

        private void cargarDataGridFiltrado(List<Marca> lista)
        {
            dgv_marcas.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_marcas.Rows.Add(item.CodigoMarca, item.Descripcion, "seleccionar");
            }
        }

        public void tomarMarca()
        {
            Marca.CodigoMarca = int.Parse(dgv_marcas.CurrentRow.Cells[0].Value.ToString());
            Marca.Descripcion = txt_nombre.Text;
        }

        //EVENTOS

        private void IU_ActualizarMarca_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btn_actualizar.Enabled = false;
            buscarMarcas();
            cargarDataGrid();
        }

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string descripcion = txt.Text;
            List<Marca> listaFiltrada = ListaMarca.FindAll(x => x.Descripcion.Contains(descripcion));
            cargarDataGridFiltrado(listaFiltrada);
        }

        private void dgv_marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
