using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGGEA.UserControls
{
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        [Description("Nombre de usuario"), Category("NombreUsuario")]
        public string NombreUsuario
        {
            get { return lblUsername.Text; }
            set { lblUsername.Text = value; }
        }

        [Description("Nombre y Apellido"), Category("NombreApellido")]
        public string NombreApellido
        {
            get { return lblNombreCompleto.Text; }
            set { lblNombreCompleto.Text = value; }
        }

        [Description("Email"), Category("Email")]
        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void lblNombreCompleto_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        private void EditarUsuario()
        {
            FormPrincipal.getInstancia().InitializeModifUsuario(NombreUsuario);
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            this.btnUsuario.BackgroundImage = global::SGGEA.Properties.Resources.fondoUsuarioHover;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(204, 223, 233);
            this.lblNombreCompleto.BackColor = System.Drawing.Color.FromArgb(204, 223, 233);
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(204, 223, 233);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            this.btnUsuario.BackgroundImage = global::SGGEA.Properties.Resources.fondoUsuario;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.lblNombreCompleto.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        }

    }
}
