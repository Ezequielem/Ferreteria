using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Ventas;
using System.Drawing.Printing;

namespace SistemaLaObra.Logistica
{
    public partial class IU_EmitirOrdenRemito : Form
    {
        //INSTANCIAS
        private Controlador_EmitirOrdenRemito _controladorEmitirOR;
        private List<Entrega> _entrega;
        private List<DetalleLogistica> _detalleLogistica;
        private List<DetalleVP> _detalleVP;
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


        //CONSTRUCTOR
        public IU_EmitirOrdenRemito()
        {
            InitializeComponent();
            _controladorEmitirOR = new Controlador_EmitirOrdenRemito(this);
            _entrega = new List<Entrega>();
            _detalleLogistica = new List<DetalleLogistica>();
            _detalleVP = new List<DetalleVP>();
        }

        private void IU_EmitirOrdenRemito_Load(object sender, EventArgs e)
        {
            _controladorEmitirOR.generarListadoEntrega();
            mostrarListadoEntrega();
        }

        //BOTONES
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        //METODOS        
        public void mostrarListadoEntrega()
        {
            foreach (var item in _controladorEmitirOR.EntregaColeccion)
            {
                dgw_listadoEntrega.Rows.Add(item.CodigoEntrega, item.FechaEntrega.Date.ToShortDateString(), 
                    item.HoraEntregaDesde.ToShortTimeString(), item.HoraEntregaHasta.ToShortTimeString(), 
                    (item.NombreCalle+", "+item.NumeroCalle+" Barrio "+item.NombreBarrio+", "+item.NombreLocalidad), 
                    "PENDIENTE");
            }
        }

        private void tomarSeleccioPedido(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==6)
            {
                DataGridView dgv_actual = sender as DataGridView;
                _controladorEmitirOR.seleccionPedidoIngresado(int.Parse(dgv_actual.CurrentRow.Cells[0].Value.ToString()));
                _controladorEmitirOR.buscarDatoPedido();
                mostrarDatosRemito();
            }
        }

        public void mostrarDatosRemito()
        {
            _controladorEmitirOR.generarRemito(_controladorEmitirOR.Entrega, _controladorEmitirOR.DetalleLogistica);
        }      
    }
}
