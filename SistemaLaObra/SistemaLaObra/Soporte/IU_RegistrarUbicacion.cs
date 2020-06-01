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

        public Ubicacion Ubicacion
        {
            get
            {
                return _ubicacion;
            }

            set
            {
                _ubicacion = value;
            }
        }

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
            else
            {
                tomarDescripcion();
                Ubicacion.crear(Ubicacion);
                MessageBox.Show(this, "Se ha registrado correctamente la ubicación", "UBICACION", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                borrarCampos();
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

        private void borrarCampos()
        {
            txt_descripcion.Text = "";
        }
    }
}
