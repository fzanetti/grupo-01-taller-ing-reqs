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
    public partial class Login : UserControl
    {

        public Login()
        {
            InitializeComponent();
            lblError.Text = Globals.ErrorLogin;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Validar

            //Si da error la validación:
            //lblError.Visible = true;
            FormPrincipal.getInstancia().InitializePrincipal();
        }

        private void tbContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbContrasenia.UseSystemPasswordChar = true;
        }
    }
}
