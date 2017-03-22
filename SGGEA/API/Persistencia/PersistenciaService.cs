using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using API.Dominio;
using API.Controladores;
using System.Threading;

namespace API.Persistencia
{
    public class PersistenciaService : IPersistencia
    {
        private const string _archivoUsuarios = ".\\Recursos\\datos_de_usuarios.csv";
        private const string _archivoPerfiles = ".\\Recursos\\datos_de_perfiles.csv";
        private const string _archivoPerfilesFunciones = ".\\Recursos\\datos_de_perfiles_funciones.csv";
        private const string _archivoUsuariosPerfiles = ".\\Recursos\\datos_de_usuarios_perfiles.csv";


        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] usuariosString = this.LeerArchivoFisico(_archivoUsuarios);

            foreach(string s in usuariosString){
                if (!String.IsNullOrEmpty(s))
                {
                    Usuario usr;
                    usr = ParsearUsuario(s);
                    usr.Perfiles = ObtenerPerfilesUsuario(usr);
                    usuarios.Add(usr);
                }  
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

            string[] perfilesString = this.LeerArchivoFisico(_archivoPerfiles);
            string[] perfilesFuncionesString = this.LeerArchivoFisico(_archivoPerfilesFunciones);

            foreach (string s in perfilesString)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    Perfil perfil;
                    perfil = ParsearPerfil(s);
                    List<Funcion> funciones = new List<Funcion>();

                    foreach (string s2 in perfilesFuncionesString)
                    {
                        if (!String.IsNullOrEmpty(s2))
                        {
                            int idFuncion = ParsearPerfilesFunciones(perfil.Id, s2);
                            if (idFuncion > -1)
                            {
                                funciones.Add(Funciones.ObtenerFuncionPorId(idFuncion));
                            }
                        }
                    }
                    perfil.Funciones = funciones;

                    perfiles.Add(perfil);              
                }
             
            }

            return perfiles;
        }

        public Perfil ObtenerPerfil(string nombrePerfil)
        {
            List<Perfil> perfiles = ObtenerPerfiles();
            return perfiles.Find(prf => prf.Nombre.Equals(nombrePerfil));
        }

        private List<Perfil> ObtenerPerfilesUsuario(Usuario usr)
        {
            List<Perfil> perfiles = new List<Perfil>();
            List<Perfil> todosLosPerfiles= ObtenerPerfiles();

            string[] datosString = LeerArchivoFisico(_archivoUsuariosPerfiles);

            foreach (string s in datosString)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    int idPerfil = ParsearUsuariosPerfiles(usr.Username, s);
                    if (idPerfil > -1)
                    {
                        perfiles.Add(todosLosPerfiles.Find(p => p.Id == idPerfil));
                    }
                }
              
            }

            return perfiles;

        }


        private string[] LeerArchivoFisico(string archivo)
        {
            string result;

            using (StreamReader sr = new StreamReader(archivo))
            {
                result = sr.ReadToEnd();
            }

            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = result.Split(stringSeparators, StringSplitOptions.None);
            return lines;
        }


        private Usuario ParsearUsuario(string linea)
        {
            Usuario user = new Usuario();

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

            File.AppendAllText(_archivoUsuarios, "\r\n"+line);

            //Ahora persistimos los perfiles
            foreach(Perfil p in user.Perfiles)
            {
                File.AppendAllText(_archivoUsuariosPerfiles, "\r\n" + user.Username + ";" + p.Id.ToString());
            }

            CleanFileWrapper(_archivoUsuarios);

        }

        public void ModificarUsuario(Usuario user)
        {
            List<string> usuariosLineas = new List<String>();

            //Modificamos primero los datos del usuario
            string tempLine;
            using (StreamReader reader = new StreamReader(_archivoUsuarios))
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

            using(StreamWriter writer=new StreamWriter(_archivoUsuarios))
            {
                foreach(string s in usuariosLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoUsuarios);

            List<string> perfilesLineas = new List<string>();

            //Ahora modificamos los datos del perfil
            using (StreamReader reader = new StreamReader(_archivoUsuariosPerfiles))
            {
                    while ((tempLine = reader.ReadLine()) != null)
                    {
                        if (tempLine.IndexOf(user.Username) == -1)//La linea no corresponde al usuario
                            perfilesLineas.Add(tempLine);
                    }
            }

            //Ahora, recorremos los perfiles y los agregamos al archivo
            foreach (Perfil p in user.Perfiles)
            {
                perfilesLineas.Add(user.Username + ";" + p.Id.ToString());
            }

            //Ahora escribimos los datos en el archivo
            using (StreamWriter writer = new StreamWriter(_archivoUsuariosPerfiles))
            {
                foreach (string s in perfilesLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoUsuariosPerfiles);

        }

        public void BajaUsuario(Usuario user)
        {
            List<string> usuariosLineas = new List<String>();

            string tempLine;
            using (StreamReader reader = new StreamReader(_archivoUsuarios))
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

            using (StreamWriter writer = new StreamWriter(_archivoUsuarios))
            {
                foreach (string s in usuariosLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoUsuarios);

            List<string> perfilesLineas = new List<string>();

            //Ahora modificamos los datos del perfil
            using (StreamReader reader = new StreamReader(_archivoUsuariosPerfiles))
            {
                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(user.Username) == -1)
                        perfilesLineas.Add(tempLine);
                }
            }

            //Ahora escribimos los datos en el archivo

            using (StreamWriter writer = new StreamWriter(_archivoUsuariosPerfiles))
            {
                foreach (string s in perfilesLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoUsuariosPerfiles);
        }

        public void AgregarPerfil(Perfil perfil)
        {
            //Nos fijamos el numero del ultimo perfil registrado.
            var lastLine = File.ReadLines(_archivoPerfiles).Last();
            Perfil ultimo=ParsearPerfil(lastLine);
            perfil.Id = ultimo.Id + 1;

            //Generamos la linea para agregar a la persistencia
            string line = perfil.Id + ";" + perfil.Nombre;

            File.AppendAllText(_archivoPerfiles, "\r\n" + line);

            //Ahora persistimos las funciones
            foreach (Funcion f in perfil.Funciones)
            {
                File.AppendAllText(_archivoPerfilesFunciones, "\r\n" + perfil.Id + ";" + f.Valor);
            }

            CleanFileWrapper(_archivoPerfilesFunciones);
        }

        public void ModificarPerfil(Perfil perfil)
        {
            string tempLine;         
            List<string> funcionesLineas = new List<string>();

            //Actualizamos las funciones del perfil
            using (StreamReader reader = new StreamReader(_archivoPerfilesFunciones))
            {
                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(perfil.Id.ToString()+";") == -1)//La linea no corresponde al perfil
                        funcionesLineas.Add(tempLine);
                }
            }

            //Ahora, recorremos las funciones y las agregamos al archivo
            foreach (Funcion f in perfil.Funciones)
            {
                funcionesLineas.Add(perfil.Id.ToString() + ";" + f.Valor);
            }

            //Ahora escribimos los datos en el archivo
            using (StreamWriter writer = new StreamWriter(_archivoPerfilesFunciones))
            {
                foreach (string s in funcionesLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoPerfilesFunciones);

        }

        public void BajaPerfil(Perfil perfil)
        {
            List<string> perfilesLineas = new List<String>();

            string tempLine;
            using (StreamReader reader = new StreamReader(_archivoPerfiles))
            {
                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(perfil.Id.ToString()+";") == -1)
                    {
                        perfilesLineas.Add(tempLine);
                    }
                }
            }

            //Ahora escribimos los datos en el archivo
            using (StreamWriter writer = new StreamWriter(_archivoPerfiles))
            {
                foreach (string s in perfilesLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoPerfiles);

            List<string> usuariosLineas = new List<string>();

            //Ahora actualizamos las referencias de los usuarios al perfil
            using (StreamReader reader = new StreamReader(_archivoUsuariosPerfiles))
            {
                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(";"+perfil.Id.ToString()) == -1)
                        usuariosLineas.Add(tempLine);
                }
            }

            //Ahora escribimos los datos en el archivo
            using (StreamWriter writer = new StreamWriter(_archivoUsuariosPerfiles))
            {
                foreach (string s in usuariosLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoUsuariosPerfiles);

            List<string> funcionesLineas = new List<string>();

            //Ahora actualizamos las referencias de las funciones al perfil
            using (StreamReader reader = new StreamReader(_archivoPerfilesFunciones))
            {
                while ((tempLine = reader.ReadLine()) != null)
                {
                    if (tempLine.IndexOf(perfil.Id.ToString()+";") == -1)
                        funcionesLineas.Add(tempLine);
                }
            }

            //Ahora escribimos los datos en el archivo
            using (StreamWriter writer = new StreamWriter(_archivoPerfilesFunciones))
            {
                foreach (string s in funcionesLineas)
                {
                    writer.WriteLine(s);
                }
            }

            CleanFileWrapper(_archivoPerfilesFunciones);
        }

        private void CleanFileWrapper(String fileName)
        {
            var t = Task.Run(() => CleanFile(fileName));

        }
        private void CleanFile(String fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            int count = lines.Length;


            //Ahora escribimos los datos en el archivo
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < count-1; i++)
                {
                    writer.WriteLine(lines[i]);

                }
                //La ultima linea la escribimos sin retorno de linea
                writer.Write(lines[count - 1]);
            }

            
            
        }
    }
}
