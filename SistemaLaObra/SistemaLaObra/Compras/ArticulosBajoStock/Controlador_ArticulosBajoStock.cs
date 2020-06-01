using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLaObra;
using SistemaLaObra.Compras.ArticulosBajoStock;
using SistemaLaObra.Compras.RegistrarCompra;
using System.Drawing;

namespace SistemaLaObra.Compras.ArticulosBajoStock
{

    public class AriculoSeleccionado
    {
        public string codigoArticulo="";
        public string descripcion="";
        public string proveedor="";
        public string precioCoste="";
        public string stock="";

    }

    public class Controlador_ArticulosBajoStock
    {
        //INSTANCIAS

        public Articulo articulo;
        public IU_ArticulosBajoStock interfaz;
        public List<Articulo> listaArticulos;
        IU_RegistrarPedidoCompra interfazPedidoCompra;
        public List<ListaProveedoresArticulo> listaProveedoresArticulo;
        private Image modeloListado;
        private IU_VistaPrevia vistaPrevia;
        public AriculoSeleccionado articuloSeleccionado;
        List<AriculoSeleccionado> _ariculoSeleccionados;
        public Encargado encargado;

        public IU_VistaPrevia VistaPrevia
        {
            get
            {
                return vistaPrevia;
            }
            set
            {
                value = vistaPrevia;
            }
        }

        public Controlador_ArticulosBajoStock()
        {

            articuloSeleccionado = new AriculoSeleccionado();
            _ariculoSeleccionados = new List<AriculoSeleccionado>();
            articulo = new Articulo();
            vistaPrevia = new IU_VistaPrevia();
            modeloListado = SistemaLaObra.Properties.Resources.Modelo_BajoStock;
            encargado = new Encargado();
         
         
        }

     

        //METODOS

        public void stockMinimoTomado(int stock)
        {
            articulo.StockMinimo = stock;
        }

        public void verificarArticulosBajoStockManual(IU_ArticulosBajoStock inter)
        {
            _ariculoSeleccionados.Clear();
            interfaz = inter;
            listaArticulos = articulo.mostrarArticulosBajoStockManual(articulo.StockMinimo);

            if (listaArticulos.Count == 0)
                interfaz.mensaje("No se encontró ningún articulo por debajo del stock minimo ingresado");
            else
            {
                foreach (var item in listaArticulos)
                {
                    int codigoP = articulo.buscarCodigoProveedor(item.CodigoArticulo);
                    string nombreP = articulo.buscarNombreProveedor(codigoP);
                    interfaz.dgv_articulosBajoStock.Rows.Add(item.CodigoArticulo, item.Descripcion, item.PrecioUnitario, item.PrecioCoste, item.Stock, item.StockMinimo, nombreP);

                    _ariculoSeleccionados.Add(new AriculoSeleccionado
                    {
                        codigoArticulo = item.CodigoArticulo.ToString(),
                        descripcion = item.Descripcion,
                        proveedor = nombreP,
                        precioCoste= item.PrecioCoste.ToString(),
                        stock=item.Stock.ToString()
                    });

              
             
                }
            }   
        }

        public void verificarArticulosBajoStock(IU_ArticulosBajoStock inter)
        {
            _ariculoSeleccionados.Clear();
            interfaz = inter;
            listaArticulos = articulo.mostrarArticulosBajoStock();

                foreach (var item in listaArticulos)
                {
                    int codigoP = articulo.buscarCodigoProveedor(item.CodigoArticulo);
                    string nombreP = articulo.buscarNombreProveedor(codigoP);
                    interfaz.dgv_articulosBajoStock.Rows.Add(item.CodigoArticulo, item.Descripcion, item.PrecioUnitario, item.PrecioCoste, item.Stock, item.StockMinimo, nombreP);

                _ariculoSeleccionados.Add(new AriculoSeleccionado
                {
                    codigoArticulo = item.CodigoArticulo.ToString(),
                    descripcion = item.Descripcion,
                    proveedor = nombreP,
                    precioCoste = item.PrecioCoste.ToString(),
                    stock = item.Stock.ToString()
                });
            }
        } 

        public void generarPedidoDeCompra(List<Articulo> listaArticulo, List<ListaProveedoresArticulo> listaProveedor)
        {
            interfazPedidoCompra = new IU_RegistrarPedidoCompra();
            interfazPedidoCompra.InterfazContenedora = interfaz.InterfazContenedora;
            interfazPedidoCompra.opcionGenerarPedidoDeCompra(listaArticulo, listaProveedor);

            /////Agregado por Eze/////////////            
            interfaz.Close();
            interfazPedidoCompra.ShowDialog();
            //////////////////////////////////
        }

        public void opcionImprimir()
        {
            //VISTA PREVIA
            VistaPrevia.tomarModelo(modeloListado, "Articulos Bajo Stock");
            VistaPrevia.generarArticulosBajoStock(_ariculoSeleccionados, this);
            vistaPrevia.ShowDialog();


        }



    }
}
