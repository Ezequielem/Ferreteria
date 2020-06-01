namespace SistemaLaObra.Soporte.Reportes.InformeMensualVentas
{
    partial class IU_ReporteMensualVentas
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
            this.reporte_mensualVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal = new SistemaLaObra.Soporte.Reportes.DataSetPrincipal();
            this.btn_bottonRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.reporte_mensualVentasTableAdapter = new SistemaLaObra.Soporte.Reportes.DataSetPrincipalTableAdapters.Reporte_mensualVentasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_mensualVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte_mensualVentasBindingSource
            // 
            this.reporte_mensualVentasBindingSource.DataMember = "Reporte_mensualVentas";
            this.reporte_mensualVentasBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_bottonRegistrar
            // 
            this.btn_bottonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bottonRegistrar.Image = global::SistemaLaObra.Properties.Resources.detalle;
            this.btn_bottonRegistrar.Location = new System.Drawing.Point(614, 12);
            this.btn_bottonRegistrar.Name = "btn_bottonRegistrar";
            this.btn_bottonRegistrar.Size = new System.Drawing.Size(115, 50);
            this.btn_bottonRegistrar.TabIndex = 1;
            this.btn_bottonRegistrar.Text = "Generar Informe";
            this.btn_bottonRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bottonRegistrar.UseVisualStyleBackColor = true;
            this.btn_bottonRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(397, 33);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(200, 20);
            this.dateHasta.TabIndex = 6;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(87, 34);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(200, 20);
            this.dateDesde.TabIndex = 5;
            // 
            // reporte_mensualVentasTableAdapter
            // 
            this.reporte_mensualVentasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte_mensualVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaLaObra.Soporte.Reportes.InformeMensualVentas.ReporteMensualVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(958, 621);
            this.reportViewer1.TabIndex = 9;
            // 
            // IU_ReporteMensualVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 718);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.btn_bottonRegistrar);
            this.MaximizeBox = false;
            this.Name = "IU_ReporteMensualVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE MENSUAL DE VENTAS";
            this.Load += new System.EventHandler(this.IU_ReporteMensualVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_mensualVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_bottonRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource reporte_mensualVentasBindingSource;
        private DataSetPrincipalTableAdapters.Reporte_mensualVentasTableAdapter reporte_mensualVentasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}