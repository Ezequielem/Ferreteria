using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SistemaLaObra
{
  

    public partial class DialogBox : Form
    {
        IU_RegistrarVenta venta;
        float interesGenerado;
        float importeTotal1;


        public DialogBox()
        {

            InitializeComponent();


        }



        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bt_aceptar_Click(object sender, EventArgs e)
        {

            EnviarLabel();
          importeTotal();

            venta.Show();
            //venta.actualizarLabel(interesGenerado);
            

          
         

        }

        //METODOS

        public float calcularInteres () {

            if (tb_interes.Text != "")
            {

              float num1 = (float)Convert.ToDouble(lb_importeFactura.Text);
            
              int inte1 = int.Parse(tb_interes.Text);

                interesGenerado = num1* inte1 /100;          
            }

            return interesGenerado;
        }




        public void EnviarLabel ()
        {
          
            venta = new IU_RegistrarVenta();

            calcularInteres();
            venta.lbl_interes.Text= interesGenerado.ToString("0.00");

          
        }

        public void importeTotal()
        {
            calcularInteres();
            float numeroFactura= (float)Convert.ToDouble(lb_importeFactura.Text);

            importeTotal1 = interesGenerado + numeroFactura;

            bl_importeFinal.Text = importeTotal1.ToString("0.00");
        }

       

       
    }
}


 

      