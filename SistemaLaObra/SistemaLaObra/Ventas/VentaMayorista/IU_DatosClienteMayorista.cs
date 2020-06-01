using SistemaLaObra.Ventas.ActualizarClienteMayorista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.VentaMayorista
{
    public partial class IU_DatosClienteMayorista : Form
    {
        IU_ActualizarClienteMayorista actualizarClienteMayorista;
        public IU_RegistrarVenta InterfazVenta { get; set; }

        public IU_DatosClienteMayorista()
        {
            InitializeComponent();
        }

        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {
            actualizarClienteMayorista = new IU_ActualizarClienteMayorista();
            actualizarClienteMayorista.InterfazDatosCliente = this;
            actualizarClienteMayorista.InterfazVenta = InterfazVenta;
            actualizarClienteMayorista.txt_razonSocial.Text = lbl_razonSocial.Text;
            actualizarClienteMayorista.ShowDialog();
            this.Close();
        }

        private void btn_confirmarDatos_Click(object sender, EventArgs e)
        {
            InterfazVenta.txt_razonSocial.Enabled = false;
            InterfazVenta.btn_buscarDatos.Enabled = false;
            InterfazVenta.rb_clienteMinorista.Enabled = false;
            InterfazVenta.rb_clienteMayorista.Enabled = false;
            InterfazVenta.gb_productos.Enabled = true;
            this.Close();
        }
    }
}
