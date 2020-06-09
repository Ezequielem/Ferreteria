namespace SistemaLaObra.Soporte.Reportes.Informe_MensualCliente
{
    partial class IU_ReporteMensualClientes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ReporteMensualClientes));
            this.reporte_mensualClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal = new SistemaLaObra.Soporte.Reportes.DataSetPrincipal();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.reporte_mensualClientesTableAdapter = new SistemaLaObra.Soporte.Reportes.DataSetPrincipalTableAdapters.Reporte_mensualClientesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_mensualClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte_mensualClientesBindingSource
            // 
            this.reporte_mensualClientesBindingSource.DataMember = "Reporte_mensualClientes";
            this.reporte_mensualClientesBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaLaObra.Properties.Resources.detalle;
            this.button1.Location = new System.Drawing.Point(610, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar Informe";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(392, 31);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(200, 20);
            this.dateHasta.TabIndex = 7;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(91, 32);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(200, 20);
            this.dateDesde.TabIndex = 6;
            // 
            // reporte_mensualClientesTableAdapter
            // 
            this.reporte_mensualClientesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte_mensualClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaLaObra.Soporte.Reportes.InformeMensualCliente.ReporteMensualClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(959, 549);
            this.reportViewer1.TabIndex = 11;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_salir.Location = new System.Drawing.Point(831, 656);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(140, 50);
            this.btn_salir.TabIndex = 22;
            this.btn_salir.Text = "Aceptar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // IU_ReporteMensualClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 718);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ReporteMensualClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REPORTE MENSUAL DE CLIENTES";
            this.Load += new System.EventHandler(this.IU_ReporteMensualClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_mensualClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource reporte_mensualClientesBindingSource;
        private DataSetPrincipalTableAdapters.Reporte_mensualClientesTableAdapter reporte_mensualClientesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_salir;
    }
}