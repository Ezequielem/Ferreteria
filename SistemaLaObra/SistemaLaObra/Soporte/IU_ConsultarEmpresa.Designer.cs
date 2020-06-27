namespace SistemaLaObra.Soporte
{
    partial class IU_ConsultarEmpresa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ConsultarEmpresa));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.gb_datosUsuario = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreEmpresa = new System.Windows.Forms.TextBox();
            this.dgv_empresas = new System.Windows.Forms.DataGridView();
            this.col_nombreFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombreRazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_datosUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_modificar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_registrar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_aceptar, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(732, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.908163F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.09184F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.21428F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 392);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Image = global::SistemaLaObra.Properties.Resources.actualizar;
            this.btn_modificar.Location = new System.Drawing.Point(4, 216);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(128, 50);
            this.btn_modificar.TabIndex = 19;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Image = global::SistemaLaObra.Properties.Resources.registrar;
            this.btn_registrar.Location = new System.Drawing.Point(4, 125);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(128, 50);
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::SistemaLaObra.Properties.Resources.empresaGris_64;
            this.pictureBox1.Location = new System.Drawing.Point(68, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_aceptar.Location = new System.Drawing.Point(4, 339);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(128, 50);
            this.btn_aceptar.TabIndex = 17;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // gb_datosUsuario
            // 
            this.gb_datosUsuario.Controls.Add(this.tableLayoutPanel1);
            this.gb_datosUsuario.Controls.Add(this.dgv_empresas);
            this.gb_datosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datosUsuario.Location = new System.Drawing.Point(12, 12);
            this.gb_datosUsuario.Name = "gb_datosUsuario";
            this.gb_datosUsuario.Size = new System.Drawing.Size(714, 392);
            this.gb_datosUsuario.TabIndex = 19;
            this.gb_datosUsuario.TabStop = false;
            this.gb_datosUsuario.Text = "EMPRESA";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_nombreEmpresa, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 40);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre empresa:";
            // 
            // txt_nombreEmpresa
            // 
            this.txt_nombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nombreEmpresa.Location = new System.Drawing.Point(123, 9);
            this.txt_nombreEmpresa.Name = "txt_nombreEmpresa";
            this.txt_nombreEmpresa.Size = new System.Drawing.Size(574, 21);
            this.txt_nombreEmpresa.TabIndex = 1;
            this.txt_nombreEmpresa.TextChanged += new System.EventHandler(this.txt_nombreEmpresa_TextChanged);
            // 
            // dgv_empresas
            // 
            this.dgv_empresas.AllowUserToAddRows = false;
            this.dgv_empresas.AllowUserToDeleteRows = false;
            this.dgv_empresas.AllowUserToResizeRows = false;
            this.dgv_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nombreFantasia,
            this.col_nombreRazon,
            this.col_cuit,
            this.col_fechaInicio,
            this.Id});
            this.dgv_empresas.Location = new System.Drawing.Point(6, 66);
            this.dgv_empresas.MultiSelect = false;
            this.dgv_empresas.Name = "dgv_empresas";
            this.dgv_empresas.ReadOnly = true;
            this.dgv_empresas.RowHeadersVisible = false;
            this.dgv_empresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empresas.Size = new System.Drawing.Size(700, 320);
            this.dgv_empresas.TabIndex = 16;
            // 
            // col_nombreFantasia
            // 
            this.col_nombreFantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nombreFantasia.HeaderText = "Nombre de Fantasia";
            this.col_nombreFantasia.Name = "col_nombreFantasia";
            this.col_nombreFantasia.ReadOnly = true;
            // 
            // col_nombreRazon
            // 
            this.col_nombreRazon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nombreRazon.HeaderText = "Razón Social";
            this.col_nombreRazon.Name = "col_nombreRazon";
            this.col_nombreRazon.ReadOnly = true;
            // 
            // col_cuit
            // 
            this.col_cuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_cuit.HeaderText = "CUIT";
            this.col_cuit.Name = "col_cuit";
            this.col_cuit.ReadOnly = true;
            // 
            // col_fechaInicio
            // 
            this.col_fechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_fechaInicio.HeaderText = "Fecha de inicio";
            this.col_fechaInicio.Name = "col_fechaInicio";
            this.col_fechaInicio.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IU_ConsultarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 414);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gb_datosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ConsultarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONSULTAR EMPRESA";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_datosUsuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.GroupBox gb_datosUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreEmpresa;
        private System.Windows.Forms.DataGridView dgv_empresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombreFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombreRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Timer timer1;
    }
}