namespace MiPrimerAplicacion
{
    partial class MiPrimeraApp
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
            this.btnBoton = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtCajaTexto = new System.Windows.Forms.TextBox();
            this.txtCajaTextoMultilinea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBoton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBoton.Image = global::MiPrimerAplicacion.Properties.Resources.iconRun;
            this.btnBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoton.Location = new System.Drawing.Point(95, 77);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(68, 44);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Run";
            this.btnBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.UseWaitCursor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEtiqueta.Location = new System.Drawing.Point(45, 16);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(174, 30);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Esta es una etiqueta";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEtiqueta_MouseMove);
            // 
            // txtCajaTexto
            // 
            this.txtCajaTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCajaTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCajaTexto.Location = new System.Drawing.Point(45, 51);
            this.txtCajaTexto.MaxLength = 100;
            this.txtCajaTexto.Name = "txtCajaTexto";
            this.txtCajaTexto.Size = new System.Drawing.Size(174, 20);
            this.txtCajaTexto.TabIndex = 2;
            this.txtCajaTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCajaTexto_KeyPress);
            // 
            // txtCajaTextoMultilinea
            // 
            this.txtCajaTextoMultilinea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCajaTextoMultilinea.Location = new System.Drawing.Point(45, 131);
            this.txtCajaTextoMultilinea.Multiline = true;
            this.txtCajaTextoMultilinea.Name = "txtCajaTextoMultilinea";
            this.txtCajaTextoMultilinea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCajaTextoMultilinea.Size = new System.Drawing.Size(174, 149);
            this.txtCajaTextoMultilinea.TabIndex = 3;
            this.txtCajaTextoMultilinea.Leave += new System.EventHandler(this.txtCajaTextoMultilinea_Leave);
            // 
            // MiPrimeraApp
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 325);
            this.Controls.Add(this.txtCajaTextoMultilinea);
            this.Controls.Add(this.txtCajaTexto);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnBoton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiPrimeraApp";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primera App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiPrimeraApp_FormClosed);
            this.Load += new System.EventHandler(this.MiPrimeraApp_Load);
            this.Click += new System.EventHandler(this.MiPrimeraApp_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtCajaTexto;
        private System.Windows.Forms.TextBox txtCajaTextoMultilinea;
    }
}

