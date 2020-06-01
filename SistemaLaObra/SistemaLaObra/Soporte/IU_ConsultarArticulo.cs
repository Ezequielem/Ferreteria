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

namespace SistemaLaObra
{
    public partial class IU_ConsultarArticulo : Form
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

        public IU_ConsultarArticulo()
        {
            InitializeComponent();
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

        private void IU_ConsultarArticulo_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
        }

        //METODOS

        private void cargarDataGridView()
        {
            listaProveedoresArticulos.Clear();
            listaProveedoresArticulos = listaProveedoresArticulo.mostrarDatos();
            dgv_articulos.Rows.Clear();
            foreach (var item in listaProveedoresArticulos)
            {                
                dgv_articulos.Rows.Add(
                    item.Articulo.Descripcion, 
                    marca.mostrarDatos(item.Articulo.CodigoMarca).Descripcion,
                    item.Articulo.CodigoDescripcion, 
                    item.Articulo.PrecioUnitario.ToString("$ 0.00"),
                    item.PrecioProveedor.ToString("$ 0.00"),
                    item.Articulo.Stock,
                    item.Articulo.StockMinimo,
                    unidadDeMedida.mostrarDatos(item.Articulo.CodigoUnidadesDeMedida).Descripcion,
                    ubicacion.mostrarDatos(item.Articulo.CodigoUbicacion).Descripcion,
                    proveedor.obtenerDatosProveedor(item.CodigoProveedor).RazonSocial,
                    tipoArticulo.mostrarDatos(item.Articulo.CodigoTipoArticulo).Descripcion,
                    sub1TipoArticulo.mostrarDatos(item.Articulo.CodigoSub1TipoArticulo).Descripcion,
                    sub2TipoArticulo.mostrarDatos(item.Articulo.CodigoSub2TipoArticulo).Descripcion,
                    sub3TipoArticulo.mostrarDatos(item.Articulo.CodigoSub3TipoArticulo).Descripcion,
                    item.CodigoArticulo
                    );
                limpiarObjetos();
            }                        
        }

        private void cargarDataGridFiltrado(List<ListaProveedoresArticulo> lista)
        {
            dgv_articulos.Rows.Clear();
            foreach (var item in lista)
            {                
                dgv_articulos.Rows.Add(
                    item.Articulo.Descripcion,
                    marca.mostrarDatos(item.Articulo.CodigoMarca).Descripcion,
                    item.Articulo.CodigoDescripcion,
                    item.Articulo.PrecioUnitario.ToString("$ 0.00"),
                    item.PrecioProveedor.ToString("$ 0.00"),
                    item.Articulo.Stock,
                    item.Articulo.StockMinimo,
                    unidadDeMedida.mostrarDatos(item.Articulo.CodigoUnidadesDeMedida).Descripcion,
                    ubicacion.mostrarDatos(item.Articulo.CodigoUbicacion).Descripcion,
                    proveedor.obtenerDatosProveedor(item.CodigoProveedor).RazonSocial,
                    tipoArticulo.mostrarDatos(item.Articulo.CodigoTipoArticulo).Descripcion,
                    sub1TipoArticulo.mostrarDatos(item.Articulo.CodigoSub1TipoArticulo).Descripcion,
                    sub2TipoArticulo.mostrarDatos(item.Articulo.CodigoSub2TipoArticulo).Descripcion,
                    sub3TipoArticulo.mostrarDatos(item.Articulo.CodigoSub3TipoArticulo).Descripcion,
                    item.CodigoArticulo
                    );
                limpiarObjetos();
            }
        }

        private void limpiarObjetos()
        {
            tipoArticulo.CodigoTipoArticulo=0;
            tipoArticulo.Descripcion="";
            sub1TipoArticulo.CodigoSub1TipoArticulo = 0;
            sub1TipoArticulo.Descripcion = "";
            sub2TipoArticulo.CodigoSub2TipoArticulo=0;
            sub2TipoArticulo.Descripcion="";
            sub3TipoArticulo.CodigoSub3TipoArticulo=0;
            sub3TipoArticulo.Descripcion="";
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            IU_RegistrarArticulo interfaz = new IU_RegistrarArticulo();
            interfaz.ShowDialog();
            cargarDataGridView();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            IU_ActualizarArticulo interfaz = new IU_ActualizarArticulo();
            interfaz.tomarArticulo(int.Parse(dgv_articulos.CurrentRow.Cells[14].Value.ToString()));
            interfaz.ShowDialog();
            cargarDataGridView();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENTOS

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string descripcion = txt.Text;            
            List<ListaProveedoresArticulo> listaFiltrada = listaProveedoresArticulos.FindAll(a => a.Articulo.Descripcion.Contains(descripcion));
            cargarDataGridFiltrado(listaFiltrada);
        }
    }
}
