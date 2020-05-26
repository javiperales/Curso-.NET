using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    class Programa2
    {
        string nombre;
        public void Ejecutar2()
        {
            Console.WriteLine("Escribe tu nombre");
            nombre = System.Console.ReadLine();
            Console.WriteLine("mi nombre es : "+nombre);
        }
    }
}
