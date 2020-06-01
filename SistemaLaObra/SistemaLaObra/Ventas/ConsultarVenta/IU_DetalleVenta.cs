using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.ConsultarVenta
{
    public partial class IU_DetalleVenta : Form
    {
        public Controlador_ConsultarVenta controladorConsultarVenta { get; set; }
        public bool detalleEnvio;
        public bool detalleCliente;

        public IU_DetalleVenta()
        {
            InitializeComponent();
        }

        private void btn_detalleEnvio_Click(object sender, EventArgs e)
        {
            controladorConsultarVenta.mostrarDetalleEnvio();
        }

        private void btn_consultarDatosCliente_Click(object sender, EventArgs e)
        {
            controladorConsultarVenta.mostrarDetalleCliente();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
