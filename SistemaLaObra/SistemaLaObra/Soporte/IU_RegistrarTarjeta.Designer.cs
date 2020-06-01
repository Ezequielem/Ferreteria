namespace SistemaLaObra.Soporte
{
    partial class IU_RegistrarTarjeta
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
            this.txt_NombreTarjeta = new System.Windows.Forms.TextBox();
            this.lbl_CuentaCorriente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nombreTarjeta = new System.Windows.Forms.ComboBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tipoTarjeta = new System.Windows.Forms.TextBox();
            this.chb_tipoTarjeta = new System.Windows.Forms.CheckBox();
            this.cb_nombreBanco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NombreTarjeta
            // 
            this.txt_NombreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTarjeta.Location = new System.Drawing.Point(160, 28);
            this.txt_NombreTarjeta.Name = "txt_NombreTarjeta";
            this.txt_NombreTarjeta.Size = new System.Drawing.Size(118, 21);
            this.txt_NombreTarjeta.TabIndex = 41;
            // 
            // lbl_CuentaCorriente
            // 
            this.lbl_CuentaCorriente.AutoSize = true;
            this.lbl_CuentaCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuentaCorriente.Location = new System.Drawing.Point(13, 31);
            this.lbl_CuentaCorriente.Name = "lbl_CuentaCorriente";
            this.lbl_CuentaCorriente.Size = new System.Drawing.Size(134, 15);
            this.lbl_CuentaCorriente.TabIndex = 40;
            this.lbl_CuentaCorriente.Text = "Banco/Nombre Tarjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tipo de Tarjeta:";
            // 
            // cb_nombreTarjeta
            // 
            this.cb_nombreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nombreTarjeta.FormattingEnabled = true;
            this.cb_nombreTarjeta.Location = new System.Drawing.Point(160, 70);
            this.cb_nombreTarjeta.Name = "cb_nombreTarjeta";
            this.cb_nombreTarjeta.Size = new System.Drawing.Size(118, 23);
            this.cb_nombreTarjeta.TabIndex = 43;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_Cerrar.Location = new System.Drawing.Point(12, 174);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(118, 50);
            this.btn_Cerrar.TabIndex = 54;
            this.btn_Cerrar.Text = "Cancelar";
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Registrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Image = global::SistemaLaObra.Properties.Resources.registrar;
            this.btn_Registrar.Location = new System.Drawing.Point(323, 174);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(128, 50);
            this.btn_Registrar.TabIndex = 55;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tipoTarjeta);
            this.groupBox1.Controls.Add(this.chb_tipoTarjeta);
            this.groupBox1.Controls.Add(this.cb_nombreBanco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_CuentaCorriente);
            this.groupBox1.Controls.Add(this.txt_NombreTarjeta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_nombreTarjeta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 156);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR DATOS TARJETA DE CREDITO";
            // 
            // txt_tipoTarjeta
            // 
            this.txt_tipoTarjeta.Enabled = false;
            this.txt_tipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoTarjeta.Location = new System.Drawing.Point(160, 116);
            this.txt_tipoTarjeta.Name = "txt_tipoTarjeta";
            this.txt_tipoTarjeta.Size = new System.Drawing.Size(118, 21);
            this.txt_tipoTarjeta.TabIndex = 57;
            // 
            // chb_tipoTarjeta
            // 
            this.chb_tipoTarjeta.AutoSize = true;
            this.chb_tipoTarjeta.Location = new System.Drawing.Point(18, 118);
            this.chb_tipoTarjeta.Name = "chb_tipoTarjeta";
            this.chb_tipoTarjeta.Size = new System.Drawing.Size(129, 19);
            this.chb_tipoTarjeta.TabIndex = 56;
            this.chb_tipoTarjeta.Text = "Agregar tipo tarjeta";
            this.chb_tipoTarjeta.UseVisualStyleBackColor = true;
            this.chb_tipoTarjeta.CheckedChanged += new System.EventHandler(this.chb_tipoTarjeta_CheckedChanged);
            // 
            // cb_nombreBanco
            // 
            this.cb_nombreBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nombreBanco.FormattingEnabled = true;
            this.cb_nombreBanco.Location = new System.Drawing.Point(294, 28);
            this.cb_nombreBanco.Name = "cb_nombreBanco";
            this.cb_nombreBanco.Size = new System.Drawing.Size(133, 23);
            this.cb_nombreBanco.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "*Ver cargadas actualmente:";
            // 
            // IU_RegistrarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IU_RegistrarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR TARJETA";
            this.Load += new System.EventHandler(this.IU_RegistrarTarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txt_NombreTarjeta;
        private System.Windows.Forms.Label lbl_CuentaCorriente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nombreTarjeta;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_nombreBanco;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tipoTarjeta;
        private System.Windows.Forms.CheckBox chb_tipoTarjeta;
    }
}