namespace EjercicioUnidad6
{
    partial class frmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantidadCanciones = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.pbxUrlImagenTapa = new System.Windows.Forms.PictureBox();
            this.txtUrlImagenTapa = new System.Windows.Forms.TextBox();
            this.lblUrlImagenTaoa = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagenTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(14, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(14, 72);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaLanzamiento.TabIndex = 1;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(14, 97);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(116, 13);
            this.lblCantidadCanciones.TabIndex = 2;
            this.lblCantidadCanciones.Text = "Cantidad de canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(157, 16);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCantidadCanciones
            // 
            this.txtCantidadCanciones.Location = new System.Drawing.Point(157, 94);
            this.txtCantidadCanciones.MaxLength = 3;
            this.txtCantidadCanciones.Name = "txtCantidadCanciones";
            this.txtCantidadCanciones.Size = new System.Drawing.Size(38, 20);
            this.txtCantidadCanciones.TabIndex = 3;
            this.txtCantidadCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadCanciones_KeyPress);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(157, 68);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaLanzamiento.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(98, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(14, 150);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(80, 13);
            this.lblTipoEdicion.TabIndex = 8;
            this.lblTipoEdicion.Text = "Tipo de edición";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(14, 123);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 9;
            this.lblEstilo.Text = "Estilo";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(157, 120);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(121, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(157, 147);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(121, 21);
            this.cboTipoEdicion.TabIndex = 5;
            // 
            // pbxUrlImagenTapa
            // 
            this.pbxUrlImagenTapa.Location = new System.Drawing.Point(314, 16);
            this.pbxUrlImagenTapa.Name = "pbxUrlImagenTapa";
            this.pbxUrlImagenTapa.Size = new System.Drawing.Size(200, 200);
            this.pbxUrlImagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrlImagenTapa.TabIndex = 12;
            this.pbxUrlImagenTapa.TabStop = false;
            // 
            // txtUrlImagenTapa
            // 
            this.txtUrlImagenTapa.Location = new System.Drawing.Point(157, 42);
            this.txtUrlImagenTapa.MaxLength = 100;
            this.txtUrlImagenTapa.Name = "txtUrlImagenTapa";
            this.txtUrlImagenTapa.Size = new System.Drawing.Size(121, 20);
            this.txtUrlImagenTapa.TabIndex = 1;
            this.txtUrlImagenTapa.Leave += new System.EventHandler(this.txtUrlImagenTapa_Leave);
            // 
            // lblUrlImagenTaoa
            // 
            this.lblUrlImagenTaoa.AutoSize = true;
            this.lblUrlImagenTaoa.Location = new System.Drawing.Point(14, 45);
            this.lblUrlImagenTaoa.Name = "lblUrlImagenTaoa";
            this.lblUrlImagenTaoa.Size = new System.Drawing.Size(75, 13);
            this.lblUrlImagenTaoa.TabIndex = 13;
            this.lblUrlImagenTaoa.Text = "Tapa de disco";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(284, 42);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(24, 20);
            this.btnAgregarImagen.TabIndex = 14;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 241);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtUrlImagenTapa);
            this.Controls.Add(this.lblUrlImagenTaoa);
            this.Controls.Add(this.pbxUrlImagenTapa);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.txtCantidadCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(520, 280);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nuevo disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagenTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantidadCanciones;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.PictureBox pbxUrlImagenTapa;
        private System.Windows.Forms.TextBox txtUrlImagenTapa;
        private System.Windows.Forms.Label lblUrlImagenTaoa;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}