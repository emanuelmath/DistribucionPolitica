namespace DistribucionPolitica_R
{
    partial class FrmInterfaz
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInterfaz));
            this.distribucionPoliticaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.distribucionMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.distribucionPoliticaMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // distribucionPoliticaMenuStrip
            // 
            this.distribucionPoliticaMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.distribucionPoliticaMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribucionMenuStrip,
            this.entidadMenuStrip,
            this.salirMenuStrip});
            this.distribucionPoliticaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.distribucionPoliticaMenuStrip.Name = "distribucionPoliticaMenuStrip";
            this.distribucionPoliticaMenuStrip.Size = new System.Drawing.Size(1300, 28);
            this.distribucionPoliticaMenuStrip.TabIndex = 0;
            this.distribucionPoliticaMenuStrip.Text = "menuStrip1";
            // 
            // distribucionMenuStrip
            // 
            this.distribucionMenuStrip.Name = "distribucionMenuStrip";
            this.distribucionMenuStrip.Size = new System.Drawing.Size(117, 24);
            this.distribucionMenuStrip.Text = "Distribuciones";
            this.distribucionMenuStrip.Click += new System.EventHandler(this.distribucionMenuStrip_Click);
            // 
            // entidadMenuStrip
            // 
            this.entidadMenuStrip.Name = "entidadMenuStrip";
            this.entidadMenuStrip.Size = new System.Drawing.Size(88, 24);
            this.entidadMenuStrip.Text = "Entidades";
            this.entidadMenuStrip.Click += new System.EventHandler(this.entidadMenuStrip_Click);
            // 
            // salirMenuStrip
            // 
            this.salirMenuStrip.Name = "salirMenuStrip";
            this.salirMenuStrip.Size = new System.Drawing.Size(52, 24);
            this.salirMenuStrip.Text = "Salir";
            this.salirMenuStrip.Click += new System.EventHandler(this.salirMenuStrip_Click);
            // 
            // FrmInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 554);
            this.ControlBox = false;
            this.Controls.Add(this.distribucionPoliticaMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.distribucionPoliticaMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInterfaz";
            this.Text = "Distribución Política";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.distribucionPoliticaMenuStrip.ResumeLayout(false);
            this.distribucionPoliticaMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip distribucionPoliticaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem distribucionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem entidadMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem salirMenuStrip;
    }
}

