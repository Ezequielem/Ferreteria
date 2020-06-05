namespace SistemaLaObra.Ventas.ActualizarNotaDeCredito
{
    partial class IU_ActualizarNotaDeCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ActualizarNotaDeCredito));
            this.gbx_datos = new System.Windows.Forms.GroupBox();
            this.lbl_cuitDni = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_documentoCliente = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.dgv_notasDeCredito = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NotaCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.gbx_datosNota = new System.Windows.Forms.GroupBox();
            this.lbl_saldoRestanteNC = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_saldoNC = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_importeAPagar = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notasDeCredito)).BeginInit();
            this.gbx_datosNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_datos
            // 
            this.gbx_datos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_datos.Controls.Add(this.lbl_cuitDni);
            this.gbx_datos.Controls.Add(this.lbl_cliente);
            this.gbx_datos.Controls.Add(this.btn_buscar);
            this.gbx_datos.Controls.Add(this.lbl_documentoCliente);
            this.gbx_datos.Controls.Add(this.txt_nombreCliente);
            this.gbx_datos.Controls.Add(this.lbl_nombreCliente);
            this.gbx_datos.Controls.Add(this.lbl_2);
            this.gbx_datos.Controls.Add(this.dgv_notasDeCredito);
            this.gbx_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos.Location = new System.Drawing.Point(12, 88);
            this.gbx_datos.Name = "gbx_datos";
            this.gbx_datos.Size = new System.Drawing.Size(752, 278);
            this.gbx_datos.TabIndex = 3;
            this.gbx_datos.TabStop = false;
            this.gbx_datos.Text = "NOTAS DE CREDITOS ASOCIADAS";
            // 
            // lbl_cuitDni
            // 
            this.lbl_cuitDni.AutoSize = true;
            this.lbl_cuitDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuitDni.Location = new System.Drawing.Point(487, 70);
            this.lbl_cuitDni.Name = "lbl_cuitDni";
            this.lbl_cuitDni.Size = new System.Drawing.Size(0, 16);
            this.lbl_cuitDni.TabIndex = 10;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(12, 70);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(0, 16);
            this.lbl_cliente.TabIndex = 9;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::SistemaLaObra.Properties.Resources.buscar;
            this.btn_buscar.Location = new System.Drawing.Point(355, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(110, 40);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_documentoCliente
            // 
            this.lbl_documentoCliente.AutoSize = true;
            this.lbl_documentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documentoCliente.Location = new System.Drawing.Point(542, 70);
            this.lbl_documentoCliente.Name = "lbl_documentoCliente";
            this.lbl_documentoCliente.Size = new System.Drawing.Size(0, 16);
            this.lbl_documentoCliente.TabIndex = 7;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nombreCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nombreCliente.Location = new System.Drawing.Point(181, 27);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(168, 21);
            this.txt_nombreCliente.TabIndex = 3;
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreCliente.Location = new System.Drawing.Point(70, 70);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 16);
            this.lbl_nombreCliente.TabIndex = 6;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(8, 28);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(156, 15);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "Ingrese nombre del cliente:";
            // 
            // dgv_notasDeCredito
            // 
            this.dgv_notasDeCredito.AllowUserToAddRows = false;
            this.dgv_notasDeCredito.AllowUserToDeleteRows = false;
            this.dgv_notasDeCredito.AllowUserToResizeColumns = false;
            this.dgv_notasDeCredito.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_notasDeCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_notasDeCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notasDeCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.NotaCredito,
            this.Saldo,
            this.Fecha,
            this.FechaVencimiento,
            this.Factura});
            this.dgv_notasDeCredito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_notasDeCredito.Location = new System.Drawing.Point(6, 101);
            this.dgv_notasDeCredito.MultiSelect = false;
            this.dgv_notasDeCredito.Name = "dgv_notasDeCredito";
            this.dgv_notasDeCredito.RowHeadersVisible = false;
            this.dgv_notasDeCredito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_notasDeCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_notasDeCredito.Size = new System.Drawing.Size(740, 168);
            this.dgv_notasDeCredito.TabIndex = 5;
            this.dgv_notasDeCredito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_notasDeCredito_CellContentClick);
            this.dgv_notasDeCredito.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_notasDeCredito_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Selección";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NotaCredito
            // 
            this.NotaCredito.HeaderText = "Nota de crédito";
            this.NotaCredito.Name = "NotaCredito";
            this.NotaCredito.ReadOnly = true;
            this.NotaCredito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NotaCredito.Width = 120;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Saldo.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha.Width = 120;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "Vencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FechaVencimiento.Width = 120;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Factura.Width = 127;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(9, 20);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(163, 15);
            this.lbl_1.TabIndex = 8;
            this.lbl_1.Text = "Seleccione el tipo de cliente:";
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_1.Location = new System.Drawing.Point(20, 54);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(117, 19);
            this.rbtn_1.TabIndex = 1;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "Cliente minorista";
            this.rbtn_1.UseVisualStyleBackColor = true;
            this.rbtn_1.CheckedChanged += new System.EventHandler(this.rbtn_1_CheckedChanged);
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_2.Location = new System.Drawing.Point(193, 54);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(119, 19);
            this.rbtn_2.TabIndex = 2;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "Cliente mayorista";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // gbx_datosNota
            // 
            this.gbx_datosNota.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_datosNota.Controls.Add(this.lbl_saldoRestanteNC);
            this.gbx_datosNota.Controls.Add(this.lbl_5);
            this.gbx_datosNota.Controls.Add(this.lbl_saldoNC);
            this.gbx_datosNota.Controls.Add(this.lbl_4);
            this.gbx_datosNota.Controls.Add(this.lbl_importeAPagar);
            this.gbx_datosNota.Controls.Add(this.lbl_3);
            this.gbx_datosNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosNota.Location = new System.Drawing.Point(11, 372);
            this.gbx_datosNota.Name = "gbx_datosNota";
            this.gbx_datosNota.Size = new System.Drawing.Size(752, 105);
            this.gbx_datosNota.TabIndex = 9;
            this.gbx_datosNota.TabStop = false;
            this.gbx_datosNota.Text = "DATOS DE IMPORTES";
            // 
            // lbl_saldoRestanteNC
            // 
            this.lbl_saldoRestanteNC.AutoSize = true;
            this.lbl_saldoRestanteNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldoRestanteNC.Location = new System.Drawing.Point(569, 57);
            this.lbl_saldoRestanteNC.Name = "lbl_saldoRestanteNC";
            this.lbl_saldoRestanteNC.Size = new System.Drawing.Size(0, 25);
            this.lbl_saldoRestanteNC.TabIndex = 5;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(569, 26);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(117, 20);
            this.lbl_5.TabIndex = 4;
            this.lbl_5.Text = "Saldo restante:";
            // 
            // lbl_saldoNC
            // 
            this.lbl_saldoNC.AutoSize = true;
            this.lbl_saldoNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldoNC.Location = new System.Drawing.Point(297, 57);
            this.lbl_saldoNC.Name = "lbl_saldoNC";
            this.lbl_saldoNC.Size = new System.Drawing.Size(0, 25);
            this.lbl_saldoNC.TabIndex = 3;
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(272, 26);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(176, 20);
            this.lbl_4.TabIndex = 2;
            this.lbl_4.Text = "Saldo nota/s de crédito:";
            // 
            // lbl_importeAPagar
            // 
            this.lbl_importeAPagar.AutoSize = true;
            this.lbl_importeAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeAPagar.Location = new System.Drawing.Point(6, 57);
            this.lbl_importeAPagar.Name = "lbl_importeAPagar";
            this.lbl_importeAPagar.Size = new System.Drawing.Size(0, 25);
            this.lbl_importeAPagar.TabIndex = 1;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(6, 26);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(126, 20);
            this.lbl_3.TabIndex = 0;
            this.lbl_3.Text = "Importe a pagar:";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = global::SistemaLaObra.Properties.Resources.actualizar;
            this.btn_actualizar.Location = new System.Drawing.Point(623, 488);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(140, 50);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Modificar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 488);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // IU_ActualizarNotaDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(775, 550);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.gbx_datosNota);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.rbtn_2);
            this.Controls.Add(this.rbtn_1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.gbx_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ActualizarNotaDeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MODIFICAR NOTA DE CREDITO";
            this.Load += new System.EventHandler(this.IU_ActualizarNotaDeCredito_Load);
            this.gbx_datos.ResumeLayout(false);
            this.gbx_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notasDeCredito)).EndInit();
            this.gbx_datosNota.ResumeLayout(false);
            this.gbx_datosNota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbx_datos;
        private System.Windows.Forms.DataGridView dgv_notasDeCredito;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label lbl_2;
        public System.Windows.Forms.RadioButton rbtn_2;
        public System.Windows.Forms.RadioButton rbtn_1;
        public System.Windows.Forms.Label lbl_cuitDni;
        public System.Windows.Forms.Label lbl_nombreCliente;
        public System.Windows.Forms.Label lbl_cliente;
        public System.Windows.Forms.Label lbl_documentoCliente;
        private System.Windows.Forms.GroupBox gbx_datosNota;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Label lbl_saldoRestanteNC;
        private System.Windows.Forms.Label lbl_5;
        public System.Windows.Forms.Label lbl_saldoNC;
        private System.Windows.Forms.Label lbl_4;
        public System.Windows.Forms.Label lbl_importeAPagar;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
    }
}