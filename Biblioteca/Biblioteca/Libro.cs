using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public string anho { get; set; }
        public string genero { get; set; }
        public bool alquiler { get; set; }

        public  int codigoLibro { get; set; }
        private static int cont = 0;
        public Libro()
        {
            titulo = "";
            autor = "";
             anho="";
            genero = "";
            alquiler = false;
            cont++;
            codigoLibro=cont;
        }

    }//Libro
}//Biblioteca
