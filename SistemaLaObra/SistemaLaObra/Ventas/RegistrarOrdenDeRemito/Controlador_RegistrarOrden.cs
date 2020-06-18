using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SistemaLaObra.Ventas.RegistrarOrdenDeRemito;

namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    public class Controlador_RegistrarOrden
    {
        //REFERENCIA
        public IU_RegistrarOrden iu_registrarOrden1;
        public IU_RegistrarOrden_2 iu_registrarOrden2;
        public IU_RegistrarOrden_3 iu_registrarOrden3;
        public IU_RegistrarOrden_4 iu_registrarOrden4;
        public IU_DatosDialogo iu_datosDialogo;
        public IU_RegistrarVenta iu_registrarVenta;

        public Venta Venta { get; set; }
        public Provincia Provincia { get; set; }
        public Departamento Departamento { get; set; }
        public Localidad Localidad { get; set; }
        public Entrega Entrega { get; set; }
        public List<DetalleVP> DetalleVP { get; set; }
        public List<DetalleLogistica> DetalleLogistica { get; set; }
        public List<Entrega> EntregaColeccion { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public int IndiceEntrega { get; set; }
        public Controlador_Venta ControladorRV { get; set; }
        public Controlador_VentaMayorista ControladorRVM { get; set; }
        public ClienteMayorista ClienteMayorista { get; set; }
        public IU_MenuPrincipal InterfazContenedora { get; set; }

        public Controlador_RegistrarOrden(IU_RegistrarOrden interfazCargarDatos)
        {
            iu_registrarOrden1 = interfazCargarDatos;
            Venta = new Venta();
            Entrega = new Entrega();
            DetalleLogistica=new List<DetalleLogistica>();
            DetalleVP = new List<DetalleVP>();
            EntregaColeccion = new List<Entrega>();
            ClienteMayorista = new ClienteMayorista();
        }

        //METODOS

        public void nroVenta(Venta ventaInstanciada)
        {
            Venta.CodigoVenta = ventaInstanciada.CodigoVenta;           
        }

        public void cantidadEnvios(int CantidadDeEnvios)
        {
            for (int i = 0; i < CantidadDeEnvios; i++)
            {
                EntregaColeccion.Add(new Entrega() { CodigoEntrega = i + 1 });             
            }
        }

        public List<Provincia> mostrarSelecProvincia()
        {
            Provincia = new Provincia();    
            return Provincia.mostrarDatos();
        }

        public void provinciaEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public List<Departamento> mostrarSelecDepartamento(int codigoProvincia)
        {
            Provincia = new Provincia();
            return Provincia.conocerDepartamento(codigoProvincia);
        }

        public void departamentoEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public List<Localidad> mostrarSelecLocalidad(int codigoDepartamento)
        {
            Departamento = new Departamento();
            return Departamento.conocerLocalidad(codigoDepartamento);            
        }

        public void localidadEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void barrioEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void nombreClienteEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void domicilioEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public List<TipoTelefono> mostrarSelectTipoTelefono()
        {
            TipoTelefono = new TipoTelefono();
            return TipoTelefono.mostrarDatos();
        }

        public void tipoNroTelefonoEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void nroTelefonoEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void observacionEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void distanciaEnvio(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void fechaPorViaje(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void horaDesdePorViaje(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void horaHastaPorViaje(List<Entrega> listaEntregaInstanciada)
        {
            EntregaColeccion = listaEntregaInstanciada;
        }

        public void articuloPorViaje(int viaje, DetalleLogistica detalleLogisticaInstaciado, int indice)
        {
            EntregaColeccion[viaje].CodigoEntrega= viaje;
            DetalleLogistica[indice].Entrega.CodigoEntrega = EntregaColeccion[viaje].CodigoEntrega;
        }

        public void precioPorDistancia(float precio, int viaje)
        {
            EntregaColeccion[viaje].PrecioEntrega = precio;            
        }

        public bool verificarNroVenta()
        {
            if (Venta.existeVenta(Venta.CodigoVenta))
                return true;
            else
                return false;
        }

        public GMapRoute buscarRutaRecomendada(int viaje)
        {
            iu_registrarOrden4.listaDeMapas[viaje].Refresh();
            PointLatLng laObra = new PointLatLng(-31.4671849, -64.2239958);
            GDirections direccion = new GDirections();
            GeoCoderStatusCode status=new GeoCoderStatusCode();
            string hasta = EntregaColeccion[viaje].NombreCalle + ", " + EntregaColeccion[viaje].NumeroCalle + ", " + EntregaColeccion[viaje].NombreProvincia + ", Argentina";        
            var puntoFin = GMapProviders.GoogleMap.GetPoint(hasta, out status);
            if (puntoFin==null)
            {
                var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, laObra, laObra, false, false, false, false, false);
                GMapRoute rutaObtenida = new GMapRoute(direccion.Route, "Ruta");
                return rutaObtenida;
            }
            else
            {
                var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, laObra, puntoFin.Value, false, false, false, false, false);
                GMapRoute rutaObtenida = new GMapRoute(direccion.Route, "Ruta");
                return rutaObtenida;
            }                        
        }

        public int buscarUltimoNroEntrega()
        {
            return Entrega.mostrarUltimoNroEntrega();
        }

        public void generarOrdenPorViaje(int ultimaEntrega)
        {
            int numeroEntrega = ultimaEntrega+1;
            foreach (var viaje in EntregaColeccion)
            {
                viaje.Venta.CodigoVenta = Venta.CodigoVenta;
                viaje.crear(numeroEntrega, viaje.Venta.CodigoVenta, viaje.FechaEntrega, viaje.HoraEntregaDesde,
                    viaje.HoraEntregaHasta, viaje.NombreCliente, viaje.NombreProvincia, viaje.NombreDepartamento,
                    viaje.NombreLocalidad, viaje.NombreCalle, viaje.NumeroCalle.ToString(), viaje.CodigoPostal,
                    viaje.NombreBarrio, viaje.NombreTipoTelefono, viaje.NumeroTelefono, viaje.Descripcion,
                    viaje.PrecioEntrega, viaje.DistanciaEntrega, viaje.CodigoEstadoEntrega,
                    iu_registrarOrden1.InterfazContenedora.EncargadoActivo.CodigoEncargado);
                foreach (var item in DetalleLogistica)
                {
                    if (viaje.CodigoEntrega==item.Entrega.CodigoEntrega)
                    {
                        item.crearDetalleLogisticaEntrega(item.CodigoArticulo, item.Cantidad, numeroEntrega);
                    }
                }
                
                numeroEntrega++;
            }
        }

        //el controlador Registrar Orden tiene las listas de la venta minorista
        public void tomarVenta(Controlador_Venta controlador) 
        {
            ControladorRV = controlador;
            ControladorRVM = new Controlador_VentaMayorista();
        }

        //el controlador Registara Orden tiene las listas de la venta minorista
        public void tomarVenta(Controlador_VentaMayorista controlador)
        {
            ControladorRVM = controlador;
            ControladorRV = new Controlador_Venta();
        }

        public void tomarDetalleVenta(List<DetalleVP> detalleVPInstanciada )
        {
            DetalleVP = detalleVPInstanciada;
            foreach (var item in DetalleVP)
            {
                DetalleLogistica.Add(new DetalleLogistica() { CodigoArticulo=item.CodigoArticulo, Cantidad=item.Cantidad });
            }
        }

        //LLAMADA A INTERFACES

        public void interfazCargarFechaHora()
        {
            iu_registrarOrden2=new IU_RegistrarOrden_2(this);
            //creo lo soluciono al tema del dialogo mandandole como referencia la interfaz anterior                                   
            iu_registrarOrden2.ShowDialog(iu_registrarOrden1);
        }

        public void interfazCargarArticulosPorViaje()
        {
            iu_registrarOrden3=new IU_RegistrarOrden_3(this);
            //creo lo soluciono al tema del dialogo mandandole como referencia la interfaz anterior 
            iu_registrarOrden3.ShowDialog(iu_registrarOrden2);
        }

        public void interfazCargarPrecioYRuta()
        {
            iu_registrarOrden4=new IU_RegistrarOrden_4(this);
            //creo lo soluciono al tema del dialogo mandandole como referencia la interfaz anterior 
            iu_registrarOrden4.InterfazContenedora = InterfazContenedora;
            iu_registrarOrden4.ShowDialog(iu_registrarOrden3);
        }

        public void interfazCargarDireccion(string nombreBoton)
        {
            IndiceEntrega = int.Parse(nombreBoton.Remove(0,9));
             iu_datosDialogo = new IU_DatosDialogo(this);
            iu_datosDialogo.ShowDialog();
        }

        public void cargarDatosAInterfaz()
        {
            iu_registrarOrden1.lbl_viaje[IndiceEntrega].Text = 
                EntregaColeccion[IndiceEntrega].NombreCliente
                +", "
                +EntregaColeccion[IndiceEntrega].NombreCalle
                +" "
                +EntregaColeccion[IndiceEntrega].NumeroCalle
                +", "
                +EntregaColeccion[IndiceEntrega].NombreBarrio
                ;
            verificarTodosDatosCargados();
        }

        private void verificarTodosDatosCargados()
        {
            foreach (var viajes in EntregaColeccion)
            {
                if (viajes.NombreCliente=="")
                {
                    iu_registrarOrden1.btn_siguiente.Enabled = false;
                    break;
                }
                else
                {
                    iu_registrarOrden1.btn_siguiente.Enabled = true;
                }
            }
        }

        public bool verificarExistenciaEntrega(int codigoVenta)
        {
            if (Venta.existeEntregaAsignada(codigoVenta)==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void registrarEntregas(int codigoVenta)
        //{
        //    Entrega entrega = new Entrega();
        //    DetalleLogistica detalleLogistica = new DetalleLogistica();
        //    foreach (var item in EntregaColeccion)
        //    {
        //        item.CodigoEntrega = entrega.mostrarUltimoNroEntrega() + 1;
        //        entrega.crear(item.CodigoEntrega, codigoVenta, item.FechaEntrega, item.HoraEntregaDesde,
        //            item.HoraEntregaHasta, item.NombreCliente, item.NombreProvincia, item.NombreDepartamento,
        //            item.NombreLocalidad, item.NombreCalle, item.NumeroCalle.ToString(), item.CodigoPostal,
        //            item.NombreBarrio, item.NombreTipoTelefono, item.NumeroTelefono, item.Descripcion,
        //            item.PrecioEntrega, item.DistanciaEntrega, item.CodigoEstadoEntrega, item.CodigoEncargado);

        //        foreach (var itemLogistica in DetalleLogistica)
        //        {
        //            detalleLogistica.crearDetalleLogisticaEntrega(itemLogistica.CodigoArticulo, itemLogistica.Cantidad, item.CodigoEntrega);
        //        }
        //    }
        //}
    }
}
