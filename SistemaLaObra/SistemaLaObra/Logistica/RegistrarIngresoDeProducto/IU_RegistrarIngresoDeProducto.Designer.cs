namespace SistemaLaObra.Compras.RegistrarIngresoDeProducto
{
    partial class IU_RegistrarIngresoDeProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_articulosBajoStock = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_PedidoCompra = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.codigoPedidop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHorap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoComprap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadManual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCoste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulosBajoStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar ingreso de productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_articulosBajoStock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 286);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de pedidos";
            // 
            // dgv_articulosBajoStock
            // 
            this.dgv_articulosBajoStock.AllowUserToAddRows = false;
            this.dgv_articulosBajoStock.AllowUserToDeleteRows = false;
            this.dgv_articulosBajoStock.AllowUserToResizeColumns = false;
            this.dgv_articulosBajoStock.AllowUserToResizeRows = false;
            this.dgv_articulosBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_articulosBajoStock.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_articulosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulosBajoStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPedidop,
            this.fechaHorap,
            this.estadop,
            this.codigoComprap,
            this.importe,
            this.proveedor,
            this.seleccionar});
            this.dgv_articulosBajoStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_articulosBajoStock.Location = new System.Drawing.Point(16, 24);
            this.dgv_articulosBajoStock.MultiSelect = false;
            this.dgv_articulosBajoStock.Name = "dgv_articulosBajoStock";
            this.dgv_articulosBajoStock.RowHeadersVisible = false;
            this.dgv_articulosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_articulosBajoStock.Size = new System.Drawing.Size(809, 239);
            this.dgv_articulosBajoStock.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 286);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCompra,
            this.codigoArticulo,
            this.cantidad,
            this.cantidadManual,
            this.precioCoste,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(16, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(809, 239);
            this.dataGridView1.TabIndex = 21;
            // 
            // btn_PedidoCompra
            // 
            this.btn_PedidoCompra.Location = new System.Drawing.Point(113, 659);
            this.btn_PedidoCompra.Name = "btn_PedidoCompra";
            this.btn_PedidoCompra.Size = new System.Drawing.Size(159, 29);
            this.btn_PedidoCompra.TabIndex = 24;
            this.btn_PedidoCompra.Text = "Confirmar Registro";
            this.btn_PedidoCompra.UseVisualStyleBackColor = true;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(15, 659);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 29);
            this.btn_Cerrar.TabIndex = 25;
            this.btn_Cerrar.Text = "Cancelar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            // 
            // codigoPedidop
            // 
            this.codigoPedidop.HeaderText = "Cod. Pedido";
            this.codigoPedidop.Name = "codigoPedidop";
            // 
            // fechaHorap
            // 
            this.fechaHorap.HeaderText = "Fecha/ Hora";
            this.fechaHorap.Name = "fechaHorap";
            // 
            // estadop
            // 
            this.estadop.HeaderText = "Estado";
            this.estadop.Name = "estadop";
            // 
            // codigoComprap
            // 
            this.codigoComprap.HeaderText = "Cod. Compra";
            this.codigoComprap.Name = "codigoComprap";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            // 
            // codigoCompra
            // 
            this.codigoCompra.HeaderText = "Codigo Compra";
            this.codigoCompra.Name = "codigoCompra";
            // 
            // codigoArticulo
            // 
            this.codigoArticulo.HeaderText = "Codigo Articulo";
            this.codigoArticulo.Name = "codigoArticulo";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // cantidadManual
            // 
            this.cantidadManual.HeaderText = "Ingrese cantidad otros";
            this.cantidadManual.Name = "cantidadManual";
            // 
            // precioCoste
            // 
            this.precioCoste.HeaderText = "Precio de Costo";
            this.precioCoste.Name = "precioCoste";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // IU_RegistrarIngresoDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 700);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_PedidoCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "IU_RegistrarIngresoDeProducto";
            this.Text = "IU_RegistrarIngresoDeProducto";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulosBajoStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_articulosBajoStock;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_PedidoCompra;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidop;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHorap;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadop;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoComprap;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCoste;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}