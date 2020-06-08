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
    public partial class IU_DetalleArticulo : Form
    {
        public Articulo Articulo { get; set; }

        public IU_DetalleArticulo()
        {
            InitializeComponent();
            Articulo = new Articulo();
        }

        public void opcionDetalle(int id)
        {
            Articulo.mostrarDatos(id);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
            txt_codigoArticulo.Text = Articulo.CodigoArticulo.ToString();
            txt_descripcion.Text = Articulo.Descripcion;
            txt_codigoDescripcion.Text = Articulo.CodigoDescripcion;
            txt_precioUnitario.Text = "$ " + Articulo.PrecioUnitario.ToString();
            txt_precioCosto.Text = "$ " + Articulo.PrecioCoste.ToString();
            txt_stock.Text = Articulo.Stock.ToString();
            txt_stockMinimo.Text = Articulo.StockMinimo.ToString();
            txt_marca.Text = Articulo.buscarNombreMarca(Articulo.CodigoMarca);
            txt_ubicacion.Text = Articulo.mostrarUbicacion(Articulo);
            txt_unidadMedida.Text = Articulo.buscarNombreUdadMedida(Articulo.CodigoUnidadesDeMedida);
            txt_tipoArticulo.Text = Articulo.buscarNombreTipoArticulo(Articulo.CodigoTipoArticulo);
            txt_sub1.Text = Articulo.buscarNombreSubTipo1(Articulo.CodigoSub1TipoArticulo);
            txt_sub2.Text = Articulo.buscarNombreSubTipo2(Articulo.CodigoSub2TipoArticulo);
            txt_sub3.Text = Articulo.buscarNombreSubTipo3(Articulo.CodigoSub3TipoArticulo);
            txt_proveedor.Text = Articulo.buscarNombreProveedor(Articulo.CodigoProveedor);
        }

        private void IU_DetalleArticulo_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
