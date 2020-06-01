using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Compras.RegistrarCompra
{
    public partial class IU_RegistrarPedidoCompra : Form
    {
        Validaciones validacion;
        Controlador_RegistrarPedidoCompra controladorPC;
        private ListaProveedoresArticulo listaPA;
        private List<Proveedor> listaP;
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

        public IU_RegistrarPedidoCompra()
        {
            InitializeComponent();
            validacion = new Validaciones();
            controladorPC = new Controlador_RegistrarPedidoCompra(this);
            listaPA = new ListaProveedoresArticulo();
            listaP=new List<Proveedor>();
        }

        //BOTONES

        private void btn_registrarPedido_Click(object sender, EventArgs e)
        {
            tomarConfirmacionRegistro();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS

        public void opcionGenerarPedidoDeCompra(List<Articulo> articulosBajoStock, List<ListaProveedoresArticulo> listaProveedorArticulo)
        {
            foreach (var item in articulosBajoStock)
            {
                controladorPC.seleccionArticulo(item.CodigoArticulo);
            }
        }

        public void tomarArticulo(int codigoArticulo)
        {
            controladorPC.seleccionArticulo(codigoArticulo);
        }

        public void tomarCantidad(int cantidad, int indiceDetalle)
        {
            controladorPC.seleccionCantidad(cantidad, indiceDetalle);
        }

        public void tomarPrecioCoste(int codigoProveedor, int indiceDetalle)
        {
            controladorPC.seleccionPrecioCoste(codigoProveedor, indiceDetalle);
        }

        public DataGridViewComboBoxCell cargarProveedores(int indice)
        {
            listaP = listaPA.mostrarColeccionProveedores(controladorPC.articulo.CodigoArticulo);
            DataGridViewComboBoxCell proveedor = dgv_listaArticulos[6, indice] as DataGridViewComboBoxCell;            
            proveedor.DataSource = listaP;
            proveedor.ValueMember = "CodigoProveedor";
            proveedor.DisplayMember = "RazonSocial";
            dgv_listaArticulos.AutoGenerateColumns = false;
            return proveedor;
        }

        public void tomarProveedor(int codigo, int indiceDetalle)
        {
            controladorPC.seleccionProveedor(codigo, indiceDetalle);
        }

        public void tomarConfirmacionRegistro()
        {
            controladorPC.nuevoRegistroPedido();
        }

        private void tomarDescripcionArticulo()
        {
            controladorPC.seleccionDescripcionArticulo(txt_descripcion.Text);
        }

        public void mostrarMensajeErrorCampos()
        {
            MessageBox.Show(this, "Debe ingresar proveedor y cantidad de los artículos solicitados", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void mostrarMensajeConfirmacion()
        {
            MessageBox.Show(this, "Orden de compra realizada correctamente", "COMPRAS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        public void mostrarMensajeErrorListaVacia()
        {
            MessageBox.Show(this, "No ha ingresado ningún artículo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //EVENTOS

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (!validacion.campoVacio(txt_descripcion.Text))
            {
                tomarDescripcionArticulo();
            }
        }

        private void dgv_listaArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_listaArticulos.Rows.Count!=0)
            {                
                if (dgv_listaArticulos.Columns[e.ColumnIndex].Index == 6)
                {
                    DataGridViewComboBoxCell combo = dgv_listaArticulos.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                    tomarProveedor(int.Parse(combo.Value.ToString()), e.RowIndex);
                    tomarPrecioCoste(int.Parse(combo.Value.ToString()), e.RowIndex);
                }
                if (dgv_listaArticulos.Columns[e.ColumnIndex].Index == 8)
                {
                    DataGridViewTextBoxCell texto = dgv_listaArticulos.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewTextBoxCell;
                    if (texto.Value==null)
                    {
                        MessageBox.Show(this, "No ha ingresado cantidad", "ADVERTENCIA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        tomarCantidad(0, e.RowIndex);
                    }
                    else
                    {
                        if (validacion.soloNumerosEnteros(texto.Value.ToString()))
                        {
                            tomarCantidad(int.Parse(texto.Value.ToString()), e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show(this, "Debe ingresar un valor entero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tomarCantidad(0, e.RowIndex);
                        }
                    }                    
                }
            }            
        }

        private void dgv_aSeleccionar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DataGridView dgv_actual = sender as DataGridView;                                
                tomarArticulo(int.Parse(dgv_actual.CurrentRow.Cells[8].Value.ToString()));
            }            
        }

        private void dgv_listaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                controladorPC.deseleccionArticulo(dgv_listaArticulos.CurrentRow.Index);
            }
        }
    }
}
