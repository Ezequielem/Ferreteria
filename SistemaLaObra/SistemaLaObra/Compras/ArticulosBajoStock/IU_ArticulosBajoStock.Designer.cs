namespace SistemaLaObra.Compras.ArticulosBajoStock
{
    partial class IU_ArticulosBajoStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_StockMinimo = new System.Windows.Forms.TextBox();
            this.lbl_Cuit = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_articulosBajoStock = new System.Windows.Forms.DataGridView();
            this.codigoArticuloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDeCostoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rb_cargaManual = new System.Windows.Forms.RadioButton();
            this.rb_cargaAutomatica = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_PedidoCompra = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulosBajoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulos bajo stock";
            // 
            // txt_StockMinimo
            // 
            this.txt_StockMinimo.Enabled = false;
            this.txt_StockMinimo.Location = new System.Drawing.Point(120, 97);
            this.txt_StockMinimo.Name = "txt_StockMinimo";
            this.txt_StockMinimo.Size = new System.Drawing.Size(40, 20);
            this.txt_StockMinimo.TabIndex = 5;
            this.txt_StockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StockMinimo_KeyPress);
            // 
            // lbl_Cuit
            // 
            this.lbl_Cuit.AutoSize = true;
            this.lbl_Cuit.Enabled = false;
            this.lbl_Cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cuit.Location = new System.Drawing.Point(12, 104);
            this.lbl_Cuit.Name = "lbl_Cuit";
            this.lbl_Cuit.Size = new System.Drawing.Size(102, 13);
            this.lbl_Cuit.TabIndex = 6;
            this.lbl_Cuit.Text = "STOCK MINIMO:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Enabled = false;
            this.btn_Buscar.Location = new System.Drawing.Point(180, 88);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 29);
            this.btn_Buscar.TabIndex = 19;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_articulosBajoStock
            // 
            this.dgv_articulosBajoStock.AllowUserToAddRows = false;
            this.dgv_articulosBajoStock.AllowUserToDeleteRows = false;
            this.dgv_articulosBajoStock.AllowUserToResizeColumns = false;
            this.dgv_articulosBajoStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_articulosBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_articulosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulosBajoStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoArticuloc,
            this.descripcionc,
            this.precioUnitarioc,
            this.precioDeCostoc,
            this.stockc,
            this.stockMinimoc,
            this.proveedorc,
            this.seleccion});
            this.dgv_articulosBajoStock.Location = new System.Drawing.Point(4, 149);
            this.dgv_articulosBajoStock.MultiSelect = false;
            this.dgv_articulosBajoStock.Name = "dgv_articulosBajoStock";
            this.dgv_articulosBajoStock.RowHeadersVisible = false;
            this.dgv_articulosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_articulosBajoStock.Size = new System.Drawing.Size(820, 239);
            this.dgv_articulosBajoStock.TabIndex = 20;
            // 
            // codigoArticuloc
            // 
            this.codigoArticuloc.HeaderText = "Cod. Articulo";
            this.codigoArticuloc.Name = "codigoArticuloc";
            this.codigoArticuloc.ReadOnly = true;
            // 
            // descripcionc
            // 
            this.descripcionc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionc.HeaderText = "Descripcion";
            this.descripcionc.Name = "descripcionc";
            this.descripcionc.ReadOnly = true;
            // 
            // precioUnitarioc
            // 
            this.precioUnitarioc.HeaderText = "Precio Unitario";
            this.precioUnitarioc.Name = "precioUnitarioc";
            this.precioUnitarioc.ReadOnly = true;
            // 
            // precioDeCostoc
            // 
            this.precioDeCostoc.HeaderText = "Precio de Costo";
            this.precioDeCostoc.Name = "precioDeCostoc";
            this.precioDeCostoc.ReadOnly = true;
            // 
            // stockc
            // 
            this.stockc.HeaderText = "Stock";
            this.stockc.Name = "stockc";
            this.stockc.ReadOnly = true;
            // 
            // stockMinimoc
            // 
            this.stockMinimoc.HeaderText = "Stock Minimo";
            this.stockMinimoc.Name = "stockMinimoc";
            this.stockMinimoc.ReadOnly = true;
            // 
            // proveedorc
            // 
            this.proveedorc.HeaderText = "Proveedor";
            this.proveedorc.Name = "proveedorc";
            this.proveedorc.ReadOnly = true;
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "Seleccion";
            this.seleccion.Name = "seleccion";
            // 
            // rb_cargaManual
            // 
            this.rb_cargaManual.AutoSize = true;
            this.rb_cargaManual.Location = new System.Drawing.Point(15, 69);
            this.rb_cargaManual.Name = "rb_cargaManual";
            this.rb_cargaManual.Size = new System.Drawing.Size(91, 17);
            this.rb_cargaManual.TabIndex = 25;
            this.rb_cargaManual.TabStop = true;
            this.rb_cargaManual.Text = "Carga Manual";
            this.rb_cargaManual.UseVisualStyleBackColor = true;
            this.rb_cargaManual.CheckedChanged += new System.EventHandler(this.rb_cargaManual_CheckedChanged);
            // 
            // rb_cargaAutomatica
            // 
            this.rb_cargaAutomatica.AutoSize = true;
            this.rb_cargaAutomatica.Checked = true;
            this.rb_cargaAutomatica.Location = new System.Drawing.Point(15, 46);
            this.rb_cargaAutomatica.Name = "rb_cargaAutomatica";
            this.rb_cargaAutomatica.Size = new System.Drawing.Size(109, 17);
            this.rb_cargaAutomatica.TabIndex = 26;
            this.rb_cargaAutomatica.TabStop = true;
            this.rb_cargaAutomatica.Text = "Carga Automatica";
            this.rb_cargaAutomatica.UseVisualStyleBackColor = true;
            this.rb_cargaAutomatica.CheckedChanged += new System.EventHandler(this.rb_cargaAutomatica_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.if_General_Office_48_2530806;
            this.pictureBox1.Location = new System.Drawing.Point(755, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_PedidoCompra
            // 
            this.btn_PedidoCompra.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PedidoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PedidoCompra.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_PedidoCompra.Location = new System.Drawing.Point(527, 416);
            this.btn_PedidoCompra.Name = "btn_PedidoCompra";
            this.btn_PedidoCompra.Size = new System.Drawing.Size(290, 50);
            this.btn_PedidoCompra.TabIndex = 23;
            this.btn_PedidoCompra.Text = "Generar pedido de compra";
            this.btn_PedidoCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_PedidoCompra.UseVisualStyleBackColor = false;
            this.btn_PedidoCompra.Click += new System.EventHandler(this.btn_PedidoCompra_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.Image = global::SistemaLaObra.Properties.Resources.imprimir;
            this.btn_Imprimir.Location = new System.Drawing.Point(386, 416);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(123, 50);
            this.btn_Imprimir.TabIndex = 22;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_Cerrar.Location = new System.Drawing.Point(12, 416);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(141, 50);
            this.btn_Cerrar.TabIndex = 21;
            this.btn_Cerrar.Text = "Cancelar";
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // IU_ArticulosBajoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 481);
            this.Controls.Add(this.rb_cargaAutomatica);
            this.Controls.Add(this.rb_cargaManual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_PedidoCompra);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.dgv_articulosBajoStock);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.lbl_Cuit);
            this.Controls.Add(this.txt_StockMinimo);
            this.Controls.Add(this.label1);
            this.Name = "IU_ArticulosBajoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMITIR ARTICULOS BAJO STOCK";
            this.Load += new System.EventHandler(this.IU_ArticulosBajoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulosBajoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_StockMinimo;
        private System.Windows.Forms.Label lbl_Cuit;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_PedidoCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgv_articulosBajoStock;
        private System.Windows.Forms.RadioButton rb_cargaManual;
        private System.Windows.Forms.RadioButton rb_cargaAutomatica;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionc;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioc;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDeCostoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
    }
}