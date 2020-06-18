namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    partial class IU_RegistrarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_RegistrarOrden));
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_cantidadEnvios = new System.Windows.Forms.TextBox();
            this.gbx_datos = new System.Windows.Forms.GroupBox();
            this.pnl_datosEnvio = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_importeParcial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigoVenta = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.gbx_datos.SuspendLayout();
            this.pnl_datosEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(16, 54);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(206, 20);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Ingrese el número de venta:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(398, 54);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(148, 20);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "Cantidad de envíos:";
            // 
            // txt_cantidadEnvios
            // 
            this.txt_cantidadEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadEnvios.Location = new System.Drawing.Point(551, 46);
            this.txt_cantidadEnvios.Name = "txt_cantidadEnvios";
            this.txt_cantidadEnvios.Size = new System.Drawing.Size(75, 26);
            this.txt_cantidadEnvios.TabIndex = 2;
            this.txt_cantidadEnvios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadEnvios_KeyPress);
            // 
            // gbx_datos
            // 
            this.gbx_datos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_datos.Controls.Add(this.pnl_datosEnvio);
            this.gbx_datos.Location = new System.Drawing.Point(20, 93);
            this.gbx_datos.Name = "gbx_datos";
            this.gbx_datos.Size = new System.Drawing.Size(752, 398);
            this.gbx_datos.TabIndex = 4;
            this.gbx_datos.TabStop = false;
            this.gbx_datos.Text = "Datos de Envío";
            // 
            // pnl_datosEnvio
            // 
            this.pnl_datosEnvio.AutoScroll = true;
            this.pnl_datosEnvio.Controls.Add(this.pictureBox2);
            this.pnl_datosEnvio.Controls.Add(this.pictureBox1);
            this.pnl_datosEnvio.Location = new System.Drawing.Point(7, 20);
            this.pnl_datosEnvio.Name = "pnl_datosEnvio";
            this.pnl_datosEnvio.Size = new System.Drawing.Size(739, 372);
            this.pnl_datosEnvio.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaLaObra.Properties.Resources.fletes_1;
            this.pictureBox2.Location = new System.Drawing.Point(366, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 366);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.fletes;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 366);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_siguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Image = global::SistemaLaObra.Properties.Resources.siguiente;
            this.btn_siguiente.Location = new System.Drawing.Point(632, 505);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(140, 50);
            this.btn_siguiente.TabIndex = 17;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 505);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_importeParcial
            // 
            this.lbl_importeParcial.AutoSize = true;
            this.lbl_importeParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeParcial.Location = new System.Drawing.Point(197, 41);
            this.lbl_importeParcial.Name = "lbl_importeParcial";
            this.lbl_importeParcial.Size = new System.Drawing.Size(93, 33);
            this.lbl_importeParcial.TabIndex = 8;
            this.lbl_importeParcial.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Importe parcial:";
            // 
            // txt_codigoVenta
            // 
            this.txt_codigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoVenta.Location = new System.Drawing.Point(246, 46);
            this.txt_codigoVenta.Name = "txt_codigoVenta";
            this.txt_codigoVenta.Size = new System.Drawing.Size(146, 26);
            this.txt_codigoVenta.TabIndex = 1;
            this.txt_codigoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoVenta_KeyPress);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_confirmar.Location = new System.Drawing.Point(632, 37);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(140, 40);
            this.btn_confirmar.TabIndex = 18;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // IU_RegistrarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.txt_codigoVenta);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_importeParcial);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.txt_cantidadEnvios);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.gbx_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_RegistrarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INGRESAR DATOS";
            this.Load += new System.EventHandler(this.IU_RegistrarOrden_Load);
            this.gbx_datos.ResumeLayout(false);
            this.pnl_datosEnvio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_cantidadEnvios;
        private System.Windows.Forms.GroupBox gbx_datos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_importeParcial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigoVenta;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pnl_datosEnvio;
        private System.Windows.Forms.Label lbl_2;
        public System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}