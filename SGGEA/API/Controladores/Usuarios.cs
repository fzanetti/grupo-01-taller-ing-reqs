using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Dominio;

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
    }
}
