using API.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Persistencia
{
    interface IPersistencia
    {
        List<Usuario> ObtenerUsuarios();
        List<Perfil> ObtenerPerfiles();
        Usuario ObtenerUsuario(string username);

        void AgregarUsuario(Usuario user);

        void ModificarUsuario(Usuario user);

        void BajaUsuario(Usuario user);


    }
}
