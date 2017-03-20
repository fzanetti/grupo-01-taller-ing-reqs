namespace SGGEA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.campoPassword = new SGGEA.UserControls.CustomTextBox();
            this.campoUsername = new SGGEA.UserControls.CustomTextBox();
            this.btnIniciarSesion = new SGGEA.UserControls.CustomButton();
            this.SuspendLayout();
            // 
            // campoPassword
            // 
            this.campoPassword.AnchoCampo = 190;
            this.campoPassword.BackColor = System.Drawing.Color.Transparent;
            this.campoPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoPassword.BackgroundImage")));
            this.campoPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoPassword.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.campoPassword.EsPassword = true;
            this.campoPassword.FontCampo = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPassword.FontError = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPassword.FontTitulo = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPassword.Location = new System.Drawing.Point(102, 301);
            this.campoPassword.Name = "campoPassword";
            this.campoPassword.Size = new System.Drawing.Size(195, 48);
            this.campoPassword.TabIndex = 2;
            this.campoPassword.TextoCampo = "";
            this.campoPassword.TextoError = "";
            this.campoPassword.TituloCampo = "Contraseña";
            // 
            // campoUsername
            // 
            this.campoUsername.AnchoCampo = 190;
            this.campoUsername.BackColor = System.Drawing.Color.Transparent;
            this.campoUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoUsername.BackgroundImage")));
            this.campoUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoUsername.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.campoUsername.EsPassword = false;
            this.campoUsername.FontCampo = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsername.FontError = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsername.FontTitulo = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsername.Location = new System.Drawing.Point(102, 232);
            this.campoUsername.Name = "campoUsername";
            this.campoUsername.Size = new System.Drawing.Size(195, 48);
            this.campoUsername.TabIndex = 1;
            this.campoUsername.TextoCampo = "";
            this.campoUsername.TextoError = "";
            this.campoUsername.TituloCampo = "Nombre de usuario";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(105, 366);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(188, 36);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.campoPassword);
            this.Controls.Add(this.campoUsername);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(404, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.CustomButton btnIniciarSesion;
        private UserControls.CustomTextBox campoUsername;
        private UserControls.CustomTextBox campoPassword;
    }
}
