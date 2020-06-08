using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class JefeLogistica: Logistica
    {
        public int anhosExperiencia { get; set; }

        public JefeLogistica()
        {
            anhosExperiencia = 0;
        }
        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.Write("  Años de experiencia: "+ anhosExperiencia);
            Console.WriteLine();
        }

        public override void pedirDatos()
        {
            base.pedirDatos();
            bool correcto = false;
            do
            {
                try
                {
                    Console.WriteLine("Años de experiencia en la empresa");
                    anhosExperiencia = int.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No es un valor valido");
                    correcto = false;

                }
            } while (correcto == false);
           
          
        }
    }
}
