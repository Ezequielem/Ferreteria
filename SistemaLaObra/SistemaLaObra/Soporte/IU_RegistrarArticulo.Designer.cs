namespace SistemaLaObra
{
    partial class IU_RegistrarArticulo
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
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.txt_coste = new System.Windows.Forms.TextBox();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_12 = new System.Windows.Forms.Label();
            this.cbx_proveedor = new System.Windows.Forms.ComboBox();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.nud_stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.txt_codigoDescripcion = new System.Windows.Forms.TextBox();
            this.lbl_9 = new System.Windows.Forms.Label();
            this.cbx_unidadDeMedida = new System.Windows.Forms.ComboBox();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.cbx_marca = new System.Windows.Forms.ComboBox();
            this.lbl_11 = new System.Windows.Forms.Label();
            this.cbx_categoria = new System.Windows.Forms.ComboBox();
            this.cbx_categoria1 = new System.Windows.Forms.ComboBox();
            this.cbx_categoria2 = new System.Windows.Forms.ComboBox();
            this.cbx_categoria3 = new System.Windows.Forms.ComboBox();
            this.cbx_ubicacion = new System.Windows.Forms.ComboBox();
            this.nud_stockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMinimo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(47, 28);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(75, 15);
            this.lbl_2.TabIndex = 8;
            this.lbl_2.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(131, 25);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(450, 21);
            this.txt_descripcion.TabIndex = 1;
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(131, 130);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(130, 21);
            this.txt_precio.TabIndex = 4;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(62, 133);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(45, 15);
            this.lbl_5.TabIndex = 10;
            this.lbl_5.Text = "Precio:";
            // 
            // txt_coste
            // 
            this.txt_coste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coste.Location = new System.Drawing.Point(131, 165);
            this.txt_coste.Name = "txt_coste";
            this.txt_coste.Size = new System.Drawing.Size(130, 21);
            this.txt_coste.TabIndex = 5;
            this.txt_coste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_coste_KeyPress);
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.Location = new System.Drawing.Point(13, 168);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(94, 15);
            this.lbl_6.TabIndex = 12;
            this.lbl_6.Text = "Precio de costo:";
            // 
            // lbl_12
            // 
            this.lbl_12.AutoSize = true;
            this.lbl_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_12.Location = new System.Drawing.Point(56, 343);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Size = new System.Drawing.Size(66, 15);
            this.lbl_12.TabIndex = 14;
            this.lbl_12.Text = "Proveedor:";
            // 
            // cbx_proveedor
            // 
            this.cbx_proveedor.DisplayMember = "codigoProveedor";
            this.cbx_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_proveedor.FormattingEnabled = true;
            this.cbx_proveedor.Location = new System.Drawing.Point(131, 340);
            this.cbx_proveedor.Name = "cbx_proveedor";
            this.cbx_proveedor.Size = new System.Drawing.Size(258, 23);
            this.cbx_proveedor.TabIndex = 14;
            this.cbx_proveedor.ValueMember = "codigoProveedor";
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.Location = new System.Drawing.Point(82, 203);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(40, 15);
            this.lbl_7.TabIndex = 16;
            this.lbl_7.Text = "Stock:";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Image = global::SistemaLaObra.Properties.Resources.registrar;
            this.btn_registrar.Location = new System.Drawing.Point(694, 422);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(140, 50);
            this.btn_registrar.TabIndex = 15;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_salir.Location = new System.Drawing.Point(12, 422);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(140, 50);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(14, 375);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 20;
            // 
            // nud_stock
            // 
            this.nud_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_stock.Location = new System.Drawing.Point(131, 200);
            this.nud_stock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_stock.Name = "nud_stock";
            this.nud_stock.Size = new System.Drawing.Size(100, 21);
            this.nud_stock.TabIndex = 6;
            this.nud_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_stock_KeyPress);
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(7, 98);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(115, 15);
            this.lbl_4.TabIndex = 22;
            this.lbl_4.Text = "Código descripción:";
            // 
            // txt_codigoDescripcion
            // 
            this.txt_codigoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoDescripcion.Location = new System.Drawing.Point(131, 95);
            this.txt_codigoDescripcion.Name = "txt_codigoDescripcion";
            this.txt_codigoDescripcion.Size = new System.Drawing.Size(180, 21);
            this.txt_codigoDescripcion.TabIndex = 3;
            // 
            // lbl_9
            // 
            this.lbl_9.AutoSize = true;
            this.lbl_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_9.Location = new System.Drawing.Point(13, 238);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Size = new System.Drawing.Size(112, 15);
            this.lbl_9.TabIndex = 24;
            this.lbl_9.Text = "Unidad de medida:";
            // 
            // cbx_unidadDeMedida
            // 
            this.cbx_unidadDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_unidadDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_unidadDeMedida.FormattingEnabled = true;
            this.cbx_unidadDeMedida.Location = new System.Drawing.Point(131, 235);
            this.cbx_unidadDeMedida.Name = "cbx_unidadDeMedida";
            this.cbx_unidadDeMedida.Size = new System.Drawing.Size(180, 23);
            this.cbx_unidadDeMedida.TabIndex = 8;
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10.Location = new System.Drawing.Point(57, 273);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(65, 15);
            this.lbl_10.TabIndex = 26;
            this.lbl_10.Text = "Ubicación:";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(77, 63);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(45, 15);
            this.lbl_3.TabIndex = 28;
            this.lbl_3.Text = "Marca:";
            // 
            // cbx_marca
            // 
            this.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_marca.FormattingEnabled = true;
            this.cbx_marca.Location = new System.Drawing.Point(131, 60);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Size = new System.Drawing.Size(180, 23);
            this.cbx_marca.TabIndex = 2;
            // 
            // lbl_11
            // 
            this.lbl_11.AutoSize = true;
            this.lbl_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_11.Location = new System.Drawing.Point(62, 308);
            this.lbl_11.Name = "lbl_11";
            this.lbl_11.Size = new System.Drawing.Size(63, 15);
            this.lbl_11.TabIndex = 30;
            this.lbl_11.Text = "Categoria:";
            // 
            // cbx_categoria
            // 
            this.cbx_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categoria.FormattingEnabled = true;
            this.cbx_categoria.Location = new System.Drawing.Point(131, 305);
            this.cbx_categoria.Name = "cbx_categoria";
            this.cbx_categoria.Size = new System.Drawing.Size(160, 23);
            this.cbx_categoria.TabIndex = 10;
            this.cbx_categoria.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria_SelectedIndexChanged);
            // 
            // cbx_categoria1
            // 
            this.cbx_categoria1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categoria1.FormattingEnabled = true;
            this.cbx_categoria1.Location = new System.Drawing.Point(306, 305);
            this.cbx_categoria1.Name = "cbx_categoria1";
            this.cbx_categoria1.Size = new System.Drawing.Size(160, 23);
            this.cbx_categoria1.TabIndex = 11;
            this.cbx_categoria1.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria1_SelectedIndexChanged);
            // 
            // cbx_categoria2
            // 
            this.cbx_categoria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categoria2.FormattingEnabled = true;
            this.cbx_categoria2.Location = new System.Drawing.Point(481, 305);
            this.cbx_categoria2.Name = "cbx_categoria2";
            this.cbx_categoria2.Size = new System.Drawing.Size(160, 23);
            this.cbx_categoria2.TabIndex = 12;
            this.cbx_categoria2.SelectedIndexChanged += new System.EventHandler(this.cbx_categoria2_SelectedIndexChanged);
            // 
            // cbx_categoria3
            // 
            this.cbx_categoria3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_categoria3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categoria3.FormattingEnabled = true;
            this.cbx_categoria3.Location = new System.Drawing.Point(655, 305);
            this.cbx_categoria3.Name = "cbx_categoria3";
            this.cbx_categoria3.Size = new System.Drawing.Size(160, 23);
            this.cbx_categoria3.TabIndex = 13;
            // 
            // cbx_ubicacion
            // 
            this.cbx_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ubicacion.FormattingEnabled = true;
            this.cbx_ubicacion.Location = new System.Drawing.Point(131, 270);
            this.cbx_ubicacion.Name = "cbx_ubicacion";
            this.cbx_ubicacion.Size = new System.Drawing.Size(160, 23);
            this.cbx_ubicacion.TabIndex = 9;
            // 
            // nud_stockMinimo
            // 
            this.nud_stockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_stockMinimo.Location = new System.Drawing.Point(339, 200);
            this.nud_stockMinimo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_stockMinimo.Name = "nud_stockMinimo";
            this.nud_stockMinimo.Size = new System.Drawing.Size(100, 21);
            this.nud_stockMinimo.TabIndex = 7;
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.Location = new System.Drawing.Point(248, 203);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(85, 15);
            this.lbl_8.TabIndex = 32;
            this.lbl_8.Text = "Stock mínimo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_2);
            this.groupBox1.Controls.Add(this.cbx_categoria3);
            this.groupBox1.Controls.Add(this.cbx_ubicacion);
            this.groupBox1.Controls.Add(this.cbx_categoria2);
            this.groupBox1.Controls.Add(this.lbl_12);
            this.groupBox1.Controls.Add(this.cbx_proveedor);
            this.groupBox1.Controls.Add(this.nud_stockMinimo);
            this.groupBox1.Controls.Add(this.cbx_categoria1);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.cbx_categoria);
            this.groupBox1.Controls.Add(this.lbl_8);
            this.groupBox1.Controls.Add(this.lbl_11);
            this.groupBox1.Controls.Add(this.lbl_3);
            this.groupBox1.Controls.Add(this.cbx_marca);
            this.groupBox1.Controls.Add(this.lbl_4);
            this.groupBox1.Controls.Add(this.lbl_10);
            this.groupBox1.Controls.Add(this.txt_codigoDescripcion);
            this.groupBox1.Controls.Add(this.cbx_unidadDeMedida);
            this.groupBox1.Controls.Add(this.lbl_5);
            this.groupBox1.Controls.Add(this.lbl_9);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.lbl_6);
            this.groupBox1.Controls.Add(this.txt_coste);
            this.groupBox1.Controls.Add(this.lbl_7);
            this.groupBox1.Controls.Add(this.nud_stock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 387);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESE LOS DATOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.if_General_Office_48_2530806;
            this.pictureBox1.Location = new System.Drawing.Point(673, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "$";
            // 
            // IU_RegistrarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(846, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IU_RegistrarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR ARTICULO";
            this.Load += new System.EventHandler(this.IU_RegistrarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stockMinimo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.TextBox txt_coste;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_12;
        private System.Windows.Forms.ComboBox cbx_proveedor;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.NumericUpDown nud_stock;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.TextBox txt_codigoDescripcion;
        private System.Windows.Forms.Label lbl_9;
        private System.Windows.Forms.ComboBox cbx_unidadDeMedida;
        private System.Windows.Forms.Label lbl_10;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.ComboBox cbx_marca;
        private System.Windows.Forms.Label lbl_11;
        private System.Windows.Forms.ComboBox cbx_categoria;
        private System.Windows.Forms.ComboBox cbx_categoria1;
        private System.Windows.Forms.ComboBox cbx_categoria2;
        private System.Windows.Forms.ComboBox cbx_categoria3;
        private System.Windows.Forms.ComboBox cbx_ubicacion;
        private System.Windows.Forms.NumericUpDown nud_stockMinimo;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}