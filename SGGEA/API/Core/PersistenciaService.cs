using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGGEA
{
    public class PersistenciaService : IPersistencia
    {
        private const string _archivoUsuarios = "datos_de_usuarios.csv";

        public List<User> ObtenerUsuarios()
        {
            List<User> usuarios = new List<User>();

            List<string> usuariosString = new List<string>();

            usuariosString = this.LeerArchivo(_archivoUsuarios);

            foreach(string s in usuariosString){

                User usr;
                usr = ParsearUsuario(s);
                usuarios.Add(usr);

            }

            return usuarios;
        }

        private List<string> LeerArchivo(String FileName)
        {
            List<string> retorno = new List<string>();

            string tempLine;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(FileName);
                while ((tempLine = file.ReadLine()) != null)
                    retorno.Add(tempLine);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return retorno;
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
