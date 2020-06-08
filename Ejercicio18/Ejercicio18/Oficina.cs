using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Oficina:Trabajador
    {
        public string departamento { get; set; }

        public Oficina()
        {
            departamento = "";
        }

        public override void mostrarInformacion()
        {
            base.datosTrabajador();
            Console.Write(" Departamento: "+ departamento);
        }

        public override void pedirDatos()
        {
            base.perdirDatosTrabajador();
            Console.WriteLine("Departamento");
            departamento = Console.ReadLine();
        }


    }
}
