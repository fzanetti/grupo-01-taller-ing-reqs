namespace SGGEA.UserControls
{
    partial class SelFuncion
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
            this.lblFuncion = new System.Windows.Forms.Label();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblFuncion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lblFuncion.Location = new System.Drawing.Point(28, 2);
            this.lblFuncion.MaximumSize = new System.Drawing.Size(224, 35);
            this.lblFuncion.MinimumSize = new System.Drawing.Size(224, 18);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(224, 18);
            this.lblFuncion.TabIndex = 7;
            this.lblFuncion.Text = "Funcion";
            this.lblFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // btnFuncion
            // 
            this.btnFuncion.BackgroundImage = global::SGGEA.Properties.Resources.checkBox;
            this.btnFuncion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncion.FlatAppearance.BorderSize = 0;
            this.btnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncion.Location = new System.Drawing.Point(0, 0);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(20, 20);
            this.btnFuncion.TabIndex = 6;
            this.btnFuncion.UseVisualStyleBackColor = true;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // SelFuncion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.btnFuncion);
            this.Name = "SelFuncion";
            this.Size = new System.Drawing.Size(257, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Button btnFuncion;
    }
}
