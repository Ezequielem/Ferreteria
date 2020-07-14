using SistemaLaObra.Modelo;
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
    public partial class IU_EliminarMiEmpresa : Form
    {
        public MiEmpresa MiEmpresa { get; set; }
        public IU_MenuPrincipal IU_Contenedora { get; set; }

        public IU_EliminarMiEmpresa()
        {
            InitializeComponent();
            IU_Contenedora = new IU_MenuPrincipal();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (MiEmpresa.CodigoMiEmpresa == IU_Contenedora.EncargadoActivo.MiEmpresa.CodigoMiEmpresa)
            {
                MessageBox.Show("No se puede eliminar la empresa porque porque es la sesión activa\n Inicie sesión con otro usuario he intente de nuevo", "Advertencia!!!");
                this.Close();
            }
            else if (MiEmpresa.existenUsuarios(MiEmpresa.CodigoMiEmpresa))
            {
                MessageBox.Show("No se puede eliminar la empresa porque posee Usuarios asociados\n Elimine los usuarios asociados he intente de nuevo", "Advertencia!!!");
                this.Close();
            }
            else
            {
                MiEmpresa.eliminar(MiEmpresa);
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO

        public void opcionEliminar(MiEmpresa miEmpresa, IU_MenuPrincipal principal)
        {
            MiEmpresa = miEmpresa;
            IU_Contenedora = principal;
        }

        private void IU_EliminarMiEmpresa_Load(object sender, EventArgs e)
        {
            lbl_empresa.Text = MiEmpresa.NombreFantasia;
        }
    }
}
