using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGGEA
{
    class Globals
    {
        public static Color ColorFondoBoton = Color.FromArgb(4, 136, 209);
        public static Color ColorFondoBotonHover = Color.FromArgb(129, 177, 203);

        public static string ErrorLogin = "Usuario o contraseña inválidos";
        public static string ConfirmacionSalir = "¿Seguro que desea salir?";
        
        public static string ErrorCampoObl = "Campo Obligatorio";
       
        //Usuarios
        public static string ErrorUsernameRegistrado = "Nombre usuario ya registrado";
        public static string ErrorSelPerfiles = "Debe seleccionar al menos un perfil";
        public static string AltaUsuarioOk = "Se ha agregado el usuario exitosamente";
        public static string AltaUsuarioError = "Error inesperado al registrar al usuario";
        public static string ModificacionUsuarioOk = "Se ha modificado el usuario exitosamente";
        public static string ModificacionUsuarioError = "Error inesperado al modificar al usuario";
        public static string ConfirmacionBajaUsuario = "¿Está seguro que desea dar de baja al usuario?";
        public static string BajaUsuarioOk = "Se ha eliminado el usuario exitosamente";
        public static string BajaUsuarioError = "Error inesperado al eliminar al usuario";
        
        //Perfiles
        public static string ErrorPerfilRegistrado = "Nombre de perfil ya existente";
        public static string ErrorSelFunciones = "Debe seleccionar al menos una función";
        public static string AltaPerfilOk = "Se ha agregado el perfil de usuario exitosamente";
        public static string AltaPerfilError = "Error inesperado al registrar el perfil";
        public static string ModificacionPerfilOk = "Se ha modificado el perfil de usuario exitosamente";
        public static string ModificacionPerfilError = "Error inesperado al modificar el perfil";
        public static string ConfirmacionBajaPerfil = "¿Está seguro que desea dar de baja al perfil?";
        public static string BajaPerfilOk = "Se ha eliminado el perfil de usuario exitosamente";
        public static string BajaPerfilError = "Error inesperado al eliminar el perfil";
    }
}
