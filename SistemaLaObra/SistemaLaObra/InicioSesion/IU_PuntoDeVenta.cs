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

namespace SistemaLaObra.InicioSesion
{
    public partial class IU_PuntoDeVenta : Form
    {
        public PuntoDeVenta PuntoDeVenta { get; set; }
        public List<PuntoDeVenta> ListaPuntosDeVenta { get; set; }
        public IU_MenuPrincipal IUContenedora { get; set; }

        public IU_PuntoDeVenta()
        {
            InitializeComponent();
            PuntoDeVenta = new PuntoDeVenta();
            ListaPuntosDeVenta = new List<PuntoDeVenta>();
        }

        //BOTONES

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            IUContenedora.PuntoDeVenta.mostrarDatos(int.Parse(cbx_puntoVenta.SelectedValue.ToString()));
            IUContenedora.Text += "        " + IUContenedora.PuntoDeVenta.NombreFantasia;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        private void cargarCombo()
        {
            cbx_puntoVenta.DisplayMember = "NombreFantasia";
            cbx_puntoVenta.ValueMember = "CodigoPuntoVenta";
            cbx_puntoVenta.DataSource = ListaPuntosDeVenta;
        }

        //EVENTO

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            timer1.Stop();
            ListaPuntosDeVenta = PuntoDeVenta.mostrarDatos(IUContenedora.EncargadoActivo.MiEmpresa);
            cargarCombo();
            if (ListaPuntosDeVenta.Count > 0)
            {
                btn_aceptar.Enabled = true;
            }
            Cursor.Current = Cursors.Default;
        }        
    }
}
