using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dominio
{
    public sealed class Funcion
    {
        public string Nombre { get; set; }
        public int Valor { get; set; }

        internal Funcion(int value, string name)
        {
            this.Nombre = name;
            this.Valor = value;
        }

        public override string ToString()
        {
            return Nombre;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this.Valor == ((Funcion)obj).Valor;
        }

    }
}
