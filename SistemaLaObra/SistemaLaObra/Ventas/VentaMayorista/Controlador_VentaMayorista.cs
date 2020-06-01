using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using SistemaLaObra.Ventas;
using SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista;
using SistemaLaObra.Ventas.VentaMayorista;
using SistemaLaObra.Ventas.OrdenDeRemito;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;
using SistemaLaObra.Ventas.ActualizarNotaDeCredito;

namespace SistemaLaObra
{
    public class Controlador_VentaMayorista
    {

        //Instancias
        Articulo articulo;
        public Venta venta;
        Entrega entrega;
        DetalleLogistica detalleLogistica;
        public List<Entrega> listaEntrega;
        public List<float> listaEntregaAuxiliar;//para el checkbox
        public List<DetalleLogistica> listaDetalleLogistica;
        public DetalleVP detalleVp;
        public List<DetalleVP> listaDetalle;
        FormaPago formaPago;
        IU_DatosClienteMayorista interfazDatosCliente;
        public ClienteMayorista clienteMayorista;
        public IU_RegistrarVentaMayorista InterfazVentaMayorista { get; set; }
        private IU_CobroConTarjetaMayorista interfazTarjetaMayorista;
        private IU_RegistrarOrden iu_registrarOrden;
        Tarjeta tarjeta;
        public List<Tarjeta> listaTarjeta;
        List<float> listaAuxiliarTarjeta;
        IU_ActualizarNotaDeCredito iu_actualizarNotaDeCredito;
        NotaCredito notaCredito;
        public List<NotaCredito> listaNotaCredito;
        IU_VistaPrevia vistaPrevia;
        Image modeloFactura;


        public string razonSocial;
        public int codigoArticulo;
        public int cantidadArticulo;
        int codigoClienteMayorista;
        float subtotal;
        public int cantidad;
        public float interesEnPesos = 0.00f;
        float acumulador = 0;
        public float saldoAPagar = 0.00f;

        public Controlador_VentaMayorista()
        {
            listaTarjeta = new List<Tarjeta>();
            listaEntrega = new List<Entrega>();
            listaEntregaAuxiliar = new List<float>();
            listaAuxiliarTarjeta = new List<float>();
            listaNotaCredito = new List<NotaCredito>();
            clienteMayorista = new ClienteMayorista();
            articulo = new Articulo();
            venta = new Venta();
            detalleVp = new DetalleVP();
            listaDetalle = new List<DetalleVP>();
            modeloFactura = Properties.Resources.ModeloFactura;
        }

        ///TARJETA
        public IU_CobroConTarjetaMayorista InterfazTarjetaMayorista
        {
            get
            {
                if (interfazTarjetaMayorista == null)
                    interfazTarjetaMayorista = new IU_CobroConTarjetaMayorista();
                return interfazTarjetaMayorista;

            }
        }      
        ////////////////////////////////////////

        public List<FormaPago> mostrarSeleccionFormaPago()
        {
            formaPago = new FormaPago();
            return formaPago.mostrarDatosColeccion();
        }

        public void razonSocialCliente(string razonSocial)
        {
            this.razonSocial = razonSocial;
        }

        public void autoCompletarRazonSocial(TextBox txt_razonSocial)
        {
            List<string> nombreClientes = clienteMayorista.mostrarColeccionNombreClientes(txt_razonSocial.Text);
            foreach (var item in nombreClientes)
            {
                txt_razonSocial.AutoCompleteCustomSource.Add(item);
            }
        }

