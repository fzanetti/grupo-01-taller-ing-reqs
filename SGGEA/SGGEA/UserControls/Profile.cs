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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        [Description("Nombre del Perfil"), Category("Nombre")]
        public string Nombre
        {
            get { return lblPerfil.Text; }
            set { lblPerfil.Text = value; }
        }

        private void EditarPerfil()
        {
            FormPrincipal.getInstancia().InitializeModifPerfil(Nombre);
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            EditarPerfil();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditarPerfil();
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(204, 223, 233);
            lblPerfil.BackColor = Color.FromArgb(204, 223, 233);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(250, 250, 250);
            lblPerfil.BackColor = Color.FromArgb(250, 250, 250);
        }
    }
}
