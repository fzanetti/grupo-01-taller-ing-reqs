using API.Dominio;
using SGGEA.UserControls;
namespace SGGEA.Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAltaUsuario = new System.Windows.Forms.Label();
            this.user1 = new SGGEA.UserControls.User();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.lblTitulo.Location = new System.Drawing.Point(55, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 29);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Usuarios";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Image = global::SGGEA.Properties.Resources.btnAtras;
            this.btnAtras.Location = new System.Drawing.Point(27, 99);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(24, 24);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(32, 143);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(339, 523);
            this.flowLayoutPanel.TabIndex = 24;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaUsuario.Image = global::SGGEA.Properties.Resources.altaUsuario;
            this.btnAltaUsuario.Location = new System.Drawing.Point(320, 599);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(48, 48);
            this.btnAltaUsuario.TabIndex = 0;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            this.btnAltaUsuario.MouseEnter += new System.EventHandler(this.btnAltaUsuario_MouseEnter);
            this.btnAltaUsuario.MouseLeave += new System.EventHandler(this.btnAltaUsuario_MouseLeave);
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.Color.Transparent;
            this.user1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user1.BackgroundImage")));
            this.user1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.user1.Email = "Email";
            this.user1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1.Location = new System.Drawing.Point(0, 0);
            this.user1.Name = "user1";
            this.user1.NombreApellido = "Nombre Apellido";
            this.user1.NombreUsuario = "Nombre de usuario";
            this.user1.Size = new System.Drawing.Size(333, 50);
            this.user1.TabIndex = 0;
            // 
            // AdminUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoPantalla;
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AdminUsuarios";
            this.Size = new System.Drawing.Size(404, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label btnAtras;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private User user1;
        private System.Windows.Forms.Label btnAltaUsuario;
    }
}
