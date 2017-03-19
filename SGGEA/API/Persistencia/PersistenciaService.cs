using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using API.Dominio;
using API.Controladores;

namespace API.Persistencia
{
    public class PersistenciaService : IPersistencia
    {
        private const string _archivoUsuarios = "API.Resources.datos_de_usuarios.csv";
        private const string _archivoPerfiles = "API.Resources.datos_de_perfiles.csv";
        private const string _archivoPerfilesFunciones = "API.Resources.datos_de_perfiles_funciones.csv";
        private const string _archivoUsuariosPerfiles = "API.Resources.datos_de_usuarios_perfiles.csv";

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] usuariosString = this.LeerArchivo(_archivoUsuarios);

            foreach(string s in usuariosString){
                Usuario usr;
                usr = ParsearUsuario(s);
                usr.Perfiles=ObtenerPerfilesUsuario(usr);
                usuarios.Add(usr);
            }

            return usuarios;
        }

        public Usuario ObtenerUsuario(string username)
        {
            List<Usuario> usuarios = ObtenerUsuarios();
            return usuarios.Find(usr => usr.Username.Equals(username));
        }

        public List<Perfil> ObtenerPerfiles()
        {
            List<Perfil> perfiles = new List<Perfil>();

            string[] perfilesString = this.LeerArchivo(_archivoPerfiles);
            string[] perfilesFuncionesString = this.LeerArchivo(_archivoPerfilesFunciones);

            foreach (string s in perfilesString)
            {
                Perfil perfil;
                perfil = ParsearPerfil(s);
                List<Funcion> funciones=new List<Funcion>();

                foreach (string s2 in perfilesFuncionesString)
                {
                    int idFuncion = ParsearPerfilesFunciones(perfil.Id, s2);
                    if (idFuncion > -1)
                    {
                        funciones.Add(Funciones.ObtenerFuncionPorId(idFuncion));
                    }
                }
                perfil.Funciones=funciones;

                perfiles.Add(perfil);              
            }

            return perfiles;
        }

        private List<Perfil> ObtenerPerfilesUsuario(Usuario usr)
        {
            List<Perfil> perfiles = new List<Perfil>();
            List<Perfil> todosLosPerfiles= ObtenerPerfiles();

            string[] datosString = LeerArchivo(_archivoUsuariosPerfiles);

            foreach (string s in datosString)
            {
                int idPerfil=ParsearUsuariosPerfiles(usr.Username,s);
                if (idPerfil > -1)
                {
                    perfiles.Add(todosLosPerfiles.Find(p => p.Id == idPerfil));
                }
            }

            return perfiles;

        }

        private string[] LeerArchivo(string archivo)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string result;

            using (Stream stream = assembly.GetManifestResourceStream(archivo))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = result.Split(stringSeparators, StringSplitOptions.None);
            return lines;
        }

        private Usuario ParsearUsuario(string linea)
        {
            Usuario user = new Usuario();
            //usuario1;password1;nombre1;apellido1;email1;planta1;ubicación física1;departamento1;cargo1 
            string[] tokens = linea.Split(';');

            if (string.IsNullOrEmpty(tokens[0]))
                return null; //No fue posible parsear el username
            user.Username = tokens[0];

            if (string.IsNullOrEmpty(tokens[1]))
                return null;//No fue posible parsear la password
            user.Password = tokens[1];

            if (string.IsNullOrEmpty(tokens[2]))
                return null;
            user.Nombre = tokens[2];

            if (string.IsNullOrEmpty(tokens[3]))
                return null;
            user.Apellido = tokens[3];

            if (string.IsNullOrEmpty(tokens[4]))
                return null;
            user.Email = tokens[4];


            return user;
        }

        private Perfil ParsearPerfil(string linea)
        {
            Perfil perfil = new Perfil();

            string[] tokens = linea.Split(';');

            if (string.IsNullOrEmpty(tokens[0]))
                return null; //No fue posible parsear el id

            int id=-1;
            bool esEntero= int.TryParse(tokens[0],out id);
            if(esEntero)
                perfil.Id = id;
            else
                return null; //No fue posible parsear el id

            if (string.IsNullOrEmpty(tokens[1]))
                return null; //No fue posible parsear el nombre

            perfil.Nombre = tokens[1];

            return perfil;
        }

        private int ParsearUsuariosPerfiles(string username,string linea)
        {
            string[] tokens = linea.Split(';');

            if (string.IsNullOrEmpty(tokens[0]))
                return -1; //No fue posible parsear el username

            if (tokens[0].Trim().Equals(username))
            {
                if (!string.IsNullOrEmpty(tokens[1]))
                {
                    int id = -1;
                    bool esEntero = int.TryParse(tokens[1], out id);
                    if (esEntero)
                        return id;
                }
            }

            return -1;

        }

        private int ParsearPerfilesFunciones(int idPerfil, string linea)
        {
            string[] tokens = linea.Split(';');

            if (!string.IsNullOrEmpty(tokens[0]))
            {
                int id = -1;
                bool esEntero = int.TryParse(tokens[0], out id);
                if (esEntero && id == idPerfil)
                {
                    if (!string.IsNullOrEmpty(tokens[1]))
                    {
                        int idFuncion = -1;
                        esEntero = int.TryParse(tokens[1], out idFuncion);
                        if (esEntero)
                            return idFuncion;
                    }
                }
            }

            return -1;
        }
     
    }
}
