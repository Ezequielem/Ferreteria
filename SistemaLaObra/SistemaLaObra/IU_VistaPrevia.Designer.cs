namespace SistemaLaObra
{
    partial class IU_VistaPrevia
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_vistaPrevia = new System.Windows.Forms.GroupBox();
            this.pb_vistaPrevia = new System.Windows.Forms.PictureBox();
            this.gbx_vistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(200, 35);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(106, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "TITULO";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(554, 628);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(138, 35);
            this.btn_imprimir.TabIndex = 16;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(12, 628);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(92, 35);
            this.btn_salir.TabIndex = 17;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vista previa";
            // 
            // gbx_vistaPrevia
            // 
            this.gbx_vistaPrevia.Controls.Add(this.pb_vistaPrevia);
            this.gbx_vistaPrevia.Location = new System.Drawing.Point(12, 114);
            this.gbx_vistaPrevia.Name = "gbx_vistaPrevia";
            this.gbx_vistaPrevia.Size = new System.Drawing.Size(677, 498);
            this.gbx_vistaPrevia.TabIndex = 20;
            this.gbx_vistaPrevia.TabStop = false;
            this.gbx_vistaPrevia.Text = "Preimpresión";
            // 
            // pb_vistaPrevia
            // 
            this.pb_vistaPrevia.Location = new System.Drawing.Point(6, 19);
            this.pb_vistaPrevia.Name = "pb_vistaPrevia";
            this.pb_vistaPrevia.Size = new System.Drawing.Size(665, 473);
            this.pb_vistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_vistaPrevia.TabIndex = 1;
            this.pb_vistaPrevia.TabStop = false;
            // 
            // IU_VistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 676);
            this.Controls.Add(this.gbx_vistaPrevia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.lbl_titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IU_VistaPrevia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISTA PREVIA DEL DOCUMENTO";
            this.gbx_vistaPrevia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_vistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox gbx_vistaPrevia;
        private System.Windows.Forms.PictureBox pb_vistaPrevia;
        public System.Windows.Forms.Button btn_imprimir;
    }
}