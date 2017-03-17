using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace SGGEA
{
    public class PersistenciaService : IPersistencia
    {
        private const string _archivoUsuarios = "API.Resources.datos_de_usuarios.csv";

        public List<User> ObtenerUsuarios()
        {
            List<User> usuarios = new List<User>();

            string[] usuariosString = this.LeerArchivo();

            foreach(string s in usuariosString){
                User usr;
                usr = ParsearUsuario(s);
                usuarios.Add(usr);
            }

            return usuarios;
        }
        
        private string[] LeerArchivo()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string result;

            using (Stream stream = assembly.GetManifestResourceStream(_archivoUsuarios))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = result.Split(stringSeparators, StringSplitOptions.None);
            return lines;
        }

        private User ParsearUsuario(string linea)
        {
            User user = new User();

            string[] tokens = linea.Split(',');

            if (string.IsNullOrEmpty(tokens[0]))
                return null; //No fue posible parsear el username

            user.Username = tokens[0];

            if (string.IsNullOrEmpty(tokens[1]))
                return null;

            user.Password = tokens[1];

            return user;

        }
    }
}
