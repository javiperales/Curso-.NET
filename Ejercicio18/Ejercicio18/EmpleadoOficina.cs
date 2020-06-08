using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class EmpleadoOficina:Oficina
    {
        public string estudiosSuperiores { get; set; }
        public JefeOficina jefeOficina { get; set; }

        public EmpleadoOficina()
        {
            estudiosSuperiores = "";
            jefeOficina=null;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Estudios superiores: " + estudiosSuperiores + "Jefe de Oficina asignado "+ jefeOficina.nombre);
        } 

        public override void pedirDatos()
        {
            base.pedirDatos();
            

            bool contratacion = false;
            do
            {
                try
                {
                    Console.WriteLine("Estudios superiores");
                    estudiosSuperiores = Console.ReadLine();

                    if (estudiosSuperiores == "Grado Superior" || estudiosSuperiores == "Grado Medio" || estudiosSuperiores=="Carrera Universitaria" || estudiosSuperiores=="Curso Inaem")
                    {
                        contratacion = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor Erroneo introduzca Grado Superior o Grado Medio o Carrera Universitaria o Curso Inaem");
                        contratacion = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Valores incorrectos");
                    contratacion = false;
                }
            } while (contratacion == false);


        }



    }
}
