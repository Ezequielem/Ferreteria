using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Ventas.ConsultarVenta
{
    public class Controlador_ConsultarVenta
    {
        public IU_ConsultarVenta interfazConsultarVenta { get; set; }
        DateTime fechaDesde;
        DateTime fechaHasta;
        Venta venta;
        List<Venta> listaVentas;
        DetalleVP detalleVP;
        List<DetalleVP> listaDetalleVP;
        Articulo articulo;
        IU_DetalleVenta interfazDetalleVenta;
        Encargado encargado;
        FormaPago formaPago;
        ListaFormaPago listaFormaPago;
        List<ListaFormaPago> listaFormasDePago;
        Entrega entrega;
        List<Entrega> listaEntrega;
        DetalleLogistica detalleLogistica;
        List<DetalleLogistica> listaDetalleLogistica;
        List<DetalleLogistica> listaDetalleLogisticaAuxiliar;
        ClienteMayorista clienteMayorista;
        IU_InfoCliente interfazInfoCliente;

        public Controlador_ConsultarVenta()
        {
            venta = new Venta();
            listaVentas = new List<Venta>();
            detalleVP = new DetalleVP();
            listaDetalleVP = new List<DetalleVP>();
            articulo = new Articulo();
            encargado = new Encargado();
            formaPago = new FormaPago();
            listaFormaPago = new ListaFormaPago();
            listaFormasDePago = new List<ListaFormaPago>();
            entrega = new Entrega();
            detalleLogistica = new DetalleLogistica();
            listaDetalleLogistica = new List<DetalleLogistica>();
            listaDetalleLogisticaAuxiliar = new List<DetalleLogistica>();
            clienteMayorista = new ClienteMayorista();
        }

        public void periodoVenta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta.AddDays(1);
        }

        public bool cargarDGV_PeriodoVentas()
        {
            listaVentas = venta.obtenerPeriodoVentas(fechaDesde,fechaHasta);
            if (listaVentas.Count != 0)
            {
                foreach (var item in listaVentas)
                {
                    string envio = "NO";
                    if (venta.existeEntregaAsignada(item.CodigoVenta))
                    {
                        envio = "SI";
                    }

                    string cliente = "MINORISTA";
                    if (item.CodigoClienteMayorista != 0)
                    {
                        cliente = "MAYORISTA";
                    }

                    encargado.mostrarDatos(item.CodigoEncargado);

                    interfazConsultarVenta.dgv_listadoVentas.Rows.Add(
                        item.CodigoVenta.ToString("00000000"),
                        item.FechaHora.ToString("dd/MM/yyyy"),
                        item.ImporteTotal.ToString("0.00"),
                        envio,cliente,encargado.Nombre + " " + encargado.Apellido,"SELECCIONAR"
                        );
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ventaEstapecifica(int nroVenta)
        {
            if (venta.existeVenta(nroVenta))
            {
                venta.mostrarDatos(nroVenta);
                listaDetalleVP = detalleVP.obtenerListaDetalleVP(venta);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void mostrarDetalleVenta()
        {
            interfazDetalleVenta = new IU_DetalleVenta();
            interfazDetalleVenta.controladorConsultarVenta = this;

            interfazDetalleVenta.lbl_nroVenta.Text = venta.CodigoVenta.ToString("00000000");

            interfazDetalleVenta.lbl_fechaHora.Text = venta.FechaHora.ToString("dd/MM/yyyy") + " - " + venta.FechaHora.ToString("HH:mm") + " Hs";

            encargado.mostrarDatos(venta.CodigoEncargado);
            interfazDetalleVenta.lbl_vendedor.Text = encargado.Nombre + " " + encargado.Apellido;

            if (venta.CodigoClienteMayorista != 0)
            {
                clienteMayorista.mostrarDatos(venta.CodigoClienteMayorista);
                interfazDetalleVenta.btn_consultarDatosCliente.Enabled = true;
                interfazDetalleVenta.lbl_tipoCliente.Text = "MAYORISTA";

                interfazInfoCliente = new IU_InfoCliente();
                interfazInfoCliente.lbl_razonSocial.Text = clienteMayorista.RazonSocial;
                interfazInfoCliente.lbl_cuit.Text = clienteMayorista.Cuit.ToString();
                interfazInfoCliente.lbl_nombreBanco.Text = clienteMayorista.conocerBanco(clienteMayorista.CodigoBanco);
                interfazInfoCliente.lbl_nroCtaCte.Text = clienteMayorista.NumeroCtaCte;
                interfazInfoCliente.lbl_telefono.Text = clienteMayorista.NumeroTelefono.ToString();
                interfazInfoCliente.lbl_domicilio.Text = clienteMayorista.Calle + " " + clienteMayorista.Numero;
                interfazInfoCliente.lbl_barrio.Text = clienteMayorista.NombreBarrio;
                interfazInfoCliente.lbl_provincia.Text = clienteMayorista.conocerProvincia(clienteMayorista.CodigoProvincia);
                interfazInfoCliente.lbl_departamento.Text = clienteMayorista.conocerDepartamento(clienteMayorista.CodigoDepartamento);
                interfazInfoCliente.lbl_localidad.Text = clienteMayorista.conocerLocalidad(clienteMayorista.CodigoLocalidad);
            }
            else
            {
                interfazDetalleVenta.lbl_tipoCliente.Text = "MINORISTA";
            }

            listaFormasDePago = listaFormaPago.mostrarDatosColeccion(venta.CodigoVenta);
            foreach (var item in listaFormasDePago)
            {
                formaPago.mostrarDatos(item.CodigoFormaPago);
                if (listaFormasDePago.Count > 1)
                {
                   interfazDetalleVenta.lbl_formaPago.Text += formaPago.Descripcion + " - ";
                }
                else
                {
                    interfazDetalleVenta.lbl_formaPago.Text = formaPago.Descripcion;
                }
                
            }

            interfazDetalleVenta.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$ 0.00");

            if (venta.existeEntregaAsignada(venta.CodigoVenta))
            {
                interfazDetalleVenta.btn_detalleEnvio.Enabled = true;
                interfazDetalleVenta.lbl_envio.Text = "Si";

                float importeTotalEnvio = 0.00f;
                int cantidadEnvios = 0;
                listaEntrega = entrega.mostrarDatos(venta.CodigoVenta);
                foreach (var item in listaEntrega)
                {
                    importeTotalEnvio += item.PrecioEntrega;
                    cantidadEnvios++;

                    listaDetalleLogistica = detalleLogistica.mostrarDatosBase(item.CodigoEntrega);

                    foreach (var item2 in listaDetalleLogistica)
                    {
                        listaDetalleLogisticaAuxiliar.Add(new DetalleLogistica
                        {
                            CodigoDetalleLogistica = item2.CodigoDetalleLogistica,
                            CodigoArticulo = item2.CodigoArticulo,
                            Cantidad = item2.Cantidad,
                            CantidadRecibida = item2.CantidadRecibida,
                            CodigoEntrega = item2.CodigoEntrega,
                            CodigoRecepcion = item2.CodigoRecepcion,
                            CodigoProveedor = item2.CodigoProveedor
                        });
                    }
                    listaDetalleLogistica.Clear();
                }
                interfazDetalleVenta.lbl_cantidadEnvios.Text = cantidadEnvios.ToString();
                interfazDetalleVenta.lbl_importeEnvio.Text = importeTotalEnvio.ToString("$0.00");
            }

            listaDetalleVP = detalleVP.obtenerListaDetalleVP(venta);
            foreach (var item in listaDetalleVP)
            {
                articulo.mostrarDatos(item.CodigoArticulo);
                interfazDetalleVenta.dgv_productos.Rows.Add(item.CodigoArticulo,articulo.Descripcion,item.PrecioUnitario.ToString("0.00"),item.Cantidad,(item.PrecioUnitario * item.Cantidad).ToString("0.00"));
            }
            interfazDetalleVenta.ShowDialog();
        }

        public void mostrarDetalleEnvio()
        {
            IU_InfoEnvio interfazInfoEnvio = new IU_InfoEnvio(listaEntrega, listaDetalleLogisticaAuxiliar);
            interfazInfoEnvio.ShowDialog();
        }

        public void mostrarDetalleCliente()
        {
            interfazInfoCliente.ShowDialog();
        }

    }
}
