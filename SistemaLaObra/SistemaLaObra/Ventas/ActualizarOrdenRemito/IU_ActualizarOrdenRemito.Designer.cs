namespace SistemaLaObra.Ventas.ActualizarOrdenRemito
{
    partial class IU_ActualizarOrdenRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ActualizarOrdenRemito));
            this.txt_codigoVenta = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.gbx_datos = new System.Windows.Forms.GroupBox();
            this.pnl_datosEnvio = new System.Windows.Forms.Panel();
            this.dgv_ordenesDeRemito = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.gbx_datos.SuspendLayout();
            this.pnl_datosEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenesDeRemito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigoVenta
            // 
            this.txt_codigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoVenta.Location = new System.Drawing.Point(295, 33);
            this.txt_codigoVenta.Name = "txt_codigoVenta";
            this.txt_codigoVenta.Size = new System.Drawing.Size(146, 26);
            this.txt_codigoVenta.TabIndex = 20;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(83, 41);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(206, 20);
            this.lbl_1.TabIndex = 19;
            this.lbl_1.Text = "Ingrese el número de venta:";
            // 
            // gbx_datos
            // 
            this.gbx_datos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_datos.Controls.Add(this.pnl_datosEnvio);
            this.gbx_datos.Location = new System.Drawing.Point(20, 80);
            this.gbx_datos.Name = "gbx_datos";
            this.gbx_datos.Size = new System.Drawing.Size(752, 398);
            this.gbx_datos.TabIndex = 23;
            this.gbx_datos.TabStop = false;
            this.gbx_datos.Text = "Datos de Envío";
            // 
            // pnl_datosEnvio
            // 
            this.pnl_datosEnvio.AutoScroll = true;
            this.pnl_datosEnvio.Controls.Add(this.dgv_ordenesDeRemito);
            this.pnl_datosEnvio.Controls.Add(this.pictureBox2);
            this.pnl_datosEnvio.Controls.Add(this.pictureBox1);
            this.pnl_datosEnvio.Location = new System.Drawing.Point(7, 20);
            this.pnl_datosEnvio.Name = "pnl_datosEnvio";
            this.pnl_datosEnvio.Size = new System.Drawing.Size(739, 372);
            this.pnl_datosEnvio.TabIndex = 0;
            // 
            // dgv_ordenesDeRemito
            // 
            this.dgv_ordenesDeRemito.AllowUserToAddRows = false;
            this.dgv_ordenesDeRemito.AllowUserToDeleteRows = false;
            this.dgv_ordenesDeRemito.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ordenesDeRemito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ordenesDeRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenesDeRemito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dgv_ordenesDeRemito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ordenesDeRemito.Location = new System.Drawing.Point(3, 3);
            this.dgv_ordenesDeRemito.MultiSelect = false;
            this.dgv_ordenesDeRemito.Name = "dgv_ordenesDeRemito";
            this.dgv_ordenesDeRemito.ReadOnly = true;
            this.dgv_ordenesDeRemito.RowHeadersVisible = false;
            this.dgv_ordenesDeRemito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ordenesDeRemito.Size = new System.Drawing.Size(733, 366);
            this.dgv_ordenesDeRemito.TabIndex = 2;
            this.dgv_ordenesDeRemito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordenesDeRemito_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de remito";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha entrega";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dirección";
            this.Column4.MinimumWidth = 190;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 190;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cliente";
            this.Column5.MinimumWidth = 120;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Responsable";
            this.Column6.MinimumWidth = 120;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Opción";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaLaObra.Properties.Resources.fletes_1;
            this.pictureBox2.Location = new System.Drawing.Point(366, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 366);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.fletes;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 366);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_confirmar.Location = new System.Drawing.Point(632, 24);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(140, 40);
            this.btn_confirmar.TabIndex = 28;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 499);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelar.TabIndex = 26;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_siguiente.Location = new System.Drawing.Point(632, 499);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(140, 50);
            this.btn_siguiente.TabIndex = 27;
            this.btn_siguiente.Text = "Aceptar";
            this.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // IU_ActualizarOrdenRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txt_codigoVenta);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.gbx_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ActualizarOrdenRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MODIFICAR ORDEN DE REMITO";
            this.Load += new System.EventHandler(this.IU_ActualizarOrdenRemito_Load);
            this.gbx_datos.ResumeLayout(false);
            this.pnl_datosEnvio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenesDeRemito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigoVenta;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.GroupBox gbx_datos;
        private System.Windows.Forms.Panel pnl_datosEnvio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView dgv_ordenesDeRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}