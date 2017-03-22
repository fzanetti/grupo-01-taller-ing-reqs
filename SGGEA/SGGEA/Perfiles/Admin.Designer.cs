namespace SGGEA.Perfiles
{
    partial class Admin
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaPerfil = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAtras = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltaPerfil
            // 
            this.btnAltaPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaPerfil.Image = global::SGGEA.Properties.Resources.altaPerfil;
            this.btnAltaPerfil.Location = new System.Drawing.Point(306, 601);
            this.btnAltaPerfil.Name = "btnAltaPerfil";
            this.btnAltaPerfil.Size = new System.Drawing.Size(48, 48);
            this.btnAltaPerfil.TabIndex = 25;
            this.btnAltaPerfil.Click += new System.EventHandler(this.btnAltaPerfil_Click);
            this.btnAltaPerfil.MouseEnter += new System.EventHandler(this.btnAltaPerfil_MouseEnter);
            this.btnAltaPerfil.MouseLeave += new System.EventHandler(this.btnAltaPerfil_MouseLeave);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(32, 143);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(339, 523);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Image = global::SGGEA.Properties.Resources.btnAtras;
            this.btnAtras.Location = new System.Drawing.Point(27, 99);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(24, 24);
            this.btnAtras.TabIndex = 27;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.lblTitulo.Location = new System.Drawing.Point(55, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 29);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Perfiles de Usuario";
            // 
            // Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoPantalla;
            this.Controls.Add(this.btnAltaPerfil);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(404, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnAltaPerfil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label btnAtras;
        private System.Windows.Forms.Label lblTitulo;
    }
}