        public bool verificarExistenciaCliente()
        {
            codigoClienteMayorista = clienteMayorista.buscarCliente(razonSocial);
            if (codigoClienteMayorista != 0)
            {
                clienteMayorista.mostrarDatos(codigoClienteMayorista);
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

            //interfazDatosCliente.InterfazVenta = InterfazVentaMayorista;
            interfazDatosCliente.lbl_razonSocial.Text = clienteMayorista.RazonSocial;
            interfazDatosCliente.lbl_cuit.Text = clienteMayorista.Cuit.ToString();
            interfazDatosCliente.lbl_nombreBanco.Text = clienteMayorista.conocerBanco(clienteMayorista.CodigoBanco);
            interfazDatosCliente.lbl_nroCtaCte.Text = clienteMayorista.NumeroCtaCte;
            interfazDatosCliente.lbl_telefono.Text = clienteMayorista.NumeroTelefono.ToString();
            interfazDatosCliente.lbl_domicilio.Text = clienteMayorista.Calle +" "+clienteMayorista.Numero;
            interfazDatosCliente.lbl_barrio.Text = clienteMayorista.NombreBarrio;
            interfazDatosCliente.lbl_provincia.Text = clienteMayorista.conocerProvincia(clienteMayorista.CodigoProvincia);
            interfazDatosCliente.lbl_departamento.Text = clienteMayorista.conocerDepartamento(clienteMayorista.CodigoDepartamento);
            interfazDatosCliente.lbl_localidad.Text = clienteMayorista.conocerLocalidad(clienteMayorista.CodigoLocalidad);

            interfazDatosCliente.ShowDialog();
        }      

        public void articuloSolicitado(string nombreArticulo)
        {
            completar_dgvArticulosDisponibles(nombreArticulo);
        }

        public void completar_dgvArticulosDisponibles(string nombreArticulo)
        {
            InterfazVentaMayorista.dgv_articulosDisponibles.Rows.Clear();

            List<int> codigoArticulos = new List<int>();
            codigoArticulos = articulo.buscarListaDeArticulos(nombreArticulo);
            foreach (var item in codigoArticulos)
            {
                articulo.mostrarDatos(item);
                InterfazVentaMayorista.dgv_articulosDisponibles.Rows.Add(articulo.CodigoArticulo,
                                                                articulo.Descripcion,
                                                                articulo.buscarNombreMarca(articulo.CodigoMarca),
                                                                articulo.buscarNombreProveedor(articulo.conocerProveedor(item)),
                                                                articulo.Stock,
                                                                articulo.buscarNombreUdadMedida(articulo.CodigoUnidadesDeMedida),
                                                                articulo.PrecioUnitario,
                                                                articulo.PrecioCoste);
            }
        }

        public void buscarDatosArticulo(int codigoArticulo)
        {
            articulo.mostrarDatos(codigoArticulo);
        }

        public void cantidadSolicitada(string cantidad)
        {
            this.cantidadArticulo = int.Parse(cantidad);
            if (!verificarStock()) //Se hace aca para poder usarlo desde consultar presupuesto
            {
                MessageBox.Show("La cantidad solicitada supera el stock actual = " + articulo.Stock);
            } 
        }

        public bool verificarStock()
        {
            if (articulo.stockValido(cantidadArticulo))
            {
                cargarGrillaArticulos();
                InterfazVentaMayorista.mostrarImporteTotal();
                InterfazVentaMayorista.mostrarOpcionEnvioDomicilio();
                InterfazVentaMayorista.mostrarOpcionPago();
                InterfazVentaMayorista.mostrarOpcionRegistrarVenta();
                InterfazVentaMayorista.txt_descripcion.Text = "";
                InterfazVentaMayorista.txt_cantidad.Text = "";
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cargarGrillaArticulos()
        {
            if (verificarExistenciaArticuloEnGrilla())
            {
                int cantidadFilas = InterfazVentaMayorista.dgv_productos.Rows.Count;
                for (int i = 0; i < cantidadFilas; i++)
                {
                    int codigoArticulo = int.Parse(InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column1"].Value.ToString());
                    if (articulo.CodigoArticulo == codigoArticulo)
                    {
                        actualizarStock();

                        //Actualizamos grilla con el nuevo stock y cantidad para reflejar con datos de base
                        int stockExistente = int.Parse(InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column4"].Value.ToString());
                        int nuevoStock = stockExistente - cantidadArticulo;
                        InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column4"].Value = nuevoStock;

                        int cantidadExistente = int.Parse(InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column5"].Value.ToString());
                        int nuevaCantidad = cantidadExistente + cantidadArticulo;
                        InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column5"].Value = nuevaCantidad;
                        ////////////////////////////////////////////////////////////////////////////////////

                        subtotal = calcularSubTotal();
                        InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column6"].Value = nuevaCantidad * articulo.PrecioUnitario;

                        modificarCantidadListaDetalle(nuevaCantidad);
                    }
                }
            }
            else
            {
                subtotal = calcularSubTotal();
                InterfazVentaMayorista.dgv_productos.Rows.Add(articulo.CodigoArticulo, articulo.Descripcion, articulo.PrecioUnitario, (articulo.Stock - cantidadArticulo), cantidadArticulo, subtotal);
                listaDetalle.Add(new DetalleVP() { CodigoArticulo = articulo.CodigoArticulo,PrecioUnitario = articulo.PrecioUnitario ,Cantidad = cantidadArticulo });
                actualizarStock();
            }
        }

        private void modificarCantidadListaDetalle(int nuevaCantidad)
        {
            foreach (DetalleVP item in listaDetalle)
            {
                if (item.CodigoArticulo == codigoArticulo)
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
                int cantidadFilas = InterfazVentaMayorista.dgv_productos.Rows.Count;
                for (int i = 0; i < cantidadFilas; i++)
                {
                    int codigoArticulo = int.Parse(InterfazVentaMayorista.dgv_productos.Rows[i].Cells["Column1"].Value.ToString());
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

        private void actualizarStock()
        {
            articulo.disminuirStock(cantidadArticulo, articulo.CodigoArticulo);
        }

        private float calcularSubTotal()
        {
            return cantidadArticulo * articulo.PrecioUnitario;
        }

        public void calcularImporteTotal()
        {
            venta.ImporteTotal += subtotal;
            saldoAPagar = venta.ImporteTotal;
            InterfazVentaMayorista.lbl_importeTotal.Text = venta.ImporteTotal.ToString("0.00");
            InterfazVentaMayorista.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
            InterfazVentaMayorista.lbl_subTotal.Text = venta.ImporteTotal.ToString("$ 0.00");
        }

        public void quitarArticulo()
        {
            int bandera = 0;
            try
            {
                int index = InterfazVentaMayorista.dgv_productos.CurrentRow.Index;

                //Para devolver el stock y restaurar importeTotal
                int codigoArticulo = int.Parse(InterfazVentaMayorista.dgv_productos.CurrentRow.Cells[0].Value.ToString());
                int cantidad = int.Parse(InterfazVentaMayorista.dgv_productos.CurrentRow.Cells[4].Value.ToString());
                float subtotal = float.Parse(InterfazVentaMayorista.dgv_productos.CurrentRow.Cells[5].Value.ToString());
                venta.ImporteTotal -= subtotal;
                InterfazVentaMayorista.lbl_importeTotal.Text = venta.ImporteTotal.ToString("0.00");

                //Agregado por eze para mostrar subtotal
                InterfazVentaMayorista.lbl_subTotal.Text = venta.ImporteTotal.ToString("$ 0.00");

                //Quitamos la fila
                InterfazVentaMayorista.dgv_productos.Rows.RemoveAt(index);
                listaDetalle.RemoveAt(index);

                //Si llego a este punto es que efectivamente pudo quitar la fila
                bandera = 1;
                if (bandera != 0)
                {
                    articulo.aumentarStock(cantidad, codigoArticulo);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No a seleccionado una fila");
            }          
        }

        public void descartarArticulos()
        {
            int cantidad = InterfazVentaMayorista.dgv_productos.Rows.Count;
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
            venta.CodigoEncargado = InterfazVentaMayorista.InterfazContenedora.EncargadoActivo.CodigoEncargado;
            
            int codigoFormaPago = int.Parse(InterfazVentaMayorista.cbx_formaPago.SelectedValue.ToString());
            //venta.CodigoFormaPago = codigoFormaPago;

            ///////EFECTIVO, EFECTIVO DEBITO, CTA. CORRIENTE////////
            if (codigoFormaPago == 1 || codigoFormaPago == 2 || codigoFormaPago == 4)
            {
                venta.crearVentaMayorista(venta);
            }
            else
            {
                ////////TARJETA/////////////
                if (codigoFormaPago == 3)
                {
                    venta.crearVentaMayorista(venta);
                    tarjeta = new Tarjeta();
                    foreach (var item in listaTarjeta)
                    {
                        tarjeta.crear(item.Nombre, item.Apellido, item.Interes, item.Cuota, item.CodigoNombreTarjeta, item.CodigoTipoTarjeta, item.CodigoBanco, item.NumeroTarjeta, item.ImporteTarjeta, venta.CodigoVenta);
                    }
                }
                else
                {
                    venta.crearVentaMayorista(venta);
                    notaCredito = new NotaCredito();
                    foreach (var item in listaNotaCredito)
                    {
                        notaCredito.actualizarNotaDeCredito(item);
                    }
                }
            }

            if (listaEntrega.Count != 0 && InterfazVentaMayorista.ch_cargoEnvio.Checked)
            {
                registrarEntregas();
            }

            registrarDetalleVP();
        }

        private void registrarEntregas()
        {
            entrega = new Entrega();
            detalleLogistica = new DetalleLogistica();
            foreach (var item in listaEntrega)
            {
                item.CodigoEntrega = entrega.mostrarUltimoNroEntrega() + 1;
                entrega.crear(item.CodigoEntrega, venta.CodigoVenta, item.FechaEntrega, item.HoraEntregaDesde,
                    item.HoraEntregaHasta, item.NombreCliente, item.NombreProvincia, item.NombreDepartamento,
                    item.NombreLocalidad, item.NombreCalle, item.NumeroCalle.ToString(), item.CodigoPostal,
                    item.NombreBarrio, item.NombreTipoTelefono, item.NumeroTelefono, item.Descripcion,
                    item.PrecioEntrega, item.DistanciaEntrega, item.CodigoEstadoEntrega, item.CodigoEncargado);

                foreach (var itemLogistica in listaDetalleLogistica)
                {
                    detalleLogistica.crearDetalleLogisticaEntrega(itemLogistica.CodigoArticulo, itemLogistica.Cantidad, item.CodigoEntrega);
                }
            }
        }

        private void registrarDetalleVP()
        {
            try
            {
                foreach (var item in listaDetalle)
                {
                    detalleVp.crearDetalleVenta(item.CodigoArticulo,item.PrecioUnitario,item.Cantidad, venta.CodigoVenta);
                }
                mostrarVistaPrevia();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void mostrarVistaPrevia()
        {
            vistaPrevia = new IU_VistaPrevia();
            vistaPrevia.tomarModelo(modeloFactura, "Factura de Venta");
            //vistaPrevia.generarFactura(listaDetalle, venta);
            vistaPrevia.ShowDialog();
        }

        public void tomarRegistroTarjeta(List<Tarjeta> entregasDevueltas)
        {
            listaTarjeta = entregasDevueltas;

            foreach (var item in listaTarjeta)
            {

                acumulador = item.ImporteTarjeta * item.Interes / 100;
                interesEnPesos = interesEnPesos + acumulador;

            }
            actualizarDatosInterfaz();
        }

        public void registrarCobroConTarjeta()
        {
            interfazTarjetaMayorista = new IU_CobroConTarjetaMayorista();
            interfazTarjetaMayorista.iniciarDatosCobroTarjeta(this);
            interfazTarjetaMayorista.ShowDialog(InterfazVentaMayorista);
            interfazTarjetaMayorista.Hide();
        }

        public void actualizarDatosInterfaz()
        {
            int i = 0;
            float precio = 0.00f;
            float totalVenta = 0.00f;
            float totalInteres = 0.00f;
            float valorTotalEnvio = 0.00f;
            float valorTotalNC = 0.00f;
            DateTime fechaEntrega = DateTime.Now;
            if (listaEntrega != null)
            {                                
                foreach (var item in listaEntrega)
                {

                    valorTotalEnvio += item.PrecioEntrega;
                }
                InterfazVentaMayorista.lbl_cargoEnvio.Text = valorTotalEnvio.ToString("$ 0.00");
                InterfazVentaMayorista.lbl_cantidadEnvios.Text = listaEntrega.Count.ToString();
                InterfazVentaMayorista.lbl_importeTotal.Text = (venta.ImporteTotal + valorTotalEnvio).ToString("$ 0.00");
                InterfazVentaMayorista.btn_detallesEnvioDomicilio.Enabled = true;                
            }
            if (listaTarjeta.Count != 0)
            {

                if (InterfazVentaMayorista.cbx_formaPago.SelectedIndex == 2)
                    InterfazVentaMayorista.lbl_importeTotal.Text = (venta.ImporteTotal + interesEnPesos + valorTotalEnvio).ToString("$ 0.00");
                foreach (var item in listaTarjeta)
                {
                    i++;
                }
                if (i == 1)
                    InterfazVentaMayorista.lbl_cantidadTarjeta.Text = "1";
                if (i == 2)
                    InterfazVentaMayorista.lbl_cantidadTarjeta.Text = "2";
                if (i == 3)
                    InterfazVentaMayorista.lbl_cantidadTarjeta.Text = "3";
                if (i == 4)
                    InterfazVentaMayorista.lbl_cantidadTarjeta.Text = "4";
                if (i == 5)
                    InterfazVentaMayorista.lbl_cantidadTarjeta.Text = "5";

            }
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
                saldoAPagar = venta.ImporteTotal + interesEnPesos + valorTotalEnvio - valorTotalNC;
                InterfazVentaMayorista.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
                InterfazVentaMayorista.ch_notaCredito.Checked = true; //Agregado por Gerardo y autorizado por Ezequiel jaja
                InterfazVentaMayorista.ch_notaCredito.Enabled = true; //Agregado por Gerardo y autorizado por Ezequiel jaja
                InterfazVentaMayorista.btn_envioDomicilio.Enabled = false;
                InterfazVentaMayorista.btn_detallesEnvioDomicilio.Enabled = false;
                InterfazVentaMayorista.btn_cobroTarjeta.Enabled = false;
                InterfazVentaMayorista.btn_detalleTarjeta.Enabled = false;
                InterfazVentaMayorista.btn_cargar.Enabled = false;
                InterfazVentaMayorista.btn_quitarArticulo.Enabled = false;
            }

            foreach (var item in listaTarjeta)
            {
                totalVenta = totalVenta + item.ImporteTotalVentaCalculado;
                totalInteres = totalInteres + item.ImporteTarjeta;


            }
            precio = totalVenta - totalInteres;
            if (InterfazVentaMayorista.cbx_formaPago.SelectedIndex == 2)
                InterfazVentaMayorista.lbl_cargoTarjeta.Text = "$ " + precio.ToString("0.00");
        }

        ///////////////////////////////////////////////
        ///////// ENVIO A DOMICILIO ///////////////////
        ///////////////////////////////////////////////

        public void registrarOrdenDeRemito() //llama al CU registrar orden de remito 
        {
            listaEntregaAuxiliar.Clear();
            iu_registrarOrden = new IU_RegistrarOrden();
            iu_registrarOrden.opcionEnvioDomicilio(this);
            iu_registrarOrden.ShowDialog(InterfazVentaMayorista);
        }

        public void tomarRegistroOrdenRemito(List<Entrega> entregasDevueltas, List<DetalleLogistica> detalleLogisticaDevuelto) //El CU devuelve la/s entregas
        {
            InterfazVentaMayorista.btn_quitarArticulo.Enabled = false;
            listaEntrega = entregasDevueltas;
            listaDetalleLogistica = detalleLogisticaDevuelto;
            foreach (var item in listaEntrega)
            {
                listaEntregaAuxiliar.Add(item.PrecioEntrega);
            }
            if (InterfazVentaMayorista.ch_cargoEnvio.Checked==true)
            {
                actualizarDatosInterfaz();
            }
            else
            {
                InterfazVentaMayorista.ch_cargoEnvio.Enabled = true;
                InterfazVentaMayorista.ch_cargoEnvio.Checked = true;
            }            
        }

        ///////////////////////////////////////////////
        ///////// ACTUALIZAR NOTA DE CREDITO //////////
        ///////////////////////////////////////////////

        public void actualizarNotaDeCredito() //llama al CU actualizar nota de credito
        {
            if (listaNotaCredito.Count != 0)
            {
                DialogResult opcion = MessageBox.Show("¿Esta seguro que desea continuar? Se perdera la nota de credito cargada", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (opcion == DialogResult.OK)
                {
                    listaNotaCredito.Clear();
                    saldoAPagar = venta.ImporteTotal;
                    InterfazVentaMayorista.lbl_saldoAPagar.Text = saldoAPagar.ToString("$ 0.00");
                    iu_actualizarNotaDeCredito = new IU_ActualizarNotaDeCredito();
                    iu_actualizarNotaDeCredito.opcionActualizarNotaDeCredito(this);
                    iu_actualizarNotaDeCredito.ShowDialog(InterfazVentaMayorista);
                }
            }
            else
            {
                listaNotaCredito.Clear();
                iu_actualizarNotaDeCredito = new IU_ActualizarNotaDeCredito();
                iu_actualizarNotaDeCredito.opcionActualizarNotaDeCredito(this);
                iu_actualizarNotaDeCredito.ShowDialog(InterfazVentaMayorista);
            }
        }

        public void tomarActualizacionNotaCredito(List<NotaCredito> listaAActualizar)
        {
            listaNotaCredito = listaAActualizar;
            actualizarDatosInterfaz();
        }

        public void restablecerSaldo_sinNotaCredito()
        {
            if (InterfazVentaMayorista.ch_notaCredito.Checked == false)
            {
                float valorTotalNC = 0.00f;
                foreach (var item in listaNotaCredito)
                {
                    valorTotalNC += item.SaldoAnterior;
                }
                saldoAPagar += valorTotalNC;
                InterfazVentaMayorista.lbl_saldoAPagar.Text = saldoAPagar.ToString("$0.00");
            }

            if (InterfazVentaMayorista.ch_notaCredito.Checked == true)
            {
                actualizarDatosInterfaz();
            }
        }
    }    
}
