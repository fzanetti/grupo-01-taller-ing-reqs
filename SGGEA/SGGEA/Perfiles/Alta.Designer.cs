namespace SGGEA.Perfiles
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
            this.lblTituloFunciones = new System.Windows.Forms.Label();
            this.flowLayoutFunciones = new System.Windows.Forms.FlowLayoutPanel();
            this.lblErrorFunciones = new SGGEA.UserControls.LabelError();
            this.btnCrear = new SGGEA.UserControls.CustomButton();
            this.campoNombre = new SGGEA.UserControls.CustomTextBox();
            this.toast = new SGGEA.UserControls.Toast();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Image = global::SGGEA.Properties.Resources.btnAtras;
            this.btnAtras.Location = new System.Drawing.Point(27, 99);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(24, 24);
            this.btnAtras.TabIndex = 29;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.lblTitulo.Location = new System.Drawing.Point(55, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 29);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Alta de perfil de usuario";
            // 
            // lblTituloFunciones
            // 
            this.lblTituloFunciones.AutoSize = true;
            this.lblTituloFunciones.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFunciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFunciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTituloFunciones.Location = new System.Drawing.Point(46, 198);
            this.lblTituloFunciones.Name = "lblTituloFunciones";
            this.lblTituloFunciones.Size = new System.Drawing.Size(80, 18);
            this.lblTituloFunciones.TabIndex = 32;
            this.lblTituloFunciones.Text = "Funciones";
            // 
            // flowLayoutFunciones
            // 
            this.flowLayoutFunciones.AutoScroll = true;
            this.flowLayoutFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.flowLayoutFunciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutFunciones.Location = new System.Drawing.Point(55, 241);
            this.flowLayoutFunciones.Name = "flowLayoutFunciones";
            this.flowLayoutFunciones.Size = new System.Drawing.Size(300, 314);
            this.flowLayoutFunciones.TabIndex = 33;
            this.flowLayoutFunciones.WrapContents = false;
            // 
            // lblErrorFunciones
            // 
            this.lblErrorFunciones.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorFunciones.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFunciones.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFunciones.Location = new System.Drawing.Point(55, 574);
            this.lblErrorFunciones.Name = "lblErrorFunciones";
            this.lblErrorFunciones.Size = new System.Drawing.Size(300, 23);
            this.lblErrorFunciones.TabIndex = 34;
            this.lblErrorFunciones.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(76, 602);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(253, 36);
            this.btnCrear.TabIndex = 31;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            this.campoNombre.Location = new System.Drawing.Point(76, 147);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(244, 45);
            this.campoNombre.TabIndex = 0;
            this.campoNombre.TextoCampo = "";
            this.campoNombre.TextoError = "";
            this.campoNombre.TituloCampo = "Nombre del perfil";
            // 
            // toast
            // 
            this.toast.BackColor = System.Drawing.Color.Transparent;
            this.toast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toast.BackgroundImage")));
            this.toast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toast.Location = new System.Drawing.Point(48, 329);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(307, 59);
            this.toast.TabIndex = 35;
            this.toast.Visible = false;
            // 
            // Alta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoAltaPerfil;
            this.Controls.Add(this.toast);
            this.Controls.Add(this.lblErrorFunciones);
            this.Controls.Add(this.flowLayoutFunciones);
            this.Controls.Add(this.lblTituloFunciones);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Alta";
            this.Size = new System.Drawing.Size(404, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnAtras;
        private System.Windows.Forms.Label lblTitulo;
        private UserControls.CustomTextBox campoNombre;
        private UserControls.CustomButton btnCrear;
        private System.Windows.Forms.Label lblTituloFunciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFunciones;
        private UserControls.LabelError lblErrorFunciones;
        private UserControls.Toast toast;
    }
}
