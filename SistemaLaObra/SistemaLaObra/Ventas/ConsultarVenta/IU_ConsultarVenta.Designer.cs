namespace SistemaLaObra.Ventas.ConsultarVenta
{
    partial class IU_ConsultarVenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_listadoVentas = new System.Windows.Forms.DataGridView();
            this.dt_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscarPeriodoVenta = new System.Windows.Forms.Button();
            this.dt_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_buscarVenta = new System.Windows.Forms.Button();
            this.txt_nroVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_listadoVentas);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTADO DE VENTAS";
            // 
            // dgv_listadoVentas
            // 
            this.dgv_listadoVentas.AllowUserToAddRows = false;
            this.dgv_listadoVentas.AllowUserToDeleteRows = false;
            this.dgv_listadoVentas.AllowUserToResizeRows = false;
            this.dgv_listadoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_listadoVentas.Location = new System.Drawing.Point(6, 19);
            this.dgv_listadoVentas.Name = "dgv_listadoVentas";
            this.dgv_listadoVentas.ReadOnly = true;
            this.dgv_listadoVentas.RowHeadersVisible = false;
            this.dgv_listadoVentas.Size = new System.Drawing.Size(703, 314);
            this.dgv_listadoVentas.TabIndex = 0;
            this.dgv_listadoVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listadoVentas_CellContentClick);
            // 
            // dt_fechaDesde
            // 
            this.dt_fechaDesde.Location = new System.Drawing.Point(64, 22);
            this.dt_fechaDesde.Name = "dt_fechaDesde";
            this.dt_fechaDesde.Size = new System.Drawing.Size(212, 20);
            this.dt_fechaDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESDE:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_buscarPeriodoVenta);
            this.groupBox2.Controls.Add(this.dt_fechaHasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dt_fechaDesde);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERIODO DE VENTAS";
            // 
            // btn_buscarPeriodoVenta
            // 
            this.btn_buscarPeriodoVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscarPeriodoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarPeriodoVenta.Location = new System.Drawing.Point(301, 37);
            this.btn_buscarPeriodoVenta.Name = "btn_buscarPeriodoVenta";
            this.btn_buscarPeriodoVenta.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarPeriodoVenta.TabIndex = 5;
            this.btn_buscarPeriodoVenta.Text = "BUSCAR";
            this.btn_buscarPeriodoVenta.UseVisualStyleBackColor = false;
            this.btn_buscarPeriodoVenta.Click += new System.EventHandler(this.btn_buscarPeriodoVenta_Click);
            // 
            // dt_fechaHasta
            // 
            this.dt_fechaHasta.Location = new System.Drawing.Point(64, 54);
            this.dt_fechaHasta.Name = "dt_fechaHasta";
            this.dt_fechaHasta.Size = new System.Drawing.Size(212, 20);
            this.dt_fechaHasta.TabIndex = 4;
            this.dt_fechaHasta.Value = new System.DateTime(2018, 7, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASTA:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_buscarVenta);
            this.groupBox3.Controls.Add(this.txt_nroVenta);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(421, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 92);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VENTA ESPECIFICA";
            // 
            // btn_buscarVenta
            // 
            this.btn_buscarVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarVenta.Location = new System.Drawing.Point(195, 37);
            this.btn_buscarVenta.Name = "btn_buscarVenta";
            this.btn_buscarVenta.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarVenta.TabIndex = 6;
            this.btn_buscarVenta.Text = "BUSCAR";
            this.btn_buscarVenta.UseVisualStyleBackColor = false;
            this.btn_buscarVenta.Click += new System.EventHandler(this.btn_buscarVenta_Click);
            // 
            // txt_nroVenta
            // 
            this.txt_nroVenta.Location = new System.Drawing.Point(9, 57);
            this.txt_nroVenta.Name = "txt_nroVenta";
            this.txt_nroVenta.Size = new System.Drawing.Size(144, 20);
            this.txt_nroVenta.TabIndex = 1;
            this.txt_nroVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nroVenta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "INGRESAR NRO DE VENTA";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nro de Venta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Fecha - Hora";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Importe total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Envio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Cliente";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Vendedor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "Ver detalle";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "";
            // 
            // IU_ConsultarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(739, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IU_ConsultarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR VENTA";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_fechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_buscarPeriodoVenta;
        private System.Windows.Forms.DateTimePicker dt_fechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_buscarVenta;
        private System.Windows.Forms.TextBox txt_nroVenta;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgv_listadoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}