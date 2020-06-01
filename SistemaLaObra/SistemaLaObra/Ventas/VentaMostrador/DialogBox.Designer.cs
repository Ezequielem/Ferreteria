namespace SistemaLaObra
{
    partial class DialogBox
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_tipoTarjeta = new System.Windows.Forms.Label();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.lb_interes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombreTitular = new System.Windows.Forms.TextBox();
            this.cb_tipoTarjeta = new System.Windows.Forms.ComboBox();
            this.tb_interes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_importeFactura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bl_importeFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(12, 95);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(94, 13);
            this.lb_nombre.TabIndex = 0;
            this.lb_nombre.Text = "Nombre de Titular:";
            // 
            // lb_tipoTarjeta
            // 
            this.lb_tipoTarjeta.AutoSize = true;
            this.lb_tipoTarjeta.Location = new System.Drawing.Point(12, 123);
            this.lb_tipoTarjeta.Name = "lb_tipoTarjeta";
            this.lb_tipoTarjeta.Size = new System.Drawing.Size(78, 13);
            this.lb_tipoTarjeta.TabIndex = 1;
            this.lb_tipoTarjeta.Text = "Tipo de tarjeta:";
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(128, 264);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 2;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(209, 264);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // lb_interes
            // 
            this.lb_interes.AutoSize = true;
            this.lb_interes.Location = new System.Drawing.Point(12, 154);
            this.lb_interes.Name = "lb_interes";
            this.lb_interes.Size = new System.Drawing.Size(82, 13);
            this.lb_interes.TabIndex = 4;
            this.lb_interes.Text = "Interés a sumar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // tb_nombreTitular
            // 
            this.tb_nombreTitular.Location = new System.Drawing.Point(128, 92);
            this.tb_nombreTitular.Name = "tb_nombreTitular";
            this.tb_nombreTitular.Size = new System.Drawing.Size(145, 20);
            this.tb_nombreTitular.TabIndex = 6;
            // 
            // cb_tipoTarjeta
            // 
            this.cb_tipoTarjeta.FormattingEnabled = true;
            this.cb_tipoTarjeta.Location = new System.Drawing.Point(128, 120);
            this.cb_tipoTarjeta.Name = "cb_tipoTarjeta";
            this.cb_tipoTarjeta.Size = new System.Drawing.Size(145, 21);
            this.cb_tipoTarjeta.TabIndex = 7;
            // 
            // tb_interes
            // 
            this.tb_interes.Location = new System.Drawing.Point(128, 151);
            this.tb_interes.Name = "tb_interes";
            this.tb_interes.Size = new System.Drawing.Size(30, 20);
            this.tb_interes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datos de la Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Importe de la factura:";
            // 
            // lb_importeFactura
            // 
            this.lb_importeFactura.AutoSize = true;
            this.lb_importeFactura.Location = new System.Drawing.Point(144, 34);
            this.lb_importeFactura.Name = "lb_importeFactura";
            this.lb_importeFactura.Size = new System.Drawing.Size(16, 13);
            this.lb_importeFactura.TabIndex = 11;
            this.lb_importeFactura.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datos de la Tarjeta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resumen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Importe final:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "$";
            // 
            // bl_importeFinal
            // 
            this.bl_importeFinal.AutoSize = true;
            this.bl_importeFinal.Location = new System.Drawing.Point(144, 213);
            this.bl_importeFinal.Name = "bl_importeFinal";
            this.bl_importeFinal.Size = new System.Drawing.Size(16, 13);
            this.bl_importeFinal.TabIndex = 17;
            this.bl_importeFinal.Text = "---";
            // 
            // DialogBox
            // 
            this.ClientSize = new System.Drawing.Size(396, 306);
            this.Controls.Add(this.bl_importeFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_importeFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_interes);
            this.Controls.Add(this.cb_tipoTarjeta);
            this.Controls.Add(this.tb_nombreTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_interes);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.lb_tipoTarjeta);
            this.Controls.Add(this.lb_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogBox";
            this.Text = "Pago con Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_nombre;
        public System.Windows.Forms.Label lb_tipoTarjeta;
        public System.Windows.Forms.Button bt_aceptar;
        public System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Label lb_interes;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_nombreTitular;
        public System.Windows.Forms.ComboBox cb_tipoTarjeta;
        public System.Windows.Forms.TextBox tb_interes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lb_importeFactura;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label bl_importeFinal;
    }
}