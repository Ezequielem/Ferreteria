namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    partial class IU_RegistrarOrden_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_RegistrarOrden_2));
            this.gbx_datosViajes = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_datosViajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_datosViajes
            // 
            this.gbx_datosViajes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_datosViajes.Controls.Add(this.tabControl1);
            this.gbx_datosViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosViajes.Location = new System.Drawing.Point(13, 30);
            this.gbx_datosViajes.Name = "gbx_datosViajes";
            this.gbx_datosViajes.Size = new System.Drawing.Size(759, 453);
            this.gbx_datosViajes.TabIndex = 0;
            this.gbx_datosViajes.TabStop = false;
            this.gbx_datosViajes.Text = "Datos de viajes";
            // 
            // tabControl1
            // 
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Image = global::SistemaLaObra.Properties.Resources.siguiente;
            this.btn_siguiente.Location = new System.Drawing.Point(632, 499);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(140, 50);
            this.btn_siguiente.TabIndex = 18;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.BackColor = System.Drawing.SystemColors.Control;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Image = global::SistemaLaObra.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(456, 499);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(140, 50);
            this.btn_volver.TabIndex = 19;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
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
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // IU_RegistrarOrden_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.gbx_datosViajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_RegistrarOrden_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INGRESAR FECHA Y HORA";
            this.Load += new System.EventHandler(this.IU_RegistrarOrden_2_Load);
            this.gbx_datosViajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_datosViajes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_cancelar;
    }
}