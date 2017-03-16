namespace SGGEA
{
    partial class Principal
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
            this.btnPerfilesUsuario = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.imgMenu = new System.Windows.Forms.PictureBox();
            this.btnAdminUsu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerfilesUsuario
            // 
            this.btnPerfilesUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerfilesUsuario.FlatAppearance.BorderSize = 0;
            this.btnPerfilesUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilesUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilesUsuario.Location = new System.Drawing.Point(48, 154);
            this.btnPerfilesUsuario.Name = "btnPerfilesUsuario";
            this.btnPerfilesUsuario.Size = new System.Drawing.Size(158, 29);
            this.btnPerfilesUsuario.TabIndex = 7;
            this.btnPerfilesUsuario.Text = "Perfiles de usuario";
            this.btnPerfilesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilesUsuario.UseVisualStyleBackColor = false;
            this.btnPerfilesUsuario.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(41, 616);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 29);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnMenu;
            this.btnMenu.Location = new System.Drawing.Point(27, 99);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 24);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.BackColor = System.Drawing.Color.Transparent;
            this.imgMenu.BackgroundImage = global::SGGEA.Properties.Resources.menu;
            this.imgMenu.Location = new System.Drawing.Point(22, 131);
            this.imgMenu.Name = "imgMenu";
            this.imgMenu.Size = new System.Drawing.Size(204, 533);
            this.imgMenu.TabIndex = 1;
            this.imgMenu.TabStop = false;
            this.imgMenu.Visible = false;
            // 
            // btnAdminUsu
            // 
            this.btnAdminUsu.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuarios;
            this.btnAdminUsu.Location = new System.Drawing.Point(99, 486);
            this.btnAdminUsu.Name = "btnAdminUsu";
            this.btnAdminUsu.Size = new System.Drawing.Size(82, 102);
            this.btnAdminUsu.TabIndex = 0;
            this.btnAdminUsu.TabStop = false;
            this.btnAdminUsu.MouseEnter += new System.EventHandler(this.Principal_MouseEnter);
            this.btnAdminUsu.MouseLeave += new System.EventHandler(this.Principal_MouseLeave);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.principal_ok;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPerfilesUsuario);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.imgMenu);
            this.Controls.Add(this.btnAdminUsu);
            this.Name = "Principal";
            this.Size = new System.Drawing.Size(404, 800);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAdminUsu;
        private System.Windows.Forms.PictureBox imgMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Button btnPerfilesUsuario;
        private System.Windows.Forms.Button btnLogout;
    }
}
