namespace Culebra
{
    partial class frmPresentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            this.pboxTableroJuego = new System.Windows.Forms.PictureBox();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblTotalMarcador = new System.Windows.Forms.Label();
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTableroJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxTableroJuego
            // 
            this.pboxTableroJuego.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxTableroJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxTableroJuego.Location = new System.Drawing.Point(21, 23);
            this.pboxTableroJuego.Name = "pboxTableroJuego";
            this.pboxTableroJuego.Size = new System.Drawing.Size(498, 439);
            this.pboxTableroJuego.TabIndex = 0;
            this.pboxTableroJuego.TabStop = false;
            this.pboxTableroJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxTableroJuego_Paint);
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMarcador.Location = new System.Drawing.Point(525, 26);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(146, 33);
            this.lblMarcador.TabIndex = 1;
            this.lblMarcador.Text = "Marcador:";
            // 
            // lblTotalMarcador
            // 
            this.lblTotalMarcador.AutoSize = true;
            this.lblTotalMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarcador.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalMarcador.Location = new System.Drawing.Point(693, 26);
            this.lblTotalMarcador.Name = "lblTotalMarcador";
            this.lblTotalMarcador.Size = new System.Drawing.Size(110, 33);
            this.lblTotalMarcador.TabIndex = 2;
            this.lblTotalMarcador.Text = "lblTotal";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(48, 80);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(86, 31);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label1";
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 498);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblTotalMarcador);
            this.Controls.Add(this.lblMarcador);
            this.Controls.Add(this.pboxTableroJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Culebrita-Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPresentacion_FormClosing);
            this.Load += new System.EventHandler(this.frmPresentacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPresentacion_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPresentacion_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTableroJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxTableroJuego;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblTotalMarcador;
        private System.Windows.Forms.Timer timerJuego;
        private System.Windows.Forms.Label lblGameOver;
    }
}

