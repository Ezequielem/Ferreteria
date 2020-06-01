namespace SistemaLaObra.Ventas.ConsultarVenta
{
    partial class IU_DetalleVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nroVenta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fechaHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tipoCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_importeTotal = new System.Windows.Forms.Label();
            this.gb_venta = new System.Windows.Forms.GroupBox();
            this.lbl_formaPago = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_importeEnvio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cantidadEnvios = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_envio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_detalleVenta = new System.Windows.Forms.GroupBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_consultarDatosCliente = new System.Windows.Forms.Button();
            this.btn_detalleEnvio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_venta.SuspendLayout();
            this.gb_detalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de venta:";
            // 
            // lbl_nroVenta
            // 
            this.lbl_nroVenta.AutoSize = true;
            this.lbl_nroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nroVenta.Location = new System.Drawing.Point(104, 30);
            this.lbl_nroVenta.Name = "lbl_nroVenta";
            this.lbl_nroVenta.Size = new System.Drawing.Size(69, 13);
            this.lbl_nroVenta.TabIndex = 1;
            this.lbl_nroVenta.Text = "[nro venta]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha y hora de la venta:";
            // 
            // lbl_fechaHora
            // 
            this.lbl_fechaHora.AutoSize = true;
            this.lbl_fechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaHora.Location = new System.Drawing.Point(140, 59);
            this.lbl_fechaHora.Name = "lbl_fechaHora";
            this.lbl_fechaHora.Size = new System.Drawing.Size(84, 13);
            this.lbl_fechaHora.TabIndex = 3;
            this.lbl_fechaHora.Text = "[fecha - hora]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendedor:";
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendedor.Location = new System.Drawing.Point(68, 85);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(68, 13);
            this.lbl_vendedor.TabIndex = 5;
            this.lbl_vendedor.Text = "[vendedor]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de cliente:";
            // 
            // lbl_tipoCliente
            // 
            this.lbl_tipoCliente.AutoSize = true;
            this.lbl_tipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoCliente.Location = new System.Drawing.Point(89, 111);
            this.lbl_tipoCliente.Name = "lbl_tipoCliente";
            this.lbl_tipoCliente.Size = new System.Drawing.Size(75, 13);
            this.lbl_tipoCliente.TabIndex = 7;
            this.lbl_tipoCliente.Text = "[tipoCliente]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Importe total:";
            // 
            // lbl_importeTotal
            // 
            this.lbl_importeTotal.AutoSize = true;
            this.lbl_importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeTotal.Location = new System.Drawing.Point(75, 164);
            this.lbl_importeTotal.Name = "lbl_importeTotal";
            this.lbl_importeTotal.Size = new System.Drawing.Size(109, 17);
            this.lbl_importeTotal.TabIndex = 9;
            this.lbl_importeTotal.Text = "[importeTotal]";
            // 
            // gb_venta
            // 
            this.gb_venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_venta.Controls.Add(this.lbl_formaPago);
            this.gb_venta.Controls.Add(this.label9);
            this.gb_venta.Controls.Add(this.lbl_importeEnvio);
            this.gb_venta.Controls.Add(this.label7);
            this.gb_venta.Controls.Add(this.lbl_cantidadEnvios);
            this.gb_venta.Controls.Add(this.label8);
            this.gb_venta.Controls.Add(this.lbl_envio);
            this.gb_venta.Controls.Add(this.label6);
            this.gb_venta.Controls.Add(this.label1);
            this.gb_venta.Controls.Add(this.lbl_importeTotal);
            this.gb_venta.Controls.Add(this.lbl_nroVenta);
            this.gb_venta.Controls.Add(this.label5);
            this.gb_venta.Controls.Add(this.label2);
            this.gb_venta.Controls.Add(this.lbl_tipoCliente);
            this.gb_venta.Controls.Add(this.lbl_fechaHora);
            this.gb_venta.Controls.Add(this.label4);
            this.gb_venta.Controls.Add(this.label3);
            this.gb_venta.Controls.Add(this.lbl_vendedor);
            this.gb_venta.Location = new System.Drawing.Point(11, 12);
            this.gb_venta.Name = "gb_venta";
            this.gb_venta.Size = new System.Drawing.Size(502, 196);
            this.gb_venta.TabIndex = 10;
            this.gb_venta.TabStop = false;
            this.gb_venta.Text = "VENTA";
            // 
            // lbl_formaPago
            // 
            this.lbl_formaPago.AutoSize = true;
            this.lbl_formaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formaPago.Location = new System.Drawing.Point(89, 137);
            this.lbl_formaPago.Name = "lbl_formaPago";
            this.lbl_formaPago.Size = new System.Drawing.Size(0, 13);
            this.lbl_formaPago.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Forma de pago:";
            // 
            // lbl_importeEnvio
            // 
            this.lbl_importeEnvio.AutoSize = true;
            this.lbl_importeEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeEnvio.Location = new System.Drawing.Point(396, 85);
            this.lbl_importeEnvio.Name = "lbl_importeEnvio";
            this.lbl_importeEnvio.Size = new System.Drawing.Size(0, 13);
            this.lbl_importeEnvio.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Importe del envio:";
            // 
            // lbl_cantidadEnvios
            // 
            this.lbl_cantidadEnvios.AutoSize = true;
            this.lbl_cantidadEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadEnvios.Location = new System.Drawing.Point(398, 59);
            this.lbl_cantidadEnvios.Name = "lbl_cantidadEnvios";
            this.lbl_cantidadEnvios.Size = new System.Drawing.Size(0, 13);
            this.lbl_cantidadEnvios.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad de envios:";
            // 
            // lbl_envio
            // 
            this.lbl_envio.AutoSize = true;
            this.lbl_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_envio.Location = new System.Drawing.Point(333, 30);
            this.lbl_envio.Name = "lbl_envio";
            this.lbl_envio.Size = new System.Drawing.Size(0, 13);
            this.lbl_envio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Envio:";
            // 
            // gb_detalleVenta
            // 
            this.gb_detalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_detalleVenta.Controls.Add(this.dgv_productos);
            this.gb_detalleVenta.Location = new System.Drawing.Point(12, 214);
            this.gb_detalleVenta.Name = "gb_detalleVenta";
            this.gb_detalleVenta.Size = new System.Drawing.Size(693, 206);
            this.gb_detalleVenta.TabIndex = 11;
            this.gb_detalleVenta.TabStop = false;
            this.gb_detalleVenta.Text = "DETALLE DE VENTA";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_productos.Location = new System.Drawing.Point(6, 19);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(681, 181);
            this.dgv_productos.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Codigo de articulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Descipcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Precio unitario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Cantidad solicitada";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(567, 426);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(138, 41);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_consultarDatosCliente
            // 
            this.btn_consultarDatosCliente.Enabled = false;
            this.btn_consultarDatosCliente.Location = new System.Drawing.Point(24, 53);
            this.btn_consultarDatosCliente.Name = "btn_consultarDatosCliente";
            this.btn_consultarDatosCliente.Size = new System.Drawing.Size(142, 23);
            this.btn_consultarDatosCliente.TabIndex = 18;
            this.btn_consultarDatosCliente.Text = "Consultar datos del cliente";
            this.btn_consultarDatosCliente.UseVisualStyleBackColor = true;
            this.btn_consultarDatosCliente.Click += new System.EventHandler(this.btn_consultarDatosCliente_Click);
            // 
            // btn_detalleEnvio
            // 
            this.btn_detalleEnvio.Enabled = false;
            this.btn_detalleEnvio.Location = new System.Drawing.Point(24, 25);
            this.btn_detalleEnvio.Name = "btn_detalleEnvio";
            this.btn_detalleEnvio.Size = new System.Drawing.Size(142, 23);
            this.btn_detalleEnvio.TabIndex = 19;
            this.btn_detalleEnvio.Text = "Detalles del envio";
            this.btn_detalleEnvio.UseVisualStyleBackColor = true;
            this.btn_detalleEnvio.Click += new System.EventHandler(this.btn_detalleEnvio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_detalleEnvio);
            this.groupBox1.Controls.Add(this.btn_consultarDatosCliente);
            this.groupBox1.Location = new System.Drawing.Point(517, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 196);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION ADICIONAL";
            // 
            // IU_DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(717, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.gb_detalleVenta);
            this.Controls.Add(this.gb_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IU_DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE DE LA VENTA";
            this.gb_venta.ResumeLayout(false);
            this.gb_venta.PerformLayout();
            this.gb_detalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_venta;
        private System.Windows.Forms.GroupBox gb_detalleVenta;
        public System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbl_nroVenta;
        public System.Windows.Forms.Label lbl_fechaHora;
        public System.Windows.Forms.Label lbl_vendedor;
        public System.Windows.Forms.Label lbl_tipoCliente;
        public System.Windows.Forms.Label lbl_importeTotal;
        public System.Windows.Forms.Label lbl_formaPago;
        public System.Windows.Forms.Label lbl_importeEnvio;
        public System.Windows.Forms.Label lbl_cantidadEnvios;
        public System.Windows.Forms.Label lbl_envio;
        public System.Windows.Forms.Button btn_detalleEnvio;
        public System.Windows.Forms.Button btn_consultarDatosCliente;
    }
}