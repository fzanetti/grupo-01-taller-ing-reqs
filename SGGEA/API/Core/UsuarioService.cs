using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGGEA;

namespace API.Core
{
    public class UsuarioService : IUsuario
    {
        IPersistencia _persistenciaService = new PersistenciaService();

        public void EliminarUsuario(string username)
        {
            throw new NotImplementedException();
        }

        public void ModificarUsuario(string username, string password, string nombre, string apellido, string email, string planta, string ubicacionFisica, string departamento, string cargo, string perfilUsuario)
        {
            throw new NotImplementedException();
        }

        public List<User> ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }

        User IUsuario.AgregarUsuario(string username, string password, string nombre, string apellido, string email, string planta, string ubicacionFisica, string departamento, string cargo, string perfilUsuario)
        {
            User user = new SGGEA.User();

            user.Username = username;
            user.Password = password;
            user.Nombre = nombre;
            user.Apellido = apellido;
            user.Email = email;
            user.Planta = planta;
            user.UbicacionFisica = ubicacionFisica;
            user.Departamento = departamento;
            user.Cargo = cargo;
            user.PerfilUsuario = perfilUsuario;

            _persistenciaService.AgregarUsuario(user);

            return user;
        }
    }
}
