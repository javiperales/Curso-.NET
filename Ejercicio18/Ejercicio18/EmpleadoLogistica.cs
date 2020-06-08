using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class EmpleadoLogistica: Logistica
    {
        public string tipoContratacion { get; set; }


        public EmpleadoLogistica()
        {
            tipoContratacion = "";
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("  Tipo de Contratacion: " + tipoContratacion);
        }

        public override void pedirDatos()
        {
            base.pedirDatos();
            bool contratacion = false;
            do
            {
                try
                {
                    Console.WriteLine(" Tipo de contratacion(Empresa o ETT)");
                    tipoContratacion = Console.ReadLine();
                    if(tipoContratacion=="ETT" || tipoContratacion == "Empresa")
                    {
                        contratacion = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor Erroneo introduzca ETT o Empresa");
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
