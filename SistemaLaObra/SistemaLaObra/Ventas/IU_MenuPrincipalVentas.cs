using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra;
using SistemaLaObra.Ventas.ReporteDeVentas;
using SistemaLaObra.Ventas.Presupuesto;
using SistemaLaObra.Ventas.OrdenDeRemito;
using SistemaLaObra.Ventas;
using SistemaLaObra.Ventas.RegistrarClienteMayorista;
using SistemaLaObra.Ventas.ActualizarOrdenRemito;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;
using SistemaLaObra.Ventas.ActualizarNotaDeCredito;
using SistemaLaObra.Ventas.ConsultarVenta;

namespace SistemaLaObra
{
    public partial class IU_MenuPrincipalVentas : Form
    {
        public IU_MenuPrincipalVentas()
        {
            InitializeComponent();
        }
        
        IU_RegistrarVenta minorista;
        IU_ConsultarVenta consultarVenta;
        IU_RegistrarPresupuesto presupuesto;
        IU_RegistrarOrden remito;
        IU_ReporteDeVentas reporte;
        IU_RegistrarClienteMayorista registrarClienteMayorista;
        IU_ActualizarOrdenRemito actualizarOrdenRemito;
        IU_ConsultarPresupuesto consultarPresupuesto;
        IU_RegistrarNotaCredito registrarNotaCredito;

        public IU_MenuPrincipal interfazContenedora { get; set; }

        private void btn_ventaMinorista_Click(object sender, EventArgs e)
        {
            minorista = new IU_RegistrarVenta();
            minorista.InterfazContenedora = interfazContenedora;
            minorista.ShowDialog();
        }

        private void btn_consultarVentas_Click(object sender, EventArgs e)
        {
            consultarVenta = new IU_ConsultarVenta();
            consultarVenta.InterfazContenedora = interfazContenedora;
            consultarVenta.ShowDialog();
        }

        private void btn_reporteVentas_Click(object sender, EventArgs e)
        {
            reporte = new IU_ReporteDeVentas();
            reporte.ShowDialog();
        }

        private void btn_registrarPresupuesto_Click(object sender, EventArgs e)
        {
            presupuesto = new IU_RegistrarPresupuesto();
            presupuesto.InterfazContenedora = interfazContenedora;
            presupuesto.ShowDialog();
        }

        private void btn_registrarEnvio_Click(object sender, EventArgs e)
        {
            remito = new IU_RegistrarOrden();
            remito.InterfazContenedora = interfazContenedora;
            remito.opcionEnvioDomicilio();
            remito.ShowDialog(this);
        }

        private void btn_registrarClienteMayorista_Click(object sender, EventArgs e)
        {
            registrarClienteMayorista = new IU_RegistrarClienteMayorista();
            registrarClienteMayorista.ShowDialog();
        }

        private void btn_actualizarEnvio_Click(object sender, EventArgs e)
        {
            actualizarOrdenRemito = new IU_ActualizarOrdenRemito();
            actualizarOrdenRemito.InterfazContenedora = interfazContenedora;
            actualizarOrdenRemito.ShowDialog(this);
        }

        private void btn_consultarPrespuesto_Click(object sender, EventArgs e)
        {
            consultarPresupuesto = new IU_ConsultarPresupuesto();
            consultarPresupuesto.InterfazContenedora = interfazContenedora;
            consultarPresupuesto.ShowDialog();
        }

        private void btn_registrarNotaCredito_Click(object sender, EventArgs e)
        {
            registrarNotaCredito = new IU_RegistrarNotaCredito();
            registrarNotaCredito.InterfazContenedora = interfazContenedora;
            registrarNotaCredito.ShowDialog();
        }
    }
}
