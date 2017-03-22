namespace SGGEA.UserControls
{
    partial class SelPerfil
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblPerfil.Location = new System.Drawing.Point(24, 2);
            this.lblPerfil.MaximumSize = new System.Drawing.Size(176, 35);
            this.lblPerfil.MinimumSize = new System.Drawing.Size(176, 18);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(176, 18);
            this.lblPerfil.TabIndex = 3;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackgroundImage = global::SGGEA.Properties.Resources.checkBox;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(20, 20);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // SelPerfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.btnPerfil);
            this.MaximumSize = new System.Drawing.Size(200, 38);
            this.MinimumSize = new System.Drawing.Size(200, 20);
            this.Name = "SelPerfil";
            this.Size = new System.Drawing.Size(200, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblPerfil;
    }
}
