namespace SistemaLaObra.Ventas.RegistrarOrdenDeRemito
{
    partial class IU_DatosDialogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_DatosDialogo));
            this.gbx_datos = new System.Windows.Forms.GroupBox();
            this.gbx_distancia = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_distancia = new System.Windows.Forms.TextBox();
            this.lbl_dist = new System.Windows.Forms.Label();
            this.rbtn_mapa = new System.Windows.Forms.RadioButton();
            this.rbtn_manual = new System.Windows.Forms.RadioButton();
            this.btn_VerMapa = new System.Windows.Forms.Button();
            this.lbl_Distancia = new System.Windows.Forms.Label();
            this.cbx_localidad = new System.Windows.Forms.ComboBox();
            this.cbx_departamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numeroTelefono = new System.Windows.Forms.TextBox();
            this.lbl_13 = new System.Windows.Forms.Label();
            this.cbx_tipoTelefono = new System.Windows.Forms.ComboBox();
            this.lbl_12 = new System.Windows.Forms.Label();
            this.lbl_11 = new System.Windows.Forms.Label();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.txt_barrio = new System.Windows.Forms.TextBox();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.cbx_provincia = new System.Windows.Forms.ComboBox();
            this.lbl_9 = new System.Windows.Forms.Label();
            this.txt_codigoPostal = new System.Windows.Forms.TextBox();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_cargarDatos = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.gbx_datos.SuspendLayout();
            this.gbx_distancia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_datos
            // 
            this.gbx_datos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbx_datos.Controls.Add(this.gbx_distancia);
            this.gbx_datos.Controls.Add(this.cbx_localidad);
            this.gbx_datos.Controls.Add(this.cbx_departamento);
            this.gbx_datos.Controls.Add(this.label3);
            this.gbx_datos.Controls.Add(this.label2);
            this.gbx_datos.Controls.Add(this.txt_numeroTelefono);
            this.gbx_datos.Controls.Add(this.lbl_13);
            this.gbx_datos.Controls.Add(this.cbx_tipoTelefono);
            this.gbx_datos.Controls.Add(this.lbl_12);
            this.gbx_datos.Controls.Add(this.lbl_11);
            this.gbx_datos.Controls.Add(this.txt_observacion);
            this.gbx_datos.Controls.Add(this.txt_barrio);
            this.gbx_datos.Controls.Add(this.lbl_10);
            this.gbx_datos.Controls.Add(this.cbx_provincia);
            this.gbx_datos.Controls.Add(this.lbl_9);
            this.gbx_datos.Controls.Add(this.txt_codigoPostal);
            this.gbx_datos.Controls.Add(this.lbl_7);
            this.gbx_datos.Controls.Add(this.txt_numero);
            this.gbx_datos.Controls.Add(this.txt_calle);
            this.gbx_datos.Controls.Add(this.lbl_6);
            this.gbx_datos.Controls.Add(this.lbl_5);
            this.gbx_datos.Controls.Add(this.txt_nombreCliente);
            this.gbx_datos.Controls.Add(this.lbl_3);
            this.gbx_datos.Location = new System.Drawing.Point(8, 12);
            this.gbx_datos.Name = "gbx_datos";
            this.gbx_datos.Size = new System.Drawing.Size(768, 488);
            this.gbx_datos.TabIndex = 5;
            this.gbx_datos.TabStop = false;
            this.gbx_datos.Text = "Datos de Envío";
            // 
            // gbx_distancia
            // 
            this.gbx_distancia.Controls.Add(this.mapa);
            this.gbx_distancia.Controls.Add(this.label1);
            this.gbx_distancia.Controls.Add(this.txt_distancia);
            this.gbx_distancia.Controls.Add(this.lbl_dist);
            this.gbx_distancia.Controls.Add(this.rbtn_mapa);
            this.gbx_distancia.Controls.Add(this.rbtn_manual);
            this.gbx_distancia.Controls.Add(this.btn_VerMapa);
            this.gbx_distancia.Controls.Add(this.lbl_Distancia);
            this.gbx_distancia.Location = new System.Drawing.Point(14, 91);
            this.gbx_distancia.Name = "gbx_distancia";
            this.gbx_distancia.Size = new System.Drawing.Size(395, 384);
            this.gbx_distancia.TabIndex = 30;
            this.gbx_distancia.TabStop = false;
            this.gbx_distancia.Text = "Distancia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Km";
            // 
            // txt_distancia
            // 
            this.txt_distancia.Location = new System.Drawing.Point(257, 16);
            this.txt_distancia.Name = "txt_distancia";
            this.txt_distancia.Size = new System.Drawing.Size(104, 20);
            this.txt_distancia.TabIndex = 12;
            this.txt_distancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_distancia_KeyPress);
            // 
            // lbl_dist
            // 
            this.lbl_dist.AutoSize = true;
            this.lbl_dist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dist.Location = new System.Drawing.Point(184, 20);
            this.lbl_dist.Name = "lbl_dist";
            this.lbl_dist.Size = new System.Drawing.Size(67, 16);
            this.lbl_dist.TabIndex = 32;
            this.lbl_dist.Text = "Distancia:";
            // 
            // rbtn_mapa
            // 
            this.rbtn_mapa.AutoSize = true;
            this.rbtn_mapa.Location = new System.Drawing.Point(10, 45);
            this.rbtn_mapa.Name = "rbtn_mapa";
            this.rbtn_mapa.Size = new System.Drawing.Size(113, 17);
            this.rbtn_mapa.TabIndex = 13;
            this.rbtn_mapa.Text = "Calcular con mapa";
            this.rbtn_mapa.UseVisualStyleBackColor = true;
            // 
            // rbtn_manual
            // 
            this.rbtn_manual.AutoSize = true;
            this.rbtn_manual.Checked = true;
            this.rbtn_manual.Location = new System.Drawing.Point(10, 20);
            this.rbtn_manual.Name = "rbtn_manual";
            this.rbtn_manual.Size = new System.Drawing.Size(97, 17);
            this.rbtn_manual.TabIndex = 11;
            this.rbtn_manual.TabStop = true;
            this.rbtn_manual.Text = "Ingreso manual";
            this.rbtn_manual.UseVisualStyleBackColor = true;
            this.rbtn_manual.CheckedChanged += new System.EventHandler(this.rbtn_manual_CheckedChanged);
            // 
            // btn_VerMapa
            // 
            this.btn_VerMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_VerMapa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_VerMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerMapa.Image = global::SistemaLaObra.Properties.Resources.calculadora;
            this.btn_VerMapa.Location = new System.Drawing.Point(7, 338);
            this.btn_VerMapa.Name = "btn_VerMapa";
            this.btn_VerMapa.Size = new System.Drawing.Size(200, 40);
            this.btn_VerMapa.TabIndex = 14;
            this.btn_VerMapa.Text = "Calcular Distancia";
            this.btn_VerMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_VerMapa.UseVisualStyleBackColor = false;
            this.btn_VerMapa.Click += new System.EventHandler(this.btn_VerMapa_Click);
            // 
            // lbl_Distancia
            // 
            this.lbl_Distancia.AutoSize = true;
            this.lbl_Distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Distancia.Location = new System.Drawing.Point(222, 348);
            this.lbl_Distancia.Name = "lbl_Distancia";
            this.lbl_Distancia.Size = new System.Drawing.Size(0, 20);
            this.lbl_Distancia.TabIndex = 28;
            // 
            // cbx_localidad
            // 
            this.cbx_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_localidad.FormattingEnabled = true;
            this.cbx_localidad.Location = new System.Drawing.Point(530, 181);
            this.cbx_localidad.Name = "cbx_localidad";
            this.cbx_localidad.Size = new System.Drawing.Size(220, 21);
            this.cbx_localidad.TabIndex = 7;
            // 
            // cbx_departamento
            // 
            this.cbx_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_departamento.FormattingEnabled = true;
            this.cbx_departamento.Location = new System.Drawing.Point(530, 151);
            this.cbx_departamento.Name = "cbx_departamento";
            this.cbx_departamento.Size = new System.Drawing.Size(220, 21);
            this.cbx_departamento.TabIndex = 6;
            this.cbx_departamento.SelectedIndexChanged += new System.EventHandler(this.cbx_departamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Departamento:";
            // 
            // txt_numeroTelefono
            // 
            this.txt_numeroTelefono.Location = new System.Drawing.Point(530, 241);
            this.txt_numeroTelefono.Name = "txt_numeroTelefono";
            this.txt_numeroTelefono.Size = new System.Drawing.Size(186, 20);
            this.txt_numeroTelefono.TabIndex = 9;
            this.txt_numeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroTelefono_KeyPress);
            // 
            // lbl_13
            // 
            this.lbl_13.AutoSize = true;
            this.lbl_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_13.Location = new System.Drawing.Point(415, 245);
            this.lbl_13.Name = "lbl_13";
            this.lbl_13.Size = new System.Drawing.Size(59, 16);
            this.lbl_13.TabIndex = 20;
            this.lbl_13.Text = "Número:";
            // 
            // cbx_tipoTelefono
            // 
            this.cbx_tipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipoTelefono.FormattingEnabled = true;
            this.cbx_tipoTelefono.Location = new System.Drawing.Point(530, 211);
            this.cbx_tipoTelefono.Name = "cbx_tipoTelefono";
            this.cbx_tipoTelefono.Size = new System.Drawing.Size(127, 21);
            this.cbx_tipoTelefono.TabIndex = 8;
            // 
            // lbl_12
            // 
            this.lbl_12.AutoSize = true;
            this.lbl_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_12.Location = new System.Drawing.Point(415, 215);
            this.lbl_12.Name = "lbl_12";
            this.lbl_12.Size = new System.Drawing.Size(109, 16);
            this.lbl_12.TabIndex = 18;
            this.lbl_12.Text = "Tipo de télefono:";
            // 
            // lbl_11
            // 
            this.lbl_11.AutoSize = true;
            this.lbl_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_11.Location = new System.Drawing.Point(415, 275);
            this.lbl_11.Name = "lbl_11";
            this.lbl_11.Size = new System.Drawing.Size(88, 16);
            this.lbl_11.TabIndex = 17;
            this.lbl_11.Text = "Observación:";
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(418, 294);
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacion.Size = new System.Drawing.Size(332, 181);
            this.txt_observacion.TabIndex = 10;
            // 
            // txt_barrio
            // 
            this.txt_barrio.Location = new System.Drawing.Point(468, 91);
            this.txt_barrio.Name = "txt_barrio";
            this.txt_barrio.Size = new System.Drawing.Size(282, 20);
            this.txt_barrio.TabIndex = 4;
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10.Location = new System.Drawing.Point(415, 95);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(47, 16);
            this.lbl_10.TabIndex = 14;
            this.lbl_10.Text = "Barrio:";
            // 
            // cbx_provincia
            // 
            this.cbx_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_provincia.FormattingEnabled = true;
            this.cbx_provincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbx_provincia.Location = new System.Drawing.Point(530, 121);
            this.cbx_provincia.Name = "cbx_provincia";
            this.cbx_provincia.Size = new System.Drawing.Size(220, 21);
            this.cbx_provincia.TabIndex = 5;
            this.cbx_provincia.SelectedIndexChanged += new System.EventHandler(this.cbx_provincia_SelectedIndexChanged);
            // 
            // lbl_9
            // 
            this.lbl_9.AutoSize = true;
            this.lbl_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_9.Location = new System.Drawing.Point(415, 125);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Size = new System.Drawing.Size(67, 16);
            this.lbl_9.TabIndex = 12;
            this.lbl_9.Text = "Provincia:";
            // 
            // txt_codigoPostal
            // 
            this.txt_codigoPostal.Location = new System.Drawing.Point(656, 31);
            this.txt_codigoPostal.Name = "txt_codigoPostal";
            this.txt_codigoPostal.Size = new System.Drawing.Size(94, 20);
            this.txt_codigoPostal.TabIndex = 1;
            this.txt_codigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoPostal_KeyPress);
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.Location = new System.Drawing.Point(555, 35);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(95, 16);
            this.lbl_7.TabIndex = 8;
            this.lbl_7.Text = "Código postal:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(668, 61);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(82, 20);
            this.txt_numero.TabIndex = 3;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(66, 61);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(475, 20);
            this.txt_calle.TabIndex = 2;
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.Location = new System.Drawing.Point(603, 65);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(59, 16);
            this.lbl_6.TabIndex = 5;
            this.lbl_6.Text = "Número:";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(18, 65);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(42, 16);
            this.lbl_5.TabIndex = 4;
            this.lbl_5.Text = "Calle:";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(140, 31);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(401, 20);
            this.txt_nombreCliente.TabIndex = 0;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(13, 35);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(124, 16);
            this.lbl_3.TabIndex = 1;
            this.lbl_3.Text = "Nombre del cliente:";
            // 
            // btn_cargarDatos
            // 
            this.btn_cargarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cargarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarDatos.Image = global::SistemaLaObra.Properties.Resources.cargar;
            this.btn_cargarDatos.Location = new System.Drawing.Point(612, 510);
            this.btn_cargarDatos.Name = "btn_cargarDatos";
            this.btn_cargarDatos.Size = new System.Drawing.Size(160, 50);
            this.btn_cargarDatos.TabIndex = 15;
            this.btn_cargarDatos.Text = "Cargar Datos";
            this.btn_cargarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cargarDatos.UseVisualStyleBackColor = false;
            this.btn_cargarDatos.Click += new System.EventHandler(this.btn_cargarDatos_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 510);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemory = 5;
            this.mapa.Location = new System.Drawing.Point(6, 68);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(383, 264);
            this.mapa.TabIndex = 34;
            this.mapa.Zoom = 0D;
            // 
            // IU_DatosDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cargarDatos);
            this.Controls.Add(this.gbx_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_DatosDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CARGAR DATOS DE ENVIO";
            this.Load += new System.EventHandler(this.IU_DatosDialogo_Load);
            this.gbx_datos.ResumeLayout(false);
            this.gbx_datos.PerformLayout();
            this.gbx_distancia.ResumeLayout(false);
            this.gbx_distancia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_datos;
        private System.Windows.Forms.Label lbl_Distancia;
        private System.Windows.Forms.ComboBox cbx_localidad;
        private System.Windows.Forms.ComboBox cbx_departamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numeroTelefono;
        private System.Windows.Forms.Label lbl_13;
        private System.Windows.Forms.ComboBox cbx_tipoTelefono;
        private System.Windows.Forms.Label lbl_12;
        private System.Windows.Forms.Label lbl_11;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.TextBox txt_barrio;
        private System.Windows.Forms.Label lbl_10;
        private System.Windows.Forms.ComboBox cbx_provincia;
        private System.Windows.Forms.Label lbl_9;
        private System.Windows.Forms.TextBox txt_codigoPostal;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Button btn_VerMapa;
        private System.Windows.Forms.Button btn_cargarDatos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gbx_distancia;
        private System.Windows.Forms.TextBox txt_distancia;
        private System.Windows.Forms.Label lbl_dist;
        private System.Windows.Forms.RadioButton rbtn_mapa;
        private System.Windows.Forms.RadioButton rbtn_manual;
        private System.Windows.Forms.Label label1;
        private GMap.NET.WindowsForms.GMapControl mapa;
    }
}