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

        public static bool AltaUsuario(Usuario usuario)
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                persistencia.AgregarUsuario(usuario);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static bool ExisteUsuario(string username)
        {
            try
            {
                foreach (Usuario u in Usuarios.ObtenerUsuarios())
                {
                    if (u.Username.Equals(username))
                        return true;
                }
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public static bool ModificarUsuario(Usuario user)
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                persistencia.ModificarUsuario(user);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static bool EliminarUsuario(Usuario user)
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                persistencia.BajaUsuario(user);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
