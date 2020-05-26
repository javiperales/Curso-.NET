using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
     class Persona
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
         
        public Persona()
        {
            
            nombre = "";
            apellidos = "";
            telefono = "";
        }
        //public Persona(string nombreExterno, string apellidosExterno, string telefonoExterno)
        //{
        //    nombre = nombreExterno;
        //    apellidos = apellidosExterno;
        //    telefono = telefonoExterno;
        //}
    }
}
