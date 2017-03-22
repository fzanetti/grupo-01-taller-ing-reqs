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

        public static Perfil ObtenerPerfil(string nombrePerfil)
        {
            IPersistencia persistencia = new PersistenciaService();
            return persistencia.ObtenerPerfil(nombrePerfil);
        }

        public static bool ExistePerfil(string nombrePerfil)
        {
            try
            {
                foreach (Perfil p in Perfiles.ObtenerPerfiles())
                {
                    if (p.Nombre.Equals(nombrePerfil))
                        return true;
                }
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public static bool AltaPerfil(Perfil perfil)
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                persistencia.AgregarPerfil(perfil);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static bool ModificarPerfil(Perfil perfil)
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                persistencia.ModificarPerfil(perfil);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static bool EliminarPerfil(Perfil perfil)
        {
            IPersistencia persistencia = new PersistenciaService();
            try
            {
                persistencia.BajaPerfil(perfil);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
