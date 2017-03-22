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
        //Usuarios
        List<Usuario> ObtenerUsuarios();
    
        Usuario ObtenerUsuario(string username);

        void AgregarUsuario(Usuario user);

        void ModificarUsuario(Usuario user);

        void BajaUsuario(Usuario user);

        //Perfiles
        List<Perfil> ObtenerPerfiles();

        Perfil ObtenerPerfil(string nombrePerfil);

        void AgregarPerfil(Perfil perfil);

        void ModificarPerfil(Perfil perfil);

        void BajaPerfil(Perfil perfil);
    }
}
