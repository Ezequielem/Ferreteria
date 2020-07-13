namespace SistemaLaObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ActualizarArticulo));
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_categoria3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_categoria2 = new System.Windows.Forms.ComboBox();
            this.cbx_categoria1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_categoria = new System.Windows.Forms.ComboBox();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.txt_codigoDescripcion = new System.Windows.Forms.TextBox();
            this.cbx_ubicacion = new System.Windows.Forms.ComboBox();
            this.cbx_unidadDeMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_stockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_marca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).BeginInit();
            this.gb_actualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_salir.Location = new System.Drawing.Point(12, 499);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(140, 50);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = global::SistemaLaObra.Properties.Resources.actualizar;
            this.btn_actualizar.Location = new System.Drawing.Point(602, 499);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(140, 50);
            this.btn_actualizar.TabIndex = 18;
            this.btn_actualizar.Text = "Modificar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(3, 7);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(115, 15);
            this.lbl_descripcion.TabIndex = 9;
            this.lbl_descripcion.Text = "Nombre de artículo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_descripcion.Location = new System.Drawing.Point(144, 4);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(419, 21);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_precioUnitario.Location = new System.Drawing.Point(144, 62);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(167, 21);
            this.txt_precioUnitario.TabIndex = 6;
            this.txt_precioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioUnitario_KeyPress);
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Location = new System.Drawing.Point(3, 65);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(58, 15);
            this.lbl_precioUnitario.TabIndex = 11;
            this.lbl_precioUnitario.Text = "Precio:  $";
            // 
            // txt_precioCoste
            // 
            this.txt_precioCoste.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_precioCoste.Enabled = false;
            this.txt_precioCoste.Location = new System.Drawing.Point(144, 120);
            this.txt_precioCoste.Name = "txt_precioCoste";
            this.txt_precioCoste.ReadOnly = true;
            this.txt_precioCoste.Size = new System.Drawing.Size(188, 21);
            this.txt_precioCoste.TabIndex = 7;
            this.txt_precioCoste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioCoste_KeyPress);
            // 
            // lbl_precioCoste
            // 
            this.lbl_precioCoste.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_precioCoste.AutoSize = true;
            this.lbl_precioCoste.Location = new System.Drawing.Point(3, 123);
            this.lbl_precioCoste.Name = "lbl_precioCoste";
            this.lbl_precioCoste.Size = new System.Drawing.Size(54, 15);
            this.lbl_precioCoste.TabIndex = 13;
            this.lbl_precioCoste.Text = "Costo:  $";
            // 
            // lbl_stock
            // 
            this.lbl_stock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(3, 152);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(40, 15);
            this.lbl_stock.TabIndex = 15;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(3, 268);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(66, 15);
            this.lbl_proveedor.TabIndex = 17;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // nud_stock
            // 
            this.nud_stock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_stock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nud_stock.Location = new System.Drawing.Point(144, 149);
            this.nud_stock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_stock.Name = "nud_stock";
            this.nud_stock.Size = new System.Drawing.Size(96, 21);
            this.nud_stock.TabIndex = 8;
            this.nud_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_stock_KeyPress);
            // 
            // gb_actualizacion
            // 
            this.gb_actualizacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_actualizacion.Controls.Add(this.pictureBox1);
            this.gb_actualizacion.Controls.Add(this.tableLayoutPanel1);
            this.gb_actualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_actualizacion.Location = new System.Drawing.Point(12, 12);
            this.gb_actualizacion.Name = "gb_actualizacion";
            this.gb_actualizacion.Size = new System.Drawing.Size(730, 458);
            this.gb_actualizacion.TabIndex = 19;
            this.gb_actualizacion.TabStop = false;
            this.gb_actualizacion.Text = "ACTUALIZAR ARTICULO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.articuloGris_128;
            this.pictureBox1.Location = new System.Drawing.Point(590, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_descripcion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_categoria3, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbx_categoria2, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txt_descripcion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_categoria1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_categoria, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txt_proveedor, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_codigoDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_ubicacion, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbx_unidadDeMedida, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.nud_stockMinimo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_proveedor, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_precioUnitario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_precioUnitario, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbx_marca, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_precioCoste, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_precioCoste, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_stock, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.nud_stock, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 412);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // cbx_categoria3
            // 
            this.cbx_categoria3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_categoria3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria3.FormattingEnabled = true;
            this.cbx_categoria3.Location = new System.Drawing.Point(144, 383);
            this.cbx_categoria3.Name = "cbx_categoria3";
            this.cbx_categoria3.Size = new System.Drawing.Size(188, 23);
            this.cbx_categoria3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria:";
            // 
            // cbx_categoria2
            // 
            this.cbx_categoria2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_categoria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria2.FormattingEnabled = true;
            this.cbx_categoria2.Location = new System.Drawing.Point(144, 352);
            this.cbx_categoria2.Name = "cbx_categoria2";
            this.cbx_categoria2.Size = new System.Drawing.Size(188, 23);
            this.cbx_categoria2.TabIndex = 15;
            this.cbx_categoria2.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria2_SelectedIndexChanged);
            // 
            // cbx_categoria1
            // 
            this.cbx_categoria1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_categoria1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria1.FormattingEnabled = true;
            this.cbx_categoria1.Location = new System.Drawing.Point(144, 323);
            this.cbx_categoria1.Name = "cbx_categoria1";
            this.cbx_categoria1.Size = new System.Drawing.Size(188, 23);
            this.cbx_categoria1.TabIndex = 14;
            this.cbx_categoria1.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Codigo:";
            // 
            // cbx_categoria
            // 
            this.cbx_categoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria.FormattingEnabled = true;
            this.cbx_categoria.Location = new System.Drawing.Point(144, 294);
            this.cbx_categoria.Name = "cbx_categoria";
            this.cbx_categoria.Size = new System.Drawing.Size(188, 23);
            this.cbx_categoria.TabIndex = 13;
            this.cbx_categoria.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria_SelectedIndexChanged);
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_proveedor.Enabled = false;
            this.txt_proveedor.Location = new System.Drawing.Point(144, 265);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.ReadOnly = true;
            this.txt_proveedor.Size = new System.Drawing.Size(188, 21);
            this.txt_proveedor.TabIndex = 33;
            // 
            // txt_codigoDescripcion
            // 
            this.txt_codigoDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_codigoDescripcion.Location = new System.Drawing.Point(144, 33);
            this.txt_codigoDescripcion.Name = "txt_codigoDescripcion";
            this.txt_codigoDescripcion.Size = new System.Drawing.Size(226, 21);
            this.txt_codigoDescripcion.TabIndex = 5;
            // 
            // cbx_ubicacion
            // 
            this.cbx_ubicacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ubicacion.FormattingEnabled = true;
            this.cbx_ubicacion.Location = new System.Drawing.Point(144, 236);
            this.cbx_ubicacion.Name = "cbx_ubicacion";
            this.cbx_ubicacion.Size = new System.Drawing.Size(188, 23);
            this.cbx_ubicacion.TabIndex = 10;
            // 
            // cbx_unidadDeMedida
            // 
            this.cbx_unidadDeMedida.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_unidadDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_unidadDeMedida.FormattingEnabled = true;
            this.cbx_unidadDeMedida.Location = new System.Drawing.Point(144, 207);
            this.cbx_unidadDeMedida.Name = "cbx_unidadDeMedida";
            this.cbx_unidadDeMedida.Size = new System.Drawing.Size(188, 23);
            this.cbx_unidadDeMedida.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ubicación:";
            // 
            // nud_stockMinimo
            // 
            this.nud_stockMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_stockMinimo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nud_stockMinimo.Location = new System.Drawing.Point(144, 178);
            this.nud_stockMinimo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_stockMinimo.Name = "nud_stockMinimo";
            this.nud_stockMinimo.Size = new System.Drawing.Size(96, 21);
            this.nud_stockMinimo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Medida:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Stock mínimo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Marca:";
            // 
            // cbx_marca
            // 
            this.cbx_marca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Location = new System.Drawing.Point(144, 91);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(268, 23);
            this.cbx_marca.TabIndex = 4;
            // 
            // IU_ActualizarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 561);
            this.Controls.Add(this.gb_actualizacion);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ActualizarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MODIFICAR ARTICULOS";
            this.Load += new System.EventHandler(this.IU_ActualizarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).EndInit();
            this.gb_actualizacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMinimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.TextBox txt_precioCoste;
        private System.Windows.Forms.Label lbl_precioCoste;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.NumericUpDown nud_stock;
        private System.Windows.Forms.GroupBox gb_actualizacion;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}