namespace SistemaLaObra.Compras.EmitirListadoCompraProveedor
{
    partial class IU_EmitirListadoCompraProveedor2
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
            this.tbc_Proveedores = new System.Windows.Forms.TabControl();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbc_Proveedores
            // 
            this.tbc_Proveedores.Location = new System.Drawing.Point(12, 12);
            this.tbc_Proveedores.Name = "tbc_Proveedores";
            this.tbc_Proveedores.SelectedIndex = 0;
            this.tbc_Proveedores.Size = new System.Drawing.Size(785, 351);
            this.tbc_Proveedores.TabIndex = 0;
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Image = global::SistemaLaObra.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(12, 390);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(140, 50);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // IU_EmitirListadoCompraProveedor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.tbc_Proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IU_EmitirListadoCompraProveedor2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE PROVEEDORES";
            this.Load += new System.EventHandler(this.IU_EmitirListadoCompraProveedor2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Proveedores;
        private System.Windows.Forms.Button btn_volver;
    }
}