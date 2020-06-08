using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Logistica: Trabajador
    {
        public string seccion { get; set; }

        public Logistica()
        {
            seccion = "";
        }

        public override void mostrarInformacion()
        {
            base.datosTrabajador();
            Console.Write($" Seccion: {seccion}");
        }

        public override void pedirDatos()
        {
            base.perdirDatosTrabajador();
            Console.WriteLine("Seccion");
            seccion = Console.ReadLine();
        }
    }
}
