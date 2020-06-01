using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Compras.ArticulosBajoStock;

namespace SistemaLaObra.Compras.ArticulosBajoStock
{
    public partial class IU_ArticulosBajoStock : Form
    {
        //INSTANCIAS

        Controlador_ArticulosBajoStock controlador;
        Validaciones validacion;
        private IU_MenuPrincipal _interfazContenedora;

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

        public IU_ArticulosBajoStock()
        {
            InitializeComponent();
            controlador = new Controlador_ArticulosBajoStock();
            validacion = new Validaciones();
        }

        private void IU_ArticulosBajoStock_Load(object sender, EventArgs e)
        {
            controlador.verificarArticulosBajoStock(this);
            if (dgv_articulosBajoStock.RowCount == 0)
                btn_Imprimir.Enabled = false;
        }

        //METODOS

        public void opcionEmitirListadoArticulosBajoStock()
        {
            tomarStockMinimo();
            controlador.verificarArticulosBajoStockManual(this);
        }

        public void tomarStockMinimo()
        {
            controlador.stockMinimoTomado(int.Parse(txt_StockMinimo.Text));
        }

        public void mensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_StockMinimo.Text == "")
            {
                MessageBox.Show("El campo stock minimo no puede quedar vacio");
                txt_StockMinimo.Focus();
            }
            else
            {
                dgv_articulosBajoStock.Rows.Clear();
                opcionEmitirListadoArticulosBajoStock();
                if (dgv_articulosBajoStock.RowCount == 0)
                    btn_Imprimir.Enabled = false;
                else
                    btn_Imprimir.Enabled = true;
            }
        }
            public void validarSeleccion()
        {
            List<string> proveedor = new List<string>();
            controlador.listaArticulos = new List<Articulo>();
            controlador.listaProveedoresArticulo = new List<ListaProveedoresArticulo>();
            foreach (DataGridViewRow fila in dgv_articulosBajoStock.Rows)
            {

                DataGridViewCheckBoxCell celdaSeleccionada = fila.Cells[7] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(celdaSeleccionada.Value)==true)
                {
                    controlador.listaArticulos = controlador.articulo.mostrarListaArticulo(controlador.listaArticulos,  int.Parse(Convert.ToString(fila.Cells[0].Value)));
                    controlador.listaProveedoresArticulo=controlador.articulo.buscarListaProveedoresArticulo(controlador.listaProveedoresArticulo, int.Parse(Convert.ToString(fila.Cells[0].Value)));

                }
            }
            if (controlador.listaArticulos.Count!=0)
            {
                controlador.generarPedidoDeCompra(controlador.listaArticulos, controlador.listaProveedoresArticulo);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun artículo");
            }            
        }

        //EVENTOS

        private void txt_StockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
            txt_StockMinimo.Focus();
        }

        private void rb_cargaManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cargaManual.Checked == true)
            {
                dgv_articulosBajoStock.Rows.Clear();
                lbl_Cuit.Enabled = true;
                txt_StockMinimo.Enabled = true;
                btn_Buscar.Enabled = true;
                if (dgv_articulosBajoStock.Rows.Count == 0)
                    btn_Imprimir.Enabled = false;
                else
                    btn_Imprimir.Enabled = true;
            }
            
        }

        private void rb_cargaAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cargaAutomatica.Checked == true)
            {
                txt_StockMinimo.Text = "";
                dgv_articulosBajoStock.Rows.Clear();
                controlador.verificarArticulosBajoStock(this);
                if (dgv_articulosBajoStock.Rows.Count == 0)
                    btn_Imprimir.Enabled = false;
                else
                    btn_Imprimir.Enabled = true;
            }
            
        }

        //BOTONES

        private void btn_PedidoCompra_Click(object sender, EventArgs e)
        {
            validarSeleccion();           
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
             controlador.opcionImprimir();
        }
    }
}
