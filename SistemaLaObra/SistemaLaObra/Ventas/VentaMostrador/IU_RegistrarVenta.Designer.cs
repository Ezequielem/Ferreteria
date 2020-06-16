namespace SistemaLaObra
{
    partial class IU_RegistrarVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_RegistrarVenta));
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_importeTotal = new System.Windows.Forms.Label();
            this.cbx_formaPago = new System.Windows.Forms.ComboBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cargoEnvio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_productos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_quitarArticulo = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.gbx_envio = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_detallesEnvioDomicilio = new System.Windows.Forms.Button();
            this.lbl_cantidadEnvios = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_envioDomicilio = new System.Windows.Forms.Button();
            this.gbx_Tarjeta = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_cantidadTarjeta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_cargoTarjeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_detalleTarjeta = new System.Windows.Forms.Button();
            this.btn_cobroTarjeta = new System.Windows.Forms.Button();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ch_cargoEnvio = new System.Windows.Forms.CheckBox();
            this.lbl_saldoAPagar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbx_FormaDePago = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrarVenta = new System.Windows.Forms.Button();
            this.ch_notaCredito = new System.Windows.Forms.CheckBox();
            this.rb_clienteMinorista = new System.Windows.Forms.RadioButton();
            this.gb_tipoCliente = new System.Windows.Forms.GroupBox();
            this.rb_clienteMayorista = new System.Windows.Forms.RadioButton();
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_razonSocial = new System.Windows.Forms.TextBox();
            this.btn_buscarDatos = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chx_facturacion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.gb_productos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbx_envio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_Tarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_FormaDePago)).BeginInit();
            this.gb_tipoCliente.SuspendLayout();
            this.gb_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(13, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "IMPORTE TOTAL: ";
            // 
            // lbl_importeTotal
            // 
            this.lbl_importeTotal.AutoSize = true;
            this.lbl_importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_importeTotal.Location = new System.Drawing.Point(200, 582);
            this.lbl_importeTotal.Name = "lbl_importeTotal";
            this.lbl_importeTotal.Size = new System.Drawing.Size(78, 26);
            this.lbl_importeTotal.TabIndex = 10;
            this.lbl_importeTotal.Text = "$ 0.00";
            // 
            // cbx_formaPago
            // 
            this.cbx_formaPago.BackColor = System.Drawing.SystemColors.Window;
            this.cbx_formaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_formaPago.Enabled = false;
            this.cbx_formaPago.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_formaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_formaPago.Items.AddRange(new object[] {
            "EFECTIVO"});
            this.cbx_formaPago.Location = new System.Drawing.Point(550, 621);
            this.cbx_formaPago.Name = "cbx_formaPago";
            this.cbx_formaPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_formaPago.Size = new System.Drawing.Size(297, 32);
            this.cbx_formaPago.TabIndex = 11;
            this.cbx_formaPago.SelectedIndexChanged += new System.EventHandler(this.cbx_formaPago_SelectedIndexChanged);
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_productos.Location = new System.Drawing.Point(5, 75);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(823, 369);
            this.dgv_productos.TabIndex = 19;
            this.dgv_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellDoubleClick);
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
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Stock disponible";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Cantidad solicitada";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Subtotal";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lbl_cargoEnvio
            // 
            this.lbl_cargoEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cargoEnvio.AutoSize = true;
            this.lbl_cargoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_cargoEnvio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cargoEnvio.Location = new System.Drawing.Point(8, 66);
            this.lbl_cargoEnvio.Name = "lbl_cargoEnvio";
            this.lbl_cargoEnvio.Size = new System.Drawing.Size(78, 26);
            this.lbl_cargoEnvio.TabIndex = 18;
            this.lbl_cargoEnvio.Text = "$ 0.00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cargo de envio: ";
            // 
            // gb_productos
            // 
            this.gb_productos.Controls.Add(this.tableLayoutPanel1);
            this.gb_productos.Controls.Add(this.dgv_productos);
            this.gb_productos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_productos.Location = new System.Drawing.Point(12, 77);
            this.gb_productos.Name = "gb_productos";
            this.gb_productos.Size = new System.Drawing.Size(835, 455);
            this.gb_productos.TabIndex = 20;
            this.gb_productos.TabStop = false;
            this.gb_productos.Text = "CARGA VENTA DE PRODUCTOS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_quitarArticulo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cargar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 49);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btn_quitarArticulo
            // 
            this.btn_quitarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_quitarArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_quitarArticulo.Enabled = false;
            this.btn_quitarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitarArticulo.Image = global::SistemaLaObra.Properties.Resources.quitar;
            this.btn_quitarArticulo.Location = new System.Drawing.Point(676, 4);
            this.btn_quitarArticulo.Name = "btn_quitarArticulo";
            this.btn_quitarArticulo.Size = new System.Drawing.Size(140, 40);
            this.btn_quitarArticulo.TabIndex = 8;
            this.btn_quitarArticulo.Text = "Quitar articulo";
            this.btn_quitarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quitarArticulo.UseVisualStyleBackColor = false;
            this.btn_quitarArticulo.Click += new System.EventHandler(this.btn_quitarArticulo_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cargar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Image = global::SistemaLaObra.Properties.Resources.cargar;
            this.btn_cargar.Location = new System.Drawing.Point(473, 4);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(136, 40);
            this.btn_cargar.TabIndex = 7;
            this.btn_cargar.Text = "Cargar articulo";
            this.btn_cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // gbx_envio
            // 
            this.gbx_envio.Controls.Add(this.pictureBox1);
            this.gbx_envio.Controls.Add(this.btn_detallesEnvioDomicilio);
            this.gbx_envio.Controls.Add(this.lbl_cantidadEnvios);
            this.gbx_envio.Controls.Add(this.label11);
            this.gbx_envio.Controls.Add(this.label6);
            this.gbx_envio.Controls.Add(this.lbl_cargoEnvio);
            this.gbx_envio.Controls.Add(this.btn_envioDomicilio);
            this.gbx_envio.Enabled = false;
            this.gbx_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbx_envio.Location = new System.Drawing.Point(856, 145);
            this.gbx_envio.Name = "gbx_envio";
            this.gbx_envio.Size = new System.Drawing.Size(309, 189);
            this.gbx_envio.TabIndex = 22;
            this.gbx_envio.TabStop = false;
            this.gbx_envio.Text = "ENVÍO DE PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.envioGris_64;
            this.pictureBox1.Location = new System.Drawing.Point(238, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_detallesEnvioDomicilio
            // 
            this.btn_detallesEnvioDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_detallesEnvioDomicilio.BackColor = System.Drawing.SystemColors.Control;
            this.btn_detallesEnvioDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detallesEnvioDomicilio.Image = global::SistemaLaObra.Properties.Resources.detalle;
            this.btn_detallesEnvioDomicilio.Location = new System.Drawing.Point(6, 143);
            this.btn_detallesEnvioDomicilio.Name = "btn_detallesEnvioDomicilio";
            this.btn_detallesEnvioDomicilio.Size = new System.Drawing.Size(120, 40);
            this.btn_detallesEnvioDomicilio.TabIndex = 10;
            this.btn_detallesEnvioDomicilio.Text = "Detalles";
            this.btn_detallesEnvioDomicilio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_detallesEnvioDomicilio.UseVisualStyleBackColor = false;
            this.btn_detallesEnvioDomicilio.Click += new System.EventHandler(this.btn_detallesEnvioDomicilio_Click);
            // 
            // lbl_cantidadEnvios
            // 
            this.lbl_cantidadEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidadEnvios.AutoSize = true;
            this.lbl_cantidadEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_cantidadEnvios.Location = new System.Drawing.Point(126, 100);
            this.lbl_cantidadEnvios.Name = "lbl_cantidadEnvios";
            this.lbl_cantidadEnvios.Size = new System.Drawing.Size(15, 15);
            this.lbl_cantidadEnvios.TabIndex = 20;
            this.lbl_cantidadEnvios.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cantidad de envios:";
            // 
            // btn_envioDomicilio
            // 
            this.btn_envioDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_envioDomicilio.BackColor = System.Drawing.SystemColors.Control;
            this.btn_envioDomicilio.Enabled = false;
            this.btn_envioDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_envioDomicilio.Image = global::SistemaLaObra.Properties.Resources.envio_32;
            this.btn_envioDomicilio.Location = new System.Drawing.Point(183, 143);
            this.btn_envioDomicilio.Name = "btn_envioDomicilio";
            this.btn_envioDomicilio.Size = new System.Drawing.Size(120, 40);
            this.btn_envioDomicilio.TabIndex = 9;
            this.btn_envioDomicilio.Text = "Envío a \r\ndomicilio";
            this.btn_envioDomicilio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_envioDomicilio.UseVisualStyleBackColor = false;
            this.btn_envioDomicilio.Click += new System.EventHandler(this.btn_envioDomicilio_Click);
            // 
            // gbx_Tarjeta
            // 
            this.gbx_Tarjeta.Controls.Add(this.pictureBox2);
            this.gbx_Tarjeta.Controls.Add(this.lbl_cantidadTarjeta);
            this.gbx_Tarjeta.Controls.Add(this.label8);
            this.gbx_Tarjeta.Controls.Add(this.lbl_cargoTarjeta);
            this.gbx_Tarjeta.Controls.Add(this.label1);
            this.gbx_Tarjeta.Controls.Add(this.btn_detalleTarjeta);
            this.gbx_Tarjeta.Controls.Add(this.btn_cobroTarjeta);
            this.gbx_Tarjeta.Enabled = false;
            this.gbx_Tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbx_Tarjeta.Location = new System.Drawing.Point(856, 355);
            this.gbx_Tarjeta.Name = "gbx_Tarjeta";
            this.gbx_Tarjeta.Size = new System.Drawing.Size(309, 175);
            this.gbx_Tarjeta.TabIndex = 23;
            this.gbx_Tarjeta.TabStop = false;
            this.gbx_Tarjeta.Text = "COBRO CON TARJETAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::SistemaLaObra.Properties.Resources.creditoGris_64;
            this.pictureBox2.Location = new System.Drawing.Point(238, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_cantidadTarjeta
            // 
            this.lbl_cantidadTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidadTarjeta.AutoSize = true;
            this.lbl_cantidadTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_cantidadTarjeta.Location = new System.Drawing.Point(136, 85);
            this.lbl_cantidadTarjeta.Name = "lbl_cantidadTarjeta";
            this.lbl_cantidadTarjeta.Size = new System.Drawing.Size(15, 15);
            this.lbl_cantidadTarjeta.TabIndex = 24;
            this.lbl_cantidadTarjeta.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cantidad de Tarjetas:";
            // 
            // lbl_cargoTarjeta
            // 
            this.lbl_cargoTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cargoTarjeta.AutoSize = true;
            this.lbl_cargoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_cargoTarjeta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_cargoTarjeta.Location = new System.Drawing.Point(8, 56);
            this.lbl_cargoTarjeta.Name = "lbl_cargoTarjeta";
            this.lbl_cargoTarjeta.Size = new System.Drawing.Size(78, 26);
            this.lbl_cargoTarjeta.TabIndex = 24;
            this.lbl_cargoTarjeta.Text = "$ 0.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cargo de tarjeta: ";
            // 
            // btn_detalleTarjeta
            // 
            this.btn_detalleTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_detalleTarjeta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_detalleTarjeta.Enabled = false;
            this.btn_detalleTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalleTarjeta.Image = global::SistemaLaObra.Properties.Resources.detalle;
            this.btn_detalleTarjeta.Location = new System.Drawing.Point(6, 129);
            this.btn_detalleTarjeta.Name = "btn_detalleTarjeta";
            this.btn_detalleTarjeta.Size = new System.Drawing.Size(120, 40);
            this.btn_detalleTarjeta.TabIndex = 13;
            this.btn_detalleTarjeta.Text = "Detalles";
            this.btn_detalleTarjeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_detalleTarjeta.UseVisualStyleBackColor = false;
            this.btn_detalleTarjeta.Click += new System.EventHandler(this.btn_detalleTarjeta_Click);
            // 
            // btn_cobroTarjeta
            // 
            this.btn_cobroTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cobroTarjeta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cobroTarjeta.Enabled = false;
            this.btn_cobroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobroTarjeta.Image = global::SistemaLaObra.Properties.Resources.credito_32;
            this.btn_cobroTarjeta.Location = new System.Drawing.Point(182, 129);
            this.btn_cobroTarjeta.Name = "btn_cobroTarjeta";
            this.btn_cobroTarjeta.Size = new System.Drawing.Size(120, 40);
            this.btn_cobroTarjeta.TabIndex = 12;
            this.btn_cobroTarjeta.Text = "Cobro con\r\ntarjeta";
            this.btn_cobroTarjeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cobroTarjeta.UseVisualStyleBackColor = false;
            this.btn_cobroTarjeta.Click += new System.EventHandler(this.btn_cobroTarjeta_Click);
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_subTotal.Location = new System.Drawing.Point(200, 546);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(78, 26);
            this.lbl_subTotal.TabIndex = 25;
            this.lbl_subTotal.Text = "$ 0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(12, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "SUBTOTAL: ";
            // 
            // ch_cargoEnvio
            // 
            this.ch_cargoEnvio.AutoSize = true;
            this.ch_cargoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_cargoEnvio.Location = new System.Drawing.Point(672, 580);
            this.ch_cargoEnvio.Name = "ch_cargoEnvio";
            this.ch_cargoEnvio.Size = new System.Drawing.Size(178, 30);
            this.ch_cargoEnvio.TabIndex = 14;
            this.ch_cargoEnvio.Text = "Cargo de envío";
            this.ch_cargoEnvio.UseVisualStyleBackColor = true;
            this.ch_cargoEnvio.CheckedChanged += new System.EventHandler(this.ch_cargoEnvio_CheckedChanged);
            // 
            // lbl_saldoAPagar
            // 
            this.lbl_saldoAPagar.AutoSize = true;
            this.lbl_saldoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_saldoAPagar.Location = new System.Drawing.Point(393, 582);
            this.lbl_saldoAPagar.Name = "lbl_saldoAPagar";
            this.lbl_saldoAPagar.Size = new System.Drawing.Size(78, 26);
            this.lbl_saldoAPagar.TabIndex = 30;
            this.lbl_saldoAPagar.Text = "$ 0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(393, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "SALDO A PAGAR";
            // 
            // pbx_FormaDePago
            // 
            this.pbx_FormaDePago.Image = global::SistemaLaObra.Properties.Resources.facturaBGris_32;
            this.pbx_FormaDePago.Location = new System.Drawing.Point(512, 621);
            this.pbx_FormaDePago.Name = "pbx_FormaDePago";
            this.pbx_FormaDePago.Size = new System.Drawing.Size(32, 32);
            this.pbx_FormaDePago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_FormaDePago.TabIndex = 31;
            this.pbx_FormaDePago.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 621);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(126, 50);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registrarVenta
            // 
            this.btn_registrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registrarVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_registrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_registrarVenta.Enabled = false;
            this.btn_registrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarVenta.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_registrarVenta.Location = new System.Drawing.Point(1015, 621);
            this.btn_registrarVenta.Name = "btn_registrarVenta";
            this.btn_registrarVenta.Size = new System.Drawing.Size(150, 50);
            this.btn_registrarVenta.TabIndex = 16;
            this.btn_registrarVenta.Text = "Registrar";
            this.btn_registrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrarVenta.UseVisualStyleBackColor = false;
            this.btn_registrarVenta.Click += new System.EventHandler(this.btn_registrarVenta_Click);
            // 
            // ch_notaCredito
            // 
            this.ch_notaCredito.AutoSize = true;
            this.ch_notaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_notaCredito.Location = new System.Drawing.Point(672, 544);
            this.ch_notaCredito.Name = "ch_notaCredito";
            this.ch_notaCredito.Size = new System.Drawing.Size(178, 30);
            this.ch_notaCredito.TabIndex = 15;
            this.ch_notaCredito.Text = "Nota de credito";
            this.ch_notaCredito.UseVisualStyleBackColor = true;
            this.ch_notaCredito.CheckedChanged += new System.EventHandler(this.ch_notaCredito_CheckedChanged);
            // 
            // rb_clienteMinorista
            // 
            this.rb_clienteMinorista.AutoSize = true;
            this.rb_clienteMinorista.Checked = true;
            this.rb_clienteMinorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_clienteMinorista.Location = new System.Drawing.Point(9, 24);
            this.rb_clienteMinorista.Name = "rb_clienteMinorista";
            this.rb_clienteMinorista.Size = new System.Drawing.Size(76, 19);
            this.rb_clienteMinorista.TabIndex = 1;
            this.rb_clienteMinorista.TabStop = true;
            this.rb_clienteMinorista.Text = "Minorista";
            this.rb_clienteMinorista.UseVisualStyleBackColor = true;
            this.rb_clienteMinorista.CheckedChanged += new System.EventHandler(this.rb_clienteMinorista_CheckedChanged);
            // 
            // gb_tipoCliente
            // 
            this.gb_tipoCliente.Controls.Add(this.rb_clienteMayorista);
            this.gb_tipoCliente.Controls.Add(this.rb_clienteMinorista);
            this.gb_tipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_tipoCliente.Location = new System.Drawing.Point(12, 12);
            this.gb_tipoCliente.Name = "gb_tipoCliente";
            this.gb_tipoCliente.Size = new System.Drawing.Size(226, 59);
            this.gb_tipoCliente.TabIndex = 34;
            this.gb_tipoCliente.TabStop = false;
            this.gb_tipoCliente.Text = "TIPO DE CLIENTE";
            // 
            // rb_clienteMayorista
            // 
            this.rb_clienteMayorista.AutoSize = true;
            this.rb_clienteMayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_clienteMayorista.Location = new System.Drawing.Point(123, 24);
            this.rb_clienteMayorista.Name = "rb_clienteMayorista";
            this.rb_clienteMayorista.Size = new System.Drawing.Size(78, 19);
            this.rb_clienteMayorista.TabIndex = 2;
            this.rb_clienteMayorista.Text = "Mayorista";
            this.rb_clienteMayorista.UseVisualStyleBackColor = true;
            this.rb_clienteMayorista.CheckedChanged += new System.EventHandler(this.rb_clienteMayorista_CheckedChanged);
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.label7);
            this.gb_cliente.Controls.Add(this.txt_razonSocial);
            this.gb_cliente.Controls.Add(this.btn_buscarDatos);
            this.gb_cliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cliente.Location = new System.Drawing.Point(244, 12);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Size = new System.Drawing.Size(603, 59);
            this.gb_cliente.TabIndex = 42;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "CONSULTAR DATOS DEL CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Razon Social: ";
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_razonSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_razonSocial.Enabled = false;
            this.txt_razonSocial.Location = new System.Drawing.Point(97, 23);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(194, 21);
            this.txt_razonSocial.TabIndex = 3;
            // 
            // btn_buscarDatos
            // 
            this.btn_buscarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscarDatos.Enabled = false;
            this.btn_buscarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarDatos.Image")));
            this.btn_buscarDatos.Location = new System.Drawing.Point(310, 13);
            this.btn_buscarDatos.Name = "btn_buscarDatos";
            this.btn_buscarDatos.Size = new System.Drawing.Size(133, 40);
            this.btn_buscarDatos.TabIndex = 4;
            this.btn_buscarDatos.Text = "Consultar datos";
            this.btn_buscarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscarDatos.UseVisualStyleBackColor = false;
            this.btn_buscarDatos.Click += new System.EventHandler(this.btn_buscarDatos_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaLaObra.Properties.Resources.ventasGris_128;
            this.pictureBox4.Location = new System.Drawing.Point(1037, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // chx_facturacion
            // 
            this.chx_facturacion.AutoSize = true;
            this.chx_facturacion.Enabled = false;
            this.chx_facturacion.Location = new System.Drawing.Point(862, 122);
            this.chx_facturacion.Name = "chx_facturacion";
            this.chx_facturacion.Size = new System.Drawing.Size(76, 17);
            this.chx_facturacion.TabIndex = 44;
            this.chx_facturacion.Text = "FACTURA";
            this.chx_facturacion.UseVisualStyleBackColor = true;
            // 
            // IU_RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 683);
            this.Controls.Add(this.chx_facturacion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.gb_cliente);
            this.Controls.Add(this.gb_tipoCliente);
            this.Controls.Add(this.ch_notaCredito);
            this.Controls.Add(this.pbx_FormaDePago);
            this.Controls.Add(this.lbl_saldoAPagar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ch_cargoEnvio);
            this.Controls.Add(this.lbl_subTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_importeTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbx_Tarjeta);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gbx_envio);
            this.Controls.Add(this.cbx_formaPago);
            this.Controls.Add(this.gb_productos);
            this.Controls.Add(this.btn_registrarVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_RegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REGISTRAR VENTA MINORISTA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IU_RegistrarVenta_FormClosed);
            this.Load += new System.EventHandler(this.IU_RegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.gb_productos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbx_envio.ResumeLayout(false);
            this.gbx_envio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_Tarjeta.ResumeLayout(false);
            this.gbx_Tarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_FormaDePago)).EndInit();
            this.gb_tipoCliente.ResumeLayout(false);
            this.gb_tipoCliente.PerformLayout();
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_importeTotal;
        public System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.GroupBox gbx_envio;
        private System.Windows.Forms.GroupBox gbx_Tarjeta;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbl_cargoEnvio;
        public System.Windows.Forms.Label lbl_cantidadEnvios;
        public System.Windows.Forms.Button btn_detallesEnvioDomicilio;
        public System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.CheckBox ch_cargoEnvio;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cbx_formaPago;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lbl_cantidadTarjeta;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_cargoTarjeta;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_detalleTarjeta;
        public System.Windows.Forms.Button btn_quitarArticulo;
        public System.Windows.Forms.Button btn_cobroTarjeta;
        public System.Windows.Forms.Button btn_envioDomicilio;
        public System.Windows.Forms.Label lbl_saldoAPagar;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pbx_FormaDePago;
        public System.Windows.Forms.CheckBox ch_notaCredito;
        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_razonSocial;
        public System.Windows.Forms.Button btn_buscarDatos;
        public System.Windows.Forms.RadioButton rb_clienteMinorista;
        public System.Windows.Forms.GroupBox gb_productos;
        public System.Windows.Forms.RadioButton rb_clienteMayorista;
        public System.Windows.Forms.GroupBox gb_tipoCliente;
        public System.Windows.Forms.Button btn_registrarVenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chx_facturacion;
    }
}

