namespace SistemaLaObra
{
    partial class IU_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_MenuPrincipal));
            this.ms_menuOpciones = new System.Windows.Forms.MenuStrip();
            this.ms_btnInicioSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_inferior = new System.Windows.Forms.Panel();
            this.lbl_tipoDeAcceso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nombreApellidoEncargado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_soporte = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_estadistica = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_logistica = new System.Windows.Forms.Button();
            this.pnl_subMenu = new System.Windows.Forms.Panel();
            this.ms_menuOpciones.SuspendLayout();
            this.pnl_inferior.SuspendLayout();
            this.pnl_opciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menuOpciones
            // 
            this.ms_menuOpciones.BackColor = System.Drawing.SystemColors.Control;
            this.ms_menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_btnInicioSesion,
            this.ms_btnCerrarSesion,
            this.baseDeDatosToolStripMenuItem});
            this.ms_menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.ms_menuOpciones.Name = "ms_menuOpciones";
            this.ms_menuOpciones.Size = new System.Drawing.Size(1008, 24);
            this.ms_menuOpciones.TabIndex = 15;
            this.ms_menuOpciones.Text = "menuStrip1";
            // 
            // ms_btnInicioSesion
            // 
            this.ms_btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_btnInicioSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ms_btnInicioSesion.Name = "ms_btnInicioSesion";
            this.ms_btnInicioSesion.Size = new System.Drawing.Size(98, 20);
            this.ms_btnInicioSesion.Text = "Iniciar sesión";
            this.ms_btnInicioSesion.Click += new System.EventHandler(this.ms_btnInicioSesion_Click);
            // 
            // ms_btnCerrarSesion
            // 
            this.ms_btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ms_btnCerrarSesion.Name = "ms_btnCerrarSesion";
            this.ms_btnCerrarSesion.Size = new System.Drawing.Size(100, 20);
            this.ms_btnCerrarSesion.Text = "Cerrar sesión";
            this.ms_btnCerrarSesion.Visible = false;
            this.ms_btnCerrarSesion.Click += new System.EventHandler(this.ms_btnCerrarSesion_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarScriptToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // generarScriptToolStripMenuItem
            // 
            this.generarScriptToolStripMenuItem.Name = "generarScriptToolStripMenuItem";
            this.generarScriptToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.generarScriptToolStripMenuItem.Text = "Generar Script backup";
            this.generarScriptToolStripMenuItem.Click += new System.EventHandler(this.generarScriptToolStripMenuItem_Click);
            // 
            // pnl_inferior
            // 
            this.pnl_inferior.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_inferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_inferior.Controls.Add(this.lbl_tipoDeAcceso);
            this.pnl_inferior.Controls.Add(this.label3);
            this.pnl_inferior.Controls.Add(this.lbl_usuario);
            this.pnl_inferior.Controls.Add(this.label2);
            this.pnl_inferior.Controls.Add(this.lbl_nombreApellidoEncargado);
            this.pnl_inferior.Controls.Add(this.label1);
            this.pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_inferior.Location = new System.Drawing.Point(0, 703);
            this.pnl_inferior.Name = "pnl_inferior";
            this.pnl_inferior.Size = new System.Drawing.Size(1008, 24);
            this.pnl_inferior.TabIndex = 17;
            this.pnl_inferior.Visible = false;
            // 
            // lbl_tipoDeAcceso
            // 
            this.lbl_tipoDeAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipoDeAcceso.AutoSize = true;
            this.lbl_tipoDeAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDeAcceso.Location = new System.Drawing.Point(636, 2);
            this.lbl_tipoDeAcceso.Name = "lbl_tipoDeAcceso";
            this.lbl_tipoDeAcceso.Size = new System.Drawing.Size(0, 15);
            this.lbl_tipoDeAcceso.TabIndex = 6;
            this.lbl_tipoDeAcceso.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de acceso:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(63, 3);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(57, 15);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuario";
            this.lbl_usuario.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // lbl_nombreApellidoEncargado
            // 
            this.lbl_nombreApellidoEncargado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreApellidoEncargado.AutoSize = true;
            this.lbl_nombreApellidoEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreApellidoEncargado.Location = new System.Drawing.Point(300, 3);
            this.lbl_nombreApellidoEncargado.Name = "lbl_nombreApellidoEncargado";
            this.lbl_nombreApellidoEncargado.Size = new System.Drawing.Size(123, 15);
            this.lbl_nombreApellidoEncargado.TabIndex = 1;
            this.lbl_nombreApellidoEncargado.Text = "Nombre - Apellido";
            this.lbl_nombreApellidoEncargado.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encargado actual:";
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.pnl_opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_opciones.Controls.Add(this.tableLayoutPanel1);
            this.pnl_opciones.Location = new System.Drawing.Point(0, 25);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(200, 678);
            this.pnl_opciones.TabIndex = 19;
            this.pnl_opciones.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_soporte, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_ventas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_estadistica, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_compras, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_logistica, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 667);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btn_soporte
            // 
            this.btn_soporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_soporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.btn_soporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_soporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_soporte.Enabled = false;
            this.btn_soporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_soporte.FlatAppearance.BorderSize = 2;
            this.btn_soporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_soporte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_soporte.ForeColor = System.Drawing.Color.White;
            this.btn_soporte.Image = global::SistemaLaObra.Properties.Resources.soporte1_32;
            this.btn_soporte.Location = new System.Drawing.Point(10, 314);
            this.btn_soporte.Name = "btn_soporte";
            this.btn_soporte.Size = new System.Drawing.Size(162, 50);
            this.btn_soporte.TabIndex = 16;
            this.btn_soporte.Text = "SOPORTE";
            this.btn_soporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_soporte.UseVisualStyleBackColor = false;
            this.btn_soporte.Click += new System.EventHandler(this.btn_soporte_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.Enabled = false;
            this.btn_ventas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ventas.FlatAppearance.BorderSize = 2;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ventas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_ventas.Image = global::SistemaLaObra.Properties.Resources.venta2_32;
            this.btn_ventas.Location = new System.Drawing.Point(10, 30);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(162, 50);
            this.btn_ventas.TabIndex = 15;
            this.btn_ventas.Text = "VENTAS";
            this.btn_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_estadistica
            // 
            this.btn_estadistica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_estadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.btn_estadistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estadistica.Enabled = false;
            this.btn_estadistica.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_estadistica.FlatAppearance.BorderSize = 2;
            this.btn_estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estadistica.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_estadistica.ForeColor = System.Drawing.Color.White;
            this.btn_estadistica.Image = global::SistemaLaObra.Properties.Resources.estadisticas_32;
            this.btn_estadistica.Location = new System.Drawing.Point(10, 243);
            this.btn_estadistica.Name = "btn_estadistica";
            this.btn_estadistica.Size = new System.Drawing.Size(162, 50);
            this.btn_estadistica.TabIndex = 19;
            this.btn_estadistica.Text = "ESTADÍSTICA";
            this.btn_estadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_estadistica.UseVisualStyleBackColor = false;
            this.btn_estadistica.Click += new System.EventHandler(this.btn_estadistica_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.btn_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_compras.Enabled = false;
            this.btn_compras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_compras.FlatAppearance.BorderSize = 2;
            this.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.ForeColor = System.Drawing.Color.White;
            this.btn_compras.Image = global::SistemaLaObra.Properties.Resources.compra3_32;
            this.btn_compras.Location = new System.Drawing.Point(10, 101);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(162, 50);
            this.btn_compras.TabIndex = 18;
            this.btn_compras.Text = "COMPRAS";
            this.btn_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_compras.UseVisualStyleBackColor = false;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_logistica
            // 
            this.btn_logistica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_logistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(150)))), ((int)(((byte)(155)))));
            this.btn_logistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logistica.Enabled = false;
            this.btn_logistica.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logistica.FlatAppearance.BorderSize = 2;
            this.btn_logistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logistica.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_logistica.ForeColor = System.Drawing.Color.White;
            this.btn_logistica.Image = global::SistemaLaObra.Properties.Resources.logistica3_32;
            this.btn_logistica.Location = new System.Drawing.Point(10, 172);
            this.btn_logistica.Name = "btn_logistica";
            this.btn_logistica.Size = new System.Drawing.Size(162, 50);
            this.btn_logistica.TabIndex = 17;
            this.btn_logistica.Text = "LOGÍSTICA";
            this.btn_logistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logistica.UseVisualStyleBackColor = false;
            this.btn_logistica.Click += new System.EventHandler(this.btn_logistica_Click);
            // 
            // pnl_subMenu
            // 
            this.pnl_subMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_subMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_subMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_subMenu.Location = new System.Drawing.Point(200, 25);
            this.pnl_subMenu.Name = "pnl_subMenu";
            this.pnl_subMenu.Size = new System.Drawing.Size(808, 678);
            this.pnl_subMenu.TabIndex = 21;
            this.pnl_subMenu.Visible = false;
            // 
            // IU_MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.pnl_subMenu);
            this.Controls.Add(this.pnl_opciones);
            this.Controls.Add(this.pnl_inferior);
            this.Controls.Add(this.ms_menuOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "IU_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferro System v2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IU_MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.IU_MenuPrincipal_Load);
            this.ms_menuOpciones.ResumeLayout(false);
            this.ms_menuOpciones.PerformLayout();
            this.pnl_inferior.ResumeLayout(false);
            this.pnl_inferior.PerformLayout();
            this.pnl_opciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_soporte;
        public System.Windows.Forms.Button btn_logistica;
        public System.Windows.Forms.Button btn_compras;
        public System.Windows.Forms.Button btn_ventas;
        public System.Windows.Forms.Panel pnl_opciones;
        public System.Windows.Forms.Panel pnl_subMenu;
        public System.Windows.Forms.MenuStrip ms_menuOpciones;
        public System.Windows.Forms.ToolStripMenuItem ms_btnCerrarSesion;
        public System.Windows.Forms.ToolStripMenuItem ms_btnInicioSesion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_nombreApellidoEncargado;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.Label lbl_tipoDeAcceso;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_estadistica;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem generarScriptToolStripMenuItem;
        public System.Windows.Forms.Panel pnl_inferior;
        public System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
    }
}