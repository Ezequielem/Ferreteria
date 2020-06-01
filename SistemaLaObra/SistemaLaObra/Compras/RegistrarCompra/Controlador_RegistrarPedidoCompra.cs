using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SistemaLaObra.Compras.RegistrarCompra
{
    public class Controlador_RegistrarPedidoCompra
    {
        public Articulo articulo;
        private ListaProveedoresArticulo _listaProveedoresArticulo;
        private Compra _compra;        
        private List<DetalleCompra> _detalleCompra;
        private Recepcion _recepcion;
        private List<DetalleLogistica> _detalleLogistica;
        private IU_RegistrarPedidoCompra _interfazPedidoCompra;
        private IU_VistaPrevia _interfazVistaPrevia;
        private Image modeloPedido;

        public Controlador_RegistrarPedidoCompra(IU_RegistrarPedidoCompra interfaz)
        {
            _interfazPedidoCompra = interfaz;
            _interfazVistaPrevia=new IU_VistaPrevia();
            articulo = new Articulo();
            _listaProveedoresArticulo = new ListaProveedoresArticulo();
            _compra = new Compra();
            _detalleCompra = new List<DetalleCompra>();
            _recepcion = new Recepcion();            
            _detalleLogistica = new List<DetalleLogistica>();
            modeloPedido = Properties.Resources.ModeloPedido;
        }

        //METODOS
        public void seleccionArticulo(int codigoArticulo)
        {
            //Este codigo permite agregar filas y no repetir articulos con el mismo codigoDescripcion
            articulo.CodigoArticulo = codigoArticulo;
            articulo.mostrarDatos(codigoArticulo);
            if (_interfazPedidoCompra.dgv_listaArticulos.Rows.Count==0)
            {
                _interfazPedidoCompra.dgv_listaArticulos.Rows.Add(articulo.CodigoDescripcion,
                                                                articulo.Descripcion,
                                                                articulo.PrecioUnitario,
                                                                articulo.Stock,
                                                                articulo.StockMinimo,
                                                                articulo.PrecioCoste,
                                                                null,
                                                                "Deseleccionar",
                                                                "1"
                                                                );
                _interfazPedidoCompra.cargarProveedores(_interfazPedidoCompra.dgv_listaArticulos.RowCount - 1);
                _detalleCompra.Add(new DetalleCompra() { CodigoArticulo=articulo.CodigoArticulo, PrecioCoste=articulo.PrecioCoste, Cantidad=1});
                actualizarSaldoCompra(); 
            }
            else
            {
                int b = 0;
                foreach (var item in _detalleCompra)
                {
                    if (item.CodigoArticulo==articulo.CodigoArticulo)
                    {
                        b = 1;
                    }
                }
                if (b==0)
                {
                    _interfazPedidoCompra.dgv_listaArticulos.Rows.Add(articulo.CodigoDescripcion,
                                                                articulo.Descripcion,
                                                                articulo.PrecioUnitario,
                                                                articulo.Stock,
                                                                articulo.StockMinimo,
                                                                articulo.PrecioCoste,
                                                                null,
                                                                "Deseleccionar",
                                                                "1"
                                                                );
                    _interfazPedidoCompra.cargarProveedores(_interfazPedidoCompra.dgv_listaArticulos.RowCount - 1);
                    _detalleCompra.Add(new DetalleCompra() { CodigoArticulo = articulo.CodigoArticulo, PrecioCoste=articulo.PrecioCoste, Cantidad=1 });
                    actualizarSaldoCompra();
                }
            }                        
        }
        
        public void deseleccionArticulo(int indice)
        {
            _detalleCompra.RemoveAt(indice);
            _interfazPedidoCompra.dgv_listaArticulos.Rows.RemoveAt(indice);
            actualizarSaldoCompra();
        }

        public void seleccionCantidad(int cantidad, int indiceDetalleCompra)
        {
            _detalleCompra[indiceDetalleCompra].Cantidad = cantidad;
            actualizarSaldoCompra();
        }

        public void seleccionProveedor(int codigoProveedor, int indiceDetalleCompra)
        {
            _detalleCompra[indiceDetalleCompra].CodigoProveedor = codigoProveedor;
        }

        public void seleccionPrecioCoste(int codigoProveedor, int indiceDetalle)
        {
            float precioCoste = 0f;
            precioCoste=_listaProveedoresArticulo.mostrarPrecioCoste(codigoProveedor, _detalleCompra[indiceDetalle].CodigoArticulo);
            _detalleCompra[indiceDetalle].PrecioCoste = precioCoste;
            _interfazPedidoCompra.dgv_listaArticulos.Rows[indiceDetalle].Cells[5].Value = precioCoste.ToString();
            actualizarSaldoCompra();
        }

        public void nuevoRegistroPedido()
        {
            if (_detalleCompra.Count == 0)
            {
                _interfazPedidoCompra.mostrarMensajeErrorListaVacia();
            }
            else
            {
                int b = 0;
                foreach (var item in _detalleCompra)
                {
                    if (item.Cantidad == 0)
                    {
                        b = 1;
                    }
                    else if (item.CodigoProveedor == 0)
                    {
                        b = 1;
                    }
                }
                if (b == 0)
                {
                    //REGISTRO MASIVO
                    registrarCompra();
                    registrarDetalleCompra();
                    registrarRecepcion();
                    registrarDetalleLogistica();

                    //VISTA PREVIA
                    _interfazVistaPrevia.tomarModelo(modeloPedido, "Orden de compra");
                    _interfazVistaPrevia.generarPedido(_compra, _detalleCompra);
                    _interfazVistaPrevia.ShowDialog();
                    //Mensaje confirmacion
                    _interfazPedidoCompra.mostrarMensajeConfirmacion();
                }
                else
                {
                    //Mensaje error
                    _interfazPedidoCompra.mostrarMensajeErrorCampos();
                }
            }                 
        }

        public void seleccionDescripcionArticulo(string descripcion)
        {
            completar_dgvListaArticulos(descripcion);
        }

        public void completar_dgvListaArticulos(string descripcion)
        {
            _interfazPedidoCompra.dgv_aSeleccionar.Rows.Clear();

            List<int> codigoArticulos = new List<int>();
            codigoArticulos = articulo.buscarListaDeArticulos(descripcion);
            foreach (var item in codigoArticulos)
            {

                articulo.mostrarDatos(item);
                _interfazPedidoCompra.dgv_aSeleccionar.Rows.Add(articulo.CodigoDescripcion,
                                                                articulo.Descripcion,
                                                                articulo.mostrarMarca(articulo),
                                                                articulo.mostrarUbicacion(articulo),
                                                                articulo.PrecioUnitario,
                                                                articulo.Stock,
                                                                articulo.StockMinimo,                                                                                                                                
                                                                "seleccionar",
                                                                articulo.CodigoArticulo);
            }
        }
        
        private void registrarCompra()
        {
            _compra.CodigoCompra = _compra.ultimoCodigoDeCompra() + 1;
            _compra.FechaHora = DateTime.Now;
            _compra.ImporteTotal = _compra.calcularImporteTotal(_detalleCompra);
            _compra.CodigoEncargadoCompra = _interfazPedidoCompra.InterfazContenedora.EncargadoActivo.CodigoEncargado;
            _compra.crear(_compra);
        }

        private void registrarDetalleCompra()
        {
            foreach (var item in _detalleCompra)
            {
                item.CodigoCompra = _compra.CodigoCompra;
                item.crear(item);
            }
        }

        private void registrarRecepcion()
        {
            _recepcion.CodigoRecepcion = _recepcion.ultimoCodigoRecepcion() + 1;
            _recepcion.FechaHoraRecepcion = DateTime.Now;
            _recepcion.CodigoEstadoRecepcion = 1;
            _recepcion.CodigoCompra = _compra.CodigoCompra;
            _recepcion.crear(_recepcion);
        }

        private void registrarDetalleLogistica()
        {
            foreach (var item in _detalleCompra)
            {
                _detalleLogistica.Add(new DetalleLogistica() {
                                                                CodigoArticulo=item.CodigoArticulo,
                                                                Cantidad=item.Cantidad,
                                                                CantidadRecibida=0,
                                                                CodigoRecepcion=_recepcion.CodigoRecepcion,
                                                                CodigoProveedor=item.CodigoProveedor
                                                            });
            }
            foreach (var item in _detalleLogistica)
            {
                item.CodigoRecepcion = _recepcion.CodigoRecepcion;
                item.crearDetalleLogisticaRecepcion(item.CodigoArticulo, item.Cantidad, item.CantidadRecibida, item.CodigoRecepcion, item.CodigoProveedor);
            }
        }

        private void actualizarSaldoCompra()
        {
            float saldo = 0f;
            foreach (var item in _detalleCompra)
            {
                saldo += item.PrecioCoste*item.Cantidad;
            }
            _interfazPedidoCompra.lbl_saldoCompra.Text = saldo.ToString("$ 0.00");
        }
    }    
}
