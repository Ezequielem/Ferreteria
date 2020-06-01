using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;

namespace SistemaLaObra.Ventas.ActualizarNotaDeCredito
{
    public class Controlador_ActualizarNotaDeCredito
    {
        //INSTANCIAS
        private ClienteMayorista _clienteMayorista;
        public List<ClienteMayorista> _clientesMayoristas;
        private NotaCredito _notaDeCredito;
        public List<NotaCredito> _clientesMinoristas;
        public List<NotaCredito> _notaCreditoColeccionMayorista;
        public List<NotaCredito> _notaCreditoColeccionMinorista;
        private List<NotaCredito> listaNotaCreditoStandBy;
        private List<NotaCredito> _listaAActualizar;
        private Venta _venta;
        private IU_ActualizarNotaDeCredito _interfazActualizarNotaDeCredito;
        private IU_DialogoBuscarCliente _interfazBuscarCliente;


        public IU_ActualizarNotaDeCredito InterfazActualizarNotaDeCredito
        {
            get
            {
                return _interfazActualizarNotaDeCredito;
            }

            set
            {
                _interfazActualizarNotaDeCredito = value;
            }
        }

        public IU_DialogoBuscarCliente InterfazBuscarCliente
        {
            get
            {
                return _interfazBuscarCliente;
            }

            set
            {
                _interfazBuscarCliente = value;
            }
        }

        public NotaCredito NotaDeCredito
        {
            get
            {
                return _notaDeCredito;
            }

            set
            {
                _notaDeCredito = value;
            }
        }

        public List<NotaCredito> ListaAActualizar
        {
            get
            {
                return _listaAActualizar;
            }

            set
            {
                _listaAActualizar = value;
            }
        }

        public List<NotaCredito> ListaNotaCreditoStandBy
        {
            get
            {
                return listaNotaCreditoStandBy;
            }

            set
            {
                listaNotaCreditoStandBy = value;
            }
        }

        public Controlador_ActualizarNotaDeCredito(IU_ActualizarNotaDeCredito interfazActNotaCredito)
        {
            InterfazActualizarNotaDeCredito = interfazActNotaCredito;
            _clienteMayorista = new ClienteMayorista();
            _clientesMayoristas = new List<ClienteMayorista>();
            NotaDeCredito = new NotaCredito();
            _clientesMinoristas = new List<NotaCredito>();
            _notaCreditoColeccionMayorista = new List<NotaCredito>();
            _notaCreditoColeccionMinorista = new List<NotaCredito>();
            ListaAActualizar = new List<NotaCredito>();
            ListaNotaCreditoStandBy = new List<NotaCredito>();
            _venta = new Venta();
        }

        //METODOS

        public void nombreClienteIngresado(string nombre)
        {
            NotaDeCredito.NombreCliente = nombre;
        }

        public void verificarExistenciaMayorista(string cuit)
        {
            if (_clienteMayorista.esCliente(cuit))
            {
                _notaCreditoColeccionMayorista.Clear();
                _notaCreditoColeccionMayorista = NotaDeCredito.buscarDatosNotaDeCreditoMayorista(cuit);
                InterfazActualizarNotaDeCredito.mostrarListaDatosNotaDeCredito(_notaCreditoColeccionMayorista);
                InterfazActualizarNotaDeCredito.lbl_cliente.Text = "Cliente:";
                InterfazActualizarNotaDeCredito.lbl_nombreCliente.Text = _clientesMayoristas.FirstOrDefault().RazonSocial;
                InterfazActualizarNotaDeCredito.lbl_cuitDni.Text = "CUIT:";
                InterfazActualizarNotaDeCredito.lbl_documentoCliente.Text = _clientesMayoristas.FirstOrDefault().Cuit;
            }            
        }

        public void verificarExistenciaMinorista(int dni)
        {
            if (NotaDeCredito.esCliente(dni))
            {
                _notaCreditoColeccionMinorista.Clear();
                _notaCreditoColeccionMinorista = NotaDeCredito.buscarDatosNotaDeCreditoMinorista(dni);
                InterfazActualizarNotaDeCredito.mostrarListaDatosNotaDeCredito(_notaCreditoColeccionMinorista);
                InterfazActualizarNotaDeCredito.lbl_cliente.Text = "Cliente:";
                InterfazActualizarNotaDeCredito.lbl_nombreCliente.Text = _notaCreditoColeccionMinorista.FirstOrDefault().NombreCliente;
                InterfazActualizarNotaDeCredito.lbl_cuitDni.Text = "DNI:";
                InterfazActualizarNotaDeCredito.lbl_documentoCliente.Text = _notaCreditoColeccionMinorista.FirstOrDefault().DniCliente.ToString();
            }
        }

        public void mostrarClientesMayoristas()
        {
            _clientesMayoristas=NotaDeCredito.mostrarDatosColeccionMayorista();            
        }

        public void mostrarClientesMinoristas()
        {
            _clientesMinoristas=NotaDeCredito.mostrarDatosColeccionMinorista();
        }

        //EVENTOS

        public void interfazCliente()
        {
            InterfazBuscarCliente = new IU_DialogoBuscarCliente(this);
            if (InterfazActualizarNotaDeCredito.rbtn_1.Checked==true)
            {
                foreach (var item in _clientesMinoristas)
                {
                    if (item.NombreCliente==NotaDeCredito.NombreCliente)
                    {
                        InterfazBuscarCliente.cargarDatosClienteMinorista(item);
                    }
                }                
            }
            else
            {
                foreach (var item in _clientesMayoristas)
                {
                    if (item.RazonSocial == NotaDeCredito.NombreCliente)
                    {
                        InterfazBuscarCliente.cargarDatosClienteMayorista(item);
                    }
                }
            }
            InterfazBuscarCliente.ShowDialog();
        }
    }
}
