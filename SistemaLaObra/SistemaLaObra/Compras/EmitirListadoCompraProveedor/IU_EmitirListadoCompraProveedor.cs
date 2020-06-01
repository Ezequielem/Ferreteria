using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Compras.EmitirListadoCompraProveedor
{
    public partial class IU_EmitirListadoCompraProveedor : Form
    {
        //INSTANCIAS
        private Controlador_EmitirListadoCompraProveedor _controladorELCP;
        private Compra _compra;
        private List<Compra> _listaCompra;
        private IU_MenuPrincipal _interfazContenedora;

        public Controlador_EmitirListadoCompraProveedor ControladorELCP
        {
            get
            {
                return _controladorELCP;
            }

            set
            {
                _controladorELCP = value;
            }
        }

        public Compra Compra
        {
            get
            {
                return _compra;
            }

            set
            {
                _compra = value;
            }
        }

        public List<Compra> ListaCompra
        {
            get
            {
                return _listaCompra;
            }

            set
            {
                _listaCompra = value;
            }
        }

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

        public IU_EmitirListadoCompraProveedor()
        {
            ControladorELCP = new Controlador_EmitirListadoCompraProveedor(this);
            ListaCompra = new List<Compra>();
            Compra = new Compra();
            InitializeComponent();
        }

        //BOTONES

        private void btn_imprimirSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void opcionEmitirListadoCompraProveedor()
        {

        }

        public void mostrarOrdenesDeCompra()
        {
            ControladorELCP.buscarOrdenesCompraPendientes();
        }

        public void tomarOrdenDECompra(int codigoCompra)
        {
            ControladorELCP.ordenDeCompraTomada(codigoCompra);
        }

        //EVENTOS

        private void IU_EmitirListadoCompraProveedor_Load(object sender, EventArgs e)
        {
            mostrarOrdenesDeCompra();
        }

        private void dgv_listaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv_actual = sender as DataGridView;
            if (dgv_actual.CurrentCell.ColumnIndex == 5)
            {                
                int codigoOrdenCompra = int.Parse(dgv_actual.Rows[e.RowIndex].Cells[0].Value.ToString());
                tomarOrdenDECompra(codigoOrdenCompra);
                ControladorELCP.buscarDetalleDeCompra(codigoOrdenCompra);
                ControladorELCP.obtenerProveedores();
                ControladorELCP.mostrarInterfazProveedores();
            }
        }
    }
}
