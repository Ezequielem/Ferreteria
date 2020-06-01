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
    public partial class IU_ActualizarTarjeta : Form
    {
        //INSTANCIA
        NombreTarjeta nombreTarjeta;

        //VARIABLES PRIVADAS
        private string datoNombreTarjeta;
        private string datoNombreActual;

        public string DatoNombreTarjeta
            {
            get
            {
                return datoNombreTarjeta;
            }
            set
            {
                datoNombreTarjeta = value;
            }

            }

        public string DatoNombreActual
        {
            get
            {
                return datoNombreActual;
            }
            set
            {
                datoNombreActual = value;
            }
        }


        public IU_ActualizarTarjeta()
        {
            InitializeComponent();
            nombreTarjeta = new NombreTarjeta();
        }

        private void IU_ActualizarTarjeta_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void tomarNombreTarjeta()
        {
            DatoNombreTarjeta = txt_Tarjeta.Text;
        }

        public void tomarNombreActual()
        {
            DatoNombreActual = cb_Tarjeta.Text;
        }

        public void cargarDatos()
        {
            cb_Tarjeta.DisplayMember = "Descripcion";
            cb_Tarjeta.DataSource = nombreTarjeta.mostrarDatosColeccion();
          
        }

        public void opcionActualizar()
        {
            nombreTarjeta.actualizarNombreTarjeta(DatoNombreActual, DatoNombreTarjeta);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (txt_Tarjeta.Text == "")
            {
                MessageBox.Show("El campo Modificar nombre no puede quedar vacío","Advertencia" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tomarNombreActual();
                tomarNombreTarjeta();
                opcionActualizar();
                this.Close();
            }


        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
