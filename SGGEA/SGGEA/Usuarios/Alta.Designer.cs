using System.ComponentModel;
namespace SGGEA.Usuarios
{
    partial class Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta));
            this.btnAtras = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPerfiles = new System.Windows.Forms.Panel();
            this.flowLayoutPerfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptarPerfiles = new SGGEA.UserControls.CustomButton();
            this.lblErrorPerfiles = new SGGEA.UserControls.LabelError();
            this.campoPassword = new SGGEA.UserControls.CustomTextBox();
            this.campoCargo = new SGGEA.UserControls.CustomTextBox();
            this.campoDto = new SGGEA.UserControls.CustomTextBox();
            this.campoUbicacion = new SGGEA.UserControls.CustomTextBox();
            this.campoPlanta = new SGGEA.UserControls.CustomTextBox();
            this.campoEmail = new SGGEA.UserControls.CustomTextBox();
            this.campoApellido = new SGGEA.UserControls.CustomTextBox();
            this.campoNombre = new SGGEA.UserControls.CustomTextBox();
            this.campoUsername = new SGGEA.UserControls.CustomTextBox();
            this.btnSelPerfiles = new SGGEA.UserControls.CustomButton();
            this.btnCrear = new SGGEA.UserControls.CustomButton();
            this.toast = new SGGEA.UserControls.Toast();
            this.panelPerfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Image = global::SGGEA.Properties.Resources.btnAtras;
            this.btnAtras.Location = new System.Drawing.Point(27, 99);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(24, 24);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.lblTitulo.Location = new System.Drawing.Point(55, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 29);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Alta de usuario";
            // 
            // panelPerfiles
            // 
            this.panelPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panelPerfiles.BackgroundImage = global::SGGEA.Properties.Resources.fondoSelPerfiles;
            this.panelPerfiles.Controls.Add(this.flowLayoutPerfiles);
            this.panelPerfiles.Controls.Add(this.btnAceptarPerfiles);
            this.panelPerfiles.Location = new System.Drawing.Point(54, 219);
            this.panelPerfiles.Name = "panelPerfiles";
            this.panelPerfiles.Size = new System.Drawing.Size(294, 258);
            this.panelPerfiles.TabIndex = 25;
            this.panelPerfiles.Visible = false;
            // 
            // flowLayoutPerfiles
            // 
            this.flowLayoutPerfiles.AutoScroll = true;
            this.flowLayoutPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.flowLayoutPerfiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPerfiles.Location = new System.Drawing.Point(30, 55);
            this.flowLayoutPerfiles.Name = "flowLayoutPerfiles";
            this.flowLayoutPerfiles.Size = new System.Drawing.Size(236, 141);
            this.flowLayoutPerfiles.TabIndex = 0;
            this.flowLayoutPerfiles.WrapContents = false;
            // 
            // btnAceptarPerfiles
            // 
            this.btnAceptarPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnAceptarPerfiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAceptarPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPerfiles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarPerfiles.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPerfiles.Location = new System.Drawing.Point(101, 200);
            this.btnAceptarPerfiles.Name = "btnAceptarPerfiles";
            this.btnAceptarPerfiles.Size = new System.Drawing.Size(92, 33);
            this.btnAceptarPerfiles.TabIndex = 1;
            this.btnAceptarPerfiles.Text = "Aceptar";
            this.btnAceptarPerfiles.UseVisualStyleBackColor = true;
            this.btnAceptarPerfiles.Click += new System.EventHandler(this.btnAceptarPerfiles_Click);
            // 
            // lblErrorPerfiles
            // 
            this.lblErrorPerfiles.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPerfiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPerfiles.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPerfiles.Location = new System.Drawing.Point(74, 587);
            this.lblErrorPerfiles.Name = "lblErrorPerfiles";
            this.lblErrorPerfiles.Size = new System.Drawing.Size(254, 16);
            this.lblErrorPerfiles.TabIndex = 4;
            this.lblErrorPerfiles.Visible = false;
            // 
            // campoPassword
            // 
            this.campoPassword.AnchoCampo = 250;
            this.campoPassword.BackColor = System.Drawing.Color.Transparent;
            this.campoPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoPassword.BackgroundImage")));
            this.campoPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoPassword.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoPassword.EsPassword = true;
            this.campoPassword.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPassword.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPassword.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoPassword.Location = new System.Drawing.Point(75, 188);
            this.campoPassword.Name = "campoPassword";
            this.campoPassword.Size = new System.Drawing.Size(256, 45);
            this.campoPassword.TabIndex = 2;
            this.campoPassword.TextoCampo = "";
            this.campoPassword.TextoError = "";
            this.campoPassword.TituloCampo = "Contraseña";
            // 
            // campoCargo
            // 
            this.campoCargo.AnchoCampo = 250;
            this.campoCargo.BackColor = System.Drawing.Color.Transparent;
            this.campoCargo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoCargo.BackgroundImage")));
            this.campoCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoCargo.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoCargo.EsPassword = false;
            this.campoCargo.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCargo.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCargo.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoCargo.Location = new System.Drawing.Point(75, 502);
            this.campoCargo.Name = "campoCargo";
            this.campoCargo.Size = new System.Drawing.Size(256, 45);
            this.campoCargo.TabIndex = 9;
            this.campoCargo.TextoCampo = "";
            this.campoCargo.TextoError = "";
            this.campoCargo.TituloCampo = "Cargo";
            // 
            // campoDto
            // 
            this.campoDto.AnchoCampo = 250;
            this.campoDto.BackColor = System.Drawing.Color.Transparent;
            this.campoDto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoDto.BackgroundImage")));
            this.campoDto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoDto.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoDto.EsPassword = false;
            this.campoDto.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDto.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDto.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoDto.Location = new System.Drawing.Point(75, 457);
            this.campoDto.Name = "campoDto";
            this.campoDto.Size = new System.Drawing.Size(256, 45);
            this.campoDto.TabIndex = 8;
            this.campoDto.TextoCampo = "";
            this.campoDto.TextoError = "";
            this.campoDto.TituloCampo = "Departamento";
            // 
            // campoUbicacion
            // 
            this.campoUbicacion.AnchoCampo = 250;
            this.campoUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.campoUbicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoUbicacion.BackgroundImage")));
            this.campoUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoUbicacion.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoUbicacion.EsPassword = false;
            this.campoUbicacion.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUbicacion.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUbicacion.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoUbicacion.Location = new System.Drawing.Point(75, 412);
            this.campoUbicacion.Name = "campoUbicacion";
            this.campoUbicacion.Size = new System.Drawing.Size(256, 45);
            this.campoUbicacion.TabIndex = 7;
            this.campoUbicacion.TextoCampo = "";
            this.campoUbicacion.TextoError = "";
            this.campoUbicacion.TituloCampo = "Ubicación física";
            // 
            // campoPlanta
            // 
            this.campoPlanta.AnchoCampo = 250;
            this.campoPlanta.BackColor = System.Drawing.Color.Transparent;
            this.campoPlanta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoPlanta.BackgroundImage")));
            this.campoPlanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoPlanta.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoPlanta.EsPassword = false;
            this.campoPlanta.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPlanta.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPlanta.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoPlanta.Location = new System.Drawing.Point(75, 367);
            this.campoPlanta.Name = "campoPlanta";
            this.campoPlanta.Size = new System.Drawing.Size(256, 45);
            this.campoPlanta.TabIndex = 6;
            this.campoPlanta.TextoCampo = "";
            this.campoPlanta.TextoError = "";
            this.campoPlanta.TituloCampo = "Planta";
            // 
            // campoEmail
            // 
            this.campoEmail.AnchoCampo = 250;
            this.campoEmail.BackColor = System.Drawing.Color.Transparent;
            this.campoEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoEmail.BackgroundImage")));
            this.campoEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoEmail.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoEmail.EsPassword = false;
            this.campoEmail.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoEmail.Location = new System.Drawing.Point(75, 323);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(256, 45);
            this.campoEmail.TabIndex = 5;
            this.campoEmail.TextoCampo = "";
            this.campoEmail.TextoError = "";
            this.campoEmail.TituloCampo = "Email";
            // 
            // campoApellido
            // 
            this.campoApellido.AnchoCampo = 250;
            this.campoApellido.BackColor = System.Drawing.Color.Transparent;
            this.campoApellido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoApellido.BackgroundImage")));
            this.campoApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoApellido.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoApellido.EsPassword = false;
            this.campoApellido.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoApellido.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoApellido.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoApellido.Location = new System.Drawing.Point(75, 278);
            this.campoApellido.Name = "campoApellido";
            this.campoApellido.Size = new System.Drawing.Size(256, 45);
            this.campoApellido.TabIndex = 4;
            this.campoApellido.TextoCampo = "";
            this.campoApellido.TextoError = "";
            this.campoApellido.TituloCampo = "Apellido";
            // 
            // campoNombre
            // 
            this.campoNombre.AnchoCampo = 250;
            this.campoNombre.BackColor = System.Drawing.Color.Transparent;
            this.campoNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoNombre.BackgroundImage")));
            this.campoNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoNombre.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoNombre.EsPassword = false;
            this.campoNombre.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNombre.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNombre.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoNombre.Location = new System.Drawing.Point(75, 233);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(256, 45);
            this.campoNombre.TabIndex = 3;
            this.campoNombre.TextoCampo = "";
            this.campoNombre.TextoError = "";
            this.campoNombre.TituloCampo = "Nombre";
            // 
            // campoUsername
            // 
            this.campoUsername.AnchoCampo = 250;
            this.campoUsername.BackColor = System.Drawing.Color.Transparent;
            this.campoUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campoUsername.BackgroundImage")));
            this.campoUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campoUsername.ColorDeFondo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.campoUsername.EsPassword = false;
            this.campoUsername.FontCampo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsername.FontError = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoUsername.FontTitulo = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic);
            this.campoUsername.Location = new System.Drawing.Point(75, 143);
            this.campoUsername.Name = "campoUsername";
            this.campoUsername.Size = new System.Drawing.Size(256, 45);
            this.campoUsername.TabIndex = 1;
            this.campoUsername.TextoCampo = "";
            this.campoUsername.TextoError = "";
            this.campoUsername.TituloCampo = "Nombre de usuario";
            // 
            // btnSelPerfiles
            // 
            this.btnSelPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnSelPerfiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelPerfiles.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPerfiles.ForeColor = System.Drawing.Color.White;
            this.btnSelPerfiles.Location = new System.Drawing.Point(74, 553);
            this.btnSelPerfiles.Name = "btnSelPerfiles";
            this.btnSelPerfiles.Size = new System.Drawing.Size(254, 30);
            this.btnSelPerfiles.TabIndex = 10;
            this.btnSelPerfiles.Text = "Seleccionar Perfiles";
            this.btnSelPerfiles.UseVisualStyleBackColor = true;
            this.btnSelPerfiles.Click += new System.EventHandler(this.btnSelPerfiles_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(74, 612);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(254, 36);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // toast
            // 
            this.toast.BackColor = System.Drawing.Color.Transparent;
            this.toast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toast.BackgroundImage")));
            this.toast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toast.Location = new System.Drawing.Point(48, 329);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(307, 59);
            this.toast.TabIndex = 26;
            this.toast.Visible = false;
            // 
            // Alta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoPantalla;
            this.Controls.Add(this.toast);
            this.Controls.Add(this.panelPerfiles);
            this.Controls.Add(this.lblErrorPerfiles);
            this.Controls.Add(this.campoPassword);
            this.Controls.Add(this.campoCargo);
            this.Controls.Add(this.campoDto);
            this.Controls.Add(this.campoUbicacion);
            this.Controls.Add(this.campoPlanta);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoApellido);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.campoUsername);
            this.Controls.Add(this.btnSelPerfiles);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Alta";
            this.Size = new System.Drawing.Size(404, 800);
            this.panelPerfiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label btnAtras;
        private System.Windows.Forms.Label lblTitulo;
        private UserControls.CustomButton btnCrear;
        private UserControls.CustomButton btnSelPerfiles;
        private UserControls.CustomTextBox campoUsername;
        private UserControls.CustomTextBox campoNombre;
        private UserControls.CustomTextBox campoApellido;
        private UserControls.CustomTextBox campoEmail;
        private UserControls.CustomTextBox campoPlanta;
        private UserControls.CustomTextBox campoUbicacion;
        private UserControls.CustomTextBox campoDto;
        private UserControls.CustomTextBox campoCargo;
        private UserControls.CustomTextBox campoPassword;
        private UserControls.LabelError lblErrorPerfiles;
        private System.Windows.Forms.Panel panelPerfiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPerfiles;
        private UserControls.CustomButton btnAceptarPerfiles;
        private UserControls.Toast toast;
    }
}
