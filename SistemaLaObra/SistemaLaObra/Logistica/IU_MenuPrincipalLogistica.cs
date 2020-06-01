using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Logistica.ActualizarEstadoOrden;
using SistemaLaObra.Logistica.RegistrarIngresoDeProducto;

namespace SistemaLaObra.Logistica
{
    public partial class IU_MenuPrincipalLogistica : Form
    {

        public IU_MenuPrincipal interfazContenedora { get; set; }
        IU_RegistroIngresoProducto interfazRecepcion;

        public IU_MenuPrincipalLogistica()
        {
            InitializeComponent();
            interfazRecepcion = new IU_RegistroIngresoProducto();
        }

        private void btn_emitirOrdenRemito_Click(object sender, EventArgs e)
        {
            IU_EmitirOrdenRemito iu_emitirOR = new IU_EmitirOrdenRemito();
            iu_emitirOR.InterfazContenedora = interfazContenedora;
            iu_emitirOR.ShowDialog(this);
        }

        private void btn_actualizarOrdenRemito_Click(object sender, EventArgs e)
        {
            IU_ActualizarEstadoRemito iu_actualizarOR = new IU_ActualizarEstadoRemito();
            iu_actualizarOR.InterfazContenedora = interfazContenedora;
            iu_actualizarOR.ShowDialog(this);
        }

        private void btn_registrarIngresoProductos_Click(object sender, EventArgs e)
        {
            interfazRecepcion.ShowDialog();
        }

        private void IU_MenuPrincipalLogistica_Load(object sender, EventArgs e)
        {

        }
    }
}
