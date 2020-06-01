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
using System.Data.SqlTypes;
using System.Globalization;

namespace SistemaLaObra
{
    public partial class IU_RegistrarArticulo : Form
    {        
        private Validaciones validar;
        private Articulo articulo;
        private ListaProveedoresArticulo listaProveedoresArticulo;
        private TipoArticulo tipoArticulo;
        private Sub1TipoArticulo sub1TipoArticulo;
        private Sub2TipoArticulo sub2TipoArticulo;
        private Sub3TipoArticulo sub3TipoArticulo;
        private Proveedor proveedor;
        private Marca marca;
        private Ubicacion ubicacion;
        private UnidadDeMedida unidadDeMedida;

        public IU_RegistrarArticulo()
        {
            InitializeComponent();
            validar = new Validaciones();
            articulo = new Articulo();
            listaProveedoresArticulo = new ListaProveedoresArticulo();
            tipoArticulo = new TipoArticulo();
            sub1TipoArticulo = new Sub1TipoArticulo();
            sub2TipoArticulo = new Sub2TipoArticulo();
            sub3TipoArticulo = new Sub3TipoArticulo();
            proveedor = new Proveedor();
            marca = new Marca();
            ubicacion = new Ubicacion();
            unidadDeMedida = new UnidadDeMedida();
        }

                
        private void IU_RegistrarArticulo_Load(object sender, EventArgs e)
        {
            cargarProveedor();
            cargarMarca();
            cargarUnidadesDeMedida();
            cargarUbicaciones();
            cargarCategoria();
            cargarCategoria1(); 
            cargarCategoria2();
            cargarCategoria3();
        }

        //METODOS

        public void borrarCampos()
        {
            txt_descripcion.Text = "";
            txt_codigoDescripcion.Text = "";
            txt_precio.Text = "";
            txt_coste.Text = "";
            cbx_ubicacion.ResetText();
            cbx_marca.ResetText();
            cbx_unidadDeMedida.ResetText();
            cbx_categoria.ResetText();
            cbx_categoria1.ResetText();
            cbx_categoria2.ResetText();
            cbx_categoria3.ResetText();
            cbx_proveedor.ResetText();
            nud_stock.Value=0;
            nud_stockMinimo.Value=0;           
        }

        public void cargarProveedor()
        {            
            cbx_proveedor.ValueMember = "CodigoProveedor";
            cbx_proveedor.DisplayMember = "RazonSocial";
            cbx_proveedor.DataSource = proveedor.mostrarColeccionProveedores();
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
      
        private void tomarCampos()
        {
            articulo.Descripcion = txt_descripcion.Text;
            articulo.CodigoMarca = int.Parse(cbx_marca.SelectedValue.ToString());
            articulo.CodigoDescripcion = txt_codigoDescripcion.Text;
            articulo.PrecioUnitario = float.Parse(txt_precio.Text, CultureInfo.InvariantCulture);
            articulo.PrecioCoste = float.Parse(txt_coste.Text, CultureInfo.InvariantCulture);
            articulo.Stock = int.Parse(nud_stock.Value.ToString());
            articulo.StockMinimo = int.Parse(nud_stockMinimo.Value.ToString());
            articulo.CodigoUnidadesDeMedida = int.Parse(cbx_unidadDeMedida.SelectedValue.ToString());
            articulo.CodigoUbicacion =int.Parse(cbx_ubicacion.SelectedValue.ToString());
            articulo.CodigoTipoArticulo = int.Parse(cbx_categoria.SelectedValue.ToString());
            articulo.CodigoProveedor = int.Parse(cbx_proveedor.SelectedValue.ToString());
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

        private void tomarlistaProveedoresçarticulos()
        {
            listaProveedoresArticulo.CodigoArticulo = articulo.buscarUltimoCodigoArticulo();
            listaProveedoresArticulo.CodigoProveedor = articulo.CodigoProveedor;
            listaProveedoresArticulo.PrecioProveedor = articulo.PrecioCoste;
        }
       
        //BOTONES

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_descripcion.Text) == true)
                MessageBox.Show(this, "Debe Ingresar una descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validar.campoVacio(txt_precio.Text) == true)
                MessageBox.Show(this, "Debe Ingresar el precio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validar.campoVacio(txt_coste.Text) == true)
                MessageBox.Show(this, "Debe Ingresar el precio de costo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!validar.decimalValido(txt_precio.Text))
                MessageBox.Show(this, "No ha ingresado un precio válido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!validar.decimalValido(txt_coste.Text))
                MessageBox.Show(this, "No ha ingresado un precio de coste válido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
            else if (validar.mayor(float.Parse(txt_coste.Text, CultureInfo.InvariantCulture), float.Parse(txt_precio.Text, CultureInfo.InvariantCulture)) == true)
                MessageBox.Show(this, "El precio del artículo debe ser mayor al de costo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!validar.mayorACero(int.Parse(nud_stock.Value.ToString())))
                MessageBox.Show(this, "El stock debe ser mayor a cero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validar.mayor(int.Parse(nud_stockMinimo.Value.ToString()), int.Parse(nud_stock.Value.ToString())) == true)
                MessageBox.Show(this, "El stock debe ser mayor al stock mínimo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                tomarCampos();
                articulo.crear(articulo);
                tomarlistaProveedoresçarticulos();
                listaProveedoresArticulo.crear(listaProveedoresArticulo);               
                MessageBox.Show(this, "Se ha registrado correctamente el artículo", "ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                borrarCampos();
            }
        }

        //EVENTOS
        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals('.'))
            {
                validar.soloNumeros(e);
            }
        }

        private void txt_coste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals('.'))
            {
                validar.soloNumeros(e);
            }            
        }

        private void nud_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
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
