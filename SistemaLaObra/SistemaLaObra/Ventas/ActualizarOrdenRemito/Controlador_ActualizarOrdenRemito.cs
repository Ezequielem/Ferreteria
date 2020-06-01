using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Ventas.ActualizarOrdenRemito
{
    public class Controlador_ActualizarOrdenRemito
    {
        //INSTANCIAS
        private Articulo _articulo;
        private Venta _venta;
        private List<DetalleVP> _detalleVenta;
        private Entrega _entrega;
        private Entrega _entregaActualizacion;
        private List<Entrega> _listaEntregas;
        private List<Entrega> _listaEntregasActualizacion;
        private List<DetalleLogistica> _detalleLogistica;
        private List<DetalleLogistica> _detalleLogisticaActualizacion;
        private Provincia _provincia;
        private Departamento _departamento;
        private Localidad _localidad;
        private TipoTelefono _tipoTelefono;
        IU_ActualizarOrdenRemito iu_actualizarOrdenDeRemito;
        IU_ActualizarOrdenDeRemito1 iU_ActualizarOrdenDeRemito1;

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

        public Venta Venta
        {
            get
            {
                return _venta;
            }

            set
            {
                _venta = value;
            }
        }

        public List<DetalleVP> DetalleVenta
        {
            get
            {
                return _detalleVenta;
            }

            set
            {
                _detalleVenta = value;
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

        public Entrega EntregaActualizacion
        {
            get
            {
                return _entregaActualizacion;
            }

            set
            {
                _entregaActualizacion = value;
            }
        }

        public List<Entrega> ListaEntregas
        {
            get
            {
                return _listaEntregas;
            }

            set
            {
                _listaEntregas = value;
            }
        }

        public List<Entrega> ListaEntregasActualizacion
        {
            get
            {
                return _listaEntregasActualizacion;
            }

            set
            {
                _listaEntregasActualizacion = value;
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

        public List<DetalleLogistica> DetalleLogisticaActualizacion
        {
            get
            {
                return _detalleLogisticaActualizacion;
            }

            set
            {
                _detalleLogisticaActualizacion = value;
            }
        }

        public Provincia Provincia
        {
            get
            {
                return _provincia;
            }

            set
            {
                _provincia = value;
            }
        }

        public Departamento Departamento
        {
            get
            {
                return _departamento;
            }

            set
            {
                _departamento = value;
            }
        }

        public Localidad Localidad
        {
            get
            {
                return _localidad;
            }

            set
            {
                _localidad = value;
            }
        }

        public TipoTelefono TipoTelefono
        {
            get
            {
                return _tipoTelefono;
            }

            set
            {
                _tipoTelefono = value;
            }
        }

        public Controlador_ActualizarOrdenRemito(IU_ActualizarOrdenRemito interfaz)
        {
            iu_actualizarOrdenDeRemito = interfaz;
            Articulo = new Articulo();
            Venta = new Venta();
            DetalleVenta = new List<DetalleVP>();
            Entrega = new Entrega();
            EntregaActualizacion = new Entrega();
            ListaEntregas = new List<Entrega>();
            DetalleLogistica = new List<DetalleLogistica>();
            Provincia = new Provincia();
            Departamento = new Departamento();
            Localidad = new Localidad();
            TipoTelefono = new TipoTelefono();
        }

        //METODOS

        public void numeroDeVenta(int codigoVenta)
        {
            Venta.CodigoVenta = codigoVenta;
        }

        public bool buscarVenta()
        {
            if (Venta.existeVenta(Venta.CodigoVenta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void buscarEntrega()
        {
            if (Venta.existeEntregaAsignada(Venta.CodigoVenta))
            {
                ListaEntregas = Entrega.mostrarDatos(Venta.CodigoVenta).Where(x => x.CodigoEstadoEntrega==1).ToList();
                iu_actualizarOrdenDeRemito.ListaEntrega = ListaEntregas;
            }
            else
            {
                ListaEntregas.Clear();
                iu_actualizarOrdenDeRemito.ListaEntrega.Clear();
            }
        }

        public void entregaSeleccionada(Entrega entregaInstanciada)
        {
            Entrega = entregaInstanciada;
            EntregaActualizacion.CodigoEntrega = Entrega.CodigoEntrega;
            EntregaActualizacion.NombreCliente = Entrega.NombreCliente;
            EntregaActualizacion.PrecioEntrega = Entrega.PrecioEntrega;
            EntregaActualizacion.Venta.CodigoVenta = Venta.CodigoVenta;
        }

        public void mostrarInterfazDatos()
        {
            iU_ActualizarOrdenDeRemito1 = new IU_ActualizarOrdenDeRemito1(this);
            iU_ActualizarOrdenDeRemito1.InterfazContenedora = iu_actualizarOrdenDeRemito.InterfazContenedora;
            iU_ActualizarOrdenDeRemito1.ShowDialog();
        }

        public void calcularDiferenciaPrecios()
        {
            float diferenciaDeDistancia = EntregaActualizacion.DistanciaEntrega - Entrega.DistanciaEntrega;
            if (diferenciaDeDistancia>0)
            {
                //por aca va la venta
                if (diferenciaDeDistancia>0&&diferenciaDeDistancia<=7)
                {
                    EntregaActualizacion.PrecioEntrega = 100;
                }
                else if (diferenciaDeDistancia>7&&diferenciaDeDistancia<=14)
                {
                    EntregaActualizacion.PrecioEntrega = 200;
                }
                else if (diferenciaDeDistancia > 14 && diferenciaDeDistancia <= 21)
                {
                    EntregaActualizacion.PrecioEntrega = 300;
                }
                else if (diferenciaDeDistancia > 21 && diferenciaDeDistancia <= 28)
                {
                    EntregaActualizacion.PrecioEntrega = 400;
                }
                else
                {
                    //voy a poner el precio de $10 por kilometro
                    EntregaActualizacion.PrecioEntrega = diferenciaDeDistancia * 10;
                }
            }
            else
            {
                //por aca va la nota de credito
                diferenciaDeDistancia = Entrega.DistanciaEntrega - EntregaActualizacion.DistanciaEntrega ;
                if (diferenciaDeDistancia > 0 && diferenciaDeDistancia <= 7)
                {
                    EntregaActualizacion.PrecioEntrega = 100;
                }
                else if (diferenciaDeDistancia > 7 && diferenciaDeDistancia <= 14)
                {
                    EntregaActualizacion.PrecioEntrega = 200;
                }
                else if (diferenciaDeDistancia > 14 && diferenciaDeDistancia <= 21)
                {
                    EntregaActualizacion.PrecioEntrega = 300;
                }
                else if (diferenciaDeDistancia > 21 && diferenciaDeDistancia <= 28)
                {
                    EntregaActualizacion.PrecioEntrega = 400;
                }
                else
                {
                    //voy a poner el precio de $10 por kilometro
                    EntregaActualizacion.PrecioEntrega = diferenciaDeDistancia * 10;
                }
            }
        }

        //CARGA DE COMBOS
        public List<Provincia> mostrarSelecProvincia()
        {
            Provincia = new Provincia();
            return Provincia.mostrarDatosColeccion();
        }

        public List<Departamento> mostrarSelecDepartamento(int codigoProvincia)
        {
            return Provincia.conocerDepartamento(codigoProvincia);
        }

        public List<Localidad> mostrarSelecLocalidad(int codigoDepartamento)
        {
            return Departamento.conocerLocalidad(codigoDepartamento);
        }

        public List<TipoTelefono> mostrarSelectTipoTelefono()
        {
            return TipoTelefono.mostrarDatosColeccion();
        }

        public bool verificarCambios()
        {
            if (Entrega.CodigoPostal==EntregaActualizacion.CodigoPostal)
            {
                if (Entrega.NombreCalle==EntregaActualizacion.NombreCalle)
                {
                    if (Entrega.NumeroCalle == EntregaActualizacion.NumeroCalle)
                    {
                        if (Entrega.NombreBarrio == EntregaActualizacion.NombreBarrio)
                        {
                            if (Entrega.NombreProvincia == EntregaActualizacion.NombreProvincia)
                            {
                                if (Entrega.NombreDepartamento == EntregaActualizacion.NombreDepartamento)
                                {
                                    if (Entrega.NombreLocalidad == EntregaActualizacion.NombreLocalidad)
                                    {
                                        if (Entrega.NombreTipoTelefono == EntregaActualizacion.NombreTipoTelefono)
                                        {
                                            if (Entrega.NumeroTelefono == EntregaActualizacion.NumeroTelefono)
                                            {
                                                if (Entrega.Descripcion == EntregaActualizacion.Descripcion)
                                                {
                                                    if (Entrega.FechaEntrega == EntregaActualizacion.FechaEntrega)
                                                    {
                                                        if (Entrega.HoraEntregaDesde == EntregaActualizacion.HoraEntregaDesde)
                                                        {
                                                            if (Entrega.HoraEntregaHasta == EntregaActualizacion.HoraEntregaHasta)
                                                            {
                                                                return true;
                                                            }
                                                            else
                                                            {
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool verificarDistanciaCorrecta()
        {
            if (Entrega.NombreCalle!=EntregaActualizacion.NombreCalle)
            {
                if (Entrega.DistanciaEntrega==EntregaActualizacion.DistanciaEntrega)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (Entrega.NumeroCalle != EntregaActualizacion.NumeroCalle)
            {
                if (Entrega.DistanciaEntrega == EntregaActualizacion.DistanciaEntrega)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (Entrega.NombreProvincia != EntregaActualizacion.NombreProvincia)
            {
                if (Entrega.DistanciaEntrega == EntregaActualizacion.DistanciaEntrega)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (Entrega.NombreDepartamento != EntregaActualizacion.NombreDepartamento)
            {
                if (Entrega.DistanciaEntrega == EntregaActualizacion.DistanciaEntrega)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (Entrega.NombreLocalidad != EntregaActualizacion.NombreLocalidad)
            {
                if (Entrega.DistanciaEntrega == EntregaActualizacion.DistanciaEntrega)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public void actualizarEntrega()
        {
            EntregaActualizacion.actualizar(EntregaActualizacion);
        }
    }
}
