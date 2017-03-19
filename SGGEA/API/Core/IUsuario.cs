using SGGEA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core
{
    public interface IUsuario
    {
        User AgregarUsuario(string username, string password, string nombre,
            string apellido, string email, string planta, string ubicacionFisica,
            string departamento, string cargo, string perfilUsuario);

        void EliminarUsuario(string username);

        void ModificarUsuario(string username, string password, string nombre,
            string apellido, string email, string planta, string ubicacionFisica,
            string departamento, string cargo, string perfilUsuario);

        List<SGGEA.User> ObtenerUsuarios();
    }
}