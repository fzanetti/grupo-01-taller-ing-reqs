namespace SGGEA.Perfiles
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
            this.lblTituloFunciones = new System.Windows.Forms.Label();
            this.flowLayoutFunciones = new System.Windows.Forms.FlowLayoutPanel();
            this.toast = new SGGEA.UserControls.Toast();
            this.confirmBaja = new SGGEA.UserControls.ConfirmationDialog();
            this.lblErrorFunciones = new SGGEA.UserControls.LabelError();
            this.btnEliminar = new SGGEA.UserControls.CustomButton();
            this.btnModificar = new SGGEA.UserControls.CustomButton();
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
            this.lblTitulo.Size = new System.Drawing.Size(0, 29);
            this.lblTitulo.TabIndex = 28;
            // 
            // lblTituloFunciones
            // 
            this.lblTituloFunciones.AutoSize = true;
            this.lblTituloFunciones.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFunciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFunciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTituloFunciones.Location = new System.Drawing.Point(46, 150);
            this.lblTituloFunciones.Name = "lblTituloFunciones";
            this.lblTituloFunciones.Size = new System.Drawing.Size(80, 18);
            this.lblTituloFunciones.TabIndex = 33;
            this.lblTituloFunciones.Text = "Funciones";
            // 
            // flowLayoutFunciones
            // 
            this.flowLayoutFunciones.AutoScroll = true;
            this.flowLayoutFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.flowLayoutFunciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutFunciones.Location = new System.Drawing.Point(54, 193);
            this.flowLayoutFunciones.Name = "flowLayoutFunciones";
            this.flowLayoutFunciones.Size = new System.Drawing.Size(300, 378);
            this.flowLayoutFunciones.TabIndex = 34;
            this.flowLayoutFunciones.WrapContents = false;
            // 
            // toast
            // 
            this.toast.BackColor = System.Drawing.Color.Transparent;
            this.toast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toast.BackgroundImage")));
            this.toast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toast.Location = new System.Drawing.Point(48, 329);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(307, 59);
            this.toast.TabIndex = 36;
            this.toast.Visible = false;
            // 
            // confirmBaja
            // 
            this.confirmBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.confirmBaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBaja.BackgroundImage")));
            this.confirmBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBaja.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBaja.Location = new System.Drawing.Point(48, 281);
            this.confirmBaja.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.confirmBaja.Name = "confirmBaja";
            this.confirmBaja.PosicionBtnAceptar = System.Windows.Forms.DockStyle.Left;
            this.confirmBaja.PosicionBtnCancelar = System.Windows.Forms.DockStyle.Right;
            this.confirmBaja.Size = new System.Drawing.Size(283, 161);
            this.confirmBaja.TabIndex = 38;
            this.confirmBaja.TextoAceptar = "Aceptar";
            this.confirmBaja.TextoCancelar = "Cancelar";
            this.confirmBaja.TextoMensaje = "";
            this.confirmBaja.Visible = false;
            // 
            // lblErrorFunciones
            // 
            this.lblErrorFunciones.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorFunciones.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFunciones.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFunciones.Location = new System.Drawing.Point(54, 580);
            this.lblErrorFunciones.Name = "lblErrorFunciones";
            this.lblErrorFunciones.Size = new System.Drawing.Size(300, 23);
            this.lblErrorFunciones.TabIndex = 37;
            this.lblErrorFunciones.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(76, 612);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 36);
            this.btnEliminar.TabIndex = 31;
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
            this.btnModificar.Location = new System.Drawing.Point(222, 612);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 36);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ModificacionBaja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGGEA.Properties.Resources.fondoModifPerfil;
            this.Controls.Add(this.toast);
            this.Controls.Add(this.confirmBaja);
            this.Controls.Add(this.lblErrorFunciones);
            this.Controls.Add(this.flowLayoutFunciones);
            this.Controls.Add(this.lblTituloFunciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModificacionBaja";
            this.Size = new System.Drawing.Size(404, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnAtras;
        private System.Windows.Forms.Label lblTitulo;
        private UserControls.CustomButton btnEliminar;
        private UserControls.CustomButton btnModificar;
        private System.Windows.Forms.Label lblTituloFunciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFunciones;
        private UserControls.Toast toast;
        private UserControls.LabelError lblErrorFunciones;
        private UserControls.ConfirmationDialog confirmBaja;
    }
}
