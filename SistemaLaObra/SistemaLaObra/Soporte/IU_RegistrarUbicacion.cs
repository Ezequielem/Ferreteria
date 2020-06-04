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
    public partial class IU_RegistrarUbicacion : Form
    {
        //INSTANCIAS
        private Validaciones validar;
        private Ubicacion _ubicacion;

        public Ubicacion Ubicacion { get; set; }

        public IU_RegistrarUbicacion()
        {
            validar = new Validaciones();
            Ubicacion = new Ubicacion();
            InitializeComponent();
        }        

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_descripcion.Text))
            {
                MessageBox.Show(this , "Debe ingresar una descripción", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Ubicacion.existe(txt_descripcion.Text))
            {
                MessageBox.Show(this, "La Ubicación ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarDescripcion();
                Ubicacion.crear(Ubicacion);
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
            Ubicacion.Descripcion = txt_descripcion.Text;
        }
    }
}
