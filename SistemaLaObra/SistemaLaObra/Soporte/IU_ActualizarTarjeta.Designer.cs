namespace SistemaLaObra.Soporte
{
    partial class IU_ActualizarTarjeta
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
            this.txt_Tarjeta = new System.Windows.Forms.TextBox();
            this.lbl_CuentaCorriente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Tarjeta = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Tarjeta);
            this.groupBox1.Controls.Add(this.lbl_CuentaCorriente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Tarjeta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 126);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTUALIZAR DATOS TARJETA DE CREDITO";
            // 
            // txt_Tarjeta
            // 
            this.txt_Tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tarjeta.Location = new System.Drawing.Point(154, 89);
            this.txt_Tarjeta.Name = "txt_Tarjeta";
            this.txt_Tarjeta.Size = new System.Drawing.Size(111, 21);
            this.txt_Tarjeta.TabIndex = 57;
            // 
            // lbl_CuentaCorriente
            // 
            this.lbl_CuentaCorriente.AutoSize = true;
            this.lbl_CuentaCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuentaCorriente.Location = new System.Drawing.Point(15, 41);
            this.lbl_CuentaCorriente.Name = "lbl_CuentaCorriente";
            this.lbl_CuentaCorriente.Size = new System.Drawing.Size(116, 15);
            this.lbl_CuentaCorriente.TabIndex = 40;
            this.lbl_CuentaCorriente.Text = "Seleccionar Tarjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Modificar nombre:";
            // 
            // cb_Tarjeta
            // 
            this.cb_Tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tarjeta.FormattingEnabled = true;
            this.cb_Tarjeta.Location = new System.Drawing.Point(154, 38);
            this.cb_Tarjeta.Name = "cb_Tarjeta";
            this.cb_Tarjeta.Size = new System.Drawing.Size(111, 23);
            this.cb_Tarjeta.TabIndex = 43;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Actualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Image = global::SistemaLaObra.Properties.Resources.registrar;
            this.btn_Actualizar.Location = new System.Drawing.Point(307, 145);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(144, 50);
            this.btn_Actualizar.TabIndex = 59;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_Cerrar.Location = new System.Drawing.Point(12, 145);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(142, 50);
            this.btn_Cerrar.TabIndex = 58;
            this.btn_Cerrar.Text = "Cancelar";
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // IU_ActualizarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 201);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "IU_ActualizarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR TARJETA";
            this.Load += new System.EventHandler(this.IU_ActualizarTarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_Tarjeta;
        private System.Windows.Forms.Label lbl_CuentaCorriente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Tarjeta;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}