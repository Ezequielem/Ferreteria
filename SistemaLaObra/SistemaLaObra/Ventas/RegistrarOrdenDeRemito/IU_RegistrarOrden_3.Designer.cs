namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    partial class IU_RegistrarOrden_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IU_RegistrarOrden_3));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ArticulosEnVenta = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ArticulosEnVenta)).BeginInit();
            this.SuspendLayout();
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
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.BackColor = System.Drawing.SystemColors.Control;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Image = global::SistemaLaObra.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(461, 505);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(140, 50);
            this.btn_volver.TabIndex = 22;
            this.btn_volver.Text = "Volver";
            this.btn_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
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
            this.btn_siguiente.TabIndex = 21;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 235);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgv_ArticulosEnVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 218);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de artículos a enviar";
            // 
            // dgv_ArticulosEnVenta
            // 
            this.dgv_ArticulosEnVenta.AllowUserToAddRows = false;
            this.dgv_ArticulosEnVenta.AllowUserToDeleteRows = false;
            this.dgv_ArticulosEnVenta.AllowUserToResizeColumns = false;
            this.dgv_ArticulosEnVenta.AllowUserToResizeRows = false;
            this.dgv_ArticulosEnVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ArticulosEnVenta.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_ArticulosEnVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ArticulosEnVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ArticulosEnVenta.ColumnHeadersHeight = 35;
            this.dgv_ArticulosEnVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ArticulosEnVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4,
            this.columna5});
            this.dgv_ArticulosEnVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ArticulosEnVenta.Location = new System.Drawing.Point(18, 21);
            this.dgv_ArticulosEnVenta.MultiSelect = false;
            this.dgv_ArticulosEnVenta.Name = "dgv_ArticulosEnVenta";
            this.dgv_ArticulosEnVenta.RowHeadersVisible = false;
            this.dgv_ArticulosEnVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ArticulosEnVenta.Size = new System.Drawing.Size(722, 179);
            this.dgv_ArticulosEnVenta.TabIndex = 0;
            this.dgv_ArticulosEnVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarArticuloPorViaje);
            // 
            // columna1
            // 
            this.columna1.HeaderText = "Código";
            this.columna1.Name = "columna1";
            this.columna1.Width = 120;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Nombre del artículo";
            this.columna2.Name = "columna2";
            this.columna2.Width = 400;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "Cantidad";
            this.columna3.Name = "columna3";
            // 
            // columna4
            // 
            this.columna4.HeaderText = "Seleccionar";
            this.columna4.Name = "columna4";
            this.columna4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columna4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columna4.Text = "seleccionar";
            this.columna4.Width = 99;
            // 
            // columna5
            // 
            this.columna5.HeaderText = "Id";
            this.columna5.Name = "columna5";
            // 
            // IU_RegistrarOrden_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_siguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IU_RegistrarOrden_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SELECCIONAR ARTICULOS";
            this.Load += new System.EventHandler(this.IU_RegistrarOrden_3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ArticulosEnVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ArticulosEnVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewButtonColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna5;
    }
}