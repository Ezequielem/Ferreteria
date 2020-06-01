namespace SistemaLaObra.Soporte
{
    partial class IU_ConsultarHistorialSesiones
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.col_fechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fechaHoraCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombreEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellidoEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipoEncargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscarHistorial = new System.Windows.Forms.Button();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv_historial);
            this.groupBox1.Controls.Add(this.btn_buscarHistorial);
            this.groupBox1.Controls.Add(this.txt_nombreUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTAR HISTORIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Historial";
            // 
            // dgv_historial
            // 
            this.dgv_historial.AllowUserToAddRows = false;
            this.dgv_historial.AllowUserToDeleteRows = false;
            this.dgv_historial.AllowUserToResizeRows = false;
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fechaHoraInicio,
            this.col_fechaHoraCierre,
            this.col_nombreEncargado,
            this.col_apellidoEncargado,
            this.col_tipoEncargado});
            this.dgv_historial.Location = new System.Drawing.Point(9, 96);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.ReadOnly = true;
            this.dgv_historial.RowHeadersVisible = false;
            this.dgv_historial.Size = new System.Drawing.Size(757, 231);
            this.dgv_historial.TabIndex = 3;
            // 
            // col_fechaHoraInicio
            // 
            this.col_fechaHoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_fechaHoraInicio.HeaderText = "Fecha - Hora Inicio";
            this.col_fechaHoraInicio.Name = "col_fechaHoraInicio";
            this.col_fechaHoraInicio.ReadOnly = true;
            // 
            // col_fechaHoraCierre
            // 
            this.col_fechaHoraCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_fechaHoraCierre.HeaderText = "Fecha - Hora Cierre";
            this.col_fechaHoraCierre.Name = "col_fechaHoraCierre";
            this.col_fechaHoraCierre.ReadOnly = true;
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
            // btn_buscarHistorial
            // 
            this.btn_buscarHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.btn_buscarHistorial.Image = global::SistemaLaObra.Properties.Resources.buscar;
            this.btn_buscarHistorial.Location = new System.Drawing.Point(393, 21);
            this.btn_buscarHistorial.Name = "btn_buscarHistorial";
            this.btn_buscarHistorial.Size = new System.Drawing.Size(139, 40);
            this.btn_buscarHistorial.TabIndex = 2;
            this.btn_buscarHistorial.Text = "Buscar Historial";
            this.btn_buscarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscarHistorial.UseVisualStyleBackColor = false;
            this.btn_buscarHistorial.Click += new System.EventHandler(this.btn_buscarHistorial_Click);
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(170, 31);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(217, 21);
            this.txt_nombreUsuario.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_salir.Location = new System.Drawing.Point(665, 359);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 50);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Aceptar";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // IU_ConsultarHistorialSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(796, 421);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IU_ConsultarHistorialSesiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR HISTORIAL DE SESIONES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechaHoraCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombreEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellidoEncargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipoEncargado;
        private System.Windows.Forms.Button btn_buscarHistorial;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Button btn_salir;
    }
}