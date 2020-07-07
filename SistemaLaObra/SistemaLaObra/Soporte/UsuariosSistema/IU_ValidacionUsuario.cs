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

namespace SistemaLaObra.Soporte.UsuariosSistema
{
    public partial class IU_ValidacionUsuario : Form
    {
        public Usuario Usuario { get; set; }
        public IU_ValidacionUsuario(Usuario user)
        {
            InitializeComponent();
            Usuario = user;
        }

        //BOTONES

        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {
            Usuario.Contraseña = txt_contraseña.Text;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
