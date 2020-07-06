using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.CerrarSesion
{
    public partial class IU_CerrarSesion : Form
    {
        public IU_MenuPrincipal InterfazContenedora { get; set; }
        Controlador_CerrarSesion controlador;

        public IU_CerrarSesion()
        {
            InitializeComponent();
            controlador = new Controlador_CerrarSesion();
            controlador.interfazCerrarSesion = this;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            controlador.cerrarSesionUsuario(InterfazContenedora.CodigoHistorial);

            if (InterfazContenedora.pnl_subMenu.Controls.Count > 0)
            {
                InterfazContenedora.pnl_subMenu.Controls.RemoveAt(0);
                InterfazContenedora.pnl_subMenu.Visible = false;
                InterfazContenedora.pnl_opciones.Visible = false;

                InterfazContenedora.btn_ventas.Visible = false;
                InterfazContenedora.btn_ventas.Enabled = false;
                InterfazContenedora.btn_compras.Visible = false;
                InterfazContenedora.btn_compras.Enabled = false;
                InterfazContenedora.btn_logistica.Visible = false;
                InterfazContenedora.btn_logistica.Enabled = false;
                InterfazContenedora.btn_estadistica.Visible = false;
                InterfazContenedora.btn_estadistica.Enabled = false;
                InterfazContenedora.btn_soporte.Visible = false;
                InterfazContenedora.btn_soporte.Enabled = false;

                InterfazContenedora.ms_btnInicioSesion.Visible = true;
                InterfazContenedora.ms_btnCerrarSesion.Visible = false;

                InterfazContenedora.lbl_usuario.Visible = false;
                InterfazContenedora.lbl_nombreApellidoEncargado.Visible = false;
                InterfazContenedora.lbl_tipoDeAcceso.Visible = false;

            }
            else
            {
                InterfazContenedora.pnl_subMenu.Visible = false;
                if (InterfazContenedora.pnl_opciones.Controls.Count > 0)
                {
                    InterfazContenedora.pnl_opciones.Visible = false;

                    InterfazContenedora.btn_ventas.Visible = false;
                    InterfazContenedora.btn_ventas.Enabled = false;
                    InterfazContenedora.btn_compras.Visible = false;
                    InterfazContenedora.btn_compras.Enabled = false;
                    InterfazContenedora.btn_logistica.Visible = false;
                    InterfazContenedora.btn_logistica.Enabled = false;
                    InterfazContenedora.btn_estadistica.Visible = false;
                    InterfazContenedora.btn_estadistica.Enabled = false;
                    InterfazContenedora.btn_soporte.Visible = false;
                    InterfazContenedora.btn_soporte.Enabled = false;

                    InterfazContenedora.ms_btnInicioSesion.Visible = true;
                    InterfazContenedora.ms_btnCerrarSesion.Visible = false;

                    InterfazContenedora.lbl_usuario.Visible = false;
                    InterfazContenedora.lbl_nombreApellidoEncargado.Visible = false;
                    InterfazContenedora.lbl_tipoDeAcceso.Visible = false;
                }
            }
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
