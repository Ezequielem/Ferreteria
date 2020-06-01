namespace SistemaLaObra.Ventas.ReporteDeVentas
{
    partial class IU_Calendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptarFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxDate = new System.DateTime(9998, 12, 11, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "\r\n";
            // 
            // btn_aceptarFecha
            // 
            this.btn_aceptarFecha.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_aceptarFecha.Location = new System.Drawing.Point(161, 166);
            this.btn_aceptarFecha.Name = "btn_aceptarFecha";
            this.btn_aceptarFecha.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptarFecha.TabIndex = 2;
            this.btn_aceptarFecha.Text = "Aceptar";
            this.btn_aceptarFecha.UseVisualStyleBackColor = true;
            this.btn_aceptarFecha.Click += new System.EventHandler(this.btn_aceptarFecha_Click);
            // 
            // IU_Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 198);
            this.ControlBox = false;
            this.Controls.Add(this.btn_aceptarFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "IU_Calendario";
            this.Text = "IU_Calendario";
            this.Load += new System.EventHandler(this.IU_Calendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptarFecha;
    }
}