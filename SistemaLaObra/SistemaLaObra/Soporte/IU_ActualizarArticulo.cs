using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SistemaLaObra
{
    public partial class IU_ActualizarArticulo : Form
    {
        private Articulo articulo;
        private List<ListaProveedoresArticulo> listaProveedoresArticulos;
        private TipoArticulo tipoArticulo;
        private Sub1TipoArticulo sub1TipoArticulo;
        private Sub2TipoArticulo sub2TipoArticulo;
        private Sub3TipoArticulo sub3TipoArticulo;
        private Proveedor proveedor;
        private Marca marca;
        private Ubicacion ubicacion;
        private UnidadDeMedida unidadDeMedida;
        private ListaProveedoresArticulo listaProveedoresArticulo;
        private Validaciones validar;

        public IU_ActualizarArticulo()
        {
            InitializeComponent();
            validar = new Validaciones();
            articulo = new Articulo();
            listaProveedoresArticulos = new List<ListaProveedoresArticulo>();
            tipoArticulo = new TipoArticulo();
            sub1TipoArticulo = new Sub1TipoArticulo();
            sub2TipoArticulo = new Sub2TipoArticulo();
            sub3TipoArticulo = new Sub3TipoArticulo();
            proveedor = new Proveedor();
            marca = new Marca();
            ubicacion = new Ubicacion();
            unidadDeMedida = new UnidadDeMedida();
            listaProveedoresArticulo = new ListaProveedoresArticulo();
        }

        
        private void IU_ActualizarArticulo_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            cargarMarca();
            cargarUnidadesDeMedida();
            cargarUbicaciones();
            cargarCategoria();
            cargarCategoria1();
            cargarCategoria2();
            cargarCategoria3();
            btn_actualizar.Enabled = false; 
            gb_actualizacion.Enabled = false;                       
        }

        //METODOS

        private void cargarDataGridView()
        {
            listaProveedoresArticulos.Clear();
            listaProveedoresArticulos = listaProveedoresArticulo.mostrarDatos();
            dgv_articulos.Rows.Clear();
            foreach (var item in listaProveedoresArticulos)
            {
                dgv_articulos.Rows.Add(item.Articulo.Descripcion, marca.mostrarDatos(item.Articulo.CodigoMarca).Descripcion, item.Articulo.CodigoDescripcion, item.Articulo.PrecioUnitario.ToString("$ 0.00"), item.PrecioProveedor.ToString("$ 0.00"), item.Articulo.Stock, item.Articulo.StockMinimo, unidadDeMedida.mostrarDatos(item.Articulo.CodigoUnidadesDeMedida).Descripcion, ubicacion.mostrarDatos(item.Articulo.CodigoUbicacion).Descripcion, proveedor.obtenerDatosProveedor(item.CodigoProveedor).RazonSocial, tipoArticulo.mostrarDatos(item.Articulo.CodigoTipoArticulo).Descripcion, sub1TipoArticulo.mostrarDatos(item.Articulo.CodigoSub1TipoArticulo).Descripcion, sub2TipoArticulo.mostrarDatos(item.Articulo.CodigoSub2TipoArticulo).Descripcion, sub3TipoArticulo.mostrarDatos(item.Articulo.CodigoSub3TipoArticulo).Descripcion, item.CodigoArticulo);
                limpiarObjetos();
            }
        }

        private void cargarDataGridFiltrado(List<ListaProveedoresArticulo> lista)
        {
            dgv_articulos.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_articulos.Rows.Add(item.Articulo.Descripcion, marca.mostrarDatos(item.Articulo.CodigoMarca).Descripcion, item.Articulo.CodigoDescripcion, item.Articulo.PrecioUnitario.ToString("$ 0.00"), item.PrecioProveedor.ToString("$ 0.00"), item.Articulo.Stock, item.Articulo.StockMinimo, unidadDeMedida.mostrarDatos(item.Articulo.CodigoUnidadesDeMedida).Descripcion, ubicacion.mostrarDatos(item.Articulo.CodigoUbicacion).Descripcion, proveedor.obtenerDatosProveedor(item.CodigoProveedor).RazonSocial, tipoArticulo.mostrarDatos(item.Articulo.CodigoTipoArticulo).Descripcion, sub1TipoArticulo.mostrarDatos(item.Articulo.CodigoSub1TipoArticulo).Descripcion, sub2TipoArticulo.mostrarDatos(item.Articulo.CodigoSub2TipoArticulo).Descripcion, sub3TipoArticulo.mostrarDatos(item.Articulo.CodigoSub3TipoArticulo).Descripcion, item.CodigoArticulo);
                limpiarObjetos();
            }
        }

        private void limpiarObjetos()
        {
            tipoArticulo.CodigoTipoArticulo = 0;
            tipoArticulo.Descripcion = "";
            sub1TipoArticulo.CodigoSub1TipoArticulo = 0;
            sub1TipoArticulo.Descripcion = "";
            sub2TipoArticulo.CodigoSub2TipoArticulo = 0;
            sub2TipoArticulo.Descripcion = "";
            sub3TipoArticulo.CodigoSub3TipoArticulo = 0;
            sub3TipoArticulo.Descripcion = "";
        }

        public void cargarMarca()
        {
            cbx_marca.ValueMember = "CodigoMarca";
            cbx_marca.DisplayMember = "Descripcion";
            cbx_marca.DataSource = marca.mostrarDatos();
        }

        public void cargarUnidadesDeMedida()
        {            
            cbx_unidadDeMedida.ValueMember = "codigoUnidadDeMedida";
            cbx_unidadDeMedida.DisplayMember = "descripcion";
            cbx_unidadDeMedida.DataSource = unidadDeMedida.mostrarDatos();
        }

        public void cargarUbicaciones()
        {            
            cbx_ubicacion.ValueMember = "CodigoUbicacion";
            cbx_ubicacion.DisplayMember = "Descripcion";
            cbx_ubicacion.DataSource = ubicacion.mostrarDatos();
        }

        public void cargarCategoria()
        {            
            cbx_categoria.ValueMember = "CodigoTipoArticulo";
            cbx_categoria.DisplayMember = "Descripcion";
            cbx_categoria.DataSource = tipoArticulo.mostrarDatos();            
        }

        public void cargarCategoria1()
        {
            cbx_categoria1.ValueMember = "CodigoSub1TipoArticulo";
            cbx_categoria1.DisplayMember = "Descripcion";
            if (cbx_categoria.Items.Count==0)
            {
                cbx_categoria1.DataSource = tipoArticulo.mostrarSubCategoria(0);
            }
            else
            {
                cbx_categoria1.DataSource = tipoArticulo.mostrarSubCategoria(int.Parse(cbx_categoria.SelectedValue.ToString()));
            }            
        }

        public void cargarCategoria2()
        {
            cbx_categoria2.ValueMember = "CodigoSub2TipoArticulo";
            cbx_categoria2.DisplayMember = "Descripcion";
            if (cbx_categoria1.Items.Count==0)
            {
                cbx_categoria2.DataSource = sub1TipoArticulo.mostrarSubCategorias(0);
            }
            else
            {
                cbx_categoria2.DataSource = sub1TipoArticulo.mostrarSubCategorias(int.Parse(cbx_categoria1.SelectedValue.ToString()));
            }
        }

        public void cargarCategoria3()
        {                                     
            cbx_categoria3.ValueMember = "CodigoSub3TipoArticulo";
            cbx_categoria3.DisplayMember = "Descripcion";
            if (cbx_categoria2.Items.Count==0)
            {
                cbx_categoria3.DataSource = sub2TipoArticulo.mostrarSubCategorias(0);
            }
            else
            {
                cbx_categoria3.DataSource = sub2TipoArticulo.mostrarSubCategorias(int.Parse(cbx_categoria2.SelectedValue.ToString()));
            }
        }

        private void borrarDatos()
        {
            txt_descripcion.Text = "";
            txt_codigoDescripcion.Text = "";
            txt_precioUnitario.Text = "";
            txt_precioCoste.Text = "";
            nud_stock.ResetText();
            nud_stockMinimo.ResetText();
            cbx_marca.Refresh();
            cbx_ubicacion.Refresh();
            cbx_unidadDeMedida.Refresh();
            txt_proveedor.Text = "";            
            cbx_categoria.Refresh();
            cbx_categoria1.Refresh();
            cbx_categoria2.Refresh();
            cbx_categoria3.Refresh();
        }               
        
        private void tomarCampos()
        {
            articulo.Descripcion = txt_descripcion.Text;
            articulo.CodigoMarca = int.Parse(cbx_marca.SelectedValue.ToString());
            articulo.CodigoDescripcion = txt_codigoDescripcion.Text;
            articulo.PrecioUnitario = float.Parse(txt_precioUnitario.Text, CultureInfo.InvariantCulture);
            articulo.PrecioCoste = float.Parse(txt_precioCoste.Text, CultureInfo.InvariantCulture);
            articulo.Stock = int.Parse(nud_stock.Value.ToString());
            articulo.StockMinimo = int.Parse(nud_stockMinimo.Value.ToString());
            articulo.CodigoUnidadesDeMedida = int.Parse(cbx_unidadDeMedida.SelectedValue.ToString());
            articulo.CodigoUbicacion = int.Parse(cbx_ubicacion.SelectedValue.ToString());
            articulo.CodigoTipoArticulo = int.Parse(cbx_categoria.SelectedValue.ToString());            
            if (cbx_categoria1.SelectedValue == null)
            {
                articulo.CodigoSub1TipoArticulo = 0;
            }
            else
            {
                articulo.CodigoSub1TipoArticulo = int.Parse(cbx_categoria1.SelectedValue.ToString());
            }
            if (cbx_categoria2.SelectedValue == null)
            {
                articulo.CodigoSub2TipoArticulo = 0;
            }
            else
            {
                articulo.CodigoSub2TipoArticulo = int.Parse(cbx_categoria2.SelectedValue.ToString());
            }
            if (cbx_categoria3.SelectedValue == null)
            {
                articulo.CodigoSub3TipoArticulo = 0;
            }
            else
            {
                articulo.CodigoSub3TipoArticulo = int.Parse(cbx_categoria3.SelectedValue.ToString());
            }
        }


        //BOTONES

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_articulos.CurrentRow!=null)
            {                
                articulo.mostrarDatos(int.Parse(this.dgv_articulos.CurrentRow.Cells[14].Value.ToString()));                
                txt_descripcion.Text = articulo.Descripcion;
                txt_codigoDescripcion.Text = articulo.CodigoDescripcion;
                txt_precioUnitario.Text = articulo.PrecioUnitario.ToString();
                txt_precioCoste.Text = articulo.PrecioCoste.ToString();
                nud_stock.Value = int.Parse(articulo.Stock.ToString());
                nud_stockMinimo.Value = int.Parse(articulo.StockMinimo.ToString());
                cbx_marca.SelectedValue = articulo.CodigoMarca;
                cbx_ubicacion.SelectedValue = articulo.CodigoUbicacion;
                cbx_unidadDeMedida.SelectedValue = articulo.CodigoUnidadesDeMedida;
                txt_proveedor.Text = dgv_articulos.CurrentRow.Cells[9].Value.ToString();                
                cbx_categoria.SelectedValue =articulo.CodigoTipoArticulo;
                if (articulo.CodigoSub1TipoArticulo!=0)
                {
                    cbx_categoria1.SelectedValue = articulo.CodigoSub1TipoArticulo;
                }
                else
                {
                    cbx_categoria1.Refresh();
                }
                if (articulo.CodigoSub2TipoArticulo!=0)
                {
                    cbx_categoria2.SelectedValue = articulo.CodigoSub2TipoArticulo;
                }
                else
                {
                    cbx_categoria2.Refresh();
                }
                if (articulo.CodigoSub3TipoArticulo!=0)
                {
                    cbx_categoria3.SelectedValue = articulo.CodigoSub3TipoArticulo;
                }
                else
                {
                    cbx_categoria3.Refresh();
                }                
                btn_actualizar.Enabled = true;
                gb_articulo.Enabled = false;
                gb_actualizacion.Enabled = true;
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar un artículo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_precioUnitario.Text) == true)
            {
                MessageBox.Show(this, "Debe Ingresar el precio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (validar.campoVacio(txt_precioCoste.Text) == true)
                {
                    MessageBox.Show(this, "Debe Ingresar el precio de costo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (validar.campoVacio(nud_stock.Value.ToString()) == true)
                    {
                        MessageBox.Show(this, "Debe Ingresar el stock", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (validar.campoVacio(nud_stockMinimo.Value.ToString()) == true)
                        {
                            MessageBox.Show(this, "Debe Ingresar el stock mínimo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            float precio = float.Parse(txt_precioUnitario.Text, CultureInfo.InvariantCulture);
                            float costo = float.Parse(txt_precioCoste.Text, CultureInfo.InvariantCulture);
                            int stock = int.Parse(nud_stock.Value.ToString());

                            if (validar.campoVacio(txt_descripcion.Text) == true)
                                MessageBox.Show(this, "Debe Ingresar una descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (validar.campoVacio(txt_codigoDescripcion.Text) == true)
                                MessageBox.Show(this, "Debe Ingresar una código", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (!validar.decimalValido(txt_precioUnitario.Text))
                                MessageBox.Show(this, "Debe Ingresar el precio de manera correcta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (validar.mayorIgualCero(stock) == false)
                                MessageBox.Show(this, "El stock no puede ser negativo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (validar.mayor(costo, precio) == true)
                                MessageBox.Show(this, "El precio del artículo debe ser mayor al de costo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                            {
                                tomarCampos();
                                articulo.actualizarDatos(articulo);
                                borrarDatos();
                                cargarDataGridView();
                                gb_actualizacion.Enabled = false;
                                gb_articulo.Enabled = true;
                                MessageBox.Show(this, "Se ha modificado modificado correctamente el artículo", "ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }                        
                    }
                }
            }                                
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_actualizar.Enabled = false;
            gb_articulo.Enabled = true;
            gb_actualizacion.Enabled = false;
            txt_filtro.Text = "";
            cargarDataGridView();
            borrarDatos();
        }

        //EVENTOS

        private void nud_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void txt_precioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals('.'))
            {
                validar.soloNumeros(e);
            }            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string descripcion = txt.Text;
            List<ListaProveedoresArticulo> listaFiltrada = listaProveedoresArticulos.FindAll(a => a.Articulo.Descripcion.Contains(descripcion));
            cargarDataGridFiltrado(listaFiltrada);

        }

        private void cbx_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCategoria1();
            cargarCategoria2();
            cargarCategoria3();
        }

        private void cbx_categoria1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCategoria2();
            cargarCategoria3();
        }

        private void cbx_categoria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCategoria3();
        }
    }
}
