using API.Dominio;
using API.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controladores
{
    public class Perfiles
    {
        public static List<Perfil> ObtenerPerfiles()
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                return persistencia.ObtenerPerfiles();
            }
            catch (Exception ex)
            {

            }
            return new List<Perfil>();
        }
    }
}
