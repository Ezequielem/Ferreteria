using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaLaObra.Ventas;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;
using SistemaLaObra.Ventas.Presupuesto;
using SistemaLaObra.Compras.ArticulosBajoStock;


namespace SistemaLaObra
{
    public partial class IU_VistaPrevia : Form
    {
     public  AriculoSeleccionado articuloSeleccionado;
      public List<AriculoSeleccionado> _ariculoSeleccionados;
        public IU_VistaPrevia()
        {
            articuloSeleccionado = new AriculoSeleccionado();
            _ariculoSeleccionados = new List<AriculoSeleccionado>();
            InitializeComponent();
        }

        Image modelo;
        string titulo;
        public bool confirmacion = false;

        public void tomarModelo(Image modelo, string titulo)
        {
            this.modelo = modelo;
            this.titulo = titulo;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            imprimir();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void generarRemito(Entrega instaciaEntrega, List<DetalleLogistica> instanciaListaDetalle)
        {
            modelo = Properties.Resources.ModeloRemito;
            //Modelo factura a dibujar
            Image remitoActual = modelo;
            Graphics g = Graphics.FromImage(remitoActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            Font fontTitulo = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            Font fontTituloMenor = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Verificamos la cantidad de filas que tiene el dataGridView
            int cantidadFilas = instanciaListaDetalle.Count;//dgv_productos.Rows.Count;
            //Cordenada de la primera fila
            int primerY = 426;
            //Para verificar si se dibujo la primera fila
            int bandera = 0;
            //Luego dibujamos las subsiguientes filas con la nueva cordenada Y
            int y = 42;

            //Cordenadas X de la descripcion
            int[] x = { 34, 110 };

            //Aca dibujamos la fecha
            string dia = instaciaEntrega.FechaEntrega.Day.ToString();
            string mes = instaciaEntrega.FechaEntrega.Month.ToString();
            string ano = instaciaEntrega.FechaEntrega.Year.ToString();
            g.DrawString(dia, font, brush, new Point(630, (primerY - 320)), formatter);
            g.DrawString(mes, font, brush, new Point(705, (primerY - 320)), formatter);
            g.DrawString(ano, font, brush, new Point(760, (primerY - 320)), formatter);

            //Dibujamos los datos del cliente

            g.DrawString(instaciaEntrega.NombreCliente, font, brush, new Point(120, primerY - 195), formatter);
            string direccion = instaciaEntrega.NombreCalle + " " + instaciaEntrega.NumeroCalle + ", " + instaciaEntrega.NombreBarrio + " " + instaciaEntrega.NombreLocalidad;
            g.DrawString(direccion, font, brush, new Point(120, (primerY - 195) + y), formatter);

            //Dibujamos nuestros datos

            g.DrawString("FERRETERIA La Obra", fontTituloMenor, brush, new Point(30, primerY - 415), formatter);
            g.DrawString("De Mario Labarre", fontTituloMenor, brush, new Point(30, primerY - 390), formatter);
            g.DrawString("Confeccionó:", font, brush, new Point(30, primerY - 345), formatter);
            string nombreCompleto = instaciaEntrega.conocerEncargado(instaciaEntrega.CodigoEncargado).Nombre + " " + instaciaEntrega.conocerEncargado(instaciaEntrega.CodigoEncargado).Apellido;
            g.DrawString(nombreCompleto, font, brush, new Point(30, primerY - 325), formatter);
            g.DrawString("Legajo:", font, brush, new Point(30, primerY - 305), formatter);
            g.DrawString(instaciaEntrega.conocerEncargado(instaciaEntrega.CodigoEncargado).Legajo.ToString(), font, brush, new Point(100, primerY - 305), formatter);

            //Aca van los items
            Articulo _articulo = new Articulo();

            if (cantidadFilas <= 11)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (bandera == 0)
                    {
                        g.DrawString(instanciaListaDetalle[i].CodigoArticulo.ToString(), font, brush, new Point(x[0], primerY), formatter);
                        g.DrawString(_articulo.mostrarNombre(instanciaListaDetalle[i].CodigoArticulo), font, brush, new Point(x[1], primerY), formatter);
                        bandera = 1;
                    }
                    else
                    {
                        g.DrawString(instanciaListaDetalle[i].CodigoArticulo.ToString(), font, brush, new Point(x[0], (primerY + y)), formatter);
                        g.DrawString(_articulo.mostrarNombre(instanciaListaDetalle[i].CodigoArticulo), font, brush, new Point(x[1], (primerY + y)), formatter);
                        y += 42 - 2;
                    }
                }                
                lbl_titulo.Text = titulo;
                pb_vistaPrevia.Image = remitoActual;
            }
            else
            {
                MessageBox.Show("Supero la cantidad de productos por factura");
            }
        }

