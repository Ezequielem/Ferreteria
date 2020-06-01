using SistemaLaObra.Ventas.CobroConTarjeta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.RegistrarNotaDeCredito
{
    public class Controlador_NotaCredito
    {
        public IU_RegistrarNotaCredito InterfazNotaCredito { get; set; }
        Venta venta;
        DetalleVP detalle;
        List<DetalleVP> listaDetalle;
        Entrega entrega;
        List<Entrega> listaEntregas;
        Articulo articulo;
        Encargado encargado;
        public NotaCredito notaCredito;
        List<DetalleVP> listaDetalleNotaCredito;
        Tarjeta tarjeta;
        List<Tarjeta> listaTarjeta;
        ListaFormaPago listaFormaPago;
        List<ListaFormaPago> coleccionFormaPago;
        FormaPago formaPago;
        IU_VistaPrevia vistaPrevia;
        Image modeloNotaCredito;

        float subTotal;
        string detalleFP = "";

        public Controlador_NotaCredito()
        {
            venta = new Venta();
            detalle = new DetalleVP();
            listaDetalle = new List<DetalleVP>();
            entrega = new Entrega();
            listaEntregas = new List<Entrega>();
            articulo = new Articulo();
            encargado = new Encargado();
            notaCredito = new NotaCredito();
            listaDetalleNotaCredito = new List<DetalleVP>();
            tarjeta = new Tarjeta();
            listaTarjeta = new List<Tarjeta>();
            listaFormaPago = new ListaFormaPago();
            coleccionFormaPago = new List<ListaFormaPago>();
            formaPago = new FormaPago();
            modeloNotaCredito = Properties.Resources.Modelo_NotaCredito;
        }

        public void nroVenta(int nroVenta)
        {
            verificarNroVenta(nroVenta);
        }

        private void verificarNroVenta(int nroVenta)
        {
            if (venta.existeVenta(nroVenta))
            {
                venta.mostrarDatos(nroVenta);
                listaDetalle = detalle.obtenerListaDetalleVP_NC(venta);
                listaEntregas = entrega.mostrarDatos(nroVenta);

                notaCredito.CodigoVenta = venta.CodigoVenta;
                notaCredito.CodigoEncargado = InterfazNotaCredito.InterfazContenedora.EncargadoActivo.CodigoEncargado;
                mostrarDatosVenta();
            }
            else
            {
                MessageBox.Show("La venta no existe","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void mostrarDatosVenta()
        {
            foreach (var item in listaDetalle)
            {
                articulo.mostrarDatos(item.CodigoArticulo);
                int cantidadRestante = item.Cantidad - item.CantidadDevuelta;
                if (cantidadRestante != 0)
                {
                    InterfazNotaCredito.dgv_productos.Rows.Add(item.CodigoArticulo, articulo.Descripcion, item.PrecioUnitario, item.Cantidad, cantidadRestante);
                }
            }

            coleccionFormaPago = listaFormaPago.mostrarDatosColeccion(venta.CodigoVenta);
            foreach (var item in coleccionFormaPago)
            {
                formaPago.mostrarDatos(item.CodigoFormaPago);

                if (formaPago.Descripcion == "CREDITO")
                {
                    mostrarDatosTarjeta();
                }

                detalleFP += formaPago.Descripcion + "\n";
            }

            float totalEntrega = 0.0f;
            foreach (var item in listaEntregas)
            {
                totalEntrega += item.PrecioEntrega;
            }
            if (totalEntrega != 0.0) InterfazNotaCredito.lbl_cargoEnvio.Text = totalEntrega.ToString("$0.00");
            else InterfazNotaCredito.lbl_cargoEnvio.Text = "$0.00";

            if (InterfazNotaCredito.dgv_productos.Rows.Count != 0)
            {
                InterfazNotaCredito.btn_calcularSaldo.Enabled = true;

                encargado.mostrarDatos(venta.CodigoEncargado);

                InterfazNotaCredito.lbl_fechaVencimiento.Text = notaCredito.FechaVencimiento.ToString("dd/MM/yyyy");
                InterfazNotaCredito.lbl_fechaVenta.Text = venta.FechaHora.ToString("dd/MM/yyyy");
                InterfazNotaCredito.lbl_horaVenta.Text = venta.FechaHora.ToString("HH:mm");
                InterfazNotaCredito.lbl_vendedor.Text = encargado.Nombre + " " + encargado.Apellido;
                InterfazNotaCredito.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$0.00");

                if (venta.CodigoClienteMayorista != 0)
                {
                    ClienteMayorista cliente = venta.conocerClienteMayorista(venta.CodigoClienteMayorista);
                    InterfazNotaCredito.lbl_razonSocial.Text = cliente.RazonSocial;
                    InterfazNotaCredito.lbl_cuit.Text = cliente.Cuit;
                    InterfazNotaCredito.txt_razonSocial.Text = cliente.RazonSocial;
                    InterfazNotaCredito.txt_razonSocial.Enabled = false;
                    InterfazNotaCredito.txt_cuit.Text = cliente.Cuit;
                    InterfazNotaCredito.txt_cuit.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Se realizaron todas las notas de credito disponible para esta venta","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void mostrarDetalleFormaPago()
        {
            MessageBox.Show(detalleFP,"FORMAS DE PAGO");
        }

        private void mostrarDatosTarjeta()
        {
            listaTarjeta = tarjeta.obtenerListaTarjeta(venta.CodigoVenta);
            int cantidadTarjetas = 0;
            int cantidadCuotas = 0;
            int interesTotalGenerado = 0;
            foreach (var item in listaTarjeta)
            {
                cantidadTarjetas++;
                cantidadCuotas += item.Cuota;
                interesTotalGenerado += item.Interes;
            }
            InterfazNotaCredito.lbl_cantidadTarjetas.Text = cantidadTarjetas.ToString();
            InterfazNotaCredito.lbl_interesGenerado.Text = "% " + interesTotalGenerado.ToString();
        }

        public void articuloSeleccionado(DataGridView dgv_productos)
        {
            listaDetalleNotaCredito.Clear();
            foreach (DataGridViewRow fila in dgv_productos.Rows)
            {
                DataGridViewCheckBoxCell celdaSeleccionada = fila.Cells[6] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celdaSeleccionada.Value))
                {
                    int cantidadADevolver;
                    bool resultado = int.TryParse(fila.Cells[5].Value.ToString(), out cantidadADevolver);
                    if (resultado)
                    {
                        if (int.Parse(fila.Cells[4].Value.ToString()) >= cantidadADevolver && cantidadADevolver >= 0)
                        {
                            listaDetalleNotaCredito.Add(new DetalleVP
                            {
                                CodigoArticulo = int.Parse(fila.Cells[0].Value.ToString()),
                                PrecioUnitario = float.Parse(fila.Cells[2].Value.ToString()),
                                CantidadDevuelta = int.Parse(fila.Cells[5].Value.ToString())
                            });
                            InterfazNotaCredito.btn_registrarNotaCredito.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("La cantidad a devolver no debe superar la cantidad vendida","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            InterfazNotaCredito.btn_registrarNotaCredito.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingreso un dato incorrecto al ingresar la cantidad a devolver", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }           
        }

        public void calcularSubTotal()
        {
            subTotal = 0;
            foreach (var item in listaDetalleNotaCredito)
            {
                subTotal += item.PrecioUnitario * item.CantidadDevuelta;
            }
            notaCredito.Saldo = subTotal;
            InterfazNotaCredito.lbl_subTotal.Text = subTotal.ToString("$0.00");
            mostrarSaldo();
        }

        
        private void mostrarSaldo()
        {
            /*
             * //NO OLVIDAR REALIZAR PRUEBAS AL TENER TARJETA (SI HAY MAS DE UNA TARJETA CON DISTINTOS INTERESES?)
            if (listaTarjeta.Count != 0)
            {
                //TOMO EL PRIMERO POR QUE SOLO QUIERO SABER EL INTERES, IGUAL SE APLICA PARA TODOS LOS ARTICULOS FINANCIADOS
                int interes = int.Parse(listaTarjeta.FirstOrDefault().Interes.ToString());

                float adicionPorInteres = interes * notaCredito.Saldo / 100;
                notaCredito.Saldo += adicionPorInteres;
                InterfazNotaCredito.lbl_saldo.Text = notaCredito.Saldo.ToString("$0.00");
            }
            else
            {
                InterfazNotaCredito.lbl_saldo.Text = notaCredito.Saldo.ToString("$0.00");
            }
            */
            InterfazNotaCredito.lbl_saldo.Text = notaCredito.Saldo.ToString("$0.00");
        }

        public void datosClienteMayorista()
        {
            notaCredito.CodigoClienteMayorista = venta.CodigoClienteMayorista;
        }

        public void datosCliente(string nombreCliente, int dniCliente)
        {
            notaCredito.NombreCliente = nombreCliente;
            notaCredito.DniCliente = dniCliente;
        }

        public void registrarNotaCredito()
        {
            if (mostrarVistaPrevia())
            {
                devolverStock();
                if (notaCredito.CodigoClienteMayorista != 0)
                {
                    notaCredito.CodigoNotaCredito = notaCredito.ultimoCodigoNotaCredito() + 1;
                    notaCredito.crearNotaCreditoMayorista(notaCredito);
                }
                else
                {
                    notaCredito.CodigoNotaCredito = notaCredito.ultimoCodigoNotaCredito() + 1;
                    notaCredito.crearNotaCreditoMinorista(notaCredito);
                }
                procesarDetalleNotaCredito();
                actualizarDetalleVenta();
                MessageBox.Show("Se registro con exito la nota de credito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InterfazNotaCredito.Close();
            }
            else
            {
                MessageBox.Show("No se confirmo el registro de la nota de credito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void devolverStock()
        {
            foreach (DataGridViewRow fila in InterfazNotaCredito.dgv_productos.Rows)
            {
                DataGridViewCheckBoxCell celdaSeleccionada = fila.Cells[7] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celdaSeleccionada.Value))
                {
                    int codigoArticulo = int.Parse(fila.Cells[0].Value.ToString());
                    int cantidadDevuelta = int.Parse(fila.Cells[4].Value.ToString());
                    articulo.aumentarStock(cantidadDevuelta, codigoArticulo);
                }
            }
        }
        /*
            Esto se realiza para igualar la lista de detalle de venta con la de nota de credito
            Puesto que el detalle de venta se actualizara contra la base de datos y de esa forma sabre si
            a la venta ya se le realizo una nota de credito (hago esto para evitar tocar mas la base de datos y parece A MI CRITERIO lo mas acertado)
        */
        private void procesarDetalleNotaCredito()
        {
            foreach (var item_listaDetalle in listaDetalle)
            {
                foreach (var item_listaDetalleNC in listaDetalleNotaCredito)
                {
                    if (item_listaDetalle.CodigoArticulo == item_listaDetalleNC.CodigoArticulo)
                    {
                        if (item_listaDetalle.CantidadDevuelta != 0)
                        {
                            item_listaDetalle.CodigoNotaCredito = notaCredito.CodigoNotaCredito;
                            item_listaDetalle.CantidadDevuelta += item_listaDetalleNC.CantidadDevuelta;
                        }
                        else
                        {
                            item_listaDetalle.CodigoNotaCredito = notaCredito.CodigoNotaCredito;
                            item_listaDetalle.CantidadDevuelta = item_listaDetalleNC.CantidadDevuelta;
                        }
                    }
                }
            }
        }

        private void actualizarDetalleVenta()
        {
            foreach (var item in listaDetalle)
            {
                if (item.CodigoNotaCredito != 0)
                {
                    detalle.actualizarDetalleNC(item.CodigoDetalleVP, item.CodigoNotaCredito, item.CantidadDevuelta);
                }
            }
        }

        //Preguntar si se financia con tarjeta de credito el envio, el tema del interes
        public void procesarDevolucionExcedente(Entrega entregaInstanciada)
        {
            notaCredito.Saldo = entregaInstanciada.PrecioEntrega;
            InterfazNotaCredito.lbl_subTotal.Text = notaCredito.Saldo.ToString("$0.00");
            InterfazNotaCredito.lbl_saldo.Text = notaCredito.Saldo.ToString("$0.00");
        }

        public void registrarNotaCreditoExecedente()
        {
            if (mostrarVistaPrevia())
            {
                if (notaCredito.CodigoClienteMayorista != 0)
                {
                    notaCredito.CodigoNotaCredito = notaCredito.ultimoCodigoNotaCredito() + 1;
                    notaCredito.crearNotaCreditoMayorista(notaCredito);
                }
                else
                {
                    notaCredito.CodigoNotaCredito = notaCredito.ultimoCodigoNotaCredito() + 1;
                    notaCredito.crearNotaCreditoMinorista(notaCredito);
                }
                InterfazNotaCredito.notaCreditoRegistrada = true;
            }
        }

        private bool mostrarVistaPrevia()
        {
            vistaPrevia = new IU_VistaPrevia();
            vistaPrevia.tomarModelo(modeloNotaCredito, "Note de Credito");
            vistaPrevia.btn_imprimir.Text = "Confirmar";
            vistaPrevia.generarNotaDeCredito(listaDetalleNotaCredito, notaCredito);
            vistaPrevia.ShowDialog();
            return vistaPrevia.confirmacion;
        }

    }
}
