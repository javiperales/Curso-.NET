using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    class Programa3
    {
        string frase;
        public void Ejecutar3()
        {
            Console.WriteLine("Escribe una frase");
            frase = Console.ReadLine();
            string primeraLetra = frase.Substring(0, 1);
            Console.WriteLine("la primera letra de la frase es:"+ primeraLetra);
            string ultimaLetra = frase.Substring(frase.Length-1, 1);
            Console.WriteLine("la ultima letra de la frase es "+ ultimaLetra);
        }
    }
}
