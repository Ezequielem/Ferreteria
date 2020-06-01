using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using SistemaLaObra.Ventas;
using SistemaLaObra.Ventas.OrdenDeRemito;
using SistemaLaObra.Ventas.CobroConTarjeta;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;
using SistemaLaObra.Ventas.ActualizarNotaDeCredito;
using SistemaLaObra.Ventas.VentaMayorista;

namespace SistemaLaObra
{
    public class Controlador_Venta
    {
        public IU_RegistrarVenta InterfazVenta { get; set; }
        IU_CobroConTarjeta iu_cobroConTarjeta;
        IU_ActualizarNotaDeCredito iu_actualizarNotaDeCredito;
        IU_RegistrarOrden iu_registrarOrden;
        public Venta venta;
        DetalleVP detalleVp;
        Articulo articulo;
        FormaPago formaPago;
        Entrega entrega;
        Tarjeta tarjeta;
        NotaCredito notaCredito;
        DetalleLogistica detalleLogistica;
        ListaFormaPago listaFormaPago;
        public List<DetalleVP> listaDetalle;
        public List<Entrega> listaEntrega; 
        public List<float> listaEntregaAuxiliar;
        public List<DetalleLogistica> listaDetalleLogistica;
        public List<Tarjeta> listaTarjeta;
        List<float> listaAuxiliarTarjeta;
        public List<NotaCredito> listaNotaCredito;
        List<ListaFormaPago> coleccionFormaPago;
        IU_VistaPrevia vistaPrevia;
        Image modeloFactura;
        ClienteMayorista clienteMayorista;
        IU_DatosClienteMayorista interfazDatosCliente;

        public int codigoArticulo;
        public int cantidad;
        float subTotal;
        public float saldoAPagar = 0.00f;
        string razonSocial;

        float totalEnvio = 0.0f;
        int cantidadEnvio = 0;

        public float interesEnPesos = 0.00f;
        float importeTotalTarjeta = 0.00f;


        public Controlador_Venta()
        {
            clienteMayorista = new ClienteMayorista();
            articulo = new Articulo();
            venta = new Venta();
            detalleVp = new DetalleVP();
            listaDetalle = new List<DetalleVP>();
            listaTarjeta = new List<Tarjeta>();
            listaEntrega = new List<Entrega>();
            listaNotaCredito = new List<NotaCredito>();
            listaEntregaAuxiliar = new List<float>();
            listaAuxiliarTarjeta = new List<float>();
            listaFormaPago = new ListaFormaPago();
            coleccionFormaPago = new List<ListaFormaPago>();
        }

        ///////////////////////////////////////////////
        ///////// DATOS PARA VENTA MAYORISTA //////////
        ///////////////////////////////////////////////
        public void autoCompletarRazonSocial(TextBox txt_razonSocial)
        {
            List<string> nombreClientes = clienteMayorista.mostrarColeccionNombreClientes(txt_razonSocial.Text);
            foreach (var item in nombreClientes)
            {
                txt_razonSocial.AutoCompleteCustomSource.Add(item);
            }
        }

        public void razonSocialCliente(string razonSocial)
        {
            this.razonSocial = razonSocial;
        }

