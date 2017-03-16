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

        private void Principal_MouseEnter(object sender, EventArgs e)
        {
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuariosHover;
        }

        private void Principal_MouseLeave(object sender, EventArgs e)
        {
            this.btnAdminUsu.BackgroundImage = global::SGGEA.Properties.Resources.adminUsuarios;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnPerfilesUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.btnPerfilesUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnPerfilesUsuario.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnPerfilesUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.btnPerfilesUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerfilesUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnPerfilesUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!menuActivo)
            {
                this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnAtras;
                this.imgMenu.Visible = true;
                this.btnPerfilesUsuario.Visible = true;
                this.btnLogout.Visible = true;
                menuActivo = true;
                //this.Invalidate();
                //this.Refresh();

            }
            else
            {
                menuActivo = false;
                this.btnMenu.BackgroundImage = global::SGGEA.Properties.Resources.btnMenu;
                this.imgMenu.Visible = false;
                this.btnPerfilesUsuario.Visible = false;
                this.btnLogout.Visible = false;
                this.Invalidate();
                this.Refresh();
            }
          
        }
    }
}
