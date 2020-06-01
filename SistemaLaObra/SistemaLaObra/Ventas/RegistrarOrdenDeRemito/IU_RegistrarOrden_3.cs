using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    public partial class IU_RegistrarOrden_3 : Form
    {
        //REFERENCIA
        private Controlador_RegistrarOrden controladorOR;

        //INSTANCIAS
        private Articulo articulo;
        private List<DataGridView> _listaDGV;

        //atributos
        private int[] indice;

        public IU_RegistrarOrden_3(Controlador_RegistrarOrden controlador)
        {
            InitializeComponent();
            controladorOR = controlador;
            articulo = new Articulo();
            _listaDGV = new List<DataGridView>();            
            indice = new int[controladorOR.DetalleVP.Count];
        }

        private void IU_RegistrarOrden_3_Load(object sender, EventArgs e)
        {
            cargarTabControl();
            mostrarListadoEnvio();
            btn_siguiente.Enabled = false;
        }

        //BOTONES

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            //Acordate de validar aca para que ningun viaje se valla sin articulos
            this.Hide();
            controladorOR.interfazCargarPrecioYRuta();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            controladorOR.iu_registrarOrden1.Owner.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {            
            this.Close();
            controladorOR.iu_registrarOrden2.Show();
        }

        //METODOS

        private void cargarTabControl()
        {
            for (int i = 0; i < controladorOR.EntregaColeccion.Count; i++)
            {
                string title = "Viaje " + (tabControl1.TabCount + 1).ToString();
                TabPage miTabPage = new TabPage(title);
                tabControl1.TabPages.Add(miTabPage);
                rellenarTabControl(miTabPage);
            }
        }

        private void rellenarTabControl(TabPage tabPage)
        {

            DataGridViewCellStyle dataGridViewCellStyleEntrega = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewTextBoxColumn columnaCodigo = new DataGridViewTextBoxColumn();
            columnaCodigo.HeaderText = "Código";
            columnaCodigo.Name = "columnaCodigo";
            columnaCodigo.Width = 120;

            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.HeaderText = "Nombre del artículo";
            columnaNombre.Name = "columnaNombre";
            columnaNombre.Width = 400;

            DataGridViewTextBoxColumn columnaCantidad = new DataGridViewTextBoxColumn();
            columnaCantidad.HeaderText = "Cantidad";
            columnaCantidad.Name = "columnaCantidad";
            columnaCantidad.Width = 100;

            DataGridViewButtonColumn columnaBoton = new DataGridViewButtonColumn();
            columnaBoton.HeaderText = "Deseleccionar";
            columnaBoton.Text = "Deseleccionar";
            columnaBoton.Name = "columnaBoton";
            columnaBoton.Resizable = DataGridViewTriState.True;
            columnaBoton.SortMode = DataGridViewColumnSortMode.Automatic;
            columnaBoton.UseColumnTextForButtonValue = false;
            columnaBoton.Width = 99;

            DataGridViewTextBoxColumn columnaId = new DataGridViewTextBoxColumn();
            columnaId.HeaderText = "Id";
            columnaId.Name = "columnaId";

            DataGridView dgv_ArticulosEnVentaPorViaje = new DataGridView();
            dgv_ArticulosEnVentaPorViaje.Anchor= ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dgv_ArticulosEnVentaPorViaje.AllowUserToAddRows = false;
            dgv_ArticulosEnVentaPorViaje.AllowUserToDeleteRows = false;
            dgv_ArticulosEnVentaPorViaje.AllowUserToResizeColumns = false;
            dgv_ArticulosEnVentaPorViaje.AllowUserToResizeRows = false;
            dgv_ArticulosEnVentaPorViaje.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dgv_ArticulosEnVentaPorViaje.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyleEntrega.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleEntrega.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyleEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyleEntrega.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyleEntrega.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyleEntrega.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyleEntrega.WrapMode = DataGridViewTriState.True;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_ArticulosEnVentaPorViaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_ArticulosEnVentaPorViaje.ColumnHeadersHeight = 35;
            dgv_ArticulosEnVentaPorViaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_ArticulosEnVentaPorViaje.Columns.AddRange(new DataGridViewColumn[] {
            columnaCodigo,
            columnaNombre,
            columnaCantidad,
            columnaBoton,
            columnaId});
            dgv_ArticulosEnVentaPorViaje.EditMode= DataGridViewEditMode.EditProgrammatically;
            dgv_ArticulosEnVentaPorViaje.Location = new System.Drawing.Point(18, 21);
            dgv_ArticulosEnVentaPorViaje.MultiSelect = false;
            dgv_ArticulosEnVentaPorViaje.Name = "dgv_ArticulosEnVentaPorViaje";
            dgv_ArticulosEnVentaPorViaje.RowHeadersVisible = false;
            dgv_ArticulosEnVentaPorViaje.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgv_ArticulosEnVentaPorViaje.Size = new System.Drawing.Size(722, 173);
            dgv_ArticulosEnVentaPorViaje.TabIndex = 0;
            tabPage.Controls.Add(dgv_ArticulosEnVentaPorViaje);
            //EVENTO
            dgv_ArticulosEnVentaPorViaje.CellContentClick += new DataGridViewCellEventHandler(deseleccionarArticulosPorViaje);

            _listaDGV.Add(dgv_ArticulosEnVentaPorViaje);
        }

        private void mostrarListadoEnvio()
        {
            foreach (var item in controladorOR.DetalleVP)
            {
                articulo.mostrarDatos(item.CodigoArticulo);
                dgv_ArticulosEnVenta.Rows.Add(articulo.CodigoDescripcion, articulo.Descripcion, item.Cantidad, "Seleccionar", articulo.CodigoArticulo);
            }            
        }

        //METODO PRIVADO

        private void corroborarViajeCompleto()
        {
            int estado = 0;
            foreach (var item in _listaDGV)
            {
                if (item.Rows.Count==0)
                {
                    estado = 1;
                }
            }
            if (estado==1)
            {
                btn_siguiente.Enabled = false;
            }
            else
            {
                btn_siguiente.Enabled = true;
            }
        }

        //EVENTOS

        private void deseleccionarArticulosPorViaje(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv_actual = sender as DataGridView;
            if (dgv_actual.CurrentCell.ColumnIndex == 3)
            {
                int tabSeleccionada = tabControl1.SelectedIndex;
                int id = int.Parse(dgv_actual.CurrentRow.Cells[4].Value.ToString());
                for (int i = 0; i < controladorOR.DetalleLogistica.Count; i++)
                {
                    if (controladorOR.DetalleLogistica[i].conocerArticulo().CodigoArticulo==id)
                    {
                        articulo.mostrarDatos(id);
                        dgv_ArticulosEnVenta.Rows.Add(articulo.CodigoDescripcion, articulo.Descripcion, controladorOR.DetalleLogistica[i].Cantidad, "Seleccionar", articulo.CodigoArticulo);
                        controladorOR.DetalleLogistica[i].CodigoArticulo = 0;
                        controladorOR.DetalleLogistica[i].Cantidad = 0;
                        controladorOR.articuloPorViaje(tabSeleccionada, controladorOR.DetalleLogistica[i], i);
                        break;
                    }
                }
                dgv_actual.Rows.Remove(dgv_actual.CurrentRow);
            }
            corroborarViajeCompleto();
        }

        private void tomarArticuloPorViaje(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ArticulosEnVenta.CurrentCell.ColumnIndex==3)
            {
                int tabSeleccionada = tabControl1.SelectedIndex;
                int id = int.Parse(dgv_ArticulosEnVenta.CurrentRow.Cells[4].Value.ToString());
                for (int i = 0; i < controladorOR.DetalleVP.Count; i++)
                {
                    if (controladorOR.DetalleVP[i].conocerArticulo().CodigoArticulo==id)
                    {
                        articulo.mostrarDatos(id);
                        _listaDGV[tabSeleccionada].Rows.Add(articulo.CodigoDescripcion, articulo.Descripcion, controladorOR.DetalleVP[i].Cantidad, "Deseleccionar", articulo.CodigoArticulo);
                        controladorOR.DetalleLogistica[i].CodigoArticulo = articulo.CodigoArticulo;
                        controladorOR.DetalleLogistica[i].Cantidad = controladorOR.DetalleVP[i].Cantidad;
                        controladorOR.articuloPorViaje(tabSeleccionada, controladorOR.DetalleLogistica[i], i);
                        indice[i] = articulo.CodigoArticulo;
                        break;
                    }
                }               
                dgv_ArticulosEnVenta.Rows.Remove(dgv_ArticulosEnVenta.CurrentRow);
            }
            corroborarViajeCompleto();
        }
    }
}
