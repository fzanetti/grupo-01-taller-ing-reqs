using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Dominio;

namespace API.Controladores
{
    public interface ILogin
    {
        bool ValidarLogin(string username, string password);
        
        void Inicializar();

        bool UsuarioPuedeAcceder(Funcion funcion);

    }
}
