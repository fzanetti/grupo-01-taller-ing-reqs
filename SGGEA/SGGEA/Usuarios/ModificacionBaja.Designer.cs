using System.ComponentModel;
namespace SGGEA.Usuarios
{
    partial class ModificacionBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionBaja));
            this.btnAtras = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPlanta = new System.Windows.Forms.Label();
            this.lblUbicaion = new System.Windows.Forms.Label();
            this.lblDto = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.campoCargo = new SGGEA.UserControls.CustomTextBox();
            this.campoDto = new SGGEA.UserControls.CustomTextBox();
            this.campoUbicacion = new SGGEA.UserControls.CustomTextBox();
            this.campoPlanta = new SGGEA.UserControls.CustomTextBox();
            this.campoEmail = new SGGEA.UserControls.CustomTextBox();
            this.lblErrorPerfiles = new SGGEA.UserControls.LabelError();
            this.campoApellido = new SGGEA.UserControls.CustomTextBox();
            this.campoNombre = new SGGEA.UserControls.CustomTextBox();
            this.campoPassword = new SGGEA.UserControls.CustomTextBox();
            this.btnEliminar = new SGGEA.UserControls.CustomButton();
            this.btnModificar = new SGGEA.UserControls.CustomButton();
            this.btnSelPerfiles = new SGGEA.UserControls.CustomButton();
            this.panelPerfiles = new System.Windows.Forms.Panel();
            this.flowLayoutPerfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptarPerfiles = new SGGEA.UserControls.CustomButton();
            this.confirmBaja = new SGGEA.UserControls.ConfirmationDialog();
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
            this.btnAtras.TabIndex = 25;
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
            this.lblTitulo.Size = new System.Drawing.Size(203, 29);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblPassword.Location = new System.Drawing.Point(73, 139);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 14);
            this.lblPassword.TabIndex = 30;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblNombre.Location = new System.Drawing.Point(73, 191);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 14);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblApellido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblApellido.Location = new System.Drawing.Point(73, 243);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(45, 14);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblEmail.Location = new System.Drawing.Point(73, 295);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 14);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // lblPlanta
            // 
            this.lblPlanta.AutoSize = true;
            this.lblPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblPlanta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblPlanta.Location = new System.Drawing.Point(73, 347);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(36, 14);
            this.lblPlanta.TabIndex = 40;
            this.lblPlanta.Text = "Planta";
            // 
            // lblUbicaion
            // 
            this.lblUbicaion.AutoSize = true;
            this.lblUbicaion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblUbicaion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicaion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUbicaion.Location = new System.Drawing.Point(73, 399);
            this.lblUbicaion.Name = "lblUbicaion";
            this.lblUbicaion.Size = new System.Drawing.Size(85, 14);
            this.lblUbicaion.TabIndex = 42;
            this.lblUbicaion.Text = "Ubicación Física";
            // 
            // lblDto
            // 
            this.lblDto.AutoSize = true;
            this.lblDto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblDto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblDto.Location = new System.Drawing.Point(73, 451);
            this.lblDto.Name = "lblDto";
            this.lblDto.Size = new System.Drawing.Size(74, 14);
            this.lblDto.TabIndex = 44;
            this.lblDto.Text = "Departamento";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblCargo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCargo.Location = new System.Drawing.Point(73, 503);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(36, 14);
            this.lblCargo.TabIndex = 46;
            this.lblCargo.Text = "Cargo";
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
            this.campoCargo.Location = new System.Drawing.Point(75, 515);
            this.campoCargo.Name = "campoCargo";
            this.campoCargo.Size = new System.Drawing.Size(256, 45);
            this.campoCargo.TabIndex = 45;
            this.campoCargo.TextoCampo = "";
            this.campoCargo.TextoError = "";
            this.campoCargo.TituloCampo = "";
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
            this.campoDto.Location = new System.Drawing.Point(75, 463);
            this.campoDto.Name = "campoDto";
            this.campoDto.Size = new System.Drawing.Size(256, 45);
            this.campoDto.TabIndex = 43;
            this.campoDto.TextoCampo = "";
            this.campoDto.TextoError = "";
            this.campoDto.TituloCampo = "";
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
            this.campoUbicacion.Location = new System.Drawing.Point(75, 411);
            this.campoUbicacion.Name = "campoUbicacion";
            this.campoUbicacion.Size = new System.Drawing.Size(256, 45);
            this.campoUbicacion.TabIndex = 41;
            this.campoUbicacion.TextoCampo = "";
            this.campoUbicacion.TextoError = "";
            this.campoUbicacion.TituloCampo = "";
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
            this.campoPlanta.Location = new System.Drawing.Point(75, 359);
            this.campoPlanta.Name = "campoPlanta";
            this.campoPlanta.Size = new System.Drawing.Size(256, 45);
            this.campoPlanta.TabIndex = 39;
            this.campoPlanta.TextoCampo = "";
            this.campoPlanta.TextoError = "";
            this.campoPlanta.TituloCampo = "";
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
            this.campoEmail.Location = new System.Drawing.Point(75, 307);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(256, 45);
            this.campoEmail.TabIndex = 37;
            this.campoEmail.TextoCampo = "";
            this.campoEmail.TextoError = "";
            this.campoEmail.TituloCampo = "";
            // 
            // lblErrorPerfiles
            // 
            this.lblErrorPerfiles.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPerfiles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPerfiles.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPerfiles.Location = new System.Drawing.Point(74, 596);
            this.lblErrorPerfiles.Name = "lblErrorPerfiles";
            this.lblErrorPerfiles.Size = new System.Drawing.Size(254, 16);
            this.lblErrorPerfiles.TabIndex = 36;
            this.lblErrorPerfiles.Visible = false;
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
            this.campoApellido.Location = new System.Drawing.Point(75, 255);
            this.campoApellido.Name = "campoApellido";
            this.campoApellido.Size = new System.Drawing.Size(256, 45);
            this.campoApellido.TabIndex = 3;
            this.campoApellido.TextoCampo = "";
            this.campoApellido.TextoError = "";
            this.campoApellido.TituloCampo = "";
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
            this.campoNombre.Location = new System.Drawing.Point(75, 203);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(256, 45);
            this.campoNombre.TabIndex = 2;
            this.campoNombre.TextoCampo = "";
            this.campoNombre.TextoError = "";
            this.campoNombre.TituloCampo = "";
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
            this.campoPassword.Location = new System.Drawing.Point(75, 151);
            this.campoPassword.Name = "campoPassword";
            this.campoPassword.Size = new System.Drawing.Size(256, 45);
            this.campoPassword.TabIndex = 1;
            this.campoPassword.TextoCampo = "";
            this.campoPassword.TextoError = "";
            this.campoPassword.TituloCampo = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(74, 622);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 36);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(220, 622);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 36);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSelPerfiles
            // 
            this.btnSelPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnSelPerfiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelPerfiles.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPerfiles.ForeColor = System.Drawing.Color.White;
            this.btnSelPerfiles.Location = new System.Drawing.Point(74, 565);
            this.btnSelPerfiles.Name = "btnSelPerfiles";
            this.btnSelPerfiles.Size = new System.Drawing.Size(254, 30);
            this.btnSelPerfiles.TabIndex = 9;
            this.btnSelPerfiles.Text = "Seleccionar Perfiles";
            this.btnSelPerfiles.UseVisualStyleBackColor = true;
            this.btnSelPerfiles.Click += new System.EventHandler(this.btnSelPerfiles_Click);
            // 
            // panelPerfiles
            // 
            this.panelPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panelPerfiles.BackgroundImage = global::SGGEA.Properties.Resources.fondoSelPerfiles;
            this.panelPerfiles.Controls.Add(this.flowLayoutPerfiles);
            this.panelPerfiles.Controls.Add(this.btnAceptarPerfiles);
            this.panelPerfiles.Location = new System.Drawing.Point(54, 229);
            this.panelPerfiles.Name = "panelPerfiles";
            this.panelPerfiles.Size = new System.Drawing.Size(294, 258);
            this.panelPerfiles.TabIndex = 47;
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
            // confirmBaja
            // 
            this.confirmBaja.BackColor = System.Drawing.Color.Transparent;
            this.confirmBaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBaja.BackgroundImage")));
            this.confirmBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBaja.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBaja.Location = new System.Drawing.Point(49, 267);
            this.confirmBaja.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.confirmBaja.Name = "confirmBaja";
            this.confirmBaja.PosicionBtnAceptar = System.Windows.Forms.DockStyle.Left;
            this.confirmBaja.PosicionBtnCancelar = System.Windows.Forms.DockStyle.Right;
            this.confirmBaja.Size = new System.Drawing.Size(310, 181);
            this.confirmBaja.TabIndex = 48;
            this.confirmBaja.TextoAceptar = "Aceptar";
            this.confirmBaja.TextoCancelar = "Cancelar";
            this.confirmBaja.TextoMensaje = "¿Está seguro que desea dar de baja al usuario?";
            this.confirmBaja.Visible = false;
            // 
            // toast
            // 
            this.toast.BackColor = System.Drawing.Color.Transparent;
            this.toast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toast.BackgroundImage")));
            this.toast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toast.Location = new System.Drawing.Point(48, 329);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(307, 59);
            this.toast.TabIndex = 49;
            this.toast.Visible = false;
            // 
            // ModificacionBaja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoPantalla;
            this.Controls.Add(this.toast);
            this.Controls.Add(this.confirmBaja);
            this.Controls.Add(this.panelPerfiles);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.campoCargo);
            this.Controls.Add(this.lblDto);
            this.Controls.Add(this.campoDto);
            this.Controls.Add(this.lblUbicaion);
            this.Controls.Add(this.campoUbicacion);
            this.Controls.Add(this.lblPlanta);
            this.Controls.Add(this.campoPlanta);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.lblErrorPerfiles);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.campoApellido);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.campoPassword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSelPerfiles);
            this.Name = "ModificacionBaja";
            this.Size = new System.Drawing.Size(404, 800);
            this.panelPerfiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
   
        #endregion

        private System.Windows.Forms.Label btnAtras;
        private System.Windows.Forms.Label lblTitulo;
        private UserControls.CustomTextBox campoPassword;
        private UserControls.CustomTextBox campoNombre;
        private UserControls.CustomTextBox campoApellido;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private UserControls.CustomButton btnSelPerfiles;
        private UserControls.CustomButton btnModificar;
        private UserControls.CustomButton btnEliminar;
        private UserControls.LabelError lblErrorPerfiles;
        private System.Windows.Forms.Label lblEmail;
        private UserControls.CustomTextBox campoEmail;
        private System.Windows.Forms.Label lblPlanta;
        private UserControls.CustomTextBox campoPlanta;
        private System.Windows.Forms.Label lblUbicaion;
        private UserControls.CustomTextBox campoUbicacion;
        private System.Windows.Forms.Label lblDto;
        private UserControls.CustomTextBox campoDto;
        private System.Windows.Forms.Label lblCargo;
        private UserControls.CustomTextBox campoCargo;
        private System.Windows.Forms.Panel panelPerfiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPerfiles;
        private UserControls.CustomButton btnAceptarPerfiles;
        private UserControls.ConfirmationDialog confirmBaja;
        private UserControls.Toast toast;
    }
}
