using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dominio
{
    public class Usuario
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Planta { get; set; }
        public string UbicacionFisica { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public List<Perfil> Perfiles { get; set; }
    }
}
