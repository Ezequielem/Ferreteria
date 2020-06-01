namespace SistemaLaObra.Ventas.Presupuesto
{
    partial class IU_ConsultarPresupuesto
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
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscarPresupuesto = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numeroPresupuesto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_fechaVencimiento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_importeTotal = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_iniciarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_productos.Location = new System.Drawing.Point(9, 65);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(749, 205);
            this.dgv_productos.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Codigo articulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Nombre articulo";
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
            this.Column5.HeaderText = "SubTotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_buscarPresupuesto
            // 
            this.btn_buscarPresupuesto.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscarPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarPresupuesto.Image = global::SistemaLaObra.Properties.Resources.buscar;
            this.btn_buscarPresupuesto.Location = new System.Drawing.Point(612, 13);
            this.btn_buscarPresupuesto.Name = "btn_buscarPresupuesto";
            this.btn_buscarPresupuesto.Size = new System.Drawing.Size(168, 39);
            this.btn_buscarPresupuesto.TabIndex = 23;
            this.btn_buscarPresupuesto.Text = "Buscar presupuesto";
            this.btn_buscarPresupuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscarPresupuesto.UseVisualStyleBackColor = false;
            this.btn_buscarPresupuesto.Click += new System.EventHandler(this.btn_buscarPresupuesto_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(127, 36);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(69, 15);
            this.lbl_fecha.TabIndex = 10;
            this.lbl_fecha.Text = "dd/mm/yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha presupuesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ingrese numero de presupuesto:";
            // 
            // txt_numeroPresupuesto
            // 
            this.txt_numeroPresupuesto.Location = new System.Drawing.Point(200, 22);
            this.txt_numeroPresupuesto.Name = "txt_numeroPresupuesto";
            this.txt_numeroPresupuesto.Size = new System.Drawing.Size(406, 20);
            this.txt_numeroPresupuesto.TabIndex = 26;
            this.txt_numeroPresupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroPresupuesto_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_fechaVencimiento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_importeTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.dgv_productos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 332);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PRESUPUESTOS";
            // 
            // lbl_fechaVencimiento
            // 
            this.lbl_fechaVencimiento.AutoSize = true;
            this.lbl_fechaVencimiento.Location = new System.Drawing.Point(676, 36);
            this.lbl_fechaVencimiento.Name = "lbl_fechaVencimiento";
            this.lbl_fechaVencimiento.Size = new System.Drawing.Size(69, 15);
            this.lbl_fechaVencimiento.TabIndex = 28;
            this.lbl_fechaVencimiento.Text = "dd/mm/yyyy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fecha vencimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(3, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "IMPORTE TOTAL: $";
            // 
            // lbl_importeTotal
            // 
            this.lbl_importeTotal.AutoSize = true;
            this.lbl_importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeTotal.Location = new System.Drawing.Point(272, 285);
            this.lbl_importeTotal.Name = "lbl_importeTotal";
            this.lbl_importeTotal.Size = new System.Drawing.Size(71, 31);
            this.lbl_importeTotal.TabIndex = 25;
            this.lbl_importeTotal.Text = "0.00";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.Control;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_volver.Location = new System.Drawing.Point(12, 399);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(121, 50);
            this.btn_volver.TabIndex = 28;
            this.btn_volver.Text = "Cancelar";
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_iniciarVenta
            // 
            this.btn_iniciarVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_iniciarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarVenta.Image = global::SistemaLaObra.Properties.Resources.siguiente;
            this.btn_iniciarVenta.Location = new System.Drawing.Point(628, 399);
            this.btn_iniciarVenta.Name = "btn_iniciarVenta";
            this.btn_iniciarVenta.Size = new System.Drawing.Size(148, 50);
            this.btn_iniciarVenta.TabIndex = 29;
            this.btn_iniciarVenta.Text = "Iniciar venta";
            this.btn_iniciarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_iniciarVenta.UseVisualStyleBackColor = false;
            this.btn_iniciarVenta.Click += new System.EventHandler(this.btn_iniciarVenta_Click);
            // 
            // IU_ConsultarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(788, 461);
            this.Controls.Add(this.btn_iniciarVenta);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_numeroPresupuesto);
            this.Controls.Add(this.btn_buscarPresupuesto);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IU_ConsultarPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR PRESUPUESTO";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_importeTotal;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_iniciarVenta;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.Label lbl_fechaVencimiento;
        public System.Windows.Forms.TextBox txt_numeroPresupuesto;
        public System.Windows.Forms.Button btn_buscarPresupuesto;
    }
}