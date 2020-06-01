﻿namespace SistemaLaObra
{
    partial class IU_ActualizarArticulo
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.gb_articulo = new System.Windows.Forms.GroupBox();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.txt_precioCoste = new System.Windows.Forms.TextBox();
            this.lbl_precioCoste = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.nud_stock = new System.Windows.Forms.NumericUpDown();
            this.gb_actualizacion = new System.Windows.Forms.GroupBox();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.nud_stockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_unidadDeMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_ubicacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_categoria3 = new System.Windows.Forms.ComboBox();
            this.cbx_categoria2 = new System.Windows.Forms.ComboBox();
            this.cbx_categoria1 = new System.Windows.Forms.ComboBox();
            this.cbx_categoria = new System.Windows.Forms.ComboBox();
            this.txt_codigoDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_marca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_articulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).BeginInit();
            this.gb_actualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_salir.Location = new System.Drawing.Point(12, 473);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(140, 50);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(118, 240);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(656, 21);
            this.txt_filtro.TabIndex = 1;
            this.txt_filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por nombre:";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = global::SistemaLaObra.Properties.Resources.actualizar;
            this.btn_actualizar.Location = new System.Drawing.Point(797, 473);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(140, 50);
            this.btn_actualizar.TabIndex = 18;
            this.btn_actualizar.Text = "Modificar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // gb_articulo
            // 
            this.gb_articulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_articulo.Controls.Add(this.dgv_articulos);
            this.gb_articulo.Controls.Add(this.txt_filtro);
            this.gb_articulo.Controls.Add(this.btn_editar);
            this.gb_articulo.Controls.Add(this.label2);
            this.gb_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_articulo.Location = new System.Drawing.Point(12, 12);
            this.gb_articulo.Name = "gb_articulo";
            this.gb_articulo.Size = new System.Drawing.Size(926, 274);
            this.gb_articulo.TabIndex = 8;
            this.gb_articulo.TabStop = false;
            this.gb_articulo.Text = "LISTA DE ARTICULOS";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.AllowUserToAddRows = false;
            this.dgv_articulos.AllowUserToDeleteRows = false;
            this.dgv_articulos.AllowUserToResizeColumns = false;
            this.dgv_articulos.AllowUserToResizeRows = false;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgv_articulos.Location = new System.Drawing.Point(10, 20);
            this.dgv_articulos.MultiSelect = false;
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.ReadOnly = true;
            this.dgv_articulos.RowHeadersVisible = false;
            this.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_articulos.Size = new System.Drawing.Size(907, 202);
            this.dgv_articulos.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Artículo";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Código";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Costo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stock Mínimo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Medida";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ubicación";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Proveedor";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Categoría";
            this.Column11.MinimumWidth = 120;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Subcategoría 1";
            this.Column12.MinimumWidth = 120;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 120;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Subcategoría 2";
            this.Column13.MinimumWidth = 120;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 120;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Subcategoría 3";
            this.Column14.MinimumWidth = 120;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 120;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "ID";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = global::SistemaLaObra.Properties.Resources.cargar;
            this.btn_editar.Location = new System.Drawing.Point(785, 228);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(132, 40);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(7, 30);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(115, 15);
            this.lbl_descripcion.TabIndex = 9;
            this.lbl_descripcion.Text = "Nombre de artículo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(128, 27);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(425, 21);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(386, 55);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(167, 21);
            this.txt_precioUnitario.TabIndex = 6;
            this.txt_precioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioUnitario_KeyPress);
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Location = new System.Drawing.Point(310, 58);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(45, 15);
            this.lbl_precioUnitario.TabIndex = 11;
            this.lbl_precioUnitario.Text = "Precio:";
            // 
            // txt_precioCoste
            // 
            this.txt_precioCoste.Enabled = false;
            this.txt_precioCoste.Location = new System.Drawing.Point(642, 55);
            this.txt_precioCoste.Name = "txt_precioCoste";
            this.txt_precioCoste.ReadOnly = true;
            this.txt_precioCoste.Size = new System.Drawing.Size(176, 21);
            this.txt_precioCoste.TabIndex = 7;
            // 
            // lbl_precioCoste
            // 
            this.lbl_precioCoste.AutoSize = true;
            this.lbl_precioCoste.Location = new System.Drawing.Point(576, 58);
            this.lbl_precioCoste.Name = "lbl_precioCoste";
            this.lbl_precioCoste.Size = new System.Drawing.Size(41, 15);
            this.lbl_precioCoste.TabIndex = 13;
            this.lbl_precioCoste.Text = "Costo:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(7, 90);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(40, 15);
            this.lbl_stock.TabIndex = 15;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(566, 90);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(66, 15);
            this.lbl_proveedor.TabIndex = 17;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // nud_stock
            // 
            this.nud_stock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nud_stock.Location = new System.Drawing.Point(91, 85);
            this.nud_stock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_stock.Name = "nud_stock";
            this.nud_stock.Size = new System.Drawing.Size(72, 21);
            this.nud_stock.TabIndex = 8;
            this.nud_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_stock_KeyPress);
            // 
            // gb_actualizacion
            // 
            this.gb_actualizacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_actualizacion.Controls.Add(this.label9);
            this.gb_actualizacion.Controls.Add(this.label1);
            this.gb_actualizacion.Controls.Add(this.txt_proveedor);
            this.gb_actualizacion.Controls.Add(this.nud_stockMinimo);
            this.gb_actualizacion.Controls.Add(this.label8);
            this.gb_actualizacion.Controls.Add(this.cbx_unidadDeMedida);
            this.gb_actualizacion.Controls.Add(this.label7);
            this.gb_actualizacion.Controls.Add(this.cbx_ubicacion);
            this.gb_actualizacion.Controls.Add(this.label6);
            this.gb_actualizacion.Controls.Add(this.label5);
            this.gb_actualizacion.Controls.Add(this.cbx_categoria3);
            this.gb_actualizacion.Controls.Add(this.cbx_categoria2);
            this.gb_actualizacion.Controls.Add(this.cbx_categoria1);
            this.gb_actualizacion.Controls.Add(this.cbx_categoria);
            this.gb_actualizacion.Controls.Add(this.txt_codigoDescripcion);
            this.gb_actualizacion.Controls.Add(this.label4);
            this.gb_actualizacion.Controls.Add(this.cbx_marca);
            this.gb_actualizacion.Controls.Add(this.label3);
            this.gb_actualizacion.Controls.Add(this.btn_cancelar);
            this.gb_actualizacion.Controls.Add(this.lbl_descripcion);
            this.gb_actualizacion.Controls.Add(this.txt_descripcion);
            this.gb_actualizacion.Controls.Add(this.nud_stock);
            this.gb_actualizacion.Controls.Add(this.lbl_precioUnitario);
            this.gb_actualizacion.Controls.Add(this.lbl_proveedor);
            this.gb_actualizacion.Controls.Add(this.txt_precioUnitario);
            this.gb_actualizacion.Controls.Add(this.lbl_stock);
            this.gb_actualizacion.Controls.Add(this.lbl_precioCoste);
            this.gb_actualizacion.Controls.Add(this.txt_precioCoste);
            this.gb_actualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_actualizacion.Location = new System.Drawing.Point(12, 302);
            this.gb_actualizacion.Name = "gb_actualizacion";
            this.gb_actualizacion.Size = new System.Drawing.Size(926, 150);
            this.gb_actualizacion.TabIndex = 19;
            this.gb_actualizacion.TabStop = false;
            this.gb_actualizacion.Text = "ACTUALIZAR ARTICULO";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Enabled = false;
            this.txt_proveedor.Location = new System.Drawing.Point(630, 85);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.ReadOnly = true;
            this.txt_proveedor.Size = new System.Drawing.Size(188, 21);
            this.txt_proveedor.TabIndex = 33;
            // 
            // nud_stockMinimo
            // 
            this.nud_stockMinimo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nud_stockMinimo.Location = new System.Drawing.Point(91, 115);
            this.nud_stockMinimo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_stockMinimo.Name = "nud_stockMinimo";
            this.nud_stockMinimo.Size = new System.Drawing.Size(72, 21);
            this.nud_stockMinimo.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Stock mínimo:";
            // 
            // cbx_unidadDeMedida
            // 
            this.cbx_unidadDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_unidadDeMedida.FormattingEnabled = true;
            this.cbx_unidadDeMedida.Location = new System.Drawing.Point(240, 85);
            this.cbx_unidadDeMedida.Name = "cbx_unidadDeMedida";
            this.cbx_unidadDeMedida.Size = new System.Drawing.Size(125, 23);
            this.cbx_unidadDeMedida.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Medida:";
            // 
            // cbx_ubicacion
            // 
            this.cbx_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ubicacion.FormattingEnabled = true;
            this.cbx_ubicacion.Location = new System.Drawing.Point(447, 85);
            this.cbx_ubicacion.Name = "cbx_ubicacion";
            this.cbx_ubicacion.Size = new System.Drawing.Size(106, 23);
            this.cbx_ubicacion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ubicación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria:";
            // 
            // cbx_categoria3
            // 
            this.cbx_categoria3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria3.FormattingEnabled = true;
            this.cbx_categoria3.Location = new System.Drawing.Point(676, 115);
            this.cbx_categoria3.Name = "cbx_categoria3";
            this.cbx_categoria3.Size = new System.Drawing.Size(140, 23);
            this.cbx_categoria3.TabIndex = 16;
            // 
            // cbx_categoria2
            // 
            this.cbx_categoria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria2.FormattingEnabled = true;
            this.cbx_categoria2.Location = new System.Drawing.Point(526, 115);
            this.cbx_categoria2.Name = "cbx_categoria2";
            this.cbx_categoria2.Size = new System.Drawing.Size(140, 23);
            this.cbx_categoria2.TabIndex = 15;
            this.cbx_categoria2.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria2_SelectedIndexChanged);
            // 
            // cbx_categoria1
            // 
            this.cbx_categoria1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria1.FormattingEnabled = true;
            this.cbx_categoria1.Location = new System.Drawing.Point(376, 115);
            this.cbx_categoria1.Name = "cbx_categoria1";
            this.cbx_categoria1.Size = new System.Drawing.Size(140, 23);
            this.cbx_categoria1.TabIndex = 14;
            this.cbx_categoria1.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria1_SelectedIndexChanged);
            // 
            // cbx_categoria
            // 
            this.cbx_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria.FormattingEnabled = true;
            this.cbx_categoria.Location = new System.Drawing.Point(240, 115);
            this.cbx_categoria.Name = "cbx_categoria";
            this.cbx_categoria.Size = new System.Drawing.Size(126, 23);
            this.cbx_categoria.TabIndex = 13;
            this.cbx_categoria.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria_SelectedIndexChanged);
            // 
            // txt_codigoDescripcion
            // 
            this.txt_codigoDescripcion.Location = new System.Drawing.Point(62, 55);
            this.txt_codigoDescripcion.Name = "txt_codigoDescripcion";
            this.txt_codigoDescripcion.Size = new System.Drawing.Size(226, 21);
            this.txt_codigoDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Codigo:";
            // 
            // cbx_marca
            // 
            this.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Location = new System.Drawing.Point(630, 25);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(268, 23);
            this.cbx_marca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Marca:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(824, 77);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 59);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "$";
            // 
            // IU_ActualizarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 535);
            this.Controls.Add(this.gb_actualizacion);
            this.Controls.Add(this.gb_articulo);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IU_ActualizarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR ARTICULOS";
            this.Load += new System.EventHandler(this.IU_ActualizarArticulo_Load);
            this.gb_articulo.ResumeLayout(false);
            this.gb_articulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).EndInit();
            this.gb_actualizacion.ResumeLayout(false);
            this.gb_actualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMinimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox gb_articulo;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.TextBox txt_precioCoste;
        private System.Windows.Forms.Label lbl_precioCoste;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.NumericUpDown nud_stock;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.GroupBox gb_actualizacion;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_codigoDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_categoria3;
        private System.Windows.Forms.ComboBox cbx_categoria2;
        private System.Windows.Forms.ComboBox cbx_categoria1;
        private System.Windows.Forms.ComboBox cbx_categoria;
        private System.Windows.Forms.ComboBox cbx_ubicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_unidadDeMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_stockMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}