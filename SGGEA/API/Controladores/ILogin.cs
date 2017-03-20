﻿using System;
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

        ///<summary>
        ///<para>Devuelve true si el usuario logueado puede acceder a una funcionalidad dada.</para>
        ///</summary
        bool UsuarioPuedeAcceder(Funcion funcion);

    }
}
