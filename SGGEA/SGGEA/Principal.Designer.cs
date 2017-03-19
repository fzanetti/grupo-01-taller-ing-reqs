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
            this.btnFunciones = new System.Windows.Forms.Label();
            this.btnCompGen = new System.Windows.Forms.TextBox();
            this.btnBancos = new System.Windows.Forms.TextBox();
            this.btnControlEnergia = new System.Windows.Forms.Label();
            this.btnProvisionEnergia = new System.Windows.Forms.Label();
            this.btnConversionEnergia = new System.Windows.Forms.Label();
            this.btnBancosBateria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Label();
            this.confirmLogout = new SGGEA.UserControls.ConfirmationDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMenu
            // 
            this.imgMenu.BackColor = System.Drawing.Color.Transparent;
            this.imgMenu.BackgroundImage = global::SGGEA.Properties.Resources.fondoMenu;
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
            this.btnAdminUsu.Visible = false;
            this.btnAdminUsu.Click += new System.EventHandler(this.btnAdminUsu_Click);
            this.btnAdminUsu.MouseEnter += new System.EventHandler(this.btnAdminUsu_MouseEnter);
            this.btnAdminUsu.MouseLeave += new System.EventHandler(this.btnAdminUsu_MouseLeave);
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
            // btnFunciones
            // 
            this.btnFunciones.AutoSize = true;
            this.btnFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFunciones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnFunciones.Location = new System.Drawing.Point(51, 200);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(76, 17);
            this.btnFunciones.TabIndex = 11;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.Visible = false;
            // 
            // btnCompGen
            // 
            this.btnCompGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnCompGen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnCompGen.Location = new System.Drawing.Point(50, 250);
            this.btnCompGen.Multiline = true;
            this.btnCompGen.Name = "btnCompGen";
            this.btnCompGen.ReadOnly = true;
            this.btnCompGen.Size = new System.Drawing.Size(104, 37);
            this.btnCompGen.TabIndex = 13;
            this.btnCompGen.TabStop = false;
            this.btnCompGen.Text = "Componentes Generadores";
            this.btnCompGen.Visible = false;
            // 
            // btnBancos
            // 
            this.btnBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBancos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnBancos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBancos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnBancos.Location = new System.Drawing.Point(50, 313);
            this.btnBancos.Multiline = true;
            this.btnBancos.Name = "btnBancos";
            this.btnBancos.ReadOnly = true;
            this.btnBancos.Size = new System.Drawing.Size(132, 37);
            this.btnBancos.TabIndex = 14;
            this.btnBancos.TabStop = false;
            this.btnBancos.Text = "Bancos de Almacenamiento";
            this.btnBancos.Visible = false;
            // 
            // btnControlEnergia
            // 
            this.btnControlEnergia.AutoSize = true;
            this.btnControlEnergia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnControlEnergia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlEnergia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnControlEnergia.Location = new System.Drawing.Point(51, 377);
            this.btnControlEnergia.Name = "btnControlEnergia";
            this.btnControlEnergia.Size = new System.Drawing.Size(129, 17);
            this.btnControlEnergia.TabIndex = 15;
            this.btnControlEnergia.Text = "Control de Energía";
            this.btnControlEnergia.Visible = false;
            // 
            // btnProvisionEnergia
            // 
            this.btnProvisionEnergia.AutoSize = true;
            this.btnProvisionEnergia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnProvisionEnergia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvisionEnergia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnProvisionEnergia.Location = new System.Drawing.Point(51, 425);
            this.btnProvisionEnergia.Name = "btnProvisionEnergia";
            this.btnProvisionEnergia.Size = new System.Drawing.Size(142, 17);
            this.btnProvisionEnergia.TabIndex = 16;
            this.btnProvisionEnergia.Text = "Provisión de Energía";
            this.btnProvisionEnergia.Visible = false;
            // 
            // btnConversionEnergia
            // 
            this.btnConversionEnergia.AutoSize = true;
            this.btnConversionEnergia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnConversionEnergia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversionEnergia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnConversionEnergia.Location = new System.Drawing.Point(51, 473);
            this.btnConversionEnergia.Name = "btnConversionEnergia";
            this.btnConversionEnergia.Size = new System.Drawing.Size(156, 17);
            this.btnConversionEnergia.TabIndex = 17;
            this.btnConversionEnergia.Text = "Conversión de Energía";
            this.btnConversionEnergia.Visible = false;
            // 
            // btnBancosBateria
            // 
            this.btnBancosBateria.AutoSize = true;
            this.btnBancosBateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBancosBateria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBancosBateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnBancosBateria.Location = new System.Drawing.Point(51, 523);
            this.btnBancosBateria.Name = "btnBancosBateria";
            this.btnBancosBateria.Size = new System.Drawing.Size(128, 17);
            this.btnBancosBateria.TabIndex = 18;
            this.btnBancosBateria.Text = "Bancos de Batería";
            this.btnBancosBateria.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.lblTitulo.Location = new System.Drawing.Point(54, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(67, 29);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Inicio";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = global::SGGEA.Properties.Resources.btnMenu;
            this.btnMenu.Location = new System.Drawing.Point(27, 99);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(24, 24);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // confirmLogout
            // 
            this.confirmLogout.BackColor = System.Drawing.Color.Transparent;
            this.confirmLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmLogout.BackgroundImage")));
            this.confirmLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLogout.Location = new System.Drawing.Point(49, 267);
            this.confirmLogout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.confirmLogout.Name = "confirmLogout";
            this.confirmLogout.PosicionBtnAceptar = System.Windows.Forms.DockStyle.Left;
            this.confirmLogout.PosicionBtnCancelar = System.Windows.Forms.DockStyle.Right;
            this.confirmLogout.Size = new System.Drawing.Size(310, 181);
            this.confirmLogout.TabIndex = 9;
            this.confirmLogout.TextoAceptar = "Aceptar";
            this.confirmLogout.TextoCancelar = "Cancelar";
            this.confirmLogout.TextoMensaje = "¿Seguro que desea salir?";
            this.confirmLogout.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoPantalla;
            this.Controls.Add(this.confirmLogout);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBancosBateria);
            this.Controls.Add(this.btnConversionEnergia);
            this.Controls.Add(this.btnProvisionEnergia);
            this.Controls.Add(this.btnControlEnergia);
            this.Controls.Add(this.btnBancos);
            this.Controls.Add(this.btnCompGen);
            this.Controls.Add(this.btnFunciones);
            this.Controls.Add(this.btnPerfilesUsuario);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.imgMenu);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMenu;
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
        private Label btnFunciones;
        private TextBox btnCompGen;
        private TextBox btnBancos;
        private Label btnControlEnergia;
        private Label btnProvisionEnergia;
        private Label btnConversionEnergia;
        private Label btnBancosBateria;
        private Label lblTitulo;
        private Label btnMenu;
    }
}
