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
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.tbContrasenia = new SGGEA.UserControls.CustomTextBox();
            this.lblError = new SGGEA.UserControls.LabelError();
            this.tbUsuario = new SGGEA.UserControls.CustomTextBox();
            this.btnIniciarSesion = new SGGEA.UserControls.CustomButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.lblContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(114, 301);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(112, 23);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña";
            this.lblContrasenia.Click += new System.EventHandler(this.lblContrasenia_Click);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.tbContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContrasenia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasenia.Location = new System.Drawing.Point(113, 302);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(175, 22);
            this.tbContrasenia.TabIndex = 2;
            this.tbContrasenia.UseSystemPasswordChar = true;
            this.tbContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContrasenia_KeyPress);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(108, 330);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(36, 16);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(114, 233);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(175, 22);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Text = " Nombre de usuario";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.LogIn;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(404, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CustomButton btnIniciarSesion;
        private UserControls.CustomTextBox tbUsuario;
        private UserControls.LabelError lblError;
        private System.Windows.Forms.Label lblContrasenia;
        private UserControls.CustomTextBox tbContrasenia;
        private System.Windows.Forms.Button button1;
    }
}
