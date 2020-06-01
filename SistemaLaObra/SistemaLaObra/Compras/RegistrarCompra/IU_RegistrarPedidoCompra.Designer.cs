namespace SistemaLaObra.Compras.RegistrarCompra
{
    partial class IU_RegistrarPedidoCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_listaArticulos = new System.Windows.Forms.GroupBox();
            this.lbl_saldoCompra = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.dgv_listaArticulos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_agregarArticulo = new System.Windows.Forms.GroupBox();
            this.dgv_aSeleccionar = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_verPedido = new System.Windows.Forms.Button();
            this.gbx_listaArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaArticulos)).BeginInit();
            this.gbx_agregarArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aSeleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 517);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gbx_listaArticulos
            // 
            this.gbx_listaArticulos.Controls.Add(this.lbl_saldoCompra);
            this.gbx_listaArticulos.Controls.Add(this.lbl_2);
            this.gbx_listaArticulos.Controls.Add(this.dgv_listaArticulos);
            this.gbx_listaArticulos.Location = new System.Drawing.Point(12, 199);
            this.gbx_listaArticulos.Name = "gbx_listaArticulos";
            this.gbx_listaArticulos.Size = new System.Drawing.Size(891, 312);
            this.gbx_listaArticulos.TabIndex = 4;
            this.gbx_listaArticulos.TabStop = false;
            this.gbx_listaArticulos.Text = "Pedido de compra";
            // 
            // lbl_saldoCompra
            // 
            this.lbl_saldoCompra.AutoSize = true;
            this.lbl_saldoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldoCompra.Location = new System.Drawing.Point(261, 271);
            this.lbl_saldoCompra.Name = "lbl_saldoCompra";
            this.lbl_saldoCompra.Size = new System.Drawing.Size(95, 31);
            this.lbl_saldoCompra.TabIndex = 2;
            this.lbl_saldoCompra.Text = "$ 0.00";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(14, 271);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(241, 31);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Saldo de compra:";
            // 
            // dgv_listaArticulos
            // 
            this.dgv_listaArticulos.AllowUserToAddRows = false;
            this.dgv_listaArticulos.AllowUserToDeleteRows = false;
            this.dgv_listaArticulos.AllowUserToResizeColumns = false;
            this.dgv_listaArticulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.stock,
            this.stockMin,
            this.costo,
            this.proveedor,
            this.seleccion,
            this.cantidad});
            this.dgv_listaArticulos.Location = new System.Drawing.Point(10, 20);
            this.dgv_listaArticulos.MultiSelect = false;
            this.dgv_listaArticulos.Name = "dgv_listaArticulos";
            this.dgv_listaArticulos.RowHeadersVisible = false;
            this.dgv_listaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaArticulos.Size = new System.Drawing.Size(873, 243);
            this.dgv_listaArticulos.TabIndex = 0;
            this.dgv_listaArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaArticulos_CellContentClick);
            this.dgv_listaArticulos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaArticulos_CellValueChanged);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 70;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.codigo.Width = 70;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 250;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.descripcion.Width = 250;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 75;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.precio.Width = 75;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 65;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stock.Width = 65;
            // 
            // stockMin
            // 
            this.stockMin.HeaderText = "Stock Mínimo";
            this.stockMin.MinimumWidth = 65;
            this.stockMin.Name = "stockMin";
            this.stockMin.ReadOnly = true;
            this.stockMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stockMin.Width = 65;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.MinimumWidth = 75;
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.costo.Width = 75;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 120;
            this.proveedor.Name = "proveedor";
            this.proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.proveedor.Width = 120;
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "Selección";
            this.seleccion.MinimumWidth = 80;
            this.seleccion.Name = "seleccion";
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.seleccion.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 72;
            this.cantidad.Name = "cantidad";
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cantidad.Width = 72;
            // 
            // gbx_agregarArticulo
            // 
            this.gbx_agregarArticulo.Controls.Add(this.dgv_aSeleccionar);
            this.gbx_agregarArticulo.Controls.Add(this.txt_descripcion);
            this.gbx_agregarArticulo.Controls.Add(this.lbl_1);
            this.gbx_agregarArticulo.Location = new System.Drawing.Point(12, 12);
            this.gbx_agregarArticulo.Name = "gbx_agregarArticulo";
            this.gbx_agregarArticulo.Size = new System.Drawing.Size(891, 178);
            this.gbx_agregarArticulo.TabIndex = 5;
            this.gbx_agregarArticulo.TabStop = false;
            this.gbx_agregarArticulo.Text = "Agregar artículo";
            // 
            // dgv_aSeleccionar
            // 
            this.dgv_aSeleccionar.AllowUserToAddRows = false;
            this.dgv_aSeleccionar.AllowUserToDeleteRows = false;
            this.dgv_aSeleccionar.AllowUserToResizeColumns = false;
            this.dgv_aSeleccionar.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aSeleccionar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_aSeleccionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aSeleccionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.desc,
            this.marca,
            this.ubicacion,
            this.prec,
            this.sto,
            this.stoMin,
            this.ingart,
            this.identificador});
            this.dgv_aSeleccionar.Location = new System.Drawing.Point(12, 49);
            this.dgv_aSeleccionar.MultiSelect = false;
            this.dgv_aSeleccionar.Name = "dgv_aSeleccionar";
            this.dgv_aSeleccionar.ReadOnly = true;
            this.dgv_aSeleccionar.RowHeadersVisible = false;
            this.dgv_aSeleccionar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_aSeleccionar.Size = new System.Drawing.Size(873, 123);
            this.dgv_aSeleccionar.TabIndex = 2;
            this.dgv_aSeleccionar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aSeleccionar_CellContentClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "Código";
            this.cod.MinimumWidth = 85;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 85;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descripción";
            this.desc.MinimumWidth = 292;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 292;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 108;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 108;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicación";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            // 
            // prec
            // 
            this.prec.HeaderText = "Precio";
            this.prec.MinimumWidth = 75;
            this.prec.Name = "prec";
            this.prec.ReadOnly = true;
            this.prec.Width = 75;
            // 
            // sto
            // 
            this.sto.HeaderText = "Stock";
            this.sto.MinimumWidth = 65;
            this.sto.Name = "sto";
            this.sto.ReadOnly = true;
            this.sto.Width = 65;
            // 
            // stoMin
            // 
            this.stoMin.HeaderText = "Stock Mínimo";
            this.stoMin.MinimumWidth = 65;
            this.stoMin.Name = "stoMin";
            this.stoMin.ReadOnly = true;
            this.stoMin.Width = 65;
            // 
            // ingart
            // 
            this.ingart.HeaderText = "Opción";
            this.ingart.MinimumWidth = 80;
            this.ingart.Name = "ingart";
            this.ingart.ReadOnly = true;
            this.ingart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ingart.Text = "Seleccionar";
            this.ingart.Width = 80;
            // 
            // identificador
            // 
            this.identificador.HeaderText = "ID";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(100, 17);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(785, 26);
            this.txt_descripcion.TabIndex = 1;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(6, 20);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(96, 20);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Descripción:";
            // 
            // btn_verPedido
            // 
            this.btn_verPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_verPedido.BackColor = System.Drawing.SystemColors.Control;
            this.btn_verPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verPedido.Image = global::SistemaLaObra.Properties.Resources.registrar;
            this.btn_verPedido.Location = new System.Drawing.Point(733, 517);
            this.btn_verPedido.Name = "btn_verPedido";
            this.btn_verPedido.Size = new System.Drawing.Size(170, 50);
            this.btn_verPedido.TabIndex = 6;
            this.btn_verPedido.Text = "Registrar";
            this.btn_verPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_verPedido.UseVisualStyleBackColor = false;
            this.btn_verPedido.Click += new System.EventHandler(this.btn_registrarPedido_Click);
            // 
            // IU_RegistrarPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 579);
            this.Controls.Add(this.btn_verPedido);
            this.Controls.Add(this.gbx_agregarArticulo);
            this.Controls.Add(this.gbx_listaArticulos);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IU_RegistrarPedidoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR PEDIDO DE COMPRA";
            this.gbx_listaArticulos.ResumeLayout(false);
            this.gbx_listaArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaArticulos)).EndInit();
            this.gbx_agregarArticulo.ResumeLayout(false);
            this.gbx_agregarArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aSeleccionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.GroupBox gbx_listaArticulos;
        private System.Windows.Forms.GroupBox gbx_agregarArticulo;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_descripcion;
        public System.Windows.Forms.DataGridView dgv_listaArticulos;
        public System.Windows.Forms.DataGridView dgv_aSeleccionar;
        private System.Windows.Forms.Button btn_verPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn sto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoMin;
        private System.Windows.Forms.DataGridViewButtonColumn ingart;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewComboBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        public System.Windows.Forms.Label lbl_saldoCompra;
        private System.Windows.Forms.Label lbl_2;
    }
}