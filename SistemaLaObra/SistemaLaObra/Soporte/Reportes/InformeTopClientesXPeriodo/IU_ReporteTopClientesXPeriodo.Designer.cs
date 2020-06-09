namespace SistemaLaObra.Soporte.Reportes.InformeTopClientesXPeriodo
{
    partial class IU_ReporteTopClientesXPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ReporteTopClientesXPeriodo));
            this.reporte_ventasTopClientesPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal = new SistemaLaObra.Soporte.Reportes.DataSetPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte_ventasTopClientesPeriodoTableAdapter = new SistemaLaObra.Soporte.Reportes.DataSetPrincipalTableAdapters.Reporte_ventasTopClientesPeriodoTableAdapter();
            this.tableAdapterManager = new SistemaLaObra.Soporte.Reportes.DataSetPrincipalTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_ventasTopClientesPeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte_ventasTopClientesPeriodoBindingSource
            // 
            this.reporte_ventasTopClientesPeriodoBindingSource.DataMember = "Reporte_ventasTopClientesPeriodo";
            this.reporte_ventasTopClientesPeriodoBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte_ventasTopClientesPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaLaObra.Soporte.Reportes.InformeTopClientesXPeriodo.ReporteTopClientesPerio" +
    "do.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(963, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporte_ventasTopClientesPeriodoTableAdapter
            // 
            this.reporte_ventasTopClientesPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SistemaLaObra.Soporte.Reportes.DataSetPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaLaObra.Properties.Resources.detalle;
            this.button1.Location = new System.Drawing.Point(610, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generar Informe";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(388, 26);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(200, 20);
            this.dateHasta.TabIndex = 12;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(87, 27);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(200, 20);
            this.dateDesde.TabIndex = 11;
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
            // IU_ReporteTopClientesXPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 718);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ReporteTopClientesXPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "REPORTE TOP 5 DE CLIENTES";
            this.Load += new System.EventHandler(this.IU_ReporteTopClientesXPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_ventasTopClientesPeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource reporte_ventasTopClientesPeriodoBindingSource;
        private DataSetPrincipalTableAdapters.Reporte_ventasTopClientesPeriodoTableAdapter reporte_ventasTopClientesPeriodoTableAdapter;
        private DataSetPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.Button btn_salir;
    }
}