using SGGEA.Usuarios;
namespace SGGEA
{
    partial class FormPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources= new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.login = new SGGEA.Login();
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(404, 800);
            this.login.TabIndex = 0;
        
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 800);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunny Patch";
            this.Controls.Add(this.login);

            this.ResumeLayout(false);

        }

        
        public void InitializeLogin()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.login = new SGGEA.Login();
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.Location = new System.Drawing.Point(0, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(404, 800);
            this.login.TabIndex = 0;
            this.Controls.Clear();
            this.Controls.Add(this.login);
            this.ResumeLayout(false);
        }

        public void InitializePrincipal()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.principal = new SGGEA.Principal();
            this.principal.BackColor = System.Drawing.Color.White;
            this.principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal.BackgroundImage")));
            this.principal.Location = new System.Drawing.Point(0, 0);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(404, 800);
            this.principal.TabIndex = 1;
            this.Controls.Clear();
            this.Controls.Add(this.principal);
            this.ResumeLayout(false);
        }

        public void InitializeAdminUsuarios()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.adminUsuarios = new Admin();
            this.adminUsuarios.BackColor = System.Drawing.Color.White;
            this.adminUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal.BackgroundImage")));
            this.adminUsuarios.Location = new System.Drawing.Point(0, 0);
            this.adminUsuarios.Name = "adminUsuarios";
            this.adminUsuarios.Size = new System.Drawing.Size(404, 800);
            this.adminUsuarios.TabIndex = 3;
            this.Controls.Clear();
            this.Controls.Add(this.adminUsuarios);
            this.ResumeLayout(false);
        }

        public void InitializeAltaUsuario()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.altaUsuario = new Alta();
            this.altaUsuario.BackColor = System.Drawing.Color.White;
            this.altaUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal.BackgroundImage")));
            this.altaUsuario.Location = new System.Drawing.Point(0, 0);
            this.altaUsuario.Name = "altaUsuarios";
            this.altaUsuario.Size = new System.Drawing.Size(404, 800);
            this.altaUsuario.TabIndex = 4;
            this.Controls.Clear();
            this.Controls.Add(this.altaUsuario);
            this.ResumeLayout(false);
        }

        public void InitializeModifUsuario(string username)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.modifUsuario = new ModificacionBaja(username);
            this.modifUsuario.BackColor = System.Drawing.Color.White;
            this.modifUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal.BackgroundImage")));
            this.modifUsuario.Location = new System.Drawing.Point(0, 0);
            this.modifUsuario.Name = "modifUsuarios";
            this.modifUsuario.Size = new System.Drawing.Size(404, 800);
            this.modifUsuario.TabIndex = 5;
            this.Controls.Clear();
            this.Controls.Add(this.modifUsuario);
            this.ResumeLayout(false);
        }
        

        #endregion

        private Login login;
        private Principal principal;
        private Admin adminUsuarios;
        private Alta altaUsuario;
        private ModificacionBaja modifUsuario;




    }
}

