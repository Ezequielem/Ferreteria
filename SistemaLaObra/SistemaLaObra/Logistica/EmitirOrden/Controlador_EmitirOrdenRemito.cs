using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Drawing;

namespace SistemaLaObra.Logistica
{
    public class Controlador_EmitirOrdenRemito
    {
        //REFERENCIA
        public IU_EmitirOrdenRemito iu_emitirOrdenRemito;
        public IU_VistaPrevia vistaPrevia;
        public Image modeloRemito;
        
        //INSTANCIAS
        private List<Entrega> _entregaColeccion;
        private List<DetalleLogistica> _detalleLogistica;
        private Entrega _entrega;
        private DetalleLogistica _detalle;
        private Articulo _articulo;

        //PROPIEDADES

        public List<Entrega> EntregaColeccion
        {
            get
            {
                return _entregaColeccion;
            }

            set
            {
                _entregaColeccion = value;
            }
        }

        public List<DetalleLogistica> DetalleLogistica
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

        public Entrega Entrega
        {
            get
            {
                return _entrega;
            }

            set
            {
                _entrega = value;
            }
        }

        //CONSTRUCTOR
        public Controlador_EmitirOrdenRemito(IU_EmitirOrdenRemito iu_emitirOR)
        {
            iu_emitirOrdenRemito = iu_emitirOR;
            EntregaColeccion = new List<Entrega>();
            DetalleLogistica = new List<DetalleLogistica>();
            Entrega = new Entrega();
            _detalle = new DetalleLogistica();
            _articulo = new Articulo();           
        }

        //METODOS
        public void generarListadoEntrega()
        {
            EntregaColeccion = (from p in Entrega.mostrarDatosColeccion()
                                where p.CodigoEstadoEntrega == 1
                                select p).ToList();
        }

        public void seleccionPedidoIngresado(int numeroRemito)
        {

            foreach (var codigo in EntregaColeccion)
            {
                if (codigo.CodigoEntrega==numeroRemito)
                {
                    Entrega = codigo;
                }
            }
        }

        public void buscarDatoPedido()
        {
            DetalleLogistica = _detalle.mostrarDatos(Entrega.CodigoEntrega);
        }

        
        public void generarRemito(Entrega instaciaEntrega, List<DetalleLogistica> instanciaListaDetalle)
        {
            IU_VistaPrevia vistaPrevia = new IU_VistaPrevia();
            vistaPrevia.tomarModelo(modeloRemito, "Orden de Remito");
            vistaPrevia.generarRemito(instaciaEntrega, instanciaListaDetalle);
            vistaPrevia.ShowDialog();            
        }      
    }
}
