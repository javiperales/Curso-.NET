using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio18
{
  abstract  class Trabajador
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string DNI { get; set; }
        public DateTime fechaNac { get; set; }
        public static int cont { get; set; }
        public int codigoTrabajador { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechaInicio { get; set; }

        public Trabajador()
        {
            cont++;
            codigoTrabajador = cont;
            nombre = "";
            apellidos = "";
            DNI = "";
            fechaNac = new DateTime();
            fechaBaja = new DateTime();
            fechaInicio = new DateTime();

        }

        public void perdirDatosTrabajador()
        {
            bool bien = false;
            bool fecha = false;
            bool dni = false;
            Regex letras = new Regex(@"[A-HJ-NP-SUVW]");
            Regex numeros = new Regex(@"[0-9]{8}");
            do
            {
                try
                {
                    Console.WriteLine("DNI del trabajador");
                    DNI = Console.ReadLine();
                    string numeroDni = DNI.Substring(0, DNI.Length - 1);
                    string letraDni = DNI.Substring(8, 1);
                    string patron = "TRWAGMYFPDXBNJZSQVHLCKE";
                    int numdni = int.Parse(numeroDni);
                    int resto = numdni % 23;
                    string miLetra = patron.Substring(resto, 1);
                    string dniComprobado = numdni.ToString() + miLetra;
                    if (dniComprobado == DNI)
                    {
                        if (DNI.Length != 9 || (numeros.IsMatch(numeroDni) == false || letras.IsMatch(letraDni) == false))
                        {
                            Console.WriteLine("DNI incorrecto");
                            dni = false;
                        }
                        else
                        {
                            dni = true;
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Valores erroneos");
                }
               
               
                
               
            } while (dni == false);
            
            Console.WriteLine("Nombre del trabajador");
            nombre = Console.ReadLine(); ;
            Console.WriteLine("Apellidos del trabajador");
            apellidos= Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Fecha de nacimiento");
                    fechaNac = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    bien = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Formato de fecha incorrecto");
                    bien = false;

                }
            } while (bien==false);

            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Fecha de Inicio");
                    fechaInicio = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    
                        if (fechaInicio > DateTime.Now)
                        {
                            Console.WriteLine("Error");
                            fecha = true;
                        }
                        else
                        {
                            fecha = false;
                        }
                    } while (fecha == true);
                    
                    bien = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Formato de fecha incorrecto");
                    bien = false;

                }
            } while (bien == false);


        }

        public void datosTrabajador()
        {
            Console.WriteLine($"Nombre:{nombre} Apellidos:{apellidos} DNI: {DNI} Fecha de Nacimiento: {fechaNac}" );
            
        }

        public  abstract void mostrarInformacion();

        public abstract void pedirDatos();

       

    }
}