        public bool verificarExistenciaCliente()
        {
            clienteMayorista.CodigoClienteMayorista = clienteMayorista.buscarCliente(razonSocial);
            if (clienteMayorista.CodigoClienteMayorista != 0)
            {
                clienteMayorista.mostrarDatos(clienteMayorista.CodigoClienteMayorista);
                venta.CodigoClienteMayorista = clienteMayorista.CodigoClienteMayorista;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cargarDatosClienteMayorista()
        {
            interfazDatosCliente = new IU_DatosClienteMayorista();

            interfazDatosCliente.InterfazVenta = InterfazVenta;
            interfazDatosCliente.lbl_razonSocial.Text = clienteMayorista.RazonSocial;
            interfazDatosCliente.lbl_cuit.Text = clienteMayorista.Cuit.ToString();
            interfazDatosCliente.lbl_nombreBanco.Text = clienteMayorista.conocerBanco(clienteMayorista.CodigoBanco);
            interfazDatosCliente.lbl_nroCtaCte.Text = clienteMayorista.NumeroCtaCte;
            interfazDatosCliente.lbl_telefono.Text = clienteMayorista.NumeroTelefono.ToString();
            interfazDatosCliente.lbl_domicilio.Text = clienteMayorista.Calle + " " + clienteMayorista.Numero;
            interfazDatosCliente.lbl_barrio.Text = clienteMayorista.NombreBarrio;
            interfazDatosCliente.lbl_provincia.Text = clienteMayorista.conocerProvincia(clienteMayorista.CodigoProvincia);
            interfazDatosCliente.lbl_departamento.Text = clienteMayorista.conocerDepartamento(clienteMayorista.CodigoDepartamento);
            interfazDatosCliente.lbl_localidad.Text = clienteMayorista.conocerLocalidad(clienteMayorista.CodigoLocalidad);

            interfazDatosCliente.ShowDialog();
        }
        ///////////////////////////////////////////////

        public List<FormaPago> mostrarSeleccionFormaPago()
        {
            formaPago = new FormaPago();
            return formaPago.mostrarDatosColeccion();
        }

        public void completar_dgvArticulosDisponibles(string descripcion)
        {
            InterfazVenta.dgv_articulosDisponibles.Rows.Clear();

            List<int> codigoArticulos = new List<int>();
            codigoArticulos = articulo.buscarListaDeArticulos(descripcion);
            foreach (var item in codigoArticulos)
            {
                articulo.mostrarDatos(item);
                InterfazVenta.dgv_articulosDisponibles.Rows.Add(articulo.CodigoArticulo,
                                                                articulo.Descripcion,
                                                                articulo.buscarNombreMarca(articulo.CodigoMarca),
                                                                articulo.buscarNombreProveedor(articulo.conocerProveedor(item)),
                                                                articulo.Stock,
                                                                articulo.buscarNombreUdadMedida(articulo.CodigoUnidadesDeMedida),
                                                                articulo.PrecioUnitario,
                                                                articulo.PrecioCoste);
            }
        }

        public void articuloSolicitado(string descripcion)
        {
            completar_dgvArticulosDisponibles(descripcion);
        }

        public void cantidadSolicitada(int cantidad)
        {
            this.cantidad = cantidad;
            if (!verificarStock())
            {
                MessageBox.Show("La cantidad solicitada supera el stock actual = " + articulo.Stock,"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void buscarDatosArticulos(int codigoArticulo)
        {
            articulo.mostrarDatos(codigoArticulo);
        }

        public bool verificarStock()
        {
            if (articulo.stockValido(cantidad))
            {
                cargarGrillaArticulos();
                InterfazVenta.mostrarImporteTotal();
                InterfazVenta.mostrarOpcionEnvioDomicilio();
                InterfazVenta.mostrarOpcionPago();
                InterfazVenta.mostrarOpcionRegistrarVenta();
                InterfazVenta.txt_descripcion.Text = "";
                InterfazVenta.txt_cantidad.Text = "";
                return true;
            }
            else
            {
                return false;
            }
        }

        private void actualizarStock()
        {
            articulo.disminuirStock(cantidad, articulo.CodigoArticulo);
        }

        public void cargarGrillaArticulos()
        {
            if (verificarExistenciaArticuloEnGrilla())
            {
                int cantidadFilas = InterfazVenta.dgv_productos.Rows.Count;
                for (int i = 0; i < cantidadFilas; i++)
                {
                    int codigoArticulo = int.Parse(InterfazVenta.dgv_productos.Rows[i].Cells["Column1"].Value.ToString());
                    if (articulo.CodigoArticulo == codigoArticulo)
                    {
                        actualizarStock();

                        int stockExistente = int.Parse(InterfazVenta.dgv_productos.Rows[i].Cells["Column5"].Value.ToString());
                        int nuevoStock = stockExistente - cantidad;
                        InterfazVenta.dgv_productos.Rows[i].Cells["Column5"].Value = nuevoStock;
                       
                        int cantidadExistente = int.Parse(InterfazVenta.dgv_productos.Rows[i].Cells["Column6"].Value.ToString());
                        int nuevaCantidad = cantidadExistente + cantidad;
                        InterfazVenta.dgv_productos.Rows[i].Cells["Column6"].Value = nuevaCantidad;

                        subTotal = calcularSubTotal();
                        InterfazVenta.dgv_productos.Rows[i].Cells["Column7"].Value = nuevaCantidad * articulo.PrecioUnitario;

                        modificarCantidadListaDetalle(nuevaCantidad);
                    }
                }
            }
            else
            {
                subTotal = calcularSubTotal();
                InterfazVenta.dgv_productos.Rows.Add(articulo.CodigoArticulo, articulo.Descripcion, articulo.PrecioUnitario, (articulo.Stock - cantidad), cantidad, subTotal.ToString());
                listaDetalle.Add(new DetalleVP() { CodigoArticulo = articulo.CodigoArticulo, PrecioUnitario = articulo.PrecioUnitario ,Cantidad = cantidad });
                actualizarStock();
            }
        } 

        private void modificarCantidadListaDetalle(int nuevaCantidad)
        {
            foreach (DetalleVP item in listaDetalle)
            {
                if (item.CodigoArticulo == articulo.CodigoArticulo)
                {
                    item.Cantidad = nuevaCantidad;
                    break;
                }
            }
        }

        private bool verificarExistenciaArticuloEnGrilla()
        {
            try
            {
                int cantidadFilas = InterfazVenta.dgv_productos.Rows.Count;
                for (int i = 0; i < cantidadFilas; i++)
                {
                    int codigoArticulo = int.Parse(InterfazVenta.dgv_productos.Rows[i].Cells["Column1"].Value.ToString());
                    if (articulo.CodigoArticulo == codigoArticulo)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private float calcularSubTotal()
        {
            return articulo.PrecioUnitario * cantidad;
        }

        public void calcularImporteTotal()
        {
            venta.ImporteTotal += subTotal;
            saldoAPagar = venta.ImporteTotal;
            InterfazVenta.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$ 0.00");
            InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00"); 
            InterfazVenta.lbl_subTotal.Text = venta.ImporteTotal.ToString("$ 0.00");
        }

        public void quitarArticulo()
        {
            int bandera = 0;
            try
            {
                int index = InterfazVenta.dgv_productos.CurrentRow.Index;

                //Para devolver el stock y restablecer label de importeTotal.
                int codigoArticulo = int.Parse(InterfazVenta.dgv_productos.CurrentRow.Cells[0].Value.ToString());
                int cantidad = int.Parse(InterfazVenta.dgv_productos.CurrentRow.Cells[4].Value.ToString());
                float subtotal = float.Parse(InterfazVenta.dgv_productos.CurrentRow.Cells[5].Value.ToString());
                //

                //Eze agrego lo siguiente
                venta.ImporteTotal -= subtotal;
                InterfazVenta.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$ 0.00");
                InterfazVenta.lbl_saldoAPagar.Text = venta.ImporteTotal.ToString("$ 0.00");
                //Agregado por eze para mostrar subtotal
                InterfazVenta.lbl_subTotal.Text = venta.ImporteTotal.ToString("$ 0.00");

                InterfazVenta.dgv_productos.Rows.RemoveAt(index);
                listaDetalle.RemoveAt(index);

                //Si llego a este punto es que efectivamente pudo quitar la fila
                bandera = 1;
                if (bandera != 0)
                {
                    articulo.aumentarStock(cantidad, codigoArticulo);
                }

                //validamos si siguen quedando articulos para habilitar seleccion de clientes
                if (listaDetalle.Count == 0)
                {
                    InterfazVenta.rb_clienteMayorista.Enabled = true;
                    InterfazVenta.rb_clienteMinorista.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No tiene articulos que seleccionar","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void descartarArticulos()
        {
            int cantidad = InterfazVenta.dgv_productos.Rows.Count;
            int contador = 0;
            while (contador < cantidad)
            {
                quitarArticulo();
                contador++;
            }
        }

        private void buscarUltimoNroVenta()
        {
            int valor = venta.ultimoNroVenta();
            if (valor != 0)
            {
                venta.CodigoVenta = (int)valor + 1;
            }
            else
            {
                venta.CodigoVenta = 1;
            }
        }

        public void generarNvoNumeroVenta()
        {
            buscarUltimoNroVenta();
            venta.CodigoEncargado = InterfazVenta.InterfazContenedora.EncargadoActivo.CodigoEncargado;

            if (mostrarVistaPrevia())
            {
                if (venta.CodigoClienteMayorista != 0 && InterfazVenta.txt_razonSocial.Text != "")
                {
                    venta.crearVentaMayorista(venta);
                }
                else
                {
                    venta.crearVentaMinorista(venta);
                }

                registrarDetalleVP();

                registrarFormaPago();

                if (listaEntrega.Count != 0 && InterfazVenta.ch_cargoEnvio.Checked)
                {
                    registrarEntregas();
                }
                InterfazVenta.ventaRegistrada = true;
                MessageBox.Show("La venta se registro exitosamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                InterfazVenta.Close();
            }
            else
            {
                MessageBox.Show("La venta no se confirmo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        public void registrarFormaPago()
        {
            ///////EFECTIVO DEBITO, CTA. CORRIENTE////////
            if (InterfazVenta.cbx_formaPago.SelectedIndex == 1 || InterfazVenta.cbx_formaPago.SelectedIndex == 3)
            {
                int codigoFormaPago = int.Parse(InterfazVenta.cbx_formaPago.SelectedValue.ToString());
                listaFormaPago.crear(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
            }

            if (saldoAPagar != 0.0f && InterfazVenta.cbx_formaPago.SelectedIndex != 1 && InterfazVenta.cbx_formaPago.SelectedIndex != 3)
            {
                int codigoFormaPago = formaPago.obtenerCodigoFormaPago("EFECTIVO");
                coleccionFormaPago.Add(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
            }

            if (listaTarjeta.Count != 0)
            {
                tarjeta = new Tarjeta();
                foreach (var item in listaTarjeta)
                {
                    tarjeta.crear(item.Nombre, item.Apellido, item.Interes, item.Cuota, item.CodigoNombreTarjeta, item.CodigoTipoTarjeta, item.CodigoBanco, item.NumeroTarjeta, item.ImporteTarjeta, venta.CodigoVenta);
                }
                int codigoFormaPago = formaPago.obtenerCodigoFormaPago("CREDITO");
                coleccionFormaPago.Add(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
            }

            if (listaNotaCredito.Count != 0 && InterfazVenta.ch_notaCredito.Checked == true)
            {
                notaCredito = new NotaCredito();
                foreach (var item in listaNotaCredito)
                {
                    notaCredito.actualizarNotaDeCredito(item);
                }
                int codigoFormaPago = formaPago.obtenerCodigoFormaPago("NOTA DE CREDITO");
                coleccionFormaPago.Add(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
            }

            foreach (var item in coleccionFormaPago)
            {
                listaFormaPago.crear(new ListaFormaPago { CodigoVenta = item.CodigoVenta, CodigoFormaPago = item.CodigoFormaPago });
            }
        }

        private void registrarDetalleVP()
        {
            try
            {
                foreach (var item in listaDetalle)
                {
                    detalleVp.crearDetalleVenta(item.CodigoArticulo, item.PrecioUnitario, item.Cantidad, venta.CodigoVenta);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        
        /////////////////////////////////////////////////
        ///////// REGISTRAR COBRO CON TARJETA //////////
        ///////////////////////////////////////////////
        public void registrarCobroConTarjeta() //llama al CU registrar cobro con tarjeta
        {
            iu_cobroConTarjeta = new IU_CobroConTarjeta();
            iu_cobroConTarjeta.iniciarDatosCobroTarjeta(this);
            iu_cobroConTarjeta.ShowDialog(InterfazVenta);
            iu_cobroConTarjeta.Hide();
        }

        public void tomarRegistroTarjeta(List<Tarjeta> entregasDevueltas)
        {
            listaTarjeta = entregasDevueltas;

            foreach (var item in listaTarjeta)
            {
                interesEnPesos += item.ImporteTarjeta * item.Interes / 100;
                importeTotalTarjeta += item.ImporteTarjeta;
            }

            actualizarDatosInterfaz();
        }

        public void actualizarDatosInterfaz()
        {
            //COBRO TARJETA
            float precio = 0.00f;
            float totalVenta = 0.00f;
            float totalInteres = 0.00f;
            float valorTotalEnvio = 0.00f;

            foreach (var item in listaEntrega)
            {
                valorTotalEnvio += item.PrecioEntrega;
            }

            if (InterfazVenta.cbx_formaPago.SelectedIndex == 2)
            {
                venta.ImporteTotal = venta.ImporteTotal + interesEnPesos; //  Toda esta linea estaba abajo, cualquier cosa avisar y dejarla como estaba
            }
            InterfazVenta.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$ 0.00");

            if (saldoAPagar == importeTotalTarjeta)
            {
                saldoAPagar = 0.00f;
                InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            }
            else
            {
                saldoAPagar -= importeTotalTarjeta;
                InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            }

            InterfazVenta.lbl_cantidadTarjeta.Text = listaTarjeta.Count.ToString();

            //solo para sabar la suma del cargo de la/las tarjetas (intereses)//
            foreach (var item in listaTarjeta)
            {
                totalVenta = totalVenta + item.ImporteTotalVentaCalculado;
                totalInteres = totalInteres + item.ImporteTarjeta;
            }
            precio = totalVenta - totalInteres;
            if (InterfazVenta.cbx_formaPago.SelectedIndex == 2)
                InterfazVenta.lbl_cargoTarjeta.Text = "$ " + precio.ToString("0.00");
        }
        ////////////////////////////////////////////////


        ///////////////////////////////////////////////
        ///////// ACTUALIZAR NOTA DE CREDITO //////////
        ///////////////////////////////////////////////
        public void actualizarNotaDeCredito() //llama al CU actualizar nota de credito
        {
            if (listaNotaCredito.Count != 0)
            {
                DialogResult opcion = MessageBox.Show("¿Esta seguro que desea continuar? Se perdera la nota de credito cargada", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (opcion == DialogResult.OK)
                {
                    InterfazVenta.ch_notaCredito.Checked = false;
                    listaNotaCredito.Clear();
                    iu_actualizarNotaDeCredito = new IU_ActualizarNotaDeCredito();
                    iu_actualizarNotaDeCredito.opcionActualizarNotaDeCredito(this);
                    iu_actualizarNotaDeCredito.ShowDialog(InterfazVenta);
                }
            }
            else
            {
                listaNotaCredito.Clear();
                iu_actualizarNotaDeCredito = new IU_ActualizarNotaDeCredito();
                iu_actualizarNotaDeCredito.opcionActualizarNotaDeCredito(this);
                iu_actualizarNotaDeCredito.ShowDialog(InterfazVenta);
            }
        }

        public void tomarActualizacionNotaCredito(List<NotaCredito> listaAActualizar)
        {
            listaNotaCredito = listaAActualizar;
            InterfazVenta.ch_notaCredito.Enabled = true;
            InterfazVenta.ch_notaCredito.Checked = true;
        }

        public void restablecerSaldo_sinNotaCredito()
        {
            float valorTotalNC = 0.00f;
            if (InterfazVenta.ch_notaCredito.Checked == false)
            {
                foreach (var item in listaNotaCredito)
                {
                    if (item.Saldo != 0)
                    {
                        valorTotalNC += item.SaldoAnterior;
                        valorTotalNC -= item.Saldo;
                    }
                    if (item.Saldo == 0)
                    {
                        valorTotalNC += item.SaldoAnterior;
                    }
                }
                saldoAPagar += valorTotalNC;
                InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            }

            if (InterfazVenta.ch_notaCredito.Checked == true)
            {
                if (listaNotaCredito.Count != 0)
                {
                    foreach (var item in listaNotaCredito)
                    {
                        if (item.Saldo == 0)
                        {
                            valorTotalNC += item.SaldoAnterior;
                        }
                        else
                        {
                            valorTotalNC += (item.SaldoAnterior - item.Saldo);
                        }
                    }
                    saldoAPagar -= valorTotalNC;
                    InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
                    InterfazVenta.btn_cargar.Enabled = false;
                    InterfazVenta.btn_quitarArticulo.Enabled = false;
                }
            }
        }
        ///////////////////////////////////////////////


        ///////////////////////////////////////////////
        ///////// REGISTRAR ORDEN DE REMITO ///////////
        ///////////////////////////////////////////////
        public void registrarOrdenDeRemito() //llama al CU registrar orden de remito 
        {
            listaEntregaAuxiliar.Clear();
            iu_registrarOrden = new IU_RegistrarOrden();
            iu_registrarOrden.opcionEnvioDomicilio(this);
            iu_registrarOrden.ShowDialog(InterfazVenta);
        }

        public void tomarRegistroOrdenRemito(List<Entrega> entregasDevueltas, List<DetalleLogistica> detalleLogisticaDevuelto) //El CU devuelve la/s entregas
        {
            listaEntrega = entregasDevueltas;
            listaDetalleLogistica = detalleLogisticaDevuelto;

            InterfazVenta.btn_cargar.Enabled = false;
            InterfazVenta.btn_quitarArticulo.Enabled = false;
            InterfazVenta.ch_cargoEnvio.Enabled = true;
            InterfazVenta.ch_cargoEnvio.Checked = true;

            foreach (var item in listaEntrega)
            {
                this.totalEnvio += item.PrecioEntrega;
                this.cantidadEnvio++;
            }
        }

        private void registrarEntregas()
        {
            entrega = new Entrega();

            int numeroEntrega = entrega.mostrarUltimoNroEntrega() + 1;
            foreach (var viaje in listaEntrega)
            {
                viaje.Venta.CodigoVenta = venta.CodigoVenta;
                viaje.crear(numeroEntrega, viaje.Venta.CodigoVenta, viaje.FechaEntrega, viaje.HoraEntregaDesde,
                    viaje.HoraEntregaHasta, viaje.NombreCliente, viaje.NombreProvincia, viaje.NombreDepartamento,
                    viaje.NombreLocalidad, viaje.NombreCalle, viaje.NumeroCalle.ToString(), viaje.CodigoPostal,
                    viaje.NombreBarrio, viaje.NombreTipoTelefono, viaje.NumeroTelefono, viaje.Descripcion,
                    viaje.PrecioEntrega, viaje.DistanciaEntrega, viaje.CodigoEstadoEntrega,
                    venta.CodigoEncargado);
                foreach (var item in listaDetalleLogistica)
                {
                    if (viaje.CodigoEntrega == item.Entrega.CodigoEntrega)
                    {
                        item.crearDetalleLogisticaEntrega(item.CodigoArticulo, item.Cantidad, numeroEntrega);
                    }
                }
                numeroEntrega++;
            }
        }

        public void restablecerImporte_sinCargoEnvio()
        {
            float valorTotalEnvio = 0.00f;

            if (InterfazVenta.ch_cargoEnvio.Checked == false)
            {
                foreach (var item in listaEntrega)
                {
                    valorTotalEnvio += item.PrecioEntrega;
                }
                venta.ImporteTotal -= valorTotalEnvio;
                InterfazVenta.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$ 0.00");
                saldoAPagar -= valorTotalEnvio;
                InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            }
            if (InterfazVenta.ch_cargoEnvio.Checked == true)
            {
                foreach (var item in listaEntrega)
                {
                    valorTotalEnvio += item.PrecioEntrega;
                }
                InterfazVenta.lbl_cargoEnvio.Text = valorTotalEnvio.ToString("$ 0.00");
                InterfazVenta.lbl_cantidadEnvios.Text = listaEntrega.Count.ToString();
                venta.ImporteTotal += valorTotalEnvio;
                InterfazVenta.lbl_importeTotal.Text = venta.ImporteTotal.ToString("$ 0.00");
                saldoAPagar += valorTotalEnvio;
                InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
                InterfazVenta.btn_detallesEnvioDomicilio.Enabled = true;
            }
        }
        ///////////////////////////////////////////////


        ///////////////////////////////////////////////
        ///////// FACTURAR SOLO ENVIO /////////////////
        ///////////////////////////////////////////////
        public void procesarSoloEnvio(Entrega entregaInstanciada)
        {
            InterfazVenta.lbl_cargoEnvio.Text = entregaInstanciada.PrecioEntrega.ToString("$ 0.00");
            venta.ImporteTotal = entregaInstanciada.PrecioEntrega;
            saldoAPagar = venta.ImporteTotal;
            InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            totalEnvio = entregaInstanciada.PrecioEntrega;
        }

        public void procesarSoloEnvio(List<Entrega> listaEntrega)
        {
            totalEnvio = 0.0f;
            foreach (var item in listaEntrega)
            {
                totalEnvio += item.PrecioEntrega;
            }
            InterfazVenta.lbl_cargoEnvio.Text = totalEnvio.ToString("$ 0.00");
            venta.ImporteTotal = totalEnvio;
            saldoAPagar = venta.ImporteTotal;
            InterfazVenta.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            cantidadEnvio = listaEntrega.Count;
        }

        public void generarNvoNumeroVentaParaRemito()
        {
            buscarUltimoNroVenta();
            venta.CodigoEncargado = InterfazVenta.InterfazContenedora.EncargadoActivo.CodigoEncargado;

            if (mostrarVistaPrevia())
            {
                if (venta.CodigoClienteMayorista != 0 && InterfazVenta.txt_razonSocial.Text != "")
                {
                    venta.crearVentaMayorista(venta);
                }
                else
                {
                    venta.crearVentaMinorista(venta);
                }

                ///////EFECTIVO, EFECTIVO DEBITO, CTA. CORRIENTE////////
                if (InterfazVenta.cbx_formaPago.SelectedIndex == 0 || InterfazVenta.cbx_formaPago.SelectedIndex == 1 || InterfazVenta.cbx_formaPago.SelectedIndex == 3)
                {
                    int codigoFormaPago = int.Parse(InterfazVenta.cbx_formaPago.SelectedValue.ToString());
                    listaFormaPago.crear(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
                }
                else
                {
                    if (listaTarjeta.Count != 0)
                    {
                        tarjeta = new Tarjeta();
                        foreach (var item in listaTarjeta)
                        {
                            tarjeta.crear(item.Nombre, item.Apellido, item.Interes, item.Cuota, item.CodigoNombreTarjeta, item.CodigoTipoTarjeta, item.CodigoBanco, item.NumeroTarjeta, item.ImporteTarjeta, venta.CodigoVenta);
                        }
                        int codigoFormaPago = formaPago.obtenerCodigoFormaPago("CREDITO");
                        coleccionFormaPago.Add(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
                    }

                    if (listaNotaCredito.Count != 0 && InterfazVenta.ch_notaCredito.Checked == true)
                    {
                        notaCredito = new NotaCredito();
                        foreach (var item in listaNotaCredito)
                        {
                            notaCredito.actualizarNotaDeCredito(item);
                        }
                        int codigoFormaPago = formaPago.obtenerCodigoFormaPago("NOTA DE CREDITO");
                        coleccionFormaPago.Add(new ListaFormaPago { CodigoVenta = venta.CodigoVenta, CodigoFormaPago = codigoFormaPago });
                    }

                    foreach (var item in coleccionFormaPago)
                    {
                        listaFormaPago.crear(new ListaFormaPago { CodigoVenta = item.CodigoVenta, CodigoFormaPago = item.CodigoFormaPago });
                    }
                }
                InterfazVenta.ventaRegistrada = true;
            }
        }
        ///////////////////////////////////////////////


        ///////////////////////////////////////////////
        ///////// IMPRESION DE FORMULARIOS ////////////
        ///////////////////////////////////////////////
        private bool mostrarVistaPrevia()
        {
            vistaPrevia = new IU_VistaPrevia();
            modeloFactura = Properties.Resources.ModeloFactura;
            vistaPrevia.tomarModelo(modeloFactura, "Factura de Venta");
            vistaPrevia.generarFactura(listaDetalle, venta, InterfazVenta.ch_cargoEnvio.Checked,totalEnvio, cantidadEnvio);
            vistaPrevia.btn_imprimir.Text = "Confirmar";
            vistaPrevia.ShowDialog();
            return vistaPrevia.confirmacion;
        }
    }
}
