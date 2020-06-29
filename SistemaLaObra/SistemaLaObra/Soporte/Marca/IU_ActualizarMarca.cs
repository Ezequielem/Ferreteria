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
    public partial class IU_ActualizarMarca : Form
    {
        //INSTANCIAS
        private Validaciones validar;
        public Marca Marca { get; set; }

        public IU_ActualizarMarca()
        {            
            InitializeComponent();
            Marca = new Marca();
            validar = new Validaciones();
        }

        //BOTONES

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_nombre.Text))
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la marca", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Marca.Descripcion!=txt_nombre.Text && Marca.existe(txt_nombre.Text))
            {
                MessageBox.Show(this, "El nombre de la marca ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarMarca();
                Marca.actualizar(Marca);
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void opcionActualizarMarca(int id)
        {
            Marca.mostrarDatos(id); 
        }

        public void tomarMarca()
        {
            Marca.Descripcion = txt_nombre.Text;
        }

        private void IU_ActualizarMarca_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = Marca.Descripcion;
        }
    }
}
