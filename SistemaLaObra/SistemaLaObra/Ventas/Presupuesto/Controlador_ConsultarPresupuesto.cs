using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.Presupuesto
{
    public class Controlador_ConsultarPresupuesto
    {
        
        Presupuesto presupuesto;
        List<Presupuesto> listaPresupuestos;
        DetalleVP detalle;
        List<DetalleVP> listaDetalle;
        Articulo articulo;
        ClienteMayorista clienteMayorista;
        public IU_ConsultarPresupuesto interfazConsultarPresupuesto { get; set; }
        IU_RegistrarVenta interfazVentaMostrador;

        public Controlador_ConsultarPresupuesto()
        {
            presupuesto = new Presupuesto();
            listaPresupuestos = new List<Presupuesto>();
            detalle = new DetalleVP();
            listaDetalle = new List<DetalleVP>();
            articulo = new Articulo();
            clienteMayorista = new ClienteMayorista();
        }

        public void numeroPresupuesto(string numeroPresupuesto)
        {
            presupuesto.CodigoPresupuesto = int.Parse(numeroPresupuesto);
        }

        public bool verificarExistencia()
        {
            if (presupuesto.verificarNumeroPresupuesto(presupuesto.CodigoPresupuesto))
            {
                presupuesto.mostrarDatos(presupuesto.CodigoPresupuesto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void mostrarDatosPresupuesto()
        {
            interfazConsultarPresupuesto.lbl_fecha.Text = presupuesto.Fecha.ToString("dd/MM/yyyy");
            interfazConsultarPresupuesto.lbl_fechaVencimiento.Text = presupuesto.FechaVencimiento.ToString("dd/MM/yyyy");
            interfazConsultarPresupuesto.lbl_importeTotal.Text = presupuesto.ImporteTotal.ToString();

            listaDetalle = detalle.obtenerListaDetalleVP(presupuesto);

            foreach (var item in listaDetalle)
            {
                articulo.mostrarDatos(item.CodigoArticulo);
                interfazConsultarPresupuesto.dgv_productos.Rows.Add(item.CodigoArticulo,articulo.Descripcion,item.PrecioUnitario,item.Cantidad,(articulo.PrecioUnitario * item.Cantidad));
            }
        }

        public void iniciarVenta()
        {
            if (DateTime.Now > presupuesto.FechaVencimiento)
            {
                MessageBox.Show("El presupuesto esta vencido, los precios pueden variar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            interfazVentaMostrador = new IU_RegistrarVenta();
            interfazVentaMostrador.gb_tipoCliente.Enabled = false;

            if (presupuesto.CodigoClienteMayorista != 0)
            {
                interfazVentaMostrador.rb_clienteMayorista.Checked = true;
                interfazVentaMostrador.txt_razonSocial.Text = presupuesto.conocerClienteMayorista(presupuesto.CodigoClienteMayorista).RazonSocial;
            }

            int bandera = 0; //Se crea esta bandera para saber si se cargaron todos los articulos o no.

            foreach (var item in this.listaDetalle)
            {
                interfazVentaMostrador.controlador.codigoArticulo = item.CodigoArticulo;
                interfazVentaMostrador.controlador.cantidad = item.Cantidad;
                interfazVentaMostrador.controlador.buscarDatosArticulos(interfazVentaMostrador.controlador.codigoArticulo);
                if (!interfazVentaMostrador.controlador.verificarStock())
                    bandera = 1;

            }

            interfazVentaMostrador.InterfazContenedora = interfazConsultarPresupuesto.InterfazContenedora;
            interfazVentaMostrador.Show();
            if (bandera != 0)
            {
                MessageBox.Show("Algunos de los articulos no se cargaron por falta de stock", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
