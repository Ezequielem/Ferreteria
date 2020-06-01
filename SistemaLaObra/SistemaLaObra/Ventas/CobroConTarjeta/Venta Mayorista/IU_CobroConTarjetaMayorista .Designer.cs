namespace SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista
{
    partial class IU_CobroConTarjetaMayorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_CobroConTarjetaMayorista));
            this.cb_Banco = new System.Windows.Forms.ComboBox();
            this.cb_tipoTarjeta = new System.Windows.Forms.ComboBox();
            this.cb_tarjeta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_interes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_importeTotal = new System.Windows.Forms.Label();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_cuotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_importe = new System.Windows.Forms.CheckBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_signo_pesos = new System.Windows.Forms.Label();
            this.lbl_importeFactura = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_otroImporte = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cantidadTarjeta = new System.Windows.Forms.ComboBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.lbl_tarjeta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Banco
            // 
            this.cb_Banco.FormattingEnabled = true;
            this.cb_Banco.Location = new System.Drawing.Point(523, 101);
            this.cb_Banco.Name = "cb_Banco";
            this.cb_Banco.Size = new System.Drawing.Size(109, 23);
            this.cb_Banco.TabIndex = 72;
            this.cb_Banco.SelectedIndexChanged += new System.EventHandler(this.cb_Banco_SelectedIndexChanged);
            // 
            // cb_tipoTarjeta
            // 
            this.cb_tipoTarjeta.FormattingEnabled = true;
            this.cb_tipoTarjeta.Location = new System.Drawing.Point(523, 68);
            this.cb_tipoTarjeta.Name = "cb_tipoTarjeta";
            this.cb_tipoTarjeta.Size = new System.Drawing.Size(109, 23);
            this.cb_tipoTarjeta.TabIndex = 66;
            this.cb_tipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.cb_tipoTarjeta_SelectedIndexChanged);
            // 
            // cb_tarjeta
            // 
            this.cb_tarjeta.FormattingEnabled = true;
            this.cb_tarjeta.Location = new System.Drawing.Point(523, 135);
            this.cb_tarjeta.Name = "cb_tarjeta";
            this.cb_tarjeta.Size = new System.Drawing.Size(109, 23);
            this.cb_tarjeta.TabIndex = 65;
            this.cb_tarjeta.SelectedIndexChanged += new System.EventHandler(this.cb_tarjeta_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Cuotas:";
            // 
            // txt_interes
            // 
            this.txt_interes.Location = new System.Drawing.Point(523, 229);
            this.txt_interes.Name = "txt_interes";
            this.txt_interes.Size = new System.Drawing.Size(46, 21);
            this.txt_interes.TabIndex = 58;
            this.txt_interes.TextChanged += new System.EventHandler(this.txt_interes_TextChanged);
            this.txt_interes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_interes_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(405, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 57;
            this.label12.Text = "Interes %:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 56;
            this.label11.Text = "Tipo de Tarjeta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(405, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tarjeta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "Banco:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(404, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 20);
            this.label18.TabIndex = 81;
            this.label18.Text = "Datos de la Tarjeta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_importeTotal);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_n4);
            this.groupBox1.Controls.Add(this.txt_n3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_n2);
            this.groupBox1.Controls.Add(this.txt_n1);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txt_cuotas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_importe);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.lbl_signo_pesos);
            this.groupBox1.Controls.Add(this.lbl_importeFactura);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cb_Banco);
            this.groupBox1.Controls.Add(this.txt_otroImporte);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txt_interes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.btn_calcular);
            this.groupBox1.Controls.Add(this.cb_tipoTarjeta);
            this.groupBox1.Controls.Add(this.cb_tarjeta);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(4, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 311);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE COBRO TARJETA";
            // 
            // lbl_importeTotal
            // 
            this.lbl_importeTotal.AutoSize = true;
            this.lbl_importeTotal.Enabled = false;
            this.lbl_importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeTotal.Location = new System.Drawing.Point(520, 274);
            this.lbl_importeTotal.Name = "lbl_importeTotal";
            this.lbl_importeTotal.Size = new System.Drawing.Size(19, 15);
            this.lbl_importeTotal.TabIndex = 82;
            this.lbl_importeTotal.Text = "---";
            // 
            // txt_n4
            // 
            this.txt_n4.Enabled = false;
            this.txt_n4.Location = new System.Drawing.Point(717, 167);
            this.txt_n4.MaxLength = 4;
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.Size = new System.Drawing.Size(46, 21);
            this.txt_n4.TabIndex = 77;
            this.txt_n4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n4_KeyPress);
            // 
            // txt_n3
            // 
            this.txt_n3.Enabled = false;
            this.txt_n3.Location = new System.Drawing.Point(651, 167);
            this.txt_n3.MaxLength = 4;
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(46, 21);
            this.txt_n3.TabIndex = 76;
            this.txt_n3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n3_KeyPress);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = global::SistemaLaObra.Properties.Resources.registrar;
            this.btn_aceptar.Location = new System.Drawing.Point(664, 453);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(126, 50);
            this.btn_aceptar.TabIndex = 59;
            this.btn_aceptar.Text = "Registrar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cerrar.Location = new System.Drawing.Point(12, 453);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(134, 50);
            this.btn_cerrar.TabIndex = 71;
            this.btn_cerrar.Text = "Cancelar";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txt_n2
            // 
            this.txt_n2.Enabled = false;
            this.txt_n2.Location = new System.Drawing.Point(586, 167);
            this.txt_n2.MaxLength = 4;
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(46, 21);
            this.txt_n2.TabIndex = 75;
            this.txt_n2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n2_KeyPress);
            // 
            // txt_n1
            // 
            this.txt_n1.Enabled = false;
            this.txt_n1.Location = new System.Drawing.Point(523, 167);
            this.txt_n1.MaxLength = 4;
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(46, 21);
            this.txt_n1.TabIndex = 74;
            this.txt_n1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_n1_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(405, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 15);
            this.label22.TabIndex = 73;
            this.label22.Text = "N° Tarjeta:";
            // 
            // txt_cuotas
            // 
            this.txt_cuotas.Enabled = false;
            this.txt_cuotas.Location = new System.Drawing.Point(523, 200);
            this.txt_cuotas.Name = "txt_cuotas";
            this.txt_cuotas.Size = new System.Drawing.Size(46, 21);
            this.txt_cuotas.TabIndex = 66;
            this.txt_cuotas.TextChanged += new System.EventHandler(this.txt_cuotas_TextChanged);
            this.txt_cuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuotas_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datos del Titular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Importe a cobrar:";
            // 
            // cb_importe
            // 
            this.cb_importe.AutoSize = true;
            this.cb_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_importe.Location = new System.Drawing.Point(11, 107);
            this.cb_importe.Name = "cb_importe";
            this.cb_importe.Size = new System.Drawing.Size(124, 17);
            this.cb_importe.TabIndex = 49;
            this.cb_importe.Text = "Imgresar otro importe";
            this.cb_importe.UseVisualStyleBackColor = true;
            this.cb_importe.CheckedChanged += new System.EventHandler(this.cb_importe_CheckedChanged_1);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Enabled = false;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(8, 71);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(113, 15);
            this.lbl.TabIndex = 40;
            this.lbl.Text = "Importe de Factura:";
            // 
            // lbl_signo_pesos
            // 
            this.lbl_signo_pesos.AutoSize = true;
            this.lbl_signo_pesos.Enabled = false;
            this.lbl_signo_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signo_pesos.Location = new System.Drawing.Point(139, 71);
            this.lbl_signo_pesos.Name = "lbl_signo_pesos";
            this.lbl_signo_pesos.Size = new System.Drawing.Size(14, 15);
            this.lbl_signo_pesos.TabIndex = 42;
            this.lbl_signo_pesos.Text = "$";
            // 
            // lbl_importeFactura
            // 
            this.lbl_importeFactura.AutoSize = true;
            this.lbl_importeFactura.Enabled = false;
            this.lbl_importeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importeFactura.Location = new System.Drawing.Point(159, 71);
            this.lbl_importeFactura.Name = "lbl_importeFactura";
            this.lbl_importeFactura.Size = new System.Drawing.Size(22, 15);
            this.lbl_importeFactura.TabIndex = 41;
            this.lbl_importeFactura.Text = "---";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Ingrese otro Importe:";
            // 
            // txt_otroImporte
            // 
            this.txt_otroImporte.Enabled = false;
            this.txt_otroImporte.Location = new System.Drawing.Point(135, 140);
            this.txt_otroImporte.Name = "txt_otroImporte";
            this.txt_otroImporte.Size = new System.Drawing.Size(69, 21);
            this.txt_otroImporte.TabIndex = 48;
            this.txt_otroImporte.TextChanged += new System.EventHandler(this.txt_otroImporte_TextChanged);
            this.txt_otroImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_otroImporte_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(135, 240);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(160, 21);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 274);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(135, 271);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(160, 21);
            this.txt_apellido.TabIndex = 4;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Enabled = false;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_calcular.Image")));
            this.btn_calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calcular.Location = new System.Drawing.Point(609, 268);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(109, 29);
            this.btn_calcular.TabIndex = 46;
            this.btn_calcular.Text = "Calcular Importe";
            this.btn_calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(405, 274);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Importe Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Con cuantas tarjetas desea abonar?";
            // 
            // cb_cantidadTarjeta
            // 
            this.cb_cantidadTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_cantidadTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cantidadTarjeta.FormattingEnabled = true;
            this.cb_cantidadTarjeta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_cantidadTarjeta.Location = new System.Drawing.Point(15, 51);
            this.cb_cantidadTarjeta.Name = "cb_cantidadTarjeta";
            this.cb_cantidadTarjeta.Size = new System.Drawing.Size(109, 26);
            this.cb_cantidadTarjeta.TabIndex = 82;
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Image = global::SistemaLaObra.Properties.Resources.cargar;
            this.btn_cargar.Location = new System.Drawing.Point(146, 43);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(97, 40);
            this.btn_cargar.TabIndex = 84;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // lbl_tarjeta
            // 
            this.lbl_tarjeta.AutoSize = true;
            this.lbl_tarjeta.Enabled = false;
            this.lbl_tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tarjeta.ForeColor = System.Drawing.Color.Red;
            this.lbl_tarjeta.Location = new System.Drawing.Point(12, 90);
            this.lbl_tarjeta.Name = "lbl_tarjeta";
            this.lbl_tarjeta.Size = new System.Drawing.Size(136, 18);
            this.lbl_tarjeta.TabIndex = 83;
            this.lbl_tarjeta.Text = "Importe de Factura:";
            this.lbl_tarjeta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 70);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // IU_CobroConTarjetaMayorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 515);
            this.Controls.Add(this.lbl_tarjeta);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.cb_cantidadTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "IU_CobroConTarjetaMayorista";
            this.Text = "REGISTRAR COBRO CON TARJETA";
            this.Load += new System.EventHandler(this.IU_CobroConTarjetaMayorista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cerrar;
        public System.Windows.Forms.ComboBox cb_tipoTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_cuotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox cb_importe;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label lbl_signo_pesos;
        public System.Windows.Forms.Label lbl_importeFactura;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txt_otroImporte;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txt_n4;
        public System.Windows.Forms.TextBox txt_n3;
        public System.Windows.Forms.TextBox txt_n2;
        public System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_cantidadTarjeta;
        private System.Windows.Forms.Button btn_cargar;
        public System.Windows.Forms.Label lbl_importeTotal;
        public System.Windows.Forms.ComboBox cb_Banco;
        public System.Windows.Forms.ComboBox cb_tarjeta;
        public System.Windows.Forms.TextBox txt_interes;
        private System.Windows.Forms.Label lbl_tarjeta;
    }
}