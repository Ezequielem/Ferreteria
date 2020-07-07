namespace SistemaLaObra.Soporte.UsuariosSistema
{
    partial class IU_ValidacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_ValidacionUsuario));
            this.btn_actualizarDatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_actualizarDatos
            // 
            this.btn_actualizarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_actualizarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarDatos.Image = global::SistemaLaObra.Properties.Resources.aceptarSeleccionar;
            this.btn_actualizarDatos.Location = new System.Drawing.Point(272, 109);
            this.btn_actualizarDatos.Name = "btn_actualizarDatos";
            this.btn_actualizarDatos.Size = new System.Drawing.Size(100, 40);
            this.btn_actualizarDatos.TabIndex = 12;
            this.btn_actualizarDatos.Text = "Aceptar";
            this.btn_actualizarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_actualizarDatos.UseVisualStyleBackColor = false;
            this.btn_actualizarDatos.Click += new System.EventHandler(this.btn_actualizarDatos_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaLaObra.Properties.Resources.cancelar;
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_contraseña, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 67);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la contraseña actual:";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(40, 39);
            this.txt_contraseña.MaxLength = 50;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(280, 22);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.UseSystemPasswordChar = true;
            // 
            // IU_ValidacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_actualizarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_ValidacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VALIDACION DE USUARIO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizarDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña;
    }
}