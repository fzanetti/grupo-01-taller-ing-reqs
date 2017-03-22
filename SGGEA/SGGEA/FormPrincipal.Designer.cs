using System.ComponentModel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.login = new SGGEA.Login();
            this.SuspendLayout();
            // 
            // login
            // 
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
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunny Patch";
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.adminUsuarios = new Usuarios.Admin();
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.altaUsuario = new Usuarios.Alta();
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.modifUsuario = new Usuarios.ModificacionBaja(username);
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

        public void InitializeAdminPerfiles()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.adminPerfiles = new Perfiles.Admin();
            this.adminPerfiles.BackColor = System.Drawing.Color.White;
            this.adminPerfiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal.BackgroundImage")));
            this.adminPerfiles.Location = new System.Drawing.Point(0, 0);
            this.adminPerfiles.Name = "adminPerfiles";
            this.adminPerfiles.Size = new System.Drawing.Size(404, 800);
            this.adminPerfiles.TabIndex = 6;
            this.Controls.Clear();
            this.Controls.Add(this.adminPerfiles);
            this.ResumeLayout(false);
        }

        public void InitializeAltaPerfil()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.altaPerfil = new Perfiles.Alta();
            this.altaPerfil.BackColor = System.Drawing.Color.White;
            this.altaPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("altaPerfil.BackgroundImage")));
            this.altaPerfil.Location = new System.Drawing.Point(0, 0);
            this.altaPerfil.Name = "altaPerfiles";
            this.altaPerfil.Size = new System.Drawing.Size(404, 800);
            this.altaPerfil.TabIndex = 7;
            this.Controls.Clear();
            this.Controls.Add(this.altaPerfil);
            this.ResumeLayout(false);
        }

        public void InitializeModifPerfil(string nombrePerfil)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPrincipal));
            this.SuspendLayout();
            this.modifPerfil = new Perfiles.ModificacionBaja(nombrePerfil);
            this.modifPerfil.BackColor = System.Drawing.Color.White;
            this.modifPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifPerfil.BackgroundImage")));
            this.modifPerfil.Location = new System.Drawing.Point(0, 0);
            this.modifPerfil.Name = "modifPerfiles";
            this.modifPerfil.Size = new System.Drawing.Size(404, 800);
            this.modifPerfil.TabIndex = 8;
            this.Controls.Clear();
            this.Controls.Add(this.modifPerfil);
            this.ResumeLayout(false);
        }
        

        #endregion

        private Login login;
        private Principal principal;
        private Usuarios.Admin adminUsuarios;
        private Usuarios.Alta altaUsuario;
        private Usuarios.ModificacionBaja modifUsuario;
        private Perfiles.Admin adminPerfiles;
        private Perfiles.Alta altaPerfil;
        private Perfiles.ModificacionBaja modifPerfil;



    }
}

