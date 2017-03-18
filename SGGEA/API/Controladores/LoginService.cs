using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Dominio;
using API.Persistencia;
using API.Controladores;

namespace API.Controladores
{
    public class LoginService : ILogin
    {
        private IPersistencia _persistencia;
        private Usuario _usuarioLogueado;
        private static LoginService singleton;

        private LoginService()
        {
            _persistencia = new PersistenciaService();
        }

        public static ILogin getInstancia()
        {
            if (singleton == null)
                singleton = new LoginService();
            return singleton;
        }

        public bool ValidarLogin(string username, string password)
        {
            List<Usuario> users = _persistencia.ObtenerUsuarios();

            foreach (Usuario user in users)
            {
                if (username.Equals(user.Username) && password.Equals(user.Password))
                {
                    _usuarioLogueado = user;
                    return true;
                }
            }

            return false;
        }

        public bool UsuarioPuedeAcceder(Funcion function)
        {
            return Usuarios.PuedeAcceder(_usuarioLogueado, function);
        }


    }
}
