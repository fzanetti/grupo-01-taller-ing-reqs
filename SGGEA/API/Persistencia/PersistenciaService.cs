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
        private const string _archivoUsuarios2 = "datos_de_usuarios.csv";
        private const string _archivoUsuariosPerfiles2 = "datos_de_usuarios_perfiles.csv";

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] usuariosString = this.LeerArchivoFisico(_archivoUsuarios2);

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

        private string[] LeerArchivoFisico(string archivo)
        {
            string result;

            using(StreamReader sr=new StreamReader(archivo))
            {
                result=sr.ReadToEnd();
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

            if (string.IsNullOrEmpty(tokens[5]))
                return null;
            user.Planta= tokens[5];

            if (string.IsNullOrEmpty(tokens[6]))
                return null;
            user.UbicacionFisica = tokens[6];

            if (string.IsNullOrEmpty(tokens[7]))
                return null;
            user.Departamento = tokens[7];

            if (string.IsNullOrEmpty(tokens[8]))
                return null;
            user.Cargo = tokens[8];

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

        public void AgregarUsuario(Usuario user)
        {
            //Generamos la linea para agregar a la persistencia
            string line = user.Username + ";" +
                user.Password + ";" +
                user.Nombre + ";" +
                user.Apellido + ";" +
                user.Email + ";" +
                user.Planta + ";" +
                user.UbicacionFisica + ";" +
                user.Departamento + ";" +
                user.Cargo;

            //using (Stream stream = assembly.GetManifestResourceStream(_archivoUsuarios))
            using (StreamWriter writer = File.AppendText(_archivoUsuarios2))
            {

                writer.WriteLine(line);
                writer.Close();

            }

            //Ahora persistimos los perfiles
            foreach(Perfil p in user.Perfiles)
            {
                using(StreamWriter writer = File.AppendText(_archivoUsuariosPerfiles2))
                {
                    writer.WriteLine(user.Username + ";" + p.Id.ToString());
                }
            }

        }

        public void ModificarUsuario(Usuario user)
        {
            List<string> usuariosLineas = new List<String>();

            //Modificamos primero los datos del usuario
            string tempLine;
            using (StreamReader reader = new StreamReader(_archivoUsuarios2))
            {

                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(user.Username) != -1)
                    {//La linea corresponde al usuario
                     //Parseamos la linea para la persistencia
                        string line = user.Username + ";" +
                            user.Password + ";" +
                             user.Nombre + ";" +
                             user.Apellido + ";" +
                             user.Email + ";" +
                             user.Planta + ";" +
                             user.UbicacionFisica + ";" +
                             user.Departamento + ";" +
                             user.Cargo;
                        usuariosLineas.Add(line);
                    }
                    else
                    {
                        usuariosLineas.Add(tempLine);

                    }
                }
            }

            //Ahora escribimos los datos en el archivo

            using(StreamWriter writer=new StreamWriter(_archivoUsuarios2))
            {
                foreach(string s in usuariosLineas)
                {
                    writer.WriteLine(s);
                }
            }

            List<string> perfilesLineas = new List<string>();

            //Ahora modificamos los datos del perfil
            using (StreamReader reader = new StreamReader(_archivoUsuariosPerfiles2))
            {
                    while ((tempLine = reader.ReadLine()) != null)
                    {
                        if (tempLine.IndexOf(user.Username) == -1)//La linea no corresponde al usuario
                            perfilesLineas.Add(tempLine);
                    }

                    //Ahora, recorremos los perfiles y los agregamos al archivo

                foreach(Perfil p in user.Perfiles)
                    {
                        perfilesLineas.Add(user.Username + ";" + p.Id.ToString());
                    }
                
            }

            //Ahora escribimos los datos en el archivo

            using (StreamWriter writer = new StreamWriter(_archivoUsuariosPerfiles2))
            {
                foreach (string s in perfilesLineas)
                {
                    writer.WriteLine(s);
                }
            }

        }

        public void BajaUsuario(Usuario user)
        {
            List<string> usuariosLineas = new List<String>();

            string tempLine;
            using (StreamReader reader = new StreamReader(_archivoUsuarios2))
            {

                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(user.Username) == -1)
                    {
                        usuariosLineas.Add(tempLine);

                    }
                }
            }

            //Ahora escribimos los datos en el archivo

            using (StreamWriter writer = new StreamWriter(_archivoUsuarios2))
            {
                foreach (string s in usuariosLineas)
                {
                    writer.WriteLine(s);
                }
            }

            List<string> perfilesLineas = new List<string>();

            //Ahora modificamos los datos del perfil
            using (StreamReader reader = new StreamReader(_archivoUsuariosPerfiles2))
            {
                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(user.Username) == -1)
                        perfilesLineas.Add(tempLine);
                }
            }

            //Ahora escribimos los datos en el archivo

            using (StreamWriter writer = new StreamWriter(_archivoUsuariosPerfiles2))
            {
                foreach (string s in perfilesLineas)
                {
                    writer.WriteLine(s);
                }
            }
        }
    }
}
