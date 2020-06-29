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
    public partial class IU_RegistrarProveedorArticulo : Form
    {
        //INSTANCIAS
        private ListaProveedoresArticulo _proveedoresArticulo;
        private List<ListaProveedoresArticulo> _listaProveedoresArticulo;
        private Articulo _articulo;
        private List<Articulo> _listaArticulos;
        private Proveedor _proveedor;
        private List<Proveedor> _listaProveedor;
        private Validaciones validar;

        public ListaProveedoresArticulo ProveedoresArticulo
        {
            get
            {
                return _proveedoresArticulo;
            }

            set
            {
                _proveedoresArticulo = value;
            }
        }

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

        public List<Articulo> ListaArticulos
        {
            get
            {
                return _listaArticulos;
            }

            set
            {
                _listaArticulos = value;
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

        public List<Proveedor> ListaProveedor
        {
            get
            {
                return _listaProveedor;
            }

            set
            {
                _listaProveedor = value;
            }
        }

        public IU_RegistrarProveedorArticulo()
        {
            ProveedoresArticulo = new ListaProveedoresArticulo();
            ListaProveedoresArticulo = new List<ListaProveedoresArticulo>();
            Articulo = new Articulo();
            ListaArticulos = new List<Articulo>();
            Proveedor = new Proveedor();
            ListaProveedor = new List<Proveedor>();
            validar = new Validaciones();
            InitializeComponent();
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_articulo.Text))
            {
                MessageBox.Show(this, "No hay artículo seleccionado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validar.campoVacio(txt_precioCoste.Text))
            {
                MessageBox.Show(this, "No ha ingresado precio de coste", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ProveedoresArticulo.esProveedorAsociado(int.Parse(dgv_articulos.CurrentRow.Cells[3].Value.ToString()), int.Parse(cbx_proveedor.SelectedValue.ToString())))
            {
                MessageBox.Show(this, "Ya se encuentra registrado el proveedor para este artículo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!validar.decimalValido(txt_precioCoste.Text))
            {
                MessageBox.Show(this, "No ha ingresado un precio válido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarDatos();
                ProveedoresArticulo.crear(ProveedoresArticulo);
                MessageBox.Show(this, "Se ha registrado correctamente el proveedor del artículo", "PROVEEDOR ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                txt_filtro.Text = "";
                txt_articulo.Text = "";
                txt_precioCoste.Text = "";
                cargarDataGrid();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled==false)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                txt_filtro.Text = "";
                txt_articulo.Text = "";
                txt_precioCoste.Text = "";
                cargarDataGrid();
            }
            else
            {
                this.Close();
            }
        }

        //METODOS

        public void buscarArticulos()
        {
            ListaArticulos.Clear();
            ListaArticulos = Articulo.mostrarDatos();
        }

        public void cargarDataGrid()
        {
            dgv_articulos.Rows.Clear();           
            foreach (var item in ListaArticulos)
            {
                dgv_articulos.Rows.Add(item.CodigoDescripcion, item.Descripcion, "Seleccionar", item.CodigoArticulo);               
            }
        }

        public void buscarProveedores()
        {
            ListaProveedor.Clear();
            ListaProveedor = Proveedor.mostrarDatos();
        }

        public void cargaCombo()
        {
            cbx_proveedor.Items.Clear();
            cbx_proveedor.DisplayMember = "RazonSocial";
            cbx_proveedor.ValueMember= "CodigoProveedor";
            cbx_proveedor.DataSource = ListaProveedor;
        }

        private void cargarDataGridFiltrado(List<Articulo> lista)
        {
            dgv_articulos.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_articulos.Rows.Add(item.CodigoDescripcion, item.Descripcion, "Seleccionar", item.CodigoArticulo);
            }
        }

        public void tomarDatos()
        {
            ProveedoresArticulo.CodigoArticulo = int.Parse(dgv_articulos.CurrentRow.Cells[3].Value.ToString());
            ProveedoresArticulo.CodigoProveedor = int.Parse(cbx_proveedor.SelectedValue.ToString());
            ProveedoresArticulo.PrecioProveedor = float.Parse(txt_precioCoste.Text, CultureInfo.InvariantCulture);
        }

        //EVENTOS

        private void IU_RegistrarProveedorArticulo_Load(object sender, EventArgs e)
        {
            buscarArticulos();
            cargarDataGrid();
            buscarProveedores();
            cargaCombo();
            groupBox2.Enabled = false;
        }

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string descripcion = txt.Text;
            List<Articulo> listaFiltrada = ListaArticulos.FindAll(x => x.Descripcion.Contains(descripcion));
            cargarDataGridFiltrado(listaFiltrada);
        }

        private void dgv_articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv_actual = sender as DataGridView;
            if (dgv_actual.CurrentCell.ColumnIndex == 2)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;                
                txt_articulo.Text = dgv_actual.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txt_precioCoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals('.'))
            {
                validar.soloNumeros(e);
            }            
        }
    }
}
