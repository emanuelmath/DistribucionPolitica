namespace DistribucionPolitica_R.Formularios
{
    partial class FrmDistribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistribucion));
            this.GrdDistribucion = new System.Windows.Forms.DataGridView();
            this.toolStripDistribucion = new System.Windows.Forms.ToolStrip();
            this.BtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.ComboBoxEntidad = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtDistribucion = new System.Windows.Forms.ToolStripTextBox();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BtnLimpiar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDistribucion)).BeginInit();
            this.toolStripDistribucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdDistribucion
            // 
            this.GrdDistribucion.AllowUserToAddRows = false;
            this.GrdDistribucion.AllowUserToDeleteRows = false;
            this.GrdDistribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDistribucion.Location = new System.Drawing.Point(16, 48);
            this.GrdDistribucion.Margin = new System.Windows.Forms.Padding(4);
            this.GrdDistribucion.Name = "GrdDistribucion";
            this.GrdDistribucion.ReadOnly = true;
            this.GrdDistribucion.RowHeadersWidth = 51;
            this.GrdDistribucion.Size = new System.Drawing.Size(1172, 491);
            this.GrdDistribucion.TabIndex = 0;
            this.GrdDistribucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDistribucion_CellContentClick);
            // 
            // toolStripDistribucion
            // 
            this.toolStripDistribucion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDistribucion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregar,
            this.BtnEditar,
            this.BtnExportar,
            this.toolStripSeparator1,
            this.BtnEliminar,
            this.ComboBoxEntidad,
            this.toolStripSeparator2,
            this.TxtDistribucion,
            this.BtnBuscar,
            this.BtnLimpiar});
            this.toolStripDistribucion.Location = new System.Drawing.Point(0, 0);
            this.toolStripDistribucion.Name = "toolStripDistribucion";
            this.toolStripDistribucion.Size = new System.Drawing.Size(1201, 28);
            this.toolStripDistribucion.TabIndex = 1;
            this.toolStripDistribucion.Text = "toolStrip1";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(29, 25);
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(29, 25);
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(29, 25);
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(29, 25);
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ComboBoxEntidad
            // 
            this.ComboBoxEntidad.Name = "ComboBoxEntidad";
            this.ComboBoxEntidad.Size = new System.Drawing.Size(160, 28);
            this.ComboBoxEntidad.Click += new System.EventHandler(this.ComboBoxEntidad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // TxtDistribucion
            // 
            this.TxtDistribucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDistribucion.Name = "TxtDistribucion";
            this.TxtDistribucion.Size = new System.Drawing.Size(132, 28);
            this.TxtDistribucion.Click += new System.EventHandler(this.TxtDistribucion_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(29, 25);
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(29, 25);
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 554);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripDistribucion);
            this.Controls.Add(this.GrdDistribucion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDistribucion";
            this.Text = "Distribución";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDistribucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDistribucion)).EndInit();
            this.toolStripDistribucion.ResumeLayout(false);
            this.toolStripDistribucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdDistribucion;
        private System.Windows.Forms.ToolStrip toolStripDistribucion;
        private System.Windows.Forms.ToolStripButton BtnAgregar;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton BtnExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripComboBox ComboBoxEntidad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox TxtDistribucion;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.ToolStripButton BtnLimpiar;
    }
}