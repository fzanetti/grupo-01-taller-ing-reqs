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

        ///<summary>
        ///<para>Da de alta un nuevo usuario. Si el username ya esta registrado devuelve false en caso contrario devuelve true.</para>
        ///</summary>
        public static bool AltaUsuario(Usuario usuario)
        {
            return false;
        }
    }
}
