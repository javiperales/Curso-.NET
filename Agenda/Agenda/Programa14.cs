using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Programa14
    {
        public List<Persona> personas { get; set; }
        public Persona BuscarPorNomnreYApellidos()
        {
            Console.WriteLine("Escriba el nombre y apellidos de la persona que desea buscar: ");
            string nyaABuscar = Console.ReadLine();
            Persona personaEncontrada = personas.Find(x => $"{x.nombre} {x.apellidos}" == nyaABuscar);
            if (personaEncontrada == null)
            {
                //codigo para cuando no se encuentra una persona
                Console.WriteLine("La persona seleccionada no ha sido encontrada");
            }
            return personaEncontrada;
        }

        public void Borrar()
        {
            Persona personaEncontrada = BuscarPorNomnreYApellidos();
            if (!(personaEncontrada == null))
            {
                Console.WriteLine("¿Esta seguro que desea borrar la persona seleccionada?(pulse S o S si sí)");
                string str_borrrar = Console.ReadLine();
                if (str_borrrar.ToLower() == "s")
                {
                    personas.Remove(personaEncontrada);
                    Console.WriteLine("La persona ha sido borrada satisfactoriamente");
                }
                else
                {
                    Console.WriteLine("La persona no ha sido borrada");
                }
            }
        }

        public void CrearContacto()
        {
            Persona nuevaPersona = new Persona();
            Console.WriteLine("Escribe el nombre del contacto");
            string nombreUsuario = Console.ReadLine();
            nuevaPersona.nombre = nombreUsuario;

            Console.WriteLine("Escribe los apellidos del contacto");
            string apellidosUsuario = Console.ReadLine();
            nuevaPersona.apellidos = apellidosUsuario;
            Console.WriteLine("Escribe el numero de telefono del contacto");
            string telefonoUsuario = Console.ReadLine();
            nuevaPersona.telefono = telefonoUsuario;
            personas.Add(nuevaPersona);
        }

        public void MostrarContacto()
        {
            Persona personaEncontradaOp3 = BuscarPorNomnreYApellidos();
            if (personaEncontradaOp3 != null)
            {
                Console.WriteLine("Telefono: " + personaEncontradaOp3.telefono);
            }
        }

        public void MostrarTodosContactos()
        {
            List<Persona> personaOrdenadas = new List<Persona>();
            personaOrdenadas = personas.OrderBy(x => x.nombre).ToList();
            



            foreach (Persona persona in personaOrdenadas)
            {
                Console.WriteLine(persona.nombre + " " + persona.apellidos + " " + persona.telefono);

            }
            Console.WriteLine("Numero de contactos " + personas.Count);
        }


        public void Ejecutar()
        {
            string opc = "";
            bool terminar = false;
            personas = new List<Persona>();

            do
            {

                Console.WriteLine("1-Nuevo contacto");
                Console.WriteLine("2-Borrar contacto");
                Console.WriteLine("3-Buscar contacto");
                Console.WriteLine("4-Mostrar todos los contactos");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Elija una opcion");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        CrearContacto();
                        break;
                    case "2":
                        Borrar();
                        //string respuesta = "";
                        //Console.WriteLine("Introduzca el nombre del contacto que desea buscar");
                        //nombreUsuario = Console.ReadLine();
                        //Console.WriteLine("Introduzca los apellidos del contacto que desea buscar");
                        //apellidosUsuario = Console.ReadLine();
                        //for (int i = 0; i < personas.Count; i++)
                        //{
                        //    if (nombreUsuario == personas[i].nombre && apellidosUsuario == personas[i].apellidos)
                        //    {

                        //        Console.WriteLine("El contacto  existe, ¿seguro que desea eliminar?");
                        //        Console.Write("Pulse s o S para confirmar eliminacion");
                        //        respuesta = Console.ReadLine();
                        //        if (respuesta == "s" || respuesta == "S")
                        //        {
                        //            personas.RemoveAt(i);
                        //        }

                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("El contacto no existe");

                        //    }
                        //}
                        break;
                    case "3":
                        MostrarContacto();
                        //Console.WriteLine("Introduzca el nombre del contacto que desea buscar");
                        //nombreUsuario = Console.ReadLine();
                        //Console.WriteLine("Introduzca los apellidos del contacto que desea buscar");
                        //apellidosUsuario = Console.ReadLine();

                        //foreach (Persona persona in personas)
                        //{
                        //    if (persona.nombre == nombreUsuario && persona.apellidos == apellidosUsuario)
                        //    {
                        //        Console.WriteLine("Telefono: " + persona.telefono);

                        //    }
                        //}
                        break;
                    case "4":
                        MostrarTodosContactos();
                        break;
                    case "5":
                        Console.WriteLine("Salir");
                    break;
                }
                if (opc != "5")
                {
                    Console.WriteLine("¿Deseao realizar otra operacion? Pulse S o s para continuar");
                    string str_continuar = Console.ReadLine();
                    if (str_continuar.ToLower() == "s")
                    {

                    }
                    else
                    {
                        terminar = true;
                    }
                }

            } while (opc != "5" && terminar==false);
        }
    }
}
