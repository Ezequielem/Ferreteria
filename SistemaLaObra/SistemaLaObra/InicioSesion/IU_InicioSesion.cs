using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.InicioSesion
{
    public partial class IU_InicioSesion : Form
    {

        Validaciones validacion;
        Controlador_InicioSesion controlador;
        public IU_MenuPrincipal interfazContenedora { get; set; }

        public IU_InicioSesion()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controlador = new Controlador_InicioSesion();
            controlador.interfazInicioSesion = this;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            if (tomarUsuario())
            {
                if (tomarContraseña())
                {
                    controlador.tomarFechaHora();
                    controlador.iniciarSesion();
                }
            }
        }

        private bool tomarUsuario()
        {
            if (!validacion.campoVacio(txt_usuario.Text))
            {
                if (controlador.usuarioEmpleado(txt_usuario.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El usuario no existe","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo usuario esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }   
        }

        private bool tomarContraseña()
        {
            if (!validacion.campoVacio(txt_contraseña.Text))
            {
                if (controlador.contraseñaEmpleado(txt_contraseña.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No ingreso una contraseña","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void IU_InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            txt_usuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
