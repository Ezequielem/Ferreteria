namespace SistemaLaObra.Ventas.ReporteDeVentas
{
    partial class IU_ReporteDeVentas
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.txt_fechaInicio = new System.Windows.Forms.TextBox();
            this.txt_fechaFin = new System.Windows.Forms.TextBox();
            this.gbx_fecha = new System.Windows.Forms.GroupBox();
            this.rbtn_hoy = new System.Windows.Forms.RadioButton();
            this.rbtn_fecha = new System.Windows.Forms.RadioButton();
            this.rbtn_entrefechas = new System.Windows.Forms.RadioButton();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.gbx_seleccion = new System.Windows.Forms.GroupBox();
            this.lbl_fechaElegida = new System.Windows.Forms.Label();
            this.gbx_fecha.SuspendLayout();
            this.gbx_seleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(184, 20);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(161, 20);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Reporte de Ventas";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(15, 39);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(117, 13);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Ingrese fecha de inicio:";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(260, 39);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(104, 13);
            this.lbl_3.TabIndex = 3;
            this.lbl_3.Text = "Ingrese fecha de fin:";
            // 
            // txt_fechaInicio
            // 
            this.txt_fechaInicio.Location = new System.Drawing.Point(15, 59);
            this.txt_fechaInicio.Name = "txt_fechaInicio";
            this.txt_fechaInicio.Size = new System.Drawing.Size(183, 20);
            this.txt_fechaInicio.TabIndex = 4;
            this.txt_fechaInicio.Enter += new System.EventHandler(this.txt_fechaInicio_Enter);
            // 
            // txt_fechaFin
            // 
            this.txt_fechaFin.Location = new System.Drawing.Point(260, 59);
            this.txt_fechaFin.Name = "txt_fechaFin";
            this.txt_fechaFin.Size = new System.Drawing.Size(183, 20);
            this.txt_fechaFin.TabIndex = 5;
            this.txt_fechaFin.Enter += new System.EventHandler(this.txt_fechaFin_Enter);
            // 
            // gbx_fecha
            // 
            this.gbx_fecha.Controls.Add(this.lbl_2);
            this.gbx_fecha.Controls.Add(this.txt_fechaFin);
            this.gbx_fecha.Controls.Add(this.lbl_3);
            this.gbx_fecha.Controls.Add(this.txt_fechaInicio);
            this.gbx_fecha.Location = new System.Drawing.Point(12, 173);
            this.gbx_fecha.Name = "gbx_fecha";
            this.gbx_fecha.Size = new System.Drawing.Size(490, 109);
            this.gbx_fecha.TabIndex = 6;
            this.gbx_fecha.TabStop = false;
            this.gbx_fecha.Text = "Condiciones de reporte";
            // 
            // rbtn_hoy
            // 
            this.rbtn_hoy.AutoSize = true;
            this.rbtn_hoy.Location = new System.Drawing.Point(13, 30);
            this.rbtn_hoy.Name = "rbtn_hoy";
            this.rbtn_hoy.Size = new System.Drawing.Size(134, 17);
            this.rbtn_hoy.TabIndex = 7;
            this.rbtn_hoy.TabStop = true;
            this.rbtn_hoy.Text = "Reporte del día de hoy";
            this.rbtn_hoy.UseVisualStyleBackColor = true;
            this.rbtn_hoy.Enter += new System.EventHandler(this.rbtn_hoy_Enter);
            // 
            // rbtn_fecha
            // 
            this.rbtn_fecha.AutoSize = true;
            this.rbtn_fecha.Location = new System.Drawing.Point(13, 60);
            this.rbtn_fecha.Name = "rbtn_fecha";
            this.rbtn_fecha.Size = new System.Drawing.Size(164, 17);
            this.rbtn_fecha.TabIndex = 8;
            this.rbtn_fecha.TabStop = true;
            this.rbtn_fecha.Text = "Seleccionar fecha del reporte";
            this.rbtn_fecha.UseVisualStyleBackColor = true;
            this.rbtn_fecha.CheckedChanged += new System.EventHandler(this.rbtn_fecha_CheckedChanged);
            this.rbtn_fecha.Enter += new System.EventHandler(this.rbtn_fecha_Enter);
            // 
            // rbtn_entrefechas
            // 
            this.rbtn_entrefechas.AutoSize = true;
            this.rbtn_entrefechas.Location = new System.Drawing.Point(13, 90);
            this.rbtn_entrefechas.Name = "rbtn_entrefechas";
            this.rbtn_entrefechas.Size = new System.Drawing.Size(175, 17);
            this.rbtn_entrefechas.TabIndex = 9;
            this.rbtn_entrefechas.TabStop = true;
            this.rbtn_entrefechas.Text = "Seleccionar fecha de inicio y fin";
            this.rbtn_entrefechas.UseVisualStyleBackColor = true;
            this.rbtn_entrefechas.Enter += new System.EventHandler(this.rbtn_entrefechas_Enter);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(426, 288);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(75, 23);
            this.btn_reporte.TabIndex = 10;
            this.btn_reporte.Text = "Ver Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(301, 288);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 11;
            this.btn_volver.Text = "Salir";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // gbx_seleccion
            // 
            this.gbx_seleccion.Controls.Add(this.lbl_fechaElegida);
            this.gbx_seleccion.Controls.Add(this.rbtn_hoy);
            this.gbx_seleccion.Controls.Add(this.rbtn_fecha);
            this.gbx_seleccion.Controls.Add(this.rbtn_entrefechas);
            this.gbx_seleccion.Location = new System.Drawing.Point(12, 43);
            this.gbx_seleccion.Name = "gbx_seleccion";
            this.gbx_seleccion.Size = new System.Drawing.Size(489, 124);
            this.gbx_seleccion.TabIndex = 12;
            this.gbx_seleccion.TabStop = false;
            this.gbx_seleccion.Text = "Seleccione el tipo de reporte";
            // 
            // lbl_fechaElegida
            // 
            this.lbl_fechaElegida.AutoSize = true;
            this.lbl_fechaElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaElegida.ForeColor = System.Drawing.Color.Blue;
            this.lbl_fechaElegida.Location = new System.Drawing.Point(226, 60);
            this.lbl_fechaElegida.Name = "lbl_fechaElegida";
            this.lbl_fechaElegida.Size = new System.Drawing.Size(0, 16);
            this.lbl_fechaElegida.TabIndex = 10;
            // 
            // IU_ReporteDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 325);
            this.Controls.Add(this.gbx_seleccion);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.gbx_fecha);
            this.Controls.Add(this.lbl_1);
            this.Name = "IU_ReporteDeVentas";
            this.Text = "IU_ReporteDeVentas";
            this.Load += new System.EventHandler(this.IU_ReporteDeVentas_Load);
            this.gbx_fecha.ResumeLayout(false);
            this.gbx_fecha.PerformLayout();
            this.gbx_seleccion.ResumeLayout(false);
            this.gbx_seleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.TextBox txt_fechaInicio;
        private System.Windows.Forms.TextBox txt_fechaFin;
        private System.Windows.Forms.GroupBox gbx_fecha;
        private System.Windows.Forms.RadioButton rbtn_hoy;
        private System.Windows.Forms.RadioButton rbtn_fecha;
        private System.Windows.Forms.RadioButton rbtn_entrefechas;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.GroupBox gbx_seleccion;
        private System.Windows.Forms.Label lbl_fechaElegida;
    }
}