using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class JefeOficina:Oficina
    {
        public int anhosExperiencia { get; set; }

        public JefeOficina()
        {
            anhosExperiencia = 0;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.Write("Años de experiencia: " + anhosExperiencia);
        }

        public override void pedirDatos()
        {
            base.pedirDatos();
            bool bien = false;
            do
            {
                try
                {
                    Console.WriteLine("Años de experiencia en la Empresa");
                    anhosExperiencia = int.Parse(Console.ReadLine());

                    bien = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor incorrecto");
                   
                    bien = false;

                }
            } while (bien == false);
          
        }

    }
}
