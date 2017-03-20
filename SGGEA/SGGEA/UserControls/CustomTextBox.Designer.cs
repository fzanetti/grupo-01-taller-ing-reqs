namespace SGGEA.UserControls
{
    partial class CustomTextBox
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
            this.lblError = new System.Windows.Forms.Label();
            this.tbCampo = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 26);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(250, 15);
            this.lblError.TabIndex = 31;
            // 
            // tbCampo
            // 
            this.tbCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbCampo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCampo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCampo.ForeColor = System.Drawing.Color.Black;
            this.tbCampo.Location = new System.Drawing.Point(3, 2);
            this.tbCampo.Name = "tbCampo";
            this.tbCampo.Size = new System.Drawing.Size(250, 20);
            this.tbCampo.TabIndex = 32;
            this.tbCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCampo_KeyPress);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblCampo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCampo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.lblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCampo.Location = new System.Drawing.Point(9, 1);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(62, 20);
            this.lblCampo.TabIndex = 33;
            this.lblCampo.Text = "Campo";
            this.lblCampo.Click += new System.EventHandler(this.lblCampo_Click);
            // 
            // CustomTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoTextBox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.tbCampo);
            this.Controls.Add(this.lblError);
            this.DoubleBuffered = true;
            this.Name = "CustomTextBox";
            this.Size = new System.Drawing.Size(256, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbCampo;
        private System.Windows.Forms.Label lblCampo;


    }
}
