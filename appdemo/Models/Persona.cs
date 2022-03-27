using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appdemo.Models
{
    public class Persona
    {
        public String Dni{get; set; }

        public String Nombre{get; set; }

        public String Apellido{get; set; }

        public String Genero{get; set; }

        public DateTime fechaVencimiento {get; set; }
    }
}