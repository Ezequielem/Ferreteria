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
    public partial class IU_Info : Form
    {
        //Instancias
        List<Entrega> entregas;
        List<DetalleLogistica> detallesL;
        private List<DataGridView> _listaDGV;
        private List<Label> _fechaEntrega;
        private List<Label> _horaInicio;
        private List<Label> _horaFin;
        private List<Label> _cliente;
        private List<Label> _observacion;
        private List<Label> _telefono;
        private List<Label> _calle;
        private List<Label> _numeroDireccion;
        private List<Label> _numeroTelefono;
        private List<Label> _precio;
        private Articulo articulo;

        public IU_Info(List<Entrega> entrega, List<DetalleLogistica> detalles)
        {
            InitializeComponent();
            _listaDGV = new List<DataGridView>();
            _fechaEntrega = new List<Label>();
            _horaInicio = new List<Label>();
            _horaFin = new List<Label>();
            _cliente = new List<Label>();
            _observacion = new List<Label>();
            _telefono = new List<Label>();
            _calle = new List<Label>();
            _numeroDireccion = new List<Label>();
            _numeroTelefono = new List<Label>();
            _precio = new List<Label>();
            articulo = new Articulo();
            entregas = entrega;
            detallesL = detalles;
            cargarTabControl();
            cargarDetalles(detallesL, entrega);
        }

        private void cargarTabControl()
        {
            for (int i = 0; i < entregas.Count ; i++)
            {
                string title = "Viaje " + (tabControl1.TabCount + 1).ToString();
                TabPage miTabPage = new TabPage(title);
                tabControl1.TabPages.Add(miTabPage);
                rellenarTabControl(miTabPage);
            }
        }

        private void rellenarTabControl(TabPage tabPage)
        {
            //Cliente
            Label lbl_nombreCliente = new Label();
            lbl_nombreCliente.AutoSize = false;
            lbl_nombreCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_nombreCliente.Location = new Point(3, 10);
            lbl_nombreCliente.Name = "lbl_nombreCliente";
            lbl_nombreCliente.Size = new Size(100, 20);
            lbl_nombreCliente.Text = "Cliente:";
            //dato de cliente
            Label lbl_nombreClienteActual = new Label();
            lbl_nombreClienteActual.AutoSize = false;
            lbl_nombreClienteActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_nombreClienteActual.Location = new Point(104, 10);
            lbl_nombreClienteActual.Name = "lbl_nombreClienteActual";
            lbl_nombreClienteActual.Size = new Size(300, 20);
            lbl_nombreClienteActual.Text = "";
            //fecha:
            Label lbl_fecha = new Label();
            lbl_fecha.AutoSize = false;
            lbl_fecha.Font= new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_fecha.Location= new Point(3, 35);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(100, 20);
            lbl_fecha.Text = "Fecha:";
            //dato de fecha
            Label lbl_fechaActual = new Label();
            lbl_fechaActual.AutoSize = false;
            lbl_fechaActual.Font= new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_fechaActual.Location = new Point(104, 35);
            lbl_fechaActual.Name = "lbl_fechaActual";
            lbl_fechaActual.Size = new Size(100, 20);
            lbl_fechaActual.Text = "";
            //Entre las:
            Label lbl_horaInicio = new Label();
            lbl_horaInicio.AutoSize = false;
            lbl_horaInicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_horaInicio.Location = new Point(3, 60);
            lbl_horaInicio.Name = "lbl_horaInicio";
            lbl_horaInicio.Size = new Size(100, 20);
            lbl_horaInicio.Text = "Entre las: ";
            //dato hora de inicio
            Label lbl_horaInicioActual = new Label();
            lbl_horaInicioActual.AutoSize = false;
            lbl_horaInicioActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_horaInicioActual.Location = new Point(104, 60);
            lbl_horaInicioActual.Name = "lbl_horaInicioActual";
            lbl_horaInicioActual.Size = new Size(100, 20);
            lbl_horaInicioActual.Text = "";
            //Y las:
            Label lbl_horaFin = new Label();
            lbl_horaFin.AutoSize = false;
            lbl_horaFin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_horaFin.Location = new Point(204, 60);
            lbl_horaFin.Name = "lbl_horaFin";
            lbl_horaFin.Size = new Size(100, 20);
            lbl_horaFin.Text = "Y las: ";
            //dato hora de fin
            Label lbl_horaFinActual = new Label();
            lbl_horaFinActual.AutoSize = false;
            lbl_horaFinActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_horaFinActual.Location = new Point(304, 60);
            lbl_horaFinActual.Name = "lbl_horaFinActual";
            lbl_horaFinActual.Size = new Size(100, 20);
            lbl_horaFinActual.Text = "";
            //Domicilio
            Label lbl_domicilio = new Label();
            lbl_domicilio.AutoSize = false;
            lbl_domicilio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_domicilio.Location = new Point(3, 85);
            lbl_domicilio.Name = "lbl_domicilio";
            lbl_domicilio.Size = new Size(100, 20);
            lbl_domicilio.Text = "Domicilio";
            //dato Calle numero barrio localidad
            Label lbl_domicilioActual = new Label();
            lbl_domicilioActual.AutoSize = false;
            lbl_domicilioActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_domicilioActual.Location = new Point(104, 85);
            lbl_domicilioActual.Name = "lbl_domicilioActual";
            lbl_domicilioActual.Size = new Size(500, 20);
            lbl_domicilioActual.Text = "";
            //Telefono:
            Label lbl_telefono = new Label();
            lbl_telefono.AutoSize = false;
            lbl_telefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_telefono.Location = new Point(3, 110);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(100,20);
            lbl_telefono.Text = "Teléfono:";
            //Dato telefono
            Label lbl_telefonoActual = new Label();
            lbl_telefonoActual.AutoSize = false;
            lbl_telefonoActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_telefonoActual.Location = new Point(104, 110);
            lbl_telefonoActual.Name = "lbl_telefonoActual";
            lbl_telefonoActual.Size = new Size(100, 20);
            lbl_telefonoActual.Text = "";
            //Precio:
            Label lbl_precio = new Label();
            lbl_precio.AutoSize = false;
            lbl_precio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_precio.Location = new Point(3, 135);
            lbl_precio.Name = "lbl_preio";
            lbl_precio.Size = new Size(100,20);
            lbl_precio.Text = "Precio:";
            //Dato precio
            Label lbl_precioActual = new Label();
            lbl_precioActual.AutoSize = false;
            lbl_precioActual.Font=new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_precioActual.Location = new Point(104, 135);
            lbl_precioActual.Name = "lbl_precioActual";
            lbl_precioActual.Size = new Size(100,20);
            lbl_precioActual.Text = "";
            //Observacion
            Label lbl_observacion = new Label();
            lbl_observacion.AutoSize = false;
            lbl_observacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_observacion.Location = new Point(3, 160);
            lbl_observacion.Name = "lbl_observacion";
            lbl_observacion.Size = new Size(100, 20);
            lbl_observacion.Text = "Observación:";           
            //Dato observacion
            Label lbl_observacionActual = new Label();
            lbl_observacionActual.AutoSize = false;
            lbl_observacionActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_observacionActual.Location = new Point(104, 160);
            lbl_observacionActual.Name = "lbl_observacionActual";
            lbl_observacionActual.Size = new Size(500,20);
            lbl_observacionActual.Text = "";
            //DataGridView con los detalles
            DataGridViewCellStyle dataGridViewCellStyleEntrega = new DataGridViewCellStyle();
            DataGridViewTextBoxColumn columnaCodigo = new DataGridViewTextBoxColumn();
            columnaCodigo.HeaderText = "Codigo";
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
           
            DataGridView dgv_ArticulosEnVentaPorViaje = new DataGridView();
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
            dgv_ArticulosEnVentaPorViaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleEntrega;
            dgv_ArticulosEnVentaPorViaje.ColumnHeadersHeight = 35;
            dgv_ArticulosEnVentaPorViaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_ArticulosEnVentaPorViaje.Columns.AddRange(new DataGridViewColumn[] {
            columnaCodigo,
            columnaNombre,
            columnaCantidad});
            dgv_ArticulosEnVentaPorViaje.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_ArticulosEnVentaPorViaje.Location = new Point(0, 190);
            dgv_ArticulosEnVentaPorViaje.MultiSelect = false;
            dgv_ArticulosEnVentaPorViaje.Name = "dgv_ArticulosEnVentaPorViaje";
            dgv_ArticulosEnVentaPorViaje.RowHeadersVisible = false;
            dgv_ArticulosEnVentaPorViaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ArticulosEnVentaPorViaje.Size = new Size(620, 120);//(722, 120)
            dgv_ArticulosEnVentaPorViaje.TabIndex = 0;
            //Agregar controles al tabControl
            tabPage.Controls.Add(dgv_ArticulosEnVentaPorViaje);
            tabPage.Controls.Add(lbl_nombreCliente);
            tabPage.Controls.Add(lbl_nombreClienteActual);
            tabPage.Controls.Add(lbl_fecha);
            tabPage.Controls.Add(lbl_fechaActual);
            tabPage.Controls.Add(lbl_horaInicio);
            tabPage.Controls.Add(lbl_horaInicioActual);
            tabPage.Controls.Add(lbl_horaFin);
            tabPage.Controls.Add(lbl_horaFinActual);
            tabPage.Controls.Add(lbl_domicilio);
            tabPage.Controls.Add(lbl_domicilioActual);
            tabPage.Controls.Add(lbl_telefono);
            tabPage.Controls.Add(lbl_telefonoActual);
            tabPage.Controls.Add(lbl_precio);
            tabPage.Controls.Add(lbl_precioActual);
            tabPage.Controls.Add(lbl_observacion);
            tabPage.Controls.Add(lbl_observacionActual);
            //Se asigna el control dinamico a una lista de controles
            _cliente.Add(lbl_nombreClienteActual);
            _fechaEntrega.Add(lbl_fechaActual);
            _horaInicio.Add(lbl_horaInicioActual);
            _horaFin.Add(lbl_horaFinActual);
            _calle.Add(lbl_domicilioActual);
            _telefono.Add(lbl_telefonoActual);
            _precio.Add(lbl_precioActual);
            _observacion.Add(lbl_observacionActual);
            _listaDGV.Add(dgv_ArticulosEnVentaPorViaje);

        }

        private void cargarDetalles(List<DetalleLogistica> detalles, List<Entrega> entregaDatos)
        {
            foreach (var item in detalles)
            {
                articulo.mostrarDatos(item.CodigoArticulo);
                tabControl1.SelectedIndex = item.Entrega.CodigoEntrega;
                _listaDGV[item.Entrega.CodigoEntrega].Rows.Add(item.CodigoArticulo, articulo.Descripcion, item.Cantidad);
            }
            foreach (var item in entregaDatos)
            {
                _cliente[item.CodigoEntrega].Text = item.NombreCliente;
                _fechaEntrega[item.CodigoEntrega].Text = item.FechaEntrega.ToShortDateString();
                _horaInicio[item.CodigoEntrega].Text = item.HoraEntregaDesde.ToShortTimeString()+" hs";
                _horaFin[item.CodigoEntrega].Text = item.HoraEntregaHasta.ToShortTimeString()+" hs";
                _calle[item.CodigoEntrega].Text=item.NombreCalle+" "+item.NumeroCalle+", "+item.NombreBarrio+"  "+item.NombreLocalidad;
                _telefono[item.CodigoEntrega].Text = item.NumeroTelefono;
                _precio[item.CodigoEntrega].Text = item.PrecioEntrega.ToString("$ 0.00");
                _observacion[item.CodigoEntrega].Text = item.Descripcion;

            }
        }
    }
}
