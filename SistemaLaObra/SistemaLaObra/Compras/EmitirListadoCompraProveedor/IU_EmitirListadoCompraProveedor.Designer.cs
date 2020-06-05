namespace SistemaLaObra.Compras.EmitirListadoCompraProveedor
{
    partial class IU_EmitirListadoCompraProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_EmitirListadoCompraProveedor));
            this.gbx_ordenesDeCompra = new System.Windows.Forms.GroupBox();
            this.dgv_listaArticulos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lrgajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaPrevia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_ordenesDeCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_ordenesDeCompra
            // 
            this.gbx_ordenesDeCompra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_ordenesDeCompra.Controls.Add(this.dgv_listaArticulos);
            this.gbx_ordenesDeCompra.Location = new System.Drawing.Point(12, 12);
            this.gbx_ordenesDeCompra.Name = "gbx_ordenesDeCompra";
            this.gbx_ordenesDeCompra.Size = new System.Drawing.Size(789, 370);
            this.gbx_ordenesDeCompra.TabIndex = 0;
            this.gbx_ordenesDeCompra.TabStop = false;
            this.gbx_ordenesDeCompra.Text = "Ordenes de compra";
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
            this.fecha,
            this.importe,
            this.encargado,
            this.lrgajo,
            this.vistaPrevia});
            this.dgv_listaArticulos.Location = new System.Drawing.Point(6, 19);
            this.dgv_listaArticulos.MultiSelect = false;
            this.dgv_listaArticulos.Name = "dgv_listaArticulos";
            this.dgv_listaArticulos.RowHeadersVisible = false;
            this.dgv_listaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaArticulos.Size = new System.Drawing.Size(768, 345);
            this.dgv_listaArticulos.TabIndex = 1;
            this.dgv_listaArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaArticulos_CellContentClick);
            // 
            // codigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "Nro. de orden";
            this.codigo.MinimumWidth = 100;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // fecha
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 100;
            this.fecha.Name = "fecha";
            // 
            // importe
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.importe.HeaderText = "Importe total";
            this.importe.MinimumWidth = 123;
            this.importe.Name = "importe";
            this.importe.Width = 123;
            // 
            // encargado
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.encargado.DefaultCellStyle = dataGridViewCellStyle5;
            this.encargado.HeaderText = "Encargado";
            this.encargado.MinimumWidth = 280;
            this.encargado.Name = "encargado";
            this.encargado.Width = 280;
            // 
            // lrgajo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lrgajo.DefaultCellStyle = dataGridViewCellStyle6;
            this.lrgajo.HeaderText = "Legajo";
            this.lrgajo.MinimumWidth = 70;
            this.lrgajo.Name = "lrgajo";
            this.lrgajo.Width = 70;
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.HeaderText = "";
            this.vistaPrevia.MinimumWidth = 90;
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Width = 90;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 398);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // IU_EmitirListadoCompraProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gbx_ordenesDeCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_EmitirListadoCompraProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EMITIR COMPRA POR PROVEEDOR";
            this.Load += new System.EventHandler(this.IU_EmitirListadoCompraProveedor_Load);
            this.gbx_ordenesDeCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_ordenesDeCompra;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.DataGridView dgv_listaArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn lrgajo;
        private System.Windows.Forms.DataGridViewButtonColumn vistaPrevia;
    }
}