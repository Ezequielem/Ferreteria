using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLaObra.Logistica.RegistrarIngresoDeProducto;

namespace SistemaLaObra.Logistica.RegistrarIngresoDeProducto
{
    class Controlador_RegistrarIngresoDeProducto
    {
        //INSTANCIAS
        Articulo _articulo;
        Recepcion _recepcion;
        DetalleLogistica _detalleLogistica;
        List<Recepcion> _listadoRecepcion;
        IU_RegistroIngresoProducto interfazRP;
        List<DetalleLogistica> _listadoDetalle;


        int i = 0;

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

        public Recepcion Recepcion
        {
            get
            {
                return _recepcion;
            }

            set
            {
                _recepcion = value;
            }
        }

        public DetalleLogistica DetalleLogistica
        {
            get
            {
                return _detalleLogistica;
            }

            set
            {
                _detalleLogistica = value;
            }
        }

        public List<Recepcion> ListadoRecepcion
        {
            get
            {
                return _listadoRecepcion;
            }

            set
            {
                _listadoRecepcion = value;
            }
        }

        public List<DetalleLogistica> ListadoDetalle
        {
            get
            {
                return _listadoDetalle;
            }

            set
            {
                _listadoDetalle = value;
            }
        }

        public Controlador_RegistrarIngresoDeProducto()
        {
            Articulo = new Articulo();
            Recepcion = new Recepcion();
           DetalleLogistica= new DetalleLogistica();
            ListadoDetalle = new List<DetalleLogistica>();
        }

        public void cantidadSeleccionada(int cantidadIngresada)
        {

            DetalleLogistica.CantidadRecibida = cantidadIngresada;

            if (ListadoDetalle.ElementAt(i).CantidadRecibida > 0)
            {
                int cantidadAnterior = ListadoDetalle.ElementAt(i).CantidadRecibida;
                if (cantidadIngresada == ListadoDetalle.ElementAt(i).CantidadRecibida)
                {
                    cantidadIngresada = 0;
                    ListadoDetalle.ElementAt(i).CantidadRecibida = cantidadIngresada;
                    i++;
                }
                else
                {
                    ListadoDetalle.ElementAt(i).CantidadRecibida = cantidadIngresada - ListadoDetalle.ElementAt(i).CantidadRecibida;
                    i++;
                }
            }
            else
            {
                ListadoDetalle.ElementAt(i).CantidadRecibida = cantidadIngresada;
                i++;
            }
           
        }

        public void codigoDetalleLogisticoTomado(int codigoDetalle)
        {
            DetalleLogistica.CodigoDetalleLogistica = codigoDetalle;
        }

        public void buscarListadoPedido(IU_RegistroIngresoProducto interfaz)
        {
            interfazRP = interfaz;
            ListadoRecepcion = Recepcion.mostrarColeccionRecepciones();

                string descripcionEstado = "";
               
                 foreach (var item in ListadoRecepcion)
                  {

                    descripcionEstado = Recepcion.conocerDescripcionEstado(item.CodigoEstadoRecepcion);

                    interfazRP.dgv_ListadoRecepcion.Rows.Add(item.CodigoRecepcion, item.FechaHoraRecepcion, descripcionEstado, item.CodigoCompra, "Seleccionar");
            }
        }

        public void pedidoSeleccionado(int codigo)
        {
            string nombreProveedor = "";
            string nombreArticulo = "";
            ListadoDetalle = DetalleLogistica.mostrarDatosDetalle(codigo);

            foreach (var item in ListadoDetalle)
            {
                nombreProveedor = DetalleLogistica.buscarNombreProveedor(item.CodigoProveedor);
                nombreArticulo = DetalleLogistica.buscarNombreArticulo(item.CodigoArticulo);
                interfazRP.dgv_detallePedido.Rows.Add(item.CodigoDetalleLogistica, nombreArticulo, item.Cantidad, item.CantidadRecibida, nombreProveedor);
            }
            interfazRP.btn_confirmar.Enabled = true;
        }

        public void confirmacionPedido(int codigo)
        {
            DetalleLogistica.actualizarDatos();
        }


        public void actualizarEstadoRecepcion(int codigo)
        {
            DetalleLogistica.actualizarEstadoRecepcion(codigo);
        }


        public void actualizarStock()
        {
            foreach (var item in ListadoDetalle)
            {      
                int codigoArticulo = item.CodigoArticulo;
                int cantidadRecibida = item.CantidadRecibida;
                Articulo.aumentarStock(cantidadRecibida, codigoArticulo);
                i = 0;
            }
        }
    }
}
