namespace DistribucionPolitica_R.Formularios
{
    partial class FrmDistribucionAgregarEditar
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
            this.GroupBoxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.LblDistribucionSuperior = new System.Windows.Forms.Label();
            this.ComboBoxDistribucionSuperior = new System.Windows.Forms.ComboBox();
            this.ComboBoxEntidadSuperior = new System.Windows.Forms.ComboBox();
            this.LblEntidadSuperior = new System.Windows.Forms.Label();
            this.LblEntidad = new System.Windows.Forms.Label();
            this.CheckBoxInactivo = new System.Windows.Forms.CheckBox();
            this.ComboBoxEntidad = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GroupBoxInformacionAdicional = new System.Windows.Forms.GroupBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.NumPoblacion = new System.Windows.Forms.NumericUpDown();
            this.NumSuperficie = new System.Windows.Forms.NumericUpDown();
            this.LblCodigoPostal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblPoblacion = new System.Windows.Forms.Label();
            this.CheckBoxCabecera = new System.Windows.Forms.CheckBox();
            this.CheckBoxCapital = new System.Windows.Forms.CheckBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GroupBoxDatosGenerales.SuspendLayout();
            this.GroupBoxInformacionAdicional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPoblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSuperficie)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxDatosGenerales
            // 
            this.GroupBoxDatosGenerales.Controls.Add(this.LblDistribucionSuperior);
            this.GroupBoxDatosGenerales.Controls.Add(this.ComboBoxDistribucionSuperior);
            this.GroupBoxDatosGenerales.Controls.Add(this.ComboBoxEntidadSuperior);
            this.GroupBoxDatosGenerales.Controls.Add(this.LblEntidadSuperior);
            this.GroupBoxDatosGenerales.Controls.Add(this.LblEntidad);
            this.GroupBoxDatosGenerales.Controls.Add(this.CheckBoxInactivo);
            this.GroupBoxDatosGenerales.Controls.Add(this.ComboBoxEntidad);
            this.GroupBoxDatosGenerales.Controls.Add(this.TxtNombre);
            this.GroupBoxDatosGenerales.Controls.Add(this.LblNombre);
            this.GroupBoxDatosGenerales.Location = new System.Drawing.Point(24, 18);
            this.GroupBoxDatosGenerales.Name = "GroupBoxDatosGenerales";
            this.GroupBoxDatosGenerales.Size = new System.Drawing.Size(662, 164);
            this.GroupBoxDatosGenerales.TabIndex = 0;
            this.GroupBoxDatosGenerales.TabStop = false;
            this.GroupBoxDatosGenerales.Text = "Datos Generales";
            // 
            // LblDistribucionSuperior
            // 
            this.LblDistribucionSuperior.AutoSize = true;
            this.LblDistribucionSuperior.Location = new System.Drawing.Point(262, 67);
            this.LblDistribucionSuperior.Name = "LblDistribucionSuperior";
            this.LblDistribucionSuperior.Size = new System.Drawing.Size(131, 16);
            this.LblDistribucionSuperior.TabIndex = 8;
            this.LblDistribucionSuperior.Text = "Distribución Superior";
            // 
            // ComboBoxDistribucionSuperior
            // 
            this.ComboBoxDistribucionSuperior.FormattingEnabled = true;
            this.ComboBoxDistribucionSuperior.Location = new System.Drawing.Point(265, 86);
            this.ComboBoxDistribucionSuperior.Name = "ComboBoxDistribucionSuperior";
            this.ComboBoxDistribucionSuperior.Size = new System.Drawing.Size(236, 24);
            this.ComboBoxDistribucionSuperior.TabIndex = 7;
            this.ComboBoxDistribucionSuperior.Text = "Seleccione la distribución superior";
            // 
            // ComboBoxEntidadSuperior
            // 
            this.ComboBoxEntidadSuperior.FormattingEnabled = true;
            this.ComboBoxEntidadSuperior.Location = new System.Drawing.Point(9, 86);
            this.ComboBoxEntidadSuperior.Name = "ComboBoxEntidadSuperior";
            this.ComboBoxEntidadSuperior.Size = new System.Drawing.Size(236, 24);
            this.ComboBoxEntidadSuperior.TabIndex = 6;
            this.ComboBoxEntidadSuperior.Text = "Seleccione la entidad superior";
            // 
            // LblEntidadSuperior
            // 
            this.LblEntidadSuperior.AutoSize = true;
            this.LblEntidadSuperior.Location = new System.Drawing.Point(6, 67);
            this.LblEntidadSuperior.Name = "LblEntidadSuperior";
            this.LblEntidadSuperior.Size = new System.Drawing.Size(107, 16);
            this.LblEntidadSuperior.TabIndex = 5;
            this.LblEntidadSuperior.Text = "Entidad Superior";
            // 
            // LblEntidad
            // 
            this.LblEntidad.AutoSize = true;
            this.LblEntidad.Location = new System.Drawing.Point(262, 18);
            this.LblEntidad.Name = "LblEntidad";
            this.LblEntidad.Size = new System.Drawing.Size(53, 16);
            this.LblEntidad.TabIndex = 4;
            this.LblEntidad.Text = "Entidad";
            // 
            // CheckBoxInactivo
            // 
            this.CheckBoxInactivo.AutoSize = true;
            this.CheckBoxInactivo.Location = new System.Drawing.Point(528, 90);
            this.CheckBoxInactivo.Name = "CheckBoxInactivo";
            this.CheckBoxInactivo.Size = new System.Drawing.Size(75, 20);
            this.CheckBoxInactivo.TabIndex = 3;
            this.CheckBoxInactivo.Text = "Inactivo";
            this.CheckBoxInactivo.UseVisualStyleBackColor = true;
            // 
            // ComboBoxEntidad
            // 
            this.ComboBoxEntidad.FormattingEnabled = true;
            this.ComboBoxEntidad.Location = new System.Drawing.Point(265, 37);
            this.ComboBoxEntidad.Name = "ComboBoxEntidad";
            this.ComboBoxEntidad.Size = new System.Drawing.Size(236, 24);
            this.ComboBoxEntidad.TabIndex = 2;
            this.ComboBoxEntidad.Text = "Seleccione una entidad";
            //this.ComboBoxEntidad.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEntidad_SelectedIndexChanged);
            this.ComboBoxEntidad.SelectedValueChanged += new System.EventHandler(this.ComboBoxEntidad_SelectedValueChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(9, 37);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(230, 22);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(6, 18);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // GroupBoxInformacionAdicional
            // 
            this.GroupBoxInformacionAdicional.Controls.Add(this.TxtCodigo);
            this.GroupBoxInformacionAdicional.Controls.Add(this.NumPoblacion);
            this.GroupBoxInformacionAdicional.Controls.Add(this.NumSuperficie);
            this.GroupBoxInformacionAdicional.Controls.Add(this.LblCodigoPostal);
            this.GroupBoxInformacionAdicional.Controls.Add(this.label6);
            this.GroupBoxInformacionAdicional.Controls.Add(this.LblPoblacion);
            this.GroupBoxInformacionAdicional.Controls.Add(this.CheckBoxCabecera);
            this.GroupBoxInformacionAdicional.Controls.Add(this.CheckBoxCapital);
            this.GroupBoxInformacionAdicional.Controls.Add(this.LblFecha);
            this.GroupBoxInformacionAdicional.Controls.Add(this.DateTimeFecha);
            this.GroupBoxInformacionAdicional.Location = new System.Drawing.Point(24, 188);
            this.GroupBoxInformacionAdicional.Name = "GroupBoxInformacionAdicional";
            this.GroupBoxInformacionAdicional.Size = new System.Drawing.Size(662, 199);
            this.GroupBoxInformacionAdicional.TabIndex = 1;
            this.GroupBoxInformacionAdicional.TabStop = false;
            this.GroupBoxInformacionAdicional.Text = "Información Adicional";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(422, 146);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(230, 22);
            this.TxtCodigo.TabIndex = 9;
            // 
            // NumPoblacion
            // 
            this.NumPoblacion.Location = new System.Drawing.Point(225, 147);
            this.NumPoblacion.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumPoblacion.Name = "NumPoblacion";
            this.NumPoblacion.Size = new System.Drawing.Size(178, 22);
            this.NumPoblacion.TabIndex = 13;
            // 
            // NumSuperficie
            // 
            this.NumSuperficie.DecimalPlaces = 2;
            this.NumSuperficie.Location = new System.Drawing.Point(9, 147);
            this.NumSuperficie.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumSuperficie.Name = "NumSuperficie";
            this.NumSuperficie.Size = new System.Drawing.Size(181, 22);
            this.NumSuperficie.TabIndex = 12;
            // 
            // LblCodigoPostal
            // 
            this.LblCodigoPostal.AutoSize = true;
            this.LblCodigoPostal.Location = new System.Drawing.Point(419, 115);
            this.LblCodigoPostal.Name = "LblCodigoPostal";
            this.LblCodigoPostal.Size = new System.Drawing.Size(92, 16);
            this.LblCodigoPostal.TabIndex = 11;
            this.LblCodigoPostal.Text = "Código Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Superficie (km^2)";
            // 
            // LblPoblacion
            // 
            this.LblPoblacion.AutoSize = true;
            this.LblPoblacion.Location = new System.Drawing.Point(222, 115);
            this.LblPoblacion.Name = "LblPoblacion";
            this.LblPoblacion.Size = new System.Drawing.Size(68, 16);
            this.LblPoblacion.TabIndex = 10;
            this.LblPoblacion.Text = "Población";
            // 
            // CheckBoxCabecera
            // 
            this.CheckBoxCabecera.AutoSize = true;
            this.CheckBoxCabecera.Location = new System.Drawing.Point(265, 51);
            this.CheckBoxCabecera.Name = "CheckBoxCabecera";
            this.CheckBoxCabecera.Size = new System.Drawing.Size(181, 20);
            this.CheckBoxCabecera.TabIndex = 9;
            this.CheckBoxCabecera.Text = "Cabecera Departamental";
            this.CheckBoxCabecera.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCapital
            // 
            this.CheckBoxCapital.AutoSize = true;
            this.CheckBoxCapital.Location = new System.Drawing.Point(486, 51);
            this.CheckBoxCapital.Name = "CheckBoxCapital";
            this.CheckBoxCapital.Size = new System.Drawing.Size(117, 20);
            this.CheckBoxCapital.TabIndex = 10;
            this.CheckBoxCapital.Text = "Ciudad Capital";
            this.CheckBoxCapital.UseVisualStyleBackColor = true;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(6, 28);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(130, 16);
            this.LblFecha.TabIndex = 9;
            this.LblFecha.Text = "Fecha de Fundación";
            // 
            // DateTimeFecha
            // 
            this.DateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeFecha.Location = new System.Drawing.Point(6, 47);
            this.DateTimeFecha.Name = "DateTimeFecha";
            this.DateTimeFecha.Size = new System.Drawing.Size(200, 22);
            this.DateTimeFecha.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(460, 393);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(99, 33);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(565, 393);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 33);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmDistribucionAgregarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.GroupBoxInformacionAdicional);
            this.Controls.Add(this.GroupBoxDatosGenerales);
            this.Name = "FrmDistribucionAgregarEditar";
            this.Text = "Distribución Territorial";
            this.Load += new System.EventHandler(this.FrmDistribucionAgregarEditar_Load);
            this.GroupBoxDatosGenerales.ResumeLayout(false);
            this.GroupBoxDatosGenerales.PerformLayout();
            this.GroupBoxInformacionAdicional.ResumeLayout(false);
            this.GroupBoxInformacionAdicional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPoblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSuperficie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxDatosGenerales;
        private System.Windows.Forms.GroupBox GroupBoxInformacionAdicional;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox ComboBoxDistribucionSuperior;
        private System.Windows.Forms.ComboBox ComboBoxEntidadSuperior;
        private System.Windows.Forms.Label LblEntidadSuperior;
        private System.Windows.Forms.Label LblEntidad;
        private System.Windows.Forms.CheckBox CheckBoxInactivo;
        private System.Windows.Forms.ComboBox ComboBoxEntidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDistribucionSuperior;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.NumericUpDown NumPoblacion;
        private System.Windows.Forms.NumericUpDown NumSuperficie;
        private System.Windows.Forms.Label LblCodigoPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblPoblacion;
        private System.Windows.Forms.CheckBox CheckBoxCabecera;
        private System.Windows.Forms.CheckBox CheckBoxCapital;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DateTimeFecha;
    }
}