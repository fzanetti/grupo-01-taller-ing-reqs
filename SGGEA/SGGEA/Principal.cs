using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGGEA
{
    public partial class Principal : UserControl
    {
        private bool menuActivo = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void btnAdminUsu_MouseEnter(object sender, EventArgs e)
        {
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuariosHover;
        }

        private void btnAdminUsu_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuarios;
        }

        private void btnAdminUsu_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = Color.FromArgb(250, 250, 250);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnMenu;
            this.imgMenu.Visible = false;
            this.btnPerfilesUsuario.Visible = false;
            this.btnLogout.Visible = false;
            menuActivo = false;
            showLogoutConfirmation(true);
        }

        private void btnPerfilesUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.btnPerfilesUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnPerfilesUsuario.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnPerfilesUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = Color.FromArgb(250, 250, 250);
            this.btnPerfilesUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnPerfilesUsuario_Click(object sender, EventArgs e)
        {
            this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnMenu;
            this.imgMenu.Visible = false;
            this.btnPerfilesUsuario.Visible = false;
            this.btnLogout.Visible = false;
            menuActivo = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!menuActivo)
            {
                this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnAtras;
                this.imgMenu.Visible = true;
                this.btnPerfilesUsuario.Visible = true;
                this.btnLogout.Visible = true;
            }
            else
            {
                this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnMenu;
                this.imgMenu.Visible = false;
                this.btnPerfilesUsuario.Visible = false;
                this.btnLogout.Visible = false;
            }
            menuActivo = !menuActivo;
        }

        private void btnConfirmarLogout_Click(object sender, EventArgs e)
        {
            showLogoutConfirmation(false);
            FormPrincipal.getInstancia().InitializeLogin();
        }

        private void btnCancelarLogout_Click(object sender, EventArgs e)
        {
            showLogoutConfirmation(false);
        }

    }
}
