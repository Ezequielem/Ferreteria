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
    public partial class IU_RegistrarMarca : Form
    {       
        //INSTANCIAS
        private Validaciones validar;
        private Marca _marca;

        public Marca Marca { get; set; }

        public IU_RegistrarMarca()
        {
            validar = new Validaciones();
            Marca = new Marca();
            InitializeComponent();
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_descripcion.Text))
            {
                MessageBox.Show(this, "Debe ingresar una descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Marca.existe(txt_descripcion.Text))
            {
                MessageBox.Show(this, "La Marca ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarDescripcion();
                Marca.crear(Marca);                
                borrarCampos();
                this.Close();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void tomarDescripcion()
        {
            Marca.Descripcion = txt_descripcion.Text;
        }

        private void borrarCampos()
        {
            txt_descripcion.Text = "";
        }
    }
}
