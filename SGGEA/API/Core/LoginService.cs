using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGGEA
{
    public class LoginService : ILogin
    {
        private IPersistencia _persistencia;

        public LoginService()
        {
            _persistencia = new PersistenciaService();

        }

        public bool ValidarLogin(string username, string password)
        {
            List<User> users = _persistencia.ObtenerUsuarios();

            foreach(User u in users)
            {
                if (username.Equals(u.Username))
                    if (password.Equals(u.Password))
                        return true;
            }

            return false;
        }
    }
}
