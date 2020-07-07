using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte
{
    public partial class IU_DatosUsuario : Form
    {
        public IU_DatosUsuario()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
