using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte
{
    public partial class IU_ActualizarProveedorArticulo : Form
    {
        //INSTANCIAS

        private List<ListaProveedoresArticulo> _listaProveedoresArticulo;
        private ListaProveedoresArticulo _ProveedoresArticulo;
        private Proveedor _proveedor;
        private Articulo _articulo;
        Validaciones validar;

        public List<ListaProveedoresArticulo> ListaProveedoresArticulo
        {
            get
            {
                return _listaProveedoresArticulo;
            }

            set
            {
                _listaProveedoresArticulo = value;
            }
        }

        public ListaProveedoresArticulo ProveedoresArticulo
        {
            get
            {
                return _ProveedoresArticulo;
            }

            set
            {
                _ProveedoresArticulo = value;
            }
        }

        public Proveedor Proveedor
        {
            get
            {
                return _proveedor;
            }

            set
            {
                _proveedor = value;
            }
        }

        public Articulo Articulo
        {
            get
            {
                return _articulo;
            }

            set
            {
                _articulo = value;
            }
        }

        public IU_ActualizarProveedorArticulo()
        {
            ListaProveedoresArticulo = new List<ListaProveedoresArticulo>();
            ProveedoresArticulo = new ListaProveedoresArticulo();
            Proveedor = new Proveedor();
            Articulo = new Articulo();
            validar = new Validaciones();
            InitializeComponent();
        }

        //BOTONES

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_precio.Text))
            {
                MessageBox.Show(this,"Debe ingresar el precio del artículo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!validar.decimalValido(txt_precio.Text))
            {
                MessageBox.Show(this, "Debe ingresar el precio de forma correcta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarProveedorArticulo();
                ProveedoresArticulo.actualizar(ProveedoresArticulo);
                MessageBox.Show(this, "Se ha modificado correctamente el artículo del proveedor", "PROVEEDOR ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBox2.Enabled = false;
                btn_actualizar.Enabled = false;
                groupBox1.Enabled = true;
                txt_precio.Text = "";
                txt_filtro.Text = "";
                cargarDataGrid();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                btn_actualizar.Enabled = false;
                txt_filtro.Text = "";
                txt_precio.Text = "";
                cargarDataGrid();
            }
            else
            {
                this.Close();
            }
        }

        //METODOS

        public void buscarListaArticuloProveedor()
        {
            ListaProveedoresArticulo.Clear();
            ListaProveedoresArticulo = ProveedoresArticulo.mostrarDatos();
        }

        public void cargarDataGrid()
        {
            dgv_proveedorArticulo.Rows.Clear();
            foreach (var item in ListaProveedoresArticulo)
            {
                Articulo.mostrarDatos(item.CodigoArticulo);
                dgv_proveedorArticulo.Rows.Add(Articulo.Descripcion, Proveedor.obtenerDatosProveedor(item.CodigoProveedor).RazonSocial, item.PrecioProveedor, "seleccionar", item.CodigoArticulo, item.CodigoProveedor);
            }
        }

        private void cargarDataGridFiltrado(List<ListaProveedoresArticulo> lista)
        {
            dgv_proveedorArticulo.Rows.Clear();
            foreach (var item in lista)
            {
                Articulo.mostrarDatos(item.CodigoArticulo);
                dgv_proveedorArticulo.Rows.Add(Articulo.Descripcion, Proveedor.obtenerDatosProveedor(item.CodigoProveedor).RazonSocial, item.PrecioProveedor, "seleccionar", item.CodigoArticulo, item.CodigoProveedor);
            }
        }

        public void tomarProveedorArticulo()
        {            
            ProveedoresArticulo.CodigoArticulo = int.Parse(dgv_proveedorArticulo.CurrentRow.Cells[4].Value.ToString());
            ProveedoresArticulo.CodigoProveedor = int.Parse(dgv_proveedorArticulo.CurrentRow.Cells[5].Value.ToString());
            ProveedoresArticulo.PrecioProveedor = float.Parse(txt_precio.Text, CultureInfo.InvariantCulture);
        }

        //EVENTOS

        private void IU_ActualizarProveedorArticulo_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btn_actualizar.Enabled = false;
            buscarListaArticuloProveedor();
            cargarDataGrid();
        }

        private void dgv_proveedorArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv_actual = sender as DataGridView;
            if (dgv_actual.CurrentCell.ColumnIndex == 3)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                btn_actualizar.Enabled = true;
                txt_precio.Text = dgv_actual.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string descripcion = txt.Text;
            List<ListaProveedoresArticulo> listaFiltrada = ListaProveedoresArticulo.FindAll((ListaProveedoresArticulo a) => a.Articulo.Descripcion.Contains(descripcion));
            cargarDataGridFiltrado(listaFiltrada);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals('.'))
            {
                validar.soloNumeros(e);
            }
        }
    }
}
