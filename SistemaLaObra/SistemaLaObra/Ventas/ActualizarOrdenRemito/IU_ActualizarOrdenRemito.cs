using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.ActualizarOrdenRemito
{
    public partial class IU_ActualizarOrdenRemito : Form
    {
        //INSTANCIAS

        private IU_MenuPrincipal _interfazContenedora;
        Controlador_ActualizarOrdenRemito controladorAOR;
        private List<Entrega> _listaEntrega;
        private Encargado encargado;
        Validaciones validar;

        public IU_MenuPrincipal InterfazContenedora
        {
            get
            {
                return _interfazContenedora;
            }

            set
            {
                _interfazContenedora = value;
            }
        }

        public List<Entrega> ListaEntrega
        {
            get
            {
                return _listaEntrega;
            }

            set
            {
                _listaEntrega = value;
            }
        }

        public IU_ActualizarOrdenRemito()
        {
            validar = new Validaciones();
            controladorAOR = new Controlador_ActualizarOrdenRemito(this);
            ListaEntrega = new List<Entrega>();
            encargado = new Encargado();
            InitializeComponent();
        }        

        //BOTONES

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (validar.campoVacio(txt_codigoVenta.Text))
            {
                MessageBox.Show(this, "No ha ingresado el número de venta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!validar.soloNumerosEnteros(txt_codigoVenta.Text))
            {             
                MessageBox.Show(this, "Debe ingresar un número de venta válido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tomarNumeroDeVenta();
                if (controladorAOR.buscarVenta())
                {
                    controladorAOR.buscarEntrega();
                    if (ListaEntrega.Count!=0)
                    {
                        ocultarEncabezado();
                        mostrarFleteAnimado();
                        mostrarDatosEntregas();
                    }
                    else
                    {
                        MessageBox.Show(this, "No hay ninguna entrega pendiente asignada a esta venta por favor registre un nuevo envío", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    txt_codigoVenta.Text = "";
                    MessageBox.Show(this, "No existe la venta ingresada", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }                        
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {

        }

        //METODOS

        public void opcionActualizarOrdenDeRemito()
        {

        }

        public void tomarNumeroDeVenta()
        {       
            controladorAOR.numeroDeVenta(int.Parse(txt_codigoVenta.Text));     
        }

        public void mostrarDatosEntregas()
        {
            string direccion="";
            foreach (var item in ListaEntrega)
            {
                direccion = item.NombreCalle + " " + item.NumeroCalle + ", " + item.NombreBarrio;
                dgv_ordenesDeRemito.Rows.Add(item.CodigoEntrega, item.FechaEntrega.ToShortDateString(), direccion, item.NombreCliente, encargado.obtenerDatos(item.CodigoEncargado).Nombre, "seleccionar");
            }            
        }

        public void tomarSeleccionEntrega(int codigoEntrega)
        {
            controladorAOR.entregaSeleccionada(ListaEntrega.Find(x =>x.CodigoEntrega==codigoEntrega));
        }

        public void mostrarDatosDeEntrega()
        {
            controladorAOR.mostrarInterfazDatos();
            dgv_ordenesDeRemito.Rows.Clear();
            controladorAOR.buscarEntrega();
            mostrarDatosEntregas();
        }

        //METODOS  PRIVADOS

        private void mostrarFleteAnimado()
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("images/fleteAnimado.gif");
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 75);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            Controls.Add(pictureBox1);
        }

        private void ocultarEncabezado()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            lbl_1.Visible = false;
            txt_codigoVenta.Visible = false;
            btn_confirmar.Visible = false;
            dgv_ordenesDeRemito.Visible = true;
        }

        //EVENTOS

        private void IU_ActualizarOrdenRemito_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            dgv_ordenesDeRemito.Visible = false;
            btn_siguiente.Enabled = false;
        }

        private void dgv_ordenesDeRemito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                DataGridView dgv_actual = sender as DataGridView;
                int codigoEntrega = int.Parse(dgv_actual.CurrentRow.Cells[0].Value.ToString());
                tomarSeleccionEntrega(codigoEntrega);
                mostrarDatosDeEntrega();
            }
        }
    }
}
