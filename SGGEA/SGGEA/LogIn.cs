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
using API.Dominio;

namespace SGGEA
{
    public partial class Login : UserControl
    {

        private ILogin _login;
        
        public Login()
        {
            InitializeComponent();
            campoPassword.setKeyPressEvent(campoPassword_KeyPress);
            _login = LoginService.getInstancia();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            if (String.IsNullOrEmpty(campoUsername.TextoCampo))
            {
                campoPassword.TextoError=Globals.ErrorLogin;
            }
            else if (String.IsNullOrEmpty(campoPassword.TextoCampo))
            {
                campoPassword.TextoError = Globals.ErrorLogin;
            }
            else if (!_login.ValidarLogin(campoUsername.TextoCampo, campoPassword.TextoCampo))
            {
                campoPassword.TextoError = Globals.ErrorLogin;
            }
            else
            {
                FormPrincipal.getInstancia().InitializePrincipal();
            }
        }

        private void campoPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DoLogin();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Username="usuario1";

            API.Controladores.Usuarios.EliminarUsuario(u);

        }
    }
}
