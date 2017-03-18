using System.Windows.Forms;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.imgMenu = new System.Windows.Forms.PictureBox();
            this.btnPerfilesUsuario = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Label();
            this.btnAlertas = new System.Windows.Forms.Label();
            this.btnConfigParam = new System.Windows.Forms.Label();
            this.btnOrdenAlimentacion = new System.Windows.Forms.Label();
            this.btnAdminUsu = new System.Windows.Forms.Button();
            this.btnBitacoraFallas = new System.Windows.Forms.Label();
            this.btnMetricas = new System.Windows.Forms.Label();
            this.btnBitacoraAct = new System.Windows.Forms.Label();
            this.confirmLogout = new SGGEA.UserControls.ConfirmationDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            this.SuspendLayout();
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
            // btnPerfilesUsuario
            // 
            this.btnPerfilesUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnPerfilesUsuario.FlatAppearance.BorderSize = 0;
            this.btnPerfilesUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilesUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilesUsuario.Location = new System.Drawing.Point(48, 154);
            this.btnPerfilesUsuario.Name = "btnPerfilesUsuario";
            this.btnPerfilesUsuario.Size = new System.Drawing.Size(158, 29);
            this.btnPerfilesUsuario.TabIndex = 9;
            this.btnPerfilesUsuario.Text = "Perfiles de usuario";
            this.btnPerfilesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilesUsuario.UseVisualStyleBackColor = false;
            this.btnPerfilesUsuario.Visible = false;
            this.btnPerfilesUsuario.Click += new System.EventHandler(this.btnPerfilesUsuario_Click);
            this.btnPerfilesUsuario.MouseEnter += new System.EventHandler(this.btnPerfilesUsuario_MouseEnter);
            this.btnPerfilesUsuario.MouseLeave += new System.EventHandler(this.btnPerfilesUsuario_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(41, 616);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 29);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitor.Image = global::SGGEA.Properties.Resources.monitor;
            this.btnMonitor.Location = new System.Drawing.Point(61, 163);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(63, 91);
            this.btnMonitor.TabIndex = 1;
            this.btnMonitor.Visible = false;
            // 
            // btnAlertas
            // 
            this.btnAlertas.BackColor = System.Drawing.Color.Transparent;
            this.btnAlertas.Image = global::SGGEA.Properties.Resources.alertas;
            this.btnAlertas.Location = new System.Drawing.Point(164, 160);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(69, 94);
            this.btnAlertas.TabIndex = 2;
            this.btnAlertas.Visible = false;
            // 
            // btnConfigParam
            // 
            this.btnConfigParam.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigParam.Image = global::SGGEA.Properties.Resources.configParametros;
            this.btnConfigParam.Location = new System.Drawing.Point(256, 158);
            this.btnConfigParam.Name = "btnConfigParam";
            this.btnConfigParam.Size = new System.Drawing.Size(93, 111);
            this.btnConfigParam.TabIndex = 3;
            this.btnConfigParam.Visible = false;
            // 
            // btnOrdenAlimentacion
            // 
            this.btnOrdenAlimentacion.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdenAlimentacion.Image = global::SGGEA.Properties.Resources.ordenAlimnetacion;
            this.btnOrdenAlimentacion.Location = new System.Drawing.Point(212, 480);
            this.btnOrdenAlimentacion.Name = "btnOrdenAlimentacion";
            this.btnOrdenAlimentacion.Size = new System.Drawing.Size(114, 114);
            this.btnOrdenAlimentacion.TabIndex = 8;
            this.btnOrdenAlimentacion.Visible = false;
            // 
            // btnAdminUsu
            // 
            this.btnAdminUsu.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuarios;
            this.btnAdminUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdminUsu.FlatAppearance.BorderSize = 0;
            this.btnAdminUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUsu.Location = new System.Drawing.Point(96, 486);
            this.btnAdminUsu.Name = "btnAdminUsu";
            this.btnAdminUsu.Size = new System.Drawing.Size(82, 102);
            this.btnAdminUsu.TabIndex = 7;
            this.btnAdminUsu.UseVisualStyleBackColor = false;
            this.btnAdminUsu.Click += new System.EventHandler(this.btnAdminUsu_Click);
            this.btnAdminUsu.MouseEnter += new System.EventHandler(this.btnAdminUsu_MouseEnter);
            this.btnAdminUsu.MouseLeave += new System.EventHandler(this.btnAdminUsu_MouseLeave);
            this.btnAdminUsu.Visible = false;
            // 
            // btnBitacoraFallas
            // 
            this.btnBitacoraFallas.BackColor = System.Drawing.Color.Transparent;
            this.btnBitacoraFallas.Image = global::SGGEA.Properties.Resources.bitacoraFallas;
            this.btnBitacoraFallas.Location = new System.Drawing.Point(51, 311);
            this.btnBitacoraFallas.Name = "btnBitacoraFallas";
            this.btnBitacoraFallas.Size = new System.Drawing.Size(93, 110);
            this.btnBitacoraFallas.TabIndex = 4;
            this.btnBitacoraFallas.Visible = false;
            // 
            // btnMetricas
            // 
            this.btnMetricas.BackColor = System.Drawing.Color.Transparent;
            this.btnMetricas.Image = global::SGGEA.Properties.Resources.metricas;
            this.btnMetricas.Location = new System.Drawing.Point(158, 308);
            this.btnMetricas.Name = "btnMetricas";
            this.btnMetricas.Size = new System.Drawing.Size(88, 114);
            this.btnMetricas.TabIndex = 5;
            this.btnMetricas.Visible = false;
            // 
            // btnBitacoraAct
            // 
            this.btnBitacoraAct.BackColor = System.Drawing.Color.Transparent;
            this.btnBitacoraAct.Image = global::SGGEA.Properties.Resources.bitacoraAct;
            this.btnBitacoraAct.Location = new System.Drawing.Point(263, 307);
            this.btnBitacoraAct.Name = "btnBitacoraAct";
            this.btnBitacoraAct.Size = new System.Drawing.Size(90, 121);
            this.btnBitacoraAct.TabIndex = 6;
            this.btnBitacoraAct.Visible = false;
            // 
            // confirmLogout
            // 
            this.confirmLogout.BackColor = System.Drawing.Color.Transparent;
            this.confirmLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmLogout.BackgroundImage")));
            this.confirmLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLogout.Location = new System.Drawing.Point(46, 276);
            this.confirmLogout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.confirmLogout.Name = "confirmLogout";
            this.confirmLogout.PosicionBtnAceptar = System.Windows.Forms.DockStyle.Left;
            this.confirmLogout.PosicionBtnCancelar = System.Windows.Forms.DockStyle.Right;
            this.confirmLogout.Size = new System.Drawing.Size(310, 181);
            this.confirmLogout.TabIndex = 9;
            this.confirmLogout.TextoAceptar = "Aceptar";
            this.confirmLogout.TextoCancelar = "Cancelar";
            this.confirmLogout.TextoMensaje = "¿Seguro que desea salir?";
            this.confirmLogout.setConfirmationClickEvent(this.btnConfirmarLogout_Click);
            this.confirmLogout.setCancelClickEvent(this.btnCancelarLogout_Click);
            this.confirmLogout.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.pantallaPrincipal;
            this.Controls.Add(this.confirmLogout);
            this.Controls.Add(this.btnPerfilesUsuario);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.imgMenu);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBitacoraAct);
            this.Controls.Add(this.btnMetricas);
            this.Controls.Add(this.btnBitacoraFallas);
            this.Controls.Add(this.btnAdminUsu);
            this.Controls.Add(this.btnOrdenAlimentacion);
            this.Controls.Add(this.btnConfigParam);
            this.Controls.Add(this.btnAlertas);
            this.Controls.Add(this.btnMonitor);
            this.Name = "Principal";
            this.Size = new System.Drawing.Size(404, 800);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox imgMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private UserControls.ConfirmationDialog confirmLogout;
        private Button btnPerfilesUsuario;
        private Button btnLogout;
        private Label btnMonitor;
        private Label btnAlertas;
        private Label btnConfigParam;
        private Label btnOrdenAlimentacion;
        private Button btnAdminUsu;
        private Label btnBitacoraFallas;
        private Label btnMetricas;
        private Label btnBitacoraAct;
    }
}
