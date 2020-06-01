using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.ReporteDeVentas
{
    public partial class IU_Calendario : Form
    {
        public string fechaSeleccionada;

        public IU_Calendario()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = monthCalendar1.SelectionStart.ToShortDateString();

            if (Convert.ToDateTime(fechaSeleccionada) < DateTime.Now)
            {
                label1.Text = fechaSeleccionada;
                btn_aceptarFecha.Enabled = true;
            }
            else
            {
                label1.Text = "seleccione fechas pasadas";
                btn_aceptarFecha.Enabled = false;
            }
        }

        private void btn_aceptarFecha_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = label1.Text;
            this.Hide();
        }

        private void IU_Calendario_Load(object sender, EventArgs e)
        {
            btn_aceptarFecha.Enabled = false;
        }
    }
}