        public void generarPedido(Compra instanciaCompra, List<DetalleCompra> instanciaListaDetalleCompra)
        {
            modelo = Properties.Resources.ModeloPedido;
            //Modelo factura a dibujar
            Image pedidoActual = modelo;
            Graphics g = Graphics.FromImage(pedidoActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            Font fontTitulo = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            Font fontTituloMenor = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Verificamos la cantidad de filas que tiene el dataGridView
            int cantidadFilas = instanciaListaDetalleCompra.Count;//dgv_productos.Rows.Count;
            //Cordenada de la primera fila
            int primerY = 240;
            //Para verificar si se dibujo la primera fila
            int bandera = 0;
            //Luego dibujamos las subsiguientes filas con la nueva cordenada Y
            int y = 25;

            //Cordenadas X de la descripcion
            int[] x = { 15, 53, 300, 425 };

            //Aca dibujamos la fecha
            string dia = instanciaCompra.FechaHora.Day.ToString();
            string mes = instanciaCompra.FechaHora.Month.ToString();
            string ano = instanciaCompra.FechaHora.Year.ToString();
            g.DrawString(dia, font, brush, new Point(300, (primerY - 104)), formatter);
            g.DrawString(mes, font, brush, new Point(370, (primerY - 104)), formatter);
            g.DrawString(ano, font, brush, new Point(450, (primerY - 104)), formatter);

            //dibujamos el numero de orden
            g.DrawString(instanciaCompra.CodigoCompra.ToString("N° 0000"), fontTitulo, brush, new Point(340, primerY - 150), formatter);

            //Dibujamos nuestros datos
            g.DrawString("FERRETERIA La Obra", fontTituloMenor, brush, new Point(20, primerY - 215), formatter);
            g.DrawString("De Mario Labarre", fontTituloMenor, brush, new Point(20, primerY - 190), formatter);
            g.DrawString("Confeccionó:", font, brush, new Point(20, primerY - 145), formatter);
            string nombreCompleto = instanciaCompra.conocerEncargado(instanciaCompra.CodigoEncargadoCompra).Nombre + " " + instanciaCompra.conocerEncargado(instanciaCompra.CodigoEncargadoCompra).Apellido;
            g.DrawString(nombreCompleto, font, brush, new Point(20, primerY - 125), formatter);
            g.DrawString("Legajo:", font, brush, new Point(20, primerY - 105), formatter);
            g.DrawString(instanciaCompra.conocerEncargado(instanciaCompra.CodigoEncargadoCompra).Legajo.ToString(), font, brush, new Point(90, primerY - 105), formatter);

            //Aca van los items
            Articulo _articulo = new Articulo();

            if (cantidadFilas <= 15)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (bandera == 0)
                    {
                        g.DrawString(instanciaListaDetalleCompra[i].Cantidad.ToString(), font, brush, new Point(x[0], primerY), formatter);
                        g.DrawString(_articulo.mostrarNombre(instanciaListaDetalleCompra[i].CodigoArticulo), font, brush, new Point(x[1], primerY), formatter);
                        g.DrawString(instanciaListaDetalleCompra[i].PrecioCoste.ToString("$ 0.00"), font, brush, new Point(x[2], primerY), formatter);
                        g.DrawString((instanciaListaDetalleCompra[i].PrecioCoste* instanciaListaDetalleCompra[i].Cantidad).ToString("$ 0.00"), font, brush, new Point(x[3], primerY), formatter);
                        bandera = 1;
                    }
                    else
                    {
                        g.DrawString(instanciaListaDetalleCompra[i].Cantidad.ToString(), font, brush, new Point(x[0], (primerY + y)), formatter);
                        g.DrawString(_articulo.mostrarNombre(instanciaListaDetalleCompra[i].CodigoArticulo), font, brush, new Point(x[1], (primerY + y)), formatter);
                        g.DrawString(instanciaListaDetalleCompra[i].PrecioCoste.ToString("$ 0.00"), font, brush, new Point(x[2], primerY + y), formatter);
                        g.DrawString((instanciaListaDetalleCompra[i].PrecioCoste * instanciaListaDetalleCompra[i].Cantidad).ToString("$ 0.00"), font, brush, new Point(x[3], primerY + y), formatter);
                        y += 27 - 2;
                    }
                }
                g.DrawString(instanciaCompra.ImporteTotal.ToString("$ 0.00"), font, brush, new Point(x[3], primerY + 370), formatter);
                lbl_titulo.Text = titulo;
                pb_vistaPrevia.Image = pedidoActual;
            }
            else
            {
                MessageBox.Show("Supero la cantidad de productos por factura");
            }
        }

        public void generarPedidoPorProveedor(Compra instanciaCompra, List<DetalleCompra> instanciaListaDetalleCompra, Proveedor instanciaProveedor)
        {
            modelo = Properties.Resources.ModeloPedido;
            //Modelo factura a dibujar
            Image pedidoActual = modelo;
            Graphics g = Graphics.FromImage(pedidoActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            Font fontTitulo = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            Font fontTituloMenor = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Verificamos la cantidad de filas que tiene el dataGridView
            int cantidadFilas = instanciaListaDetalleCompra.Count;//dgv_productos.Rows.Count;
            //Cordenada de la primera fila
            int primerY = 240;
            //Para verificar si se dibujo la primera fila
            int bandera = 0;
            //Luego dibujamos las subsiguientes filas con la nueva cordenada Y
            int y = 25;

            //Cordenadas X de la descripcion
            int[] x = { 15, 53, 300, 425 };

            //Aca dibujamos la fecha
            string dia = instanciaCompra.FechaHora.Day.ToString();
            string mes = instanciaCompra.FechaHora.Month.ToString();
            string ano = instanciaCompra.FechaHora.Year.ToString();
            g.DrawString(dia, font, brush, new Point(300, (primerY - 104)), formatter);
            g.DrawString(mes, font, brush, new Point(370, (primerY - 104)), formatter);
            g.DrawString(ano, font, brush, new Point(450, (primerY - 104)), formatter);

            //dibujamos el numero de orden
            g.DrawString(instanciaCompra.CodigoCompra.ToString("N° 0000"), fontTitulo, brush, new Point(340, primerY - 150), formatter);

            //Dibujamos nuestros datos
            g.DrawString("FERRETERIA La Obra", fontTituloMenor, brush, new Point(20, primerY - 215), formatter);
            g.DrawString("De Mario Labarre", fontTituloMenor, brush, new Point(20, primerY - 190), formatter);
            g.DrawString("Confeccionó:", font, brush, new Point(20, primerY - 145), formatter);
            string nombreCompleto = instanciaCompra.conocerEncargado(instanciaCompra.CodigoEncargadoCompra).Nombre + " " + instanciaCompra.conocerEncargado(instanciaCompra.CodigoEncargadoCompra).Apellido;
            g.DrawString(nombreCompleto, font, brush, new Point(20, primerY - 125), formatter);
            g.DrawString("Legajo:", font, brush, new Point(20, primerY - 105), formatter);
            g.DrawString(instanciaCompra.conocerEncargado(instanciaCompra.CodigoEncargadoCompra).Legajo.ToString(), font, brush, new Point(90, primerY - 105), formatter);

            
            //dibujamos los datos del proveedor
            g.DrawString(instanciaProveedor.RazonSocial, font, brush, new Point(100, primerY - 75), formatter);
            g.DrawString(instanciaProveedor.Calle+""+instanciaProveedor.NumeroCasa+" "+instanciaProveedor.Localidad.Departamento.Provincia+" "+instanciaProveedor.Localidad.Departamento, font, brush, new Point(100, primerY - 50), formatter);

            //Aca van los items
            Articulo _articulo = new Articulo();

            if (cantidadFilas <= 15)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (bandera == 0)
                    {
                        g.DrawString(instanciaListaDetalleCompra[i].Cantidad.ToString(), font, brush, new Point(x[0], primerY), formatter);
                        g.DrawString(_articulo.mostrarNombre(instanciaListaDetalleCompra[i].CodigoArticulo), font, brush, new Point(x[1], primerY), formatter);
                        g.DrawString(instanciaListaDetalleCompra[i].PrecioCoste.ToString("$ 0.00"), font, brush, new Point(x[2], primerY), formatter);
                        g.DrawString((instanciaListaDetalleCompra[i].PrecioCoste * instanciaListaDetalleCompra[i].Cantidad).ToString("$ 0.00"), font, brush, new Point(x[3], primerY), formatter);
                        bandera = 1;
                    }
                    else
                    {
                        g.DrawString(instanciaListaDetalleCompra[i].Cantidad.ToString(), font, brush, new Point(x[0], (primerY + y)), formatter);
                        g.DrawString(_articulo.mostrarNombre(instanciaListaDetalleCompra[i].CodigoArticulo), font, brush, new Point(x[1], (primerY + y)), formatter);
                        g.DrawString(instanciaListaDetalleCompra[i].PrecioCoste.ToString("$ 0.00"), font, brush, new Point(x[2], primerY + y), formatter);
                        g.DrawString((instanciaListaDetalleCompra[i].PrecioCoste * instanciaListaDetalleCompra[i].Cantidad).ToString("$ 0.00"), font, brush, new Point(x[3], primerY + y), formatter);
                        y += 27 - 2;
                    }
                }
                float total = 0f;
                foreach (var item in instanciaListaDetalleCompra)
                {
                    total += item.PrecioCoste*item.Cantidad;
                }
                g.DrawString(total.ToString("$ 0.00"), font, brush, new Point(x[3], primerY + 370), formatter);
                lbl_titulo.Text = titulo;
                pb_vistaPrevia.Image = pedidoActual;
            }
            else
            {
                MessageBox.Show("Supero la cantidad de productos por factura");
            }
        }

        //FALTA CODIGO SEGUNDA HOJA Y MODIFICAR MODELOS CON PHOTOSHOP
        public void generarFactura(List<DetalleVP> listaDetalle, Venta venta, bool cargoEnvio,float totalEnvio, int cantidadEnvio)
        {
            lbl_titulo.Text = titulo;

            //Modelo factura a dibujar
            Image facturaActual = modelo;
            Graphics g = Graphics.FromImage(facturaActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Coordenada de la primera fila
            int posicionY = 420;

            if (listaDetalle.Count <= 14)
            {
                foreach (var item in listaDetalle)
                {

                    Articulo articulo = new Articulo();
                    articulo.mostrarDatos(item.CodigoArticulo);

                    g.DrawString(item.Cantidad.ToString(), font, brush, new Point(34, posicionY), formatter);
                    g.DrawString(articulo.Descripcion, font, brush, new Point(85, posicionY), formatter);
                    g.DrawString(item.PrecioUnitario.ToString("$ 0.00"), font, brush, new Point(480, posicionY), formatter);
                    g.DrawString((item.Cantidad * item.PrecioUnitario).ToString("$ 0.00"), font, brush, new Point(570, posicionY), formatter);

                    posicionY += 30;
                }

                if (cargoEnvio)
                {
                    g.DrawString(cantidadEnvio.ToString(), font, brush, new Point(34, posicionY), formatter);
                    g.DrawString("Cargo de envio", font, brush, new Point(85, posicionY), formatter);
                    g.DrawString(totalEnvio.ToString("$ 0.00"), font, brush, new Point(480, posicionY), formatter);
                    g.DrawString(totalEnvio.ToString("$ 0.00"), font, brush, new Point(570, posicionY), formatter);
                }

                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();

                //Dibujamos el importe total
                g.DrawString(venta.ImporteTotal.ToString("$0.00"), font, brush, new Point(570, 812), formatter);

                //Dibujamos fecha
                g.DrawString(dia, font, brush, new Point(520, 116), formatter);
                g.DrawString(mes, font, brush, new Point(570, 116), formatter);
                g.DrawString(ano, font, brush, new Point(620, 116), formatter);

                //Dibujamos numero de venta (factura)
                g.DrawString("000-0"+venta.CodigoVenta.ToString(), font, brush, new Point(430,30), formatter);

                //Dibujamos los datos del cliente
                if (venta.CodigoClienteMayorista != 0)
                {
                    ClienteMayorista clienteMayorista = new ClienteMayorista();
                    clienteMayorista.mostrarDatos(venta.CodigoClienteMayorista);
                    g.DrawString(clienteMayorista.RazonSocial, font, brush, new Point(110, 226), formatter);
                    g.DrawString(clienteMayorista.Calle + " " + clienteMayorista.Numero + ", " + clienteMayorista.NombreBarrio, font, brush, new Point(110, 266), formatter);
                    g.DrawString(clienteMayorista.Cuit, font, brush, new Point(530, 326), formatter);
                }

                pb_vistaPrevia.Image = facturaActual;
            }
            else
            {
                //No olvidar agregar una segunda hoja
            }
        }

        public void generarArticulosBajoStock(List<AriculoSeleccionado> _ariculoSeleccionados, Controlador_ArticulosBajoStock controlador)
        {
            //int codigoEnc = codigoEncargado;
            modelo = Properties.Resources.Modelo_BajoStock;
            //Modelo factura a dibujar
            Image pedidoActual = modelo;
            Graphics g = Graphics.FromImage(pedidoActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            Font fontTitulo = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            Font fontTituloMenor = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Verificamos la cantidad de filas que tiene el dataGridView
            int cantidadFilas = _ariculoSeleccionados.Count;//dgv_productos.Rows.Count;
            //Cordenada de la primera fila
            int primerY = 230;
            //Para verificar si se dibujo la primera fila
            int bandera = 0;
            //Luego dibujamos las subsiguientes filas con la nueva cordenada Y
            int y = 30;

            //Cordenadas X de la descripcion
            int[] x = { 20, 100, 263, 350, 435 };

            //Aca dibujamos la fecha
            string dia = DateTime.Today.Day.ToString();
            string mes = DateTime.Today.Month.ToString();
            string ano = DateTime.Today.Year.ToString();
            g.DrawString(dia, font, brush, new Point(290, (primerY - 107)), formatter);
            g.DrawString(mes, font, brush, new Point(362, (primerY - 107)), formatter);
            g.DrawString(ano, font, brush, new Point(418, (primerY - 107)), formatter);



            //Dibujamos nuestros datos
            int codigoEncargado = controlador.interfaz.InterfazContenedora.EncargadoActivo.CodigoEncargado;
            controlador.encargado.mostrarDatos(codigoEncargado);
            string nombreCompleto = controlador.encargado.Nombre + " " + controlador.encargado.Apellido;
            g.DrawString(nombreCompleto, font, brush, new Point(70, primerY - 107), formatter);

            

            //Aca van los items
    

            if (cantidadFilas <= 15)
            {
                for (int i = 0; i < cantidadFilas; i++)
                {
                    if (bandera == 0)
                    {
                        g.DrawString(_ariculoSeleccionados[i].codigoArticulo.ToString(), font, brush, new Point(x[0], primerY), formatter);
                        g.DrawString(_ariculoSeleccionados[i].descripcion.ToString(), font, brush, new Point(x[1], primerY), formatter);
                        g.DrawString(_ariculoSeleccionados[i].proveedor.ToString(), font, brush, new Point(x[2], primerY), formatter);
                        g.DrawString(_ariculoSeleccionados[i].precioCoste.ToString(), font, brush, new Point(x[3], primerY), formatter);
                        g.DrawString(_ariculoSeleccionados[i].stock, font, brush, new Point(x[4], primerY), formatter);
                        bandera = 1;
                    }
                    else
                    {
                        g.DrawString(_ariculoSeleccionados[i].codigoArticulo.ToString(), font, brush, new Point(x[0], (primerY + y)), formatter);
                        g.DrawString(_ariculoSeleccionados[i].descripcion.ToString(), font, brush, new Point(x[1], (primerY + y)), formatter);
                        g.DrawString(_ariculoSeleccionados[i].proveedor.ToString(), font, brush, new Point(x[2], (primerY + y)), formatter);
                        g.DrawString(_ariculoSeleccionados[i].precioCoste.ToString(), font, brush, new Point(x[3], (primerY + y)), formatter);
                        g.DrawString(_ariculoSeleccionados[i].stock, font, brush, new Point(x[4], (primerY + y)), formatter);
                        y += 30 + 1;
                    }
                }
            
                
                pb_vistaPrevia.Image = pedidoActual;
            }
            else
            {
                MessageBox.Show("Supero la cantidad de productos por factura");
            }
        }

        /*
        public void generarFactura(string descripcion, Venta venta)
        {
            lbl_titulo.Text = titulo;

            //Modelo factura a dibujar
            Image facturaActual = modelo;
            Graphics g = Graphics.FromImage(facturaActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Coordenada de la primera fila
            int posicionY = 420;

            g.DrawString("1", font, brush, new Point(34, posicionY), formatter);
            g.DrawString(descripcion, font, brush, new Point(85, posicionY), formatter);
            g.DrawString(venta.ImporteTotal.ToString("$ 0.00"), font, brush, new Point(480, posicionY), formatter);
            g.DrawString(venta.ImporteTotal.ToString("$ 0.00"), font, brush, new Point(570, posicionY), formatter);
            
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            //Dibujamos el importe total
            g.DrawString(venta.ImporteTotal.ToString("$0.00"), font, brush, new Point(570, 812), formatter);

            //Dibujamos fecha
            g.DrawString(dia, font, brush, new Point(520, 116), formatter);
            g.DrawString(mes, font, brush, new Point(570, 116), formatter);
            g.DrawString(ano, font, brush, new Point(620, 116), formatter);

            //Dibujamos los datos del cliente
            if (venta.CodigoClienteMayorista != 0)
            {
                ClienteMayorista clienteMayorista = new ClienteMayorista();
                clienteMayorista.mostrarDatos(venta.CodigoClienteMayorista);
                g.DrawString(clienteMayorista.RazonSocial, font, brush, new Point(110, 226), formatter);
                g.DrawString(clienteMayorista.Calle + " " + clienteMayorista.Numero + ", " + clienteMayorista.NombreBarrio, font, brush, new Point(110, 266), formatter);
                g.DrawString(clienteMayorista.Cuit, font, brush, new Point(530, 326), formatter);
            }

            pb_vistaPrevia.Image = facturaActual;
        }

        public void generarFactura(string descripcion,int cantidadEnvios, Venta venta)
        {
            lbl_titulo.Text = titulo;

            //Modelo factura a dibujar
            Image facturaActual = modelo;
            Graphics g = Graphics.FromImage(facturaActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Coordenada de la primera fila
            int posicionY = 420;

            g.DrawString(cantidadEnvios.ToString(), font, brush, new Point(34, posicionY), formatter);
            g.DrawString(descripcion, font, brush, new Point(85, posicionY), formatter);
            g.DrawString(venta.ImporteTotal.ToString("$ 0.00"), font, brush, new Point(480, posicionY), formatter);
            g.DrawString(venta.ImporteTotal.ToString("$ 0.00"), font, brush, new Point(570, posicionY), formatter);

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();

            //Dibujamos el importe total
            g.DrawString(venta.ImporteTotal.ToString("$0.00"), font, brush, new Point(570, 812), formatter);

            //Dibujamos fecha
            g.DrawString(dia, font, brush, new Point(520, 116), formatter);
            g.DrawString(mes, font, brush, new Point(570, 116), formatter);
            g.DrawString(ano, font, brush, new Point(620, 116), formatter);

            //Dibujamos los datos del cliente
            if (venta.CodigoClienteMayorista != 0)
            {
                ClienteMayorista clienteMayorista = new ClienteMayorista();
                clienteMayorista.mostrarDatos(venta.CodigoClienteMayorista);
                g.DrawString(clienteMayorista.RazonSocial, font, brush, new Point(110, 226), formatter);
                g.DrawString(clienteMayorista.Calle + " " + clienteMayorista.Numero + ", " + clienteMayorista.NombreBarrio, font, brush, new Point(110, 266), formatter);
                g.DrawString(clienteMayorista.Cuit, font, brush, new Point(530, 326), formatter);
            }

            pb_vistaPrevia.Image = facturaActual;
        }
        */

        //FALTA CODIGO SEGUNDA HOJA Y MODIFICAR MODELOS CON PHOTOSHOP
        public void generarNotaDeCredito(List<DetalleVP> listaDetalle, NotaCredito notaCredito)
        {
            lbl_titulo.Text = titulo;

            //Modelo factura a dibujar
            Image notaActual = modelo;
            Graphics g = Graphics.FromImage(notaActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Coordenada de la primera fila
            int posicionY = 390;

            if (listaDetalle.Count <= 14)
            {
                if (listaDetalle.Count != 0)
                {
                    foreach (var item in listaDetalle)
                    {
                        Articulo articulo = new Articulo();
                        articulo.mostrarDatos(item.CodigoArticulo);

                        g.DrawString(item.CantidadDevuelta.ToString(), font, brush, new Point(30, posicionY), formatter);
                        g.DrawString(item.CodigoArticulo.ToString(), font, brush, new Point(75, posicionY), formatter);
                        g.DrawString(articulo.Descripcion, font, brush, new Point(110, posicionY), formatter);
                        g.DrawString(item.PrecioUnitario.ToString("$ 0.00"), font, brush, new Point(365, posicionY), formatter);
                        g.DrawString((item.CantidadDevuelta * item.PrecioUnitario).ToString("$ 0.00"), font, brush, new Point(440, posicionY), formatter);

                        posicionY += 35;
                    }
                }
                else
                {
                    g.DrawString("1", font, brush, new Point(30, posicionY), formatter);
                    g.DrawString("0", font, brush, new Point(75, posicionY), formatter);
                    g.DrawString("Excedente de envio", font, brush, new Point(110, posicionY), formatter);
                    g.DrawString(notaCredito.Saldo.ToString("$0.00"), font, brush, new Point(365, posicionY), formatter);
                    g.DrawString(notaCredito.Saldo.ToString("$0.00"), font, brush, new Point(440, posicionY), formatter);
                }

                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();

                //Dibujamos el importe total
                g.DrawString(notaCredito.Saldo.ToString("$0.00"), font, brush, new Point(440,600), formatter);

                //Dibujamos fecha
                g.DrawString(dia, font, brush, new Point(330, 80), formatter);
                g.DrawString(mes, font, brush, new Point(370, 80), formatter);
                g.DrawString(ano, font, brush, new Point(410, 80), formatter);

                //Dibujamos datos cliente
                if (notaCredito.CodigoClienteMayorista != 0)
                {
                    ClienteMayorista clienteMayorista = new ClienteMayorista();
                    clienteMayorista.mostrarDatos(notaCredito.CodigoClienteMayorista);
                    g.DrawString(clienteMayorista.RazonSocial, font, brush, new Point(90, 200), formatter);
                    g.DrawString(clienteMayorista.Calle + " " + clienteMayorista.Numero + ", " + clienteMayorista.NombreBarrio, font, brush, new Point(90, 230), formatter);
                }
                else
                {
                    g.DrawString(notaCredito.NombreCliente, font, brush, new Point(90, 200), formatter);
                }

                pb_vistaPrevia.Image = notaActual;
            }
            else
            {
                //No olvidar agregar una segunda hoja
            }
        }

        //FALTA CODIGO SEGUNDA HOJA Y MODIFICAR MODELOS CON PHOTOSHOP
        public void generarPresupuesto(List<DetalleVP> listaDetalle, Presupuesto presupuesto)
        {
            lbl_titulo.Text = titulo;

            //Modelo factura a dibujar
            Image presupuestoActual = modelo;
            Graphics g = Graphics.FromImage(presupuestoActual);

            //Fuente y alineacion de escritura
            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Near;
            formatter.Alignment = StringAlignment.Near;
            Font font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            //Coordenada de la primera fila
            int posicionY = 420;

            if (listaDetalle.Count <= 14)
            {
                foreach (var item in listaDetalle)
                {

                    Articulo articulo = new Articulo();
                    articulo.mostrarDatos(item.CodigoArticulo);

                    g.DrawString(item.Cantidad.ToString(), font, brush, new Point(34, posicionY), formatter);
                    g.DrawString(articulo.Descripcion, font, brush, new Point(85, posicionY), formatter);
                    g.DrawString(item.PrecioUnitario.ToString("$ 0.00"), font, brush, new Point(480, posicionY), formatter);
                    g.DrawString((item.Cantidad * item.PrecioUnitario).ToString("$ 0.00"), font, brush, new Point(570, posicionY), formatter);

                    posicionY += 30;
                }

                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();

                //Dibujamos el importe total
                g.DrawString(presupuesto.ImporteTotal.ToString("$0.00"), font, brush, new Point(570, 812), formatter);

                //Dibujamos fecha
                g.DrawString(dia, font, brush, new Point(520, 116), formatter);
                g.DrawString(mes, font, brush, new Point(570, 116), formatter);
                g.DrawString(ano, font, brush, new Point(620, 116), formatter);

                //Dibujamos los datos del cliente
                if (presupuesto.CodigoClienteMayorista != 0)
                {
                    ClienteMayorista clienteMayorista = new ClienteMayorista();
                    clienteMayorista.mostrarDatos(presupuesto.CodigoClienteMayorista);
                    g.DrawString(clienteMayorista.RazonSocial, font, brush, new Point(110, 226), formatter);
                    g.DrawString(clienteMayorista.Calle + " " + clienteMayorista.Numero + ", " + clienteMayorista.NombreBarrio, font, brush, new Point(110, 266), formatter);
                    g.DrawString(clienteMayorista.Cuit, font, brush, new Point(530, 326), formatter);
                }
                else
                {
                    g.DrawString(presupuesto.NombreCliente, font, brush, new Point(110, 226), formatter);
                }

                pb_vistaPrevia.Image = presupuestoActual;
            }
            else
            {
                //No olvidar agregar una segunda hoja
            }
        }

        public bool imprimir()
        {
            confirmacion = true;
            try
            {
                ImprimirFormulario printForm = new ImprimirFormulario(gbx_vistaPrevia);
                printForm.imprimirCaja();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ninguna impresora conectada");
                return false;
            }
        }
    }
}
