using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.VentaMostrador
{
    public partial class IU_CargaArticulo : Form
    {
        public Articulo Articulo { get; set; }
        public List<Articulo> ListaArticulos { get; set; }
        public Controlador_Venta controlador { get; set; }
        Validaciones Validacion { get; set; }

        public IU_CargaArticulo(Controlador_Venta control)
        {
            InitializeComponent();
            Articulo = new Articulo();
            ListaArticulos = new List<Articulo>();
            Validacion = new Validaciones();
            controlador = control;
        }

        //BOTONES

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (Validacion.campoVacio(txt_cantidad.Text))
            {
                MessageBox.Show("No ha ingresado la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dgv_articulos.Rows.Count == 0)
            {
                MessageBox.Show("No hay ningún articulo seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(txt_cantidad.Text) > int.Parse(dgv_articulos.CurrentRow.Cells[3].Value.ToString()))
            {
                MessageBox.Show("La cantidad solicitada es mayor al stock disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                controlador.buscarDatosArticulos(int.Parse(dgv_articulos.CurrentRow.Cells[5].Value.ToString()));
                controlador.cantidadSolicitada(int.Parse(txt_cantidad.Text));
                this.Close();
            }
        }

        //METODOS

        public void cargarDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_articulos.Rows.Clear();
            ListaArticulos.Clear();
            ListaArticulos = Articulo.mostrarDatos();
            foreach (var item in ListaArticulos)
            {
                dgv_articulos.Rows.Add(
                    item.Descripcion,
                    item.buscarNombreMarca(item.CodigoMarca),
                    item.CodigoDescripcion,
                    item.Stock,
                    item.buscarNombreProveedor(item.CodigoProveedor),
                    item.CodigoArticulo
                    );
            }            
            Cursor.Current = Cursors.Default;
        }

        public void cargarDataGrid(List<Articulo> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_articulos.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_articulos.Rows.Add(
                    item.Descripcion,
                    item.buscarNombreMarca(item.CodigoMarca),
                    item.CodigoDescripcion,
                    item.Stock,
                    item.buscarNombreProveedor(item.CodigoProveedor),
                    item.CodigoArticulo
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        //EVENTOS

        private void IU_CargaArticulo_Load(object sender, EventArgs e)
        {            
            cargarDataGrid();
            txt_cantidad.Focus();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(e);
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (txt_filtro.Text == string.Empty)
            {
                cargarDataGrid();
            }
            else
            {
                ListaArticulos = ListaArticulos.Where(x => x.Descripcion.Contains(txt_filtro.Text)).ToList();
                cargarDataGrid(ListaArticulos);
            }
        }
    }
}
