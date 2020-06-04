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
    public partial class IU_ActualizarUbicacion : Form
    {
        //INSTANCIAS       
        private Validaciones validar;
        public Ubicacion Ubicacion { get; set; }
        public List<Ubicacion> ListaUbicaciones { get; set; }

        public IU_ActualizarUbicacion()
        {
            Ubicacion = new Ubicacion();
            ListaUbicaciones = new List<Ubicacion>();
            validar = new Validaciones();
            InitializeComponent();
        }

        //BOTONES

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_nombre.Text))
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la ubicación", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Ubicacion.Descripcion!=txt_nombre.Text && Ubicacion.existe(txt_nombre.Text))
            {
                MessageBox.Show(this, "La ubicación ingresada ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarUbicacion();
                Ubicacion.actualizarDatos(Ubicacion);
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        //METODOS

        public void opcionActualizarUbicacion(int id)
        {
            Ubicacion.mostrarDatos(id);
        }

        public void tomarUbicacion()
        {            
            Ubicacion.Descripcion = txt_nombre.Text;
        }

        //EVENTOS

        private void IU_ActualizarUbicacion_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = Ubicacion.Descripcion;
        }  
    }
}
