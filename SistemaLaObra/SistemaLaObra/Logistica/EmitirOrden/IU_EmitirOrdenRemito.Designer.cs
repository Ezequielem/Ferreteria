namespace SistemaLaObra.Logistica
{
    partial class IU_EmitirOrdenRemito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_EmitirOrdenRemito));
            this.btn_salir = new System.Windows.Forms.Button();
            this.gbx_listadoEntrega = new System.Windows.Forms.GroupBox();
            this.dgw_listadoEntrega = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbx_listadoEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listadoEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_salir.Location = new System.Drawing.Point(740, 414);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(140, 50);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Aceptar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gbx_listadoEntrega
            // 
            this.gbx_listadoEntrega.BackColor = System.Drawing.SystemColors.Control;
            this.gbx_listadoEntrega.Controls.Add(this.dgw_listadoEntrega);
            this.gbx_listadoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_listadoEntrega.Location = new System.Drawing.Point(12, 12);
            this.gbx_listadoEntrega.Name = "gbx_listadoEntrega";
            this.gbx_listadoEntrega.Size = new System.Drawing.Size(865, 393);
            this.gbx_listadoEntrega.TabIndex = 1;
            this.gbx_listadoEntrega.TabStop = false;
            this.gbx_listadoEntrega.Text = "LISTA DE ENTREGA";
            // 
            // dgw_listadoEntrega
            // 
            this.dgw_listadoEntrega.AllowUserToAddRows = false;
            this.dgw_listadoEntrega.AllowUserToDeleteRows = false;
            this.dgw_listadoEntrega.AllowUserToResizeColumns = false;
            this.dgw_listadoEntrega.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_listadoEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_listadoEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_listadoEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.fecha,
            this.horaDesde,
            this.horaHasta,
            this.direccion,
            this.estado,
            this.Column6});
            this.dgw_listadoEntrega.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgw_listadoEntrega.EnableHeadersVisualStyles = false;
            this.dgw_listadoEntrega.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgw_listadoEntrega.Location = new System.Drawing.Point(9, 19);
            this.dgw_listadoEntrega.Name = "dgw_listadoEntrega";
            this.dgw_listadoEntrega.ReadOnly = true;
            this.dgw_listadoEntrega.RowHeadersVisible = false;
            this.dgw_listadoEntrega.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgw_listadoEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_listadoEntrega.Size = new System.Drawing.Size(845, 360);
            this.dgw_listadoEntrega.TabIndex = 0;
            this.dgw_listadoEntrega.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccioPedido);
            // 
            // idPedido
            // 
            this.idPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.idPedido.HeaderText = "Orden remito";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            this.idPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 75;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // horaDesde
            // 
            this.horaDesde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaDesde.DefaultCellStyle = dataGridViewCellStyle4;
            this.horaDesde.HeaderText = "Desde";
            this.horaDesde.Name = "horaDesde";
            this.horaDesde.ReadOnly = true;
            this.horaDesde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // horaHasta
            // 
            this.horaHasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaHasta.DefaultCellStyle = dataGridViewCellStyle5;
            this.horaHasta.HeaderText = "Hasta";
            this.horaHasta.Name = "horaHasta";
            this.horaHasta.ReadOnly = true;
            this.horaHasta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.DefaultCellStyle = dataGridViewCellStyle6;
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.DefaultCellStyle = dataGridViewCellStyle7;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column6.HeaderText = "Opción";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Vista previa";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // IU_EmitirOrdenRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(892, 476);
            this.Controls.Add(this.gbx_listadoEntrega);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_EmitirOrdenRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EMITIR ORDEN DE REMITO";
            this.Load += new System.EventHandler(this.IU_EmitirOrdenRemito_Load);
            this.gbx_listadoEntrega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listadoEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox gbx_listadoEntrega;
        public System.Windows.Forms.DataGridView dgw_listadoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}