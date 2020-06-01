using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Logistica.ActualizarEstadoOrden
{
    class Controlador_ActualizarEstadoRemito
    {
        //REFERENCIAS
        public IU_ActualizarEstadoRemito iu_actualizarEstadoOrdenRemito;

        //INSTANCIAS
        private List<Entrega> _entregaColeccion;
        private List<int> _codigoEntrega;
        private Entrega _entrega;

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

        public List<int> CodigoEntrega
        {
            get
            {
                return _codigoEntrega;
            }

            set
            {
                _codigoEntrega = value;
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
        public Controlador_ActualizarEstadoRemito(IU_ActualizarEstadoRemito iu_actualizarEstadoOR)
        {
            iu_actualizarEstadoOrdenRemito = iu_actualizarEstadoOR;
            EntregaColeccion = new List<Entrega>();
            CodigoEntrega = new List<int>();
            Entrega = new Entrega();
        }

        //METODOS PUBLICOS
        public void buscarEntregasPendientes()
        {
            EntregaColeccion = (from p in Entrega.mostrarDatosColeccion()
                                orderby p.CodigoEstadoEntrega ascending
                                select p).ToList();
        }

        public void entregasPendientesSeleccionadas(int codigo)
        {
                CodigoEntrega.Add(codigo);          
        }

        public void entregasPendientesDeseleccionadas(int codigo)
        {
            CodigoEntrega.Remove(codigo);
        }

        public void actualizarEstadoEntrega()
        {
            foreach (var item in CodigoEntrega)
            {
                if (Entrega.mostrarEstadoEntrega(item) ==1)
                {
                    Entrega.actualizarEstadoEntrega(item, 3, iu_actualizarEstadoOrdenRemito.InterfazContenedora.EncargadoActivo.CodigoEncargado);
                }
                else
                {
                    Entrega.actualizarEstadoEntrega(item, 1, iu_actualizarEstadoOrdenRemito.InterfazContenedora.EncargadoActivo.CodigoEncargado);
                }                
            }
            CodigoEntrega.Clear();
        }
    }
}
