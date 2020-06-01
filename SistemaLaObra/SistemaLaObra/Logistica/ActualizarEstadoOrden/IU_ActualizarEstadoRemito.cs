using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Logistica.ActualizarEstadoOrden
{
    public partial class IU_ActualizarEstadoRemito : Form
    {
        //REFERENCIAS
        private Controlador_ActualizarEstadoRemito _controladorActualizarEOR;

        //INSTANCIAS
        private List<Entrega> _entrega;
        private EstadoEntrega _estadoEntrega;
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
        public IU_ActualizarEstadoRemito()
        {
            _controladorActualizarEOR = new Controlador_ActualizarEstadoRemito(this);
            _entrega = new List<Entrega>();
            _estadoEntrega = new EstadoEntrega();
            InitializeComponent();
        }

        //BOTONES
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            tomarActualizacionEstadoEntrega();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void IU_ActualizarEstadoRemito_Load(object sender, EventArgs e)
        {
            _controladorActualizarEOR.buscarEntregasPendientes();
            mostrarListadoEntregas();
        }

        //METODOS
        public void mostrarListadoEntregas()
        {
            foreach (var item in _controladorActualizarEOR.EntregaColeccion)
            {
                dgv_listadoEntrega.Rows.Add(item.CodigoEntrega, item.FechaEntrega.Date.ToShortDateString(),
                    item.HoraEntregaDesde.ToShortTimeString(), item.HoraEntregaHasta.ToShortTimeString(),
                    (item.NombreCalle + ", " + item.NumeroCalle + " Barrio " + item.NombreBarrio + ", " + item.NombreLocalidad),
                    _estadoEntrega.mostrarDescripcion(item.CodigoEstadoEntrega));
            }
        }

        private void tomarSeleccionPedido(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_listadoEntrega.Columns[e.ColumnIndex].Name == "Finalizar")
            {
                DataGridViewRow row = dgv_listadoEntrega.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Finalizar"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSeleccion.EditingCellFormattedValue))
                {

                    _controladorActualizarEOR.entregasPendientesSeleccionadas(int.Parse(row.Cells["idPedido"].Value.ToString()));
                }
                else
                {
                    _controladorActualizarEOR.entregasPendientesDeseleccionadas(int.Parse(row.Cells["idPedido"].Value.ToString()));
                }
            }
        }

        public void tomarActualizacionEstadoEntrega()
        {
            _controladorActualizarEOR.actualizarEstadoEntrega();
            actualizarDatos();
        }

        private void actualizarDatos()
        {
            _controladorActualizarEOR.buscarEntregasPendientes();
            dgv_listadoEntrega.Rows.Clear();
            mostrarListadoEntregas();
        }
    }
}
