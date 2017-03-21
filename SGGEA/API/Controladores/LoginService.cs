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
        private List<Usuario> _usuarios;
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

        public void Inicializar()
        {
            try
            {
                _usuarios = _persistencia.ObtenerUsuarios();
            }
            catch (Exception ex)
            {

            }
        }

        public bool ValidarLogin(string username, string password)
        {
            try
            {
                foreach (Usuario user in _usuarios)
                {
                    if (username.Equals(user.Username) && password.Equals(user.Password))
                    {
                        _usuarioLogueado = user;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public bool UsuarioPuedeAcceder(Funcion function)
        {
            return Usuarios.PuedeAcceder(_usuarioLogueado, function);
        }


    }
}
