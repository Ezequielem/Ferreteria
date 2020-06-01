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
    public partial class IU_EmitirListadoCompraProveedor2 : Form
    {
        //INSTANCIAS
        private Controlador_EmitirListadoCompraProveedor _controladorELCP;
        private List<Proveedor> _listaProveedores;
        private List<DataGridView> _listaDGV;
        private List<Button> _listaBtnImprimir;
        private List<Button> _listaBtnVistaPrevia;
        private List<DetalleCompra> _listaDetalleCompra;
        private List<IU_VistaPrevia> _listaVistaPrevia;
        private Articulo _articulo;
        private Compra _compra;

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

        public List<Proveedor> ListaProveedores
        {
            get
            {
                return _listaProveedores;
            }

            set
            {
                _listaProveedores = value;
            }
        }

        public List<DataGridView> ListaDGV
        {
            get
            {
                return _listaDGV;
            }

            set
            {
                _listaDGV = value;
            }
        }

        public List<Button> ListaBtnImprimir
        {
            get
            {
                return _listaBtnImprimir;
            }

            set
            {
                _listaBtnImprimir = value;
            }
        }

        public List<Button> ListaBtnVistaPrevia
        {
            get
            {
                return _listaBtnVistaPrevia;
            }

            set
            {
                _listaBtnVistaPrevia = value;
            }
        }

        public List<DetalleCompra> ListaDetalleCompra
        {
            get
            {
                return _listaDetalleCompra;
            }

            set
            {
                _listaDetalleCompra = value;
            }
        }

        public List<IU_VistaPrevia> ListaVistaPrevia
        {
            get
            {
                return _listaVistaPrevia;
            }

            set
            {
                _listaVistaPrevia = value;
            }
        }

        public Articulo Articulo
        {
            get
            {
                return _articulo;
            }

            set
            {
                _articulo = value;
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

        public IU_EmitirListadoCompraProveedor2(Controlador_EmitirListadoCompraProveedor controlador)
        {
            ControladorELCP = controlador;
            Articulo = new Articulo();
            ListaDGV = new List<DataGridView>();
            ListaBtnImprimir = new List<Button>();
            ListaBtnVistaPrevia = new List<Button>();
            ListaVistaPrevia = new List<IU_VistaPrevia>();
            Compra = new Compra();
            InitializeComponent();
        }

        //BOTONES

        private void btn_volver_Click(object sender, EventArgs e)
        {            
            this.Close();
        }


        //METODOS

        private void crearInterfaz()
        {

        }

        private void cargarTabControl()
        {
            for (int i = 0; i < ListaProveedores.Count; i++)
            {
                string title = ListaProveedores[i].RazonSocial;
                TabPage miTabPage = new TabPage(title);
                tbc_Proveedores.TabPages.Add(miTabPage);
                rellenarTabControl(miTabPage, ListaDetalleCompra, ListaProveedores[i]);
            }            
        }

        private void rellenarTabControl(TabPage tabPage, List<DetalleCompra> lista, Proveedor proveedor)
        {            
            // codigo
            DataGridViewTextBoxColumn codigo = new DataGridViewTextBoxColumn();
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 90;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.SortMode = DataGridViewColumnSortMode.Programmatic;
            codigo.Width = 90;

            // descripcion           
            DataGridViewTextBoxColumn descripcion = new DataGridViewTextBoxColumn();
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 250;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.SortMode = DataGridViewColumnSortMode.Programmatic;
            descripcion.Width = 250;

            // costo             
            DataGridViewTextBoxColumn costo = new DataGridViewTextBoxColumn();
            costo.HeaderText = "Costo";
            costo.MinimumWidth = 90;
            costo.Name = "costo";
            costo.ReadOnly = true;
            costo.SortMode = DataGridViewColumnSortMode.Programmatic;
            costo.Width = 90;

            // cantidad             
            DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 90;
            cantidad.Name = "cantidad";
            cantidad.Resizable = DataGridViewTriState.True;
            cantidad.SortMode = DataGridViewColumnSortMode.Programmatic;
            cantidad.Width = 90;

            // stock             
            DataGridViewTextBoxColumn stock = new DataGridViewTextBoxColumn();
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 90;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.SortMode = DataGridViewColumnSortMode.Programmatic;
            stock.Width = 90;

            // stockMin             
            DataGridViewTextBoxColumn stockMin = new DataGridViewTextBoxColumn();
            stockMin.HeaderText = "Stock Mínimo";
            stockMin.MinimumWidth = 90;
            stockMin.Name = "stockMin";
            stockMin.ReadOnly = true;
            stockMin.SortMode = DataGridViewColumnSortMode.Programmatic;
            stockMin.Width = 90;

   
            // dgv_detalleCompra             
            DataGridView dgv_detalleCompra = new DataGridView();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_detalleCompra.AllowUserToAddRows = false;
            dgv_detalleCompra.AllowUserToDeleteRows = false;
            dgv_detalleCompra.AllowUserToResizeColumns = false;
            dgv_detalleCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_detalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_detalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_detalleCompra.Columns.AddRange(new DataGridViewColumn[] {
            codigo,
            descripcion,
            costo,
            cantidad,
            stock,
            stockMin});
            dgv_detalleCompra.Location = new System.Drawing.Point(30, 19);
            dgv_detalleCompra.MultiSelect = false;
            dgv_detalleCompra.Name = "dgv_detalleCompra";
            dgv_detalleCompra.RowHeadersVisible = false;
            dgv_detalleCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_detalleCompra.Size = new Size(705, 243);
            dgv_detalleCompra.TabIndex = 1;
            //Agrego el control al tabControl
            tabPage.Controls.Add(dgv_detalleCompra);
            //Agrego el control a la lista
            ListaDGV.Add(dgv_detalleCompra);
            //Agrego evento al dataGridView

            
            // btn_imprimir
            Button btn_imprimir = new Button();
            btn_imprimir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn_imprimir.Image = global::SistemaLaObra.Properties.Resources.imprimir;
            btn_imprimir.Location = new Point(638, 275);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(120, 50);
            btn_imprimir.TabIndex = 2;
            btn_imprimir.Text = "Imprimir";
            btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_imprimir.UseVisualStyleBackColor = true;
            //Agrego el control al tabControl
            tabPage.Controls.Add(btn_imprimir);
            //Agrego el control a la lista
            ListaBtnImprimir.Add(btn_imprimir);
            //Agrego evento al Boton
            btn_imprimir.Click += new EventHandler(tomarOpcionImprimirListado);

        }

        public void cargarListaPorProveedor()
        {
            for (int i = 0; i < ListaProveedores.Count; i++)
            {                
                mostrarDetalleCompraProveedor(ControladorELCP.generarListaDetallePorProveedor(ListaProveedores[i].CodigoProveedor), i);
                ListaVistaPrevia.Add(new IU_VistaPrevia());
            }
        }

        public void mostrarDetalleCompraProveedor(List<DetalleCompra> listaDetalle, int indice)
        {
            foreach (var item in listaDetalle)
            {
                Articulo.mostrarDatos(item.CodigoArticulo);
                ListaDGV[indice].Rows.Add(Articulo.CodigoDescripcion,
                    Articulo.Descripcion,
                    item.PrecioCoste,
                    item.Cantidad,
                    Articulo.Stock,
                    Articulo.StockMinimo);
            }
        }

        public void tomarOpcionImprimirListado(object sender, EventArgs e)
        {
            int indice = tbc_Proveedores.SelectedIndex;
            int codigoProveedorSeleccionado = ListaProveedores[indice].CodigoProveedor;
            Button btn_actual = sender as Button;
            ListaVistaPrevia[indice].generarPedidoPorProveedor(Compra, ControladorELCP.generarListaDetallePorProveedor(codigoProveedorSeleccionado), ListaProveedores[indice]);
            ListaVistaPrevia[indice].ShowDialog();
        }

        //EVENTOS

        private void IU_EmitirListadoCompraProveedor2_Load(object sender, EventArgs e)
        {
            cargarTabControl();
            cargarListaPorProveedor();
        }        
    }
}
