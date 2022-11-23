using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public   class Persona
    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }
        public Persona()
        {

        }
        public Persona(string Cedula, string Nombre, string Telefono)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
        }

    }
}
