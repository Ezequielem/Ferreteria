using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Compras.RegistrarCompra;
using SistemaLaObra.Compras.RegistrarProveedor;
using SistemaLaObra.Compras.ActualizarProveedor;
using SistemaLaObra.Compras.ArticulosBajoStock;
using SistemaLaObra.Compras.EmitirListadoCompraProveedor;

namespace SistemaLaObra.Compras
{
    public partial class IU_MenuPrincipalCompras : Form
    {

        public IU_RegistrarProveedor interfazProveedor;
        public IU_ActualizarProveedor actualizarProveedor;
        public IU_RegistrarPedidoCompra iu_registrarPedidoCompra;
        public IU_EmitirListadoCompraProveedor iu_emitirListadoCompraProveedor;
        public IU_MenuPrincipal interfazContenedora { get; set; }
        IU_ArticulosBajoStock interfazArticulosBajoStock;
        

        public IU_MenuPrincipalCompras()
        {                        
            InitializeComponent();
        }

        private void btn_registrarPedidoCompra_Click(object sender, EventArgs e)
        {
            iu_registrarPedidoCompra = new IU_RegistrarPedidoCompra();
            iu_registrarPedidoCompra.InterfazContenedora = interfazContenedora;
            iu_registrarPedidoCompra.ShowDialog();
        }

        private void btn_registrarProveedor_Click(object sender, EventArgs e)
        {
            interfazProveedor = new IU_RegistrarProveedor();
            interfazProveedor.ShowDialog();
        }

        private void btn_ActualizarProveedor_Click(object sender, EventArgs e)
        {
            actualizarProveedor = new IU_ActualizarProveedor();
            actualizarProveedor.ShowDialog();
        }

        private void btn_articulosBajoStock_Click(object sender, EventArgs e)
        {
       
            interfazArticulosBajoStock = new IU_ArticulosBajoStock();
            interfazArticulosBajoStock.InterfazContenedora = interfazContenedora;
            interfazArticulosBajoStock.ShowDialog();
        }

        private void btn_emitirListadoCompraProveedor_Click(object sender, EventArgs e)
        {
            iu_emitirListadoCompraProveedor = new IU_EmitirListadoCompraProveedor();
            iu_emitirListadoCompraProveedor.InterfazContenedora= interfazContenedora;
            iu_emitirListadoCompraProveedor.ShowDialog();
        }
    }
}
