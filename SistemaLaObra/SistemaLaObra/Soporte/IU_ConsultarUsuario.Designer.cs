namespace SistemaLaObra.Soporte
{
    partial class IU_ConsultarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_datosUsuario = new System.Windows.Forms.GroupBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.col_nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombreEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellidoEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipoEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rb_busquedaGeneral = new System.Windows.Forms.RadioButton();
            this.rb_busquedaEspecifica = new System.Windows.Forms.RadioButton();
            this.btn_buscarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.gb_datosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_datosUsuario
            // 
            this.gb_datosUsuario.Controls.Add(this.dgv_usuarios);
            this.gb_datosUsuario.Controls.Add(this.rb_busquedaGeneral);
            this.gb_datosUsuario.Controls.Add(this.rb_busquedaEspecifica);
            this.gb_datosUsuario.Controls.Add(this.btn_buscarDatos);
            this.gb_datosUsuario.Controls.Add(this.label1);
            this.gb_datosUsuario.Controls.Add(this.txt_nombreUsuario);
            this.gb_datosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datosUsuario.Location = new System.Drawing.Point(12, 12);
            this.gb_datosUsuario.Name = "gb_datosUsuario";
            this.gb_datosUsuario.Size = new System.Drawing.Size(714, 330);
            this.gb_datosUsuario.TabIndex = 14;
            this.gb_datosUsuario.TabStop = false;
            this.gb_datosUsuario.Text = "USUARIO";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AllowUserToResizeRows = false;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nombreUsuario,
            this.col_nombreEncargado,
            this.col_apellidoEncargado,
            this.col_tipoEncargado,
            this.btn_seleccion});
            this.dgv_usuarios.Location = new System.Drawing.Point(6, 145);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.Size = new System.Drawing.Size(700, 170);
            this.dgv_usuarios.TabIndex = 16;
            this.dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            // 
            // col_nombreUsuario
            // 
            this.col_nombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nombreUsuario.HeaderText = "Nombre Usuario";
            this.col_nombreUsuario.Name = "col_nombreUsuario";
            this.col_nombreUsuario.ReadOnly = true;
            // 
            // col_nombreEncargado
            // 
            this.col_nombreEncargado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nombreEncargado.HeaderText = "Nombre Encargado";
            this.col_nombreEncargado.Name = "col_nombreEncargado";
            this.col_nombreEncargado.ReadOnly = true;
            // 
            // col_apellidoEncargado
            // 
            this.col_apellidoEncargado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_apellidoEncargado.HeaderText = "Apellido Encargado";
            this.col_apellidoEncargado.Name = "col_apellidoEncargado";
            this.col_apellidoEncargado.ReadOnly = true;
            // 
            // col_tipoEncargado
            // 
            this.col_tipoEncargado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tipoEncargado.HeaderText = "Tipo Encargado";
            this.col_tipoEncargado.Name = "col_tipoEncargado";
            this.col_tipoEncargado.ReadOnly = true;
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_seleccion.DefaultCellStyle = dataGridViewCellStyle1;
            this.btn_seleccion.HeaderText = "Seleccionar";
            this.btn_seleccion.Name = "btn_seleccion";
            this.btn_seleccion.ReadOnly = true;
            this.btn_seleccion.Text = "Seleccionar";
            this.btn_seleccion.UseColumnTextForButtonValue = true;
            // 
            // rb_busquedaGeneral
            // 
            this.rb_busquedaGeneral.AutoSize = true;
            this.rb_busquedaGeneral.Location = new System.Drawing.Point(6, 109);
            this.rb_busquedaGeneral.Name = "rb_busquedaGeneral";
            this.rb_busquedaGeneral.Size = new System.Drawing.Size(100, 19);
            this.rb_busquedaGeneral.TabIndex = 14;
            this.rb_busquedaGeneral.Text = "Mostrar todos";
            this.rb_busquedaGeneral.UseVisualStyleBackColor = true;
            this.rb_busquedaGeneral.CheckedChanged += new System.EventHandler(this.rb_busquedaGeneral_CheckedChanged);
            // 
            // rb_busquedaEspecifica
            // 
            this.rb_busquedaEspecifica.AutoSize = true;
            this.rb_busquedaEspecifica.Checked = true;
            this.rb_busquedaEspecifica.Location = new System.Drawing.Point(6, 33);
            this.rb_busquedaEspecifica.Name = "rb_busquedaEspecifica";
            this.rb_busquedaEspecifica.Size = new System.Drawing.Size(107, 19);
            this.rb_busquedaEspecifica.TabIndex = 13;
            this.rb_busquedaEspecifica.TabStop = true;
            this.rb_busquedaEspecifica.Text = "Buscar usuario";
            this.rb_busquedaEspecifica.UseVisualStyleBackColor = true;
            this.rb_busquedaEspecifica.CheckedChanged += new System.EventHandler(this.rb_busquedaEspecifica_CheckedChanged);
            // 
            // btn_buscarDatos
            // 
            this.btn_buscarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarDatos.Image = global::SistemaLaObra.Properties.Resources.buscar;
            this.btn_buscarDatos.Location = new System.Drawing.Point(287, 61);
            this.btn_buscarDatos.Name = "btn_buscarDatos";
            this.btn_buscarDatos.Size = new System.Drawing.Size(128, 40);
            this.btn_buscarDatos.TabIndex = 12;
            this.btn_buscarDatos.Text = "Buscar";
            this.btn_buscarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscarDatos.UseVisualStyleBackColor = false;
            this.btn_buscarDatos.Click += new System.EventHandler(this.btn_buscarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre usuario:";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(112, 71);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(169, 21);
            this.txt_nombreUsuario.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_aceptar.Location = new System.Drawing.Point(596, 354);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(128, 50);
            this.btn_aceptar.TabIndex = 17;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // IU_ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 416);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.gb_datosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IU_ConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR USUARIO";
            this.gb_datosUsuario.ResumeLayout(false);
            this.gb_datosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_datosUsuario;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.RadioButton rb_busquedaGeneral;
        private System.Windows.Forms.RadioButton rb_busquedaEspecifica;
        private System.Windows.Forms.Button btn_buscarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombreEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellidoEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipoEncargado;
        private System.Windows.Forms.DataGridViewButtonColumn btn_seleccion;
    }
}