using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaLaObra.Ventas.Presupuesto
{
    class Controlador_RegistrarPresupuesto
    {
        public IU_RegistrarPresupuesto InterfazRegistrarPresupuesto { get; set; }
        Presupuesto presupuesto;
        DetalleVP detalleVp;
        List<DetalleVP> listaDetalle;
        Articulo articulo;
        ClienteMayorista clienteMayorista;
        IU_VistaPrevia vistaPrevia;
        Image modeloPresupuesto;

        string razonSocial;
        int cantidadSolicitada;
        float subTotal;

        public Controlador_RegistrarPresupuesto()
        {
            presupuesto = new Presupuesto();
            detalleVp = new DetalleVP();
            listaDetalle = new List<DetalleVP>();
            articulo = new Articulo();
            clienteMayorista = new ClienteMayorista();
            modeloPresupuesto = Properties.Resources.ModeloFactura; //No olvidar cambiar
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

        public void fechaPresupuesto(DateTime fechaPresupuesto)
        {
            presupuesto.Fecha = fechaPresupuesto;
        }

        public void nombreCliente(string nombreCliente)
        {
            presupuesto.NombreCliente = nombreCliente;
        }

        public void descripcionArticulo(string descripcionArticulo)
        {
            completar_dgvArticulosDisponibles(descripcionArticulo);
        }
        
        public void completar_dgvArticulosDisponibles(string nombreArticulo)
        {
            InterfazRegistrarPresupuesto.dgv_articulosDisponibles.Rows.Clear();

            List<int> codigoArticulos = new List<int>();
            codigoArticulos = articulo.buscarListaDeArticulos(nombreArticulo);
            foreach (var item in codigoArticulos)
            {
                articulo.mostrarDatos(item);
                InterfazRegistrarPresupuesto.dgv_articulosDisponibles.Rows.Add(articulo.CodigoArticulo,
                                                                articulo.Descripcion,
                                                                articulo.buscarNombreMarca(articulo.CodigoMarca),
                                                                articulo.buscarNombreProveedor(articulo.conocerProveedor(item)),
                                                                articulo.Stock,
                                                                articulo.buscarNombreUdadMedida(articulo.CodigoUnidadesDeMedida),
                                                                articulo.PrecioUnitario,
                                                                articulo.PrecioCoste);
            }
        }

        public void buscarDatosArticulos(int codigoArticulo)
        {
            articulo.mostrarDatos(codigoArticulo);
        }

        public void cantidadArticuloSolicitado(string cantidadArticulo)
        {
            this.cantidadSolicitada = int.Parse(cantidadArticulo);
            verificarStock();
        }

        private void verificarStock()
        {
            if (articulo.stockValido(cantidadSolicitada))
            {
                cargarGrillaArticulos();
            }
            else
            {
                MessageBox.Show("La cantidad solicitada supera el stock actual ="+articulo.Stock, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarGrillaArticulos()
        {
            if (verificarExistenciaArticuloEnGrilla())
            {
                int cantidadFilas = InterfazRegistrarPresupuesto.dgv_productos.Rows.Count;
                for (int i = 0; i < cantidadFilas; i++)
                {
                    int codigoArticulo = int.Parse(InterfazRegistrarPresupuesto.dgv_productos.Rows[i].Cells["Column1"].Value.ToString());
                    if (articulo.CodigoArticulo == codigoArticulo)
                    {
                        int cantidadExistente = int.Parse(InterfazRegistrarPresupuesto.dgv_productos.Rows[i].Cells["Column4"].Value.ToString());
                        int nuevaCantidad = cantidadExistente + cantidadSolicitada;
                        InterfazRegistrarPresupuesto.dgv_productos.Rows[i].Cells["Column4"].Value = nuevaCantidad;

                        subTotal = calcularSubTotal();
                        InterfazRegistrarPresupuesto.dgv_productos.Rows[i].Cells["Column5"].Value = nuevaCantidad * articulo.PrecioUnitario;

                        modificarCantidadListaDetalle(nuevaCantidad,codigoArticulo);
                    }
                }
            }
            else
            {
                subTotal = calcularSubTotal();
                InterfazRegistrarPresupuesto.dgv_productos.Rows.Add(articulo.CodigoArticulo, articulo.Descripcion, articulo.PrecioUnitario, cantidadSolicitada.ToString(), subTotal.ToString());
                listaDetalle.Add(new DetalleVP { CodigoArticulo = articulo.CodigoArticulo, PrecioUnitario = articulo.PrecioUnitario, Cantidad = cantidadSolicitada });
            }
        }

        private bool verificarExistenciaArticuloEnGrilla()
        {
            try
            {
                int cantidadFilas = InterfazRegistrarPresupuesto.dgv_productos.Rows.Count;
                for (int i = 0; i < cantidadFilas; i++)
                {
                    int codigoArticulo = int.Parse(InterfazRegistrarPresupuesto.dgv_productos.Rows[i].Cells["Column1"].Value.ToString());
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

        private void modificarCantidadListaDetalle(int nuevaCantidad, int codigoArticulo)
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

        private float calcularSubTotal()
        {
            return articulo.PrecioUnitario * cantidadSolicitada;
        }

        public void calcularImporteTotal()
        {
            presupuesto.ImporteTotal += subTotal;
            InterfazRegistrarPresupuesto.lbl_importeTotal.Text = presupuesto.ImporteTotal.ToString("0.00");
        }

        private void calcularFechaVencimiento()
        {
            presupuesto.FechaVencimiento = DateTime.Now;
            presupuesto.FechaVencimiento = presupuesto.FechaVencimiento.AddDays(10);
        }

        public void quitarArticulos()
        {
            try
            {
                int index = InterfazRegistrarPresupuesto.dgv_productos.CurrentRow.Index;
                float subTotal = float.Parse(InterfazRegistrarPresupuesto.dgv_productos.CurrentRow.Cells[4].Value.ToString());

                presupuesto.ImporteTotal -= subTotal;
                InterfazRegistrarPresupuesto.lbl_importeTotal.Text = presupuesto.ImporteTotal.ToString("0.00");

                InterfazRegistrarPresupuesto.dgv_productos.Rows.RemoveAt(index);
                listaDetalle.RemoveAt(index);
            }
            catch (Exception)
            {
                MessageBox.Show("No se selecciono ninguna articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    
        public void registrarPresupuesto()
        {
            if (razonSocial != "")
            {
                presupuesto.CodigoClienteMayorista = presupuesto.conocerClienteMayorista(razonSocial);
            }
            calcularFechaVencimiento();
            presupuesto.CodigoEncargado = InterfazRegistrarPresupuesto.InterfazContenedora.EncargadoActivo.CodigoEncargado;
            presupuesto.CodigoPresupuesto = presupuesto.ultimoCodigoPresupuesto() + 1;
            if (mostrarVistaPrevia())
            {
                presupuesto.crear(presupuesto);
                registrarDetalleVP();
                InterfazRegistrarPresupuesto.limpiarCampos();
                MessageBox.Show("El presupuesto se ha registrado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InterfazRegistrarPresupuesto.Close();
            }
        }
        private void registrarDetalleVP()
        {
          try
            {
                foreach (var item in listaDetalle)
                {
                    detalleVp.crearDetallePresupuesto(item.CodigoArticulo,item.PrecioUnitario,item.Cantidad, presupuesto.CodigoPresupuesto);
                }
                InterfazRegistrarPresupuesto.dgv_productos.Rows.Clear();
                InterfazRegistrarPresupuesto.dgv_articulosDisponibles.Rows.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        //PENDIENTE
        private bool mostrarVistaPrevia()
        {
            vistaPrevia = new IU_VistaPrevia();
            vistaPrevia.tomarModelo(modeloPresupuesto, "Presupuesto");
            vistaPrevia.generarPresupuesto(listaDetalle, presupuesto);
            vistaPrevia.btn_imprimir.Text = "Confirmar";
            vistaPrevia.ShowDialog();
            return vistaPrevia.confirmacion;
        }

    }
}
