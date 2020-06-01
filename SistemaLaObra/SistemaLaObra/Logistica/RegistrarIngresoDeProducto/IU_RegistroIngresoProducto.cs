using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Logistica.RegistrarIngresoDeProducto
{
    public partial class IU_RegistroIngresoProducto : Form
    {

        //INSTANCIAS
        Controlador_RegistrarIngresoDeProducto controlador;
        Validaciones validacion;
        IU_MenuPrincipal _interfazContenedora;

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

        public IU_RegistroIngresoProducto()
        {
            InitializeComponent();
            controlador = new Controlador_RegistrarIngresoDeProducto();
            validacion = new Validaciones();

        }

        //METODOS

        public void mensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }


        public void opciónRegistrarIngresoDeProcto()
        {

        }

        private void IU_RegistroIngresoProducto_Load(object sender, EventArgs e)
        {

            dgv_ListadoRecepcion.Rows.Clear();
            controlador.buscarListadoPedido(this);
            btn_confirmar.Enabled = false;
        


        }

        public void tomarSeleecionPedido(int cantidad)
        {
            controlador.cantidadSeleccionada(cantidad);
        }

        public void tomarCodigoDetalleLogistico(int codigo)
        {
            controlador.codigoDetalleLogisticoTomado(codigo);
        }

        public void tomarConfirmacionCantidad()
        {

        }

        public void tomarConfirmacionRegistro(int codigo)
        {
            controlador.confirmacionPedido(codigo);

        }

        public void mostrarListadoPedido()
        {

        }

        private void dgv_ListadoRecepcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_detallePedido.Rows.Clear();
            if (e.ColumnIndex == 4)
            {
                DataGridView dgv_actual = sender as DataGridView;

                controlador.pedidoSeleccionado(int.Parse(dgv_actual.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        //Devolvemos un valor en base a todas las validaciones (luego la utilizara el metodo "validaciones".//
        public int validarDataGridView()
        {
            int i = 0;
            int banderaDgv = 0;

            foreach (DataGridViewRow fila in dgv_detallePedido.Rows)
            {
                string stockSolicitado = this.dgv_detallePedido.Rows[i].Cells[2].Value.ToString();
                try
                {
                    string stockIngresado = this.dgv_detallePedido.Rows[i].Cells[3].Value.ToString();
                    int _stockSolicitado = int.Parse(stockSolicitado);
                    try
                    {
                        int _stockIngresado = int.Parse(stockIngresado);
                        if (_stockIngresado > _stockSolicitado)
                            banderaDgv = 1;
                        i++;
                    }
                    catch
                    {
                        banderaDgv = 2;
                        return banderaDgv;
                    }
                }
                catch
                {
                    banderaDgv = -1;
                    return banderaDgv;
                }
            
              
            }
            return banderaDgv;
        }
        //
        //Enviamos el mensaje correspondiente a la validacion del datagridview//
            public int validacionMensajes()
        {
            int banderaDgv;
            banderaDgv = validarDataGridView();
            if (banderaDgv < 0)
            {
                MessageBox.Show("Ningun campo puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
            else if (banderaDgv == 2)
            {
                MessageBox.Show("Solo numeros y sin espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
            else if (banderaDgv == 1)
            {
                MessageBox.Show("La cantidad ingresada no puede superar la cantidad recibida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
            return 0;
        }
        //


        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            int banderaAuxiliar = 0;
            int bandera = 0;
            int validacion = validacionMensajes();
            if (validacion < 0)
                dgv_detallePedido.Focus();
            else
            {
                foreach (DataGridViewRow fila in dgv_detallePedido.Rows)
                {
                    tomarCodigoDetalleLogistico(int.Parse(Convert.ToString(fila.Cells[0].Value)));
                    tomarSeleecionPedido(int.Parse(Convert.ToString(fila.Cells[3].Value)));
                    banderaAuxiliar = banderaAuxiliar + 1;
                    if (controlador.DetalleLogistica.CantidadRecibida == int.Parse(Convert.ToString(fila.Cells[2].Value)))
                        bandera = bandera + 1;
                    tomarConfirmacionRegistro(int.Parse(Convert.ToString(fila.Cells[0].Value)));

                }
                if (bandera == banderaAuxiliar)
                    controlador.actualizarEstadoRecepcion(3);
                else
                    controlador.actualizarEstadoRecepcion(2);
                controlador.actualizarStock();
                MessageBox.Show("El Ingreso de Productos se registro con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_detallePedido.Rows.Clear();
                dgv_ListadoRecepcion.Rows.Clear();
                controlador.buscarListadoPedido(this);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            dgv_detallePedido.Rows.Clear();
        }

    }

    }


