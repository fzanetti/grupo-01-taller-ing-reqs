using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Controladores;



namespace SGGEA
{
    public partial class Login : UserControl
    {

        private ILogin _login;
        
        public Login()
        {
            InitializeComponent();
            _login = LoginService.getInstancia();
            lblError.Text = Globals.ErrorLogin;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            if (String.IsNullOrEmpty(tbUsuario.Text))
            {
                lblError.Visible = true;
            }
            else if (String.IsNullOrEmpty(tbContrasenia.Text))
            {
                lblError.Visible = true;
            }
            else if (!_login.ValidarLogin(tbUsuario.Text, tbContrasenia.Text))
            {
                lblError.Visible = true;
            }
            else
            {
                FormPrincipal.getInstancia().InitializePrincipal();
            }
        }

        private void tbContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblContrasenia.Visible = false;
            if (e.KeyChar == (char)13)
            {
                DoLogin();
            }
        }

        private void lblContrasenia_Click(object sender, EventArgs e)
        {
            this.ActiveControl = tbContrasenia;
        }

     
    }
}
