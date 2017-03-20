using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Dominio;
using API.Persistencia;

namespace API.Controladores
{
    public class Usuarios
    {
        public static bool PuedeAcceder(Usuario usuario,Funcion funcion)
        {
            foreach (Perfil perfil in usuario.Perfiles)
            {
                if (perfil.Funciones.Contains(funcion))
                    return true;
            }
            return false;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
             IPersistencia persistencia = new PersistenciaService();
             return persistencia.ObtenerUsuarios();
        }

        public static Usuario ObtenerUsuario(string username)
        {
            IPersistencia persistencia = new PersistenciaService();
            return persistencia.ObtenerUsuario(username);
        }

        public static Usuario AgregarUsuario(string username, string password, string nombre, string apellido, string email, string planta, string ubicacionFisica, string departamento, string cargo, List<Perfil> perfiles)
        {
            IPersistencia persistencia = new PersistenciaService();
            Usuario usuario = new Dominio.Usuario();

            usuario.Username = username;
            usuario.Password = password;
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Email = email;
            usuario.Planta = planta;
            usuario.UbicacionFisica = ubicacionFisica;
            usuario.Departamento = departamento;
            usuario.Cargo = cargo;
            usuario.Perfiles = perfiles;

            persistencia.AgregarUsuario(usuario);

            return usuario;
        }

        public static bool ExisteUsuario(string username)
        {
            foreach(Usuario u in Usuarios.ObtenerUsuarios())
            {
                if (u.Username.Equals(username))
                    return true;
            }

            return false;
        }

        public static void ModificarUsuario(Usuario user)
        {
            IPersistencia persistencia = new PersistenciaService();
            persistencia.ModificarUsuario(user);

        }

        public static void EliminarUsuario(Usuario user)
        {
            IPersistencia persistencia = new PersistenciaService();
            persistencia.BajaUsuario(user);
        }
    }
}
