using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Main18
    {
      public  List<Trabajador> ListaTrabajadores { get; set; }
      public  List<Logistica> secciones { get; set; }
      public  List<Oficina> departamentos { get; set; }
      public string opc { get; set; }
      public string opcEmpresa { get; set; }

        public void Ejecutar()
        {

            
            datosBase();
            menuGen();



        }//ejecutar aqui esta todo

        public void menuGen()
        {
            bool fin = false;
            do
            {
                Console.WriteLine("1-Gestion logística");
                Console.WriteLine("2-Gestion Oficina");
                Console.WriteLine("3-Dar de baja a un trabajador");
                Console.WriteLine("4-Mostrar usuarios dados de baja");
                Console.WriteLine("5-Salir");
                opcEmpresa = Console.ReadLine();

                switch (opcEmpresa)
                {
                    case "1":
                        Console.Clear();
                        gestionLogistica();
                        
                        break;
                    case "2":
                        Console.Clear();
                        gestionOficina();
                        break;
                    case "3":
                        Console.Clear();
                        bajaUsuario();
                        break;
                    case "4":
                        mostrarTrabajadoresDeBaja();
                        break;
                    case "5":
                        fin = true;
                        Environment.Exit(0);
                        break;
                }
            } while (fin == true);
        }

        public void mostrarTrabajadoresDeBaja()
        {
            bool encontrado = false;
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.fechaBaja != new DateTime())
                {
                    item.mostrarInformacion();
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("No hay trabajadores dados de baja");
            }
            Console.ReadKey();
        }
        public void creaJefeLogistica()
        {
            JefeLogistica jefeLogistica = new JefeLogistica();
            jefeLogistica.pedirDatos();
            ListaTrabajadores.Add(jefeLogistica);
            Console.WriteLine();
        }

        public void creaEmpleadoLogistica()
        {
            EmpleadoLogistica empleado = new EmpleadoLogistica();
            empleado.pedirDatos();
            ListaTrabajadores.Add(empleado);
            Console.WriteLine();
        }

        public void actualizaJefeLogistica()
        {
            Console.WriteLine("DNI del Jefe de logística a modificar");
            string dniAmodificar = Console.ReadLine();
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "JefeLogistica" && ((JefeLogistica)item).DNI != dniAmodificar)
                {
                    Console.WriteLine("DNI incorrecto");
                }

                if (item.GetType().Name == "JefeLogistica" && ((JefeLogistica)item).DNI == dniAmodificar)
                {
                    string opcionMod;
                    bool terminar = false;
                    do
                    {
                        Console.WriteLine("1-Cambiar nombre");
                        Console.WriteLine("2-Cambiar apellidos");
                        Console.WriteLine("3-Cambiar DNI");
                        Console.WriteLine("4-Cambiar sección");
                        Console.WriteLine("5-Cambiar años de experiencia");
                        Console.WriteLine("6-Salir");
                        opcionMod = Console.ReadLine();

                        switch (opcionMod)
                        {
                            case "1":
                                Console.WriteLine("Nuevo nombre");
                                string nuevoNombre = Console.ReadLine();
                                item.nombre = nuevoNombre;
                                break;
                            case "2":
                                Console.WriteLine("Nuevos Apellidos");
                                string nuevoApellido = Console.ReadLine();
                                item.apellidos = nuevoApellido;

                                break;
                            case "3":
                                Console.WriteLine("Nuevo DNI");
                                string nuevoDNI = Console.ReadLine();
                                item.DNI = nuevoDNI;
                                break;
                            case "4":
                                Console.WriteLine("Nueva sección");
                                string nuevaSeccion = Console.ReadLine();
                                ((JefeLogistica)item).seccion = nuevaSeccion;
                                break;
                            case "5":
                                Console.WriteLine("Actualizar años de experiencia");
                                int nuevoAnhos = int.Parse(Console.ReadLine());
                                ((JefeLogistica)item).anhosExperiencia = nuevoAnhos;
                                break;
                            case "6":
                                terminar = true;
                                break;
                        }
                    } while (terminar == true);
                }
            }
        }


        public void actualizaEmpleadoLogistica()
        {
            Console.WriteLine("DNI del Empleado de logística a modificar");
            string dniEmpleadoAmodificar = Console.ReadLine();
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "EmpleadoLogistica" && ((EmpleadoLogistica)item).DNI != dniEmpleadoAmodificar)
                {
                    Console.WriteLine("DNI incorrecto");
                }

                if (item.GetType().Name == "EmpleadoLogistica" && ((EmpleadoLogistica)item).DNI == dniEmpleadoAmodificar)
                {
                    string opcionMod;
                    bool terminar = false;
                    do
                    {
                        Console.WriteLine("1-Cambiar nombre");
                        Console.WriteLine("2-Cambiar apellidos");
                        Console.WriteLine("3-Cambiar DNI");
                        Console.WriteLine("4-Cambiar sección");
                        Console.WriteLine("5-Cambiar tipo de contratación");
                        Console.WriteLine("6-Salir");
                        opcionMod = Console.ReadLine();

                        switch (opcionMod)
                        {
                            case "1":
                                Console.WriteLine("Nuevo nombre");
                                string nuevoNombre = Console.ReadLine();
                                item.nombre = nuevoNombre;
                                break;
                            case "2":
                                Console.WriteLine("Nuevos Apellidos");
                                string nuevoApellido = Console.ReadLine();
                                item.apellidos = nuevoApellido;

                                break;
                            case "3":
                                Console.WriteLine("Nuevo DNI");
                                string nuevoDNI = Console.ReadLine();
                                item.DNI = nuevoDNI;
                                break;
                            case "4":
                                Console.WriteLine("Nueva sección");
                                string nuevaSeccion = Console.ReadLine();
                                ((EmpleadoLogistica)item).seccion = nuevaSeccion;
                                break;
                            case "5":
                                Console.WriteLine("Tipo de contratacion");
                                string nuevoTipoContratacion = Console.ReadLine();
                                ((EmpleadoLogistica)item).tipoContratacion = nuevoTipoContratacion;
                                break;
                            case "6":
                                terminar = true;
                                break;
                        }
                    } while (terminar == true);
                }
            }
        }

        public void buscarJefeLogPorNombre()
        {
            Console.WriteLine("Nombre del Jefe de logística que desea buscar");
            string nombreABuscar = Console.ReadLine();
            bool encontrado = false;
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "JefeLogistica" && ((JefeLogistica)item).nombre == nombreABuscar)
                {
                    encontrado = true;
                    item.mostrarInformacion();
                }
            }
            if (encontrado==false)
            {
                Console.WriteLine("Nombre no encontrado");
            }
        }

        public void buscarEmplLogPorNombre()
        {
            Console.WriteLine("Nombre del Jefe de logística que desea buscar");
            string nombreEmpleadoABuscar = Console.ReadLine();
            bool encontrado = false;
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "EmpleadoLogistica" && ((EmpleadoLogistica)item).nombre == nombreEmpleadoABuscar)
                {
                    encontrado = true;
                    item.mostrarInformacion();
                }
            }

            if (encontrado==false)
            {
                Console.WriteLine("Nombre no encontrado");
            }
        }

        public void mostrarJefeLog()
        {
            List<Trabajador> jefeslogistica = ListaTrabajadores.Where(x => x.ToString().Contains("JefeLogistica")).ToList();
            if (jefeslogistica.Count() == 0)
            {
                Console.WriteLine("No hay trabajadores disponibles");
            }

            foreach (Trabajador item in jefeslogistica)
            {
                item.mostrarInformacion();
            }
        }

        public void mostrarEmplLog()
        {
            List<Trabajador> empleadosLogistica = ListaTrabajadores.Where(x => x.ToString().Contains("EmpleadoLogistica")).ToList();
            if (empleadosLogistica.Count() == 0)
            {
                Console.WriteLine("No hay trabajadores disponibles");
            }

            foreach (Trabajador item in empleadosLogistica)
            {
                item.mostrarInformacion();
            }
        }

        public void mostrarEmpPorContrato()
        {
            Console.WriteLine("Por que quieres buscar por ETT o Empresa");
            string contratacion = Console.ReadLine();
            if (contratacion == "ETT" || contratacion == "Empresa")
            {
                ListaTrabajadores.ForEach(x =>
                {

                    if (x.GetType().Name == "EmpleadoLogistica" && ((EmpleadoLogistica)x).tipoContratacion == contratacion)
                    {
                        x.mostrarInformacion();
                    }
                });
            }
            else
            {
                Console.WriteLine("¡Error!, Escriba ETT o Empresa");
            }
        }

        public void mostrarJefePorAnhos()
        {
            Console.WriteLine("Indique los años de experiencia por los que desea filtrar a los jefes de logística,Mostrara los jefes desde el numero indicado");
            int anhosFiltrar;
            anhosFiltrar = int.Parse(Console.ReadLine());

            ListaTrabajadores.ForEach(x =>
            {
                if (x.GetType().Name == "JefeLogistica" && anhosFiltrar <= ((JefeLogistica)x).anhosExperiencia)
                {
                    Console.WriteLine("No hay jefes que mostrar");
                }
                if (x.GetType().Name == "JefeLogistica" && ((JefeLogistica)x).anhosExperiencia <= anhosFiltrar)
                {
                    x.mostrarInformacion();
                }
            });
        }
        public void gestionLogistica()
        {
           
            bool finalizar = false;

            do
            {
                Console.WriteLine("1-Crear un Jefe de logística");
                Console.WriteLine("2-Crear un Empleado de logística");
                Console.WriteLine("3-Actualizar un Jefe de logística");
                Console.WriteLine("4-Actualizar un Empleado de logística");
                Console.WriteLine("5-Buscar un Jefe de logística por nombre");
                Console.WriteLine("6-Buscar un Empleado de logistica por nombre");
                Console.WriteLine("7-Mostrar todos los Jefes de logística");
                Console.WriteLine("8-Mostrar todos los Empleados de logística");
                Console.WriteLine("9-Mostrar todos los Empleados de logística por tipo de contratación (ETT o Empresa)");
                Console.WriteLine("10-Mostrar todos los Jefes de logística por años de experiencia");
                Console.WriteLine("11-Volver atrás");
                
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.Clear();
                        creaJefeLogistica();

                        break;
                    case "2":
                        Console.Clear();
                        creaEmpleadoLogistica();
                        break;
                    case "3":
                        Console.Clear();
                        actualizaJefeLogistica();
                        break;
                    case "4":
                        Console.Clear();
                        actualizaEmpleadoLogistica();
                        break;
                    case "5":
                        Console.Clear();
                        buscarJefeLogPorNombre();
                        break;
                    case "6":
                        Console.Clear();
                        buscarEmplLogPorNombre();
                        break;
                    case "7":
                        Console.Clear();
                        mostrarJefeLog();
                        break;
                    case "8":
                        Console.Clear();
                        mostrarEmplLog();
                        break;
                    case "9":
                        Console.Clear();
                        mostrarEmpPorContrato();
                        break;
                    case "10":
                        Console.Clear();
                        mostrarJefePorAnhos();
                        break;
                    case "11":
                        Console.Clear();
                        menuGen();
                        finalizar = true;
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

                if (finalizar == false)
                {
                    Console.Write("(pulse cualquier tecla para volver al menú principal)");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (finalizar == false);
        }

        public void bajaUsuario()
        {
            Console.WriteLine("Introduzca el dni del usuario que quiere dar de baja");
            string dniBaja = Console.ReadLine();
            
            foreach (Trabajador item in ListaTrabajadores)
            {
            
                if (dniBaja == item.DNI)
                {
                    if (item.fechaBaja == new DateTime())
                    {
                        Console.WriteLine("Introduce una fecha de baja 'dd-MM-yyyy'");
                        item.fechaBaja = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                        Console.WriteLine("El trabajador se ha dado de baja correctamente");
                    }
                    else
                    {
                        Console.WriteLine($"El trabajador {item.nombre} ya se dio de baja {item.fechaBaja}");
                    }
                }
               
            }
            Console.WriteLine("Pulsa para finalizar");
            menuGen();
            

        }
        public void creaJefeOfi()
        {
            JefeOficina jefeOficina = new JefeOficina();
            jefeOficina.pedirDatos();
            ListaTrabajadores.Add(jefeOficina);
            Console.WriteLine();
        }
        public void creaEmplOfi()
        {
            //meter el jefe de logistica
            EmpleadoOficina empleado = new EmpleadoOficina();
            bool codigoJefecorrecto = false;

            List<Trabajador> Jefesoficina = ListaTrabajadores.Where(x => x.ToString().Contains("JefeOficina")).ToList();
            JefeOficina jefeElegido = new JefeOficina();
            foreach (Trabajador item in Jefesoficina)
            {
                Console.WriteLine(item.codigoTrabajador + " " + item.nombre + " " + item.apellidos);
            }
            do
            {
                Console.WriteLine("Escribe el codigo del Jefe que quieres asignar a este Trabajador");
                int codigoJefe = int.Parse(Console.ReadLine());
           
                foreach (Trabajador item2 in Jefesoficina)
                {
               
                    if (item2.codigoTrabajador == codigoJefe)
                    {
                        codigoJefecorrecto = true;
                        jefeElegido.codigoTrabajador = codigoJefe;
                        jefeElegido.nombre = item2.nombre;
                        jefeElegido.apellidos = item2.apellidos;
                        jefeElegido.departamento = ((JefeOficina)item2).departamento;
                        jefeElegido.anhosExperiencia = ((JefeOficina)item2).anhosExperiencia;
                        jefeElegido.DNI = item2.DNI;
                        jefeElegido.fechaNac = item2.fechaNac;

                        empleado.jefeOficina = jefeElegido;
                    }
                    else
                    {
                        Console.WriteLine("Valor Erroneo");
                        Console.WriteLine(item2.codigoTrabajador + " " + item2.nombre + " " + item2.apellidos);
                        codigoJefecorrecto = false;
                    }
                 }
            } while (codigoJefecorrecto == false);
            empleado.pedirDatos();
            
            Console.WriteLine("El Jefe asignado a " + empleado.nombre + " es " + jefeElegido.nombre);
            ListaTrabajadores.Add(empleado);
            Console.WriteLine();
        }
        public void actualizaJefeOfi()
        {
            Console.WriteLine("DNI del Jefe de oficina a modificar");
            string dniAmodificar = Console.ReadLine();
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "JefeOficina" && ((JefeOficina)item).DNI != dniAmodificar)
                {
                    Console.WriteLine("DNI incorrecto");
                }

                if (item.GetType().Name == "JefeOficina" && ((JefeOficina)item).DNI == dniAmodificar)
                {
                    string opcionMod;
                    bool terminar = false;
                    do
                    {
                        Console.WriteLine("1-Cambiar nombre");
                        Console.WriteLine("2-Cambiar apellidos");
                        Console.WriteLine("3-Cambiar DNI");
                        Console.WriteLine("4-Cambiar departamento");
                        Console.WriteLine("5-Cambiar años de experiencia");
                        Console.WriteLine("6-Salir");
                        opcionMod = Console.ReadLine();

                        switch (opcionMod)
                        {
                            case "1":
                                Console.WriteLine("Nuevo nombre");
                                string nuevoNombre = Console.ReadLine();
                                item.nombre = nuevoNombre;
                                break;
                            case "2":
                                Console.WriteLine("Nuevos Apellidos");
                                string nuevoApellido = Console.ReadLine();
                                item.apellidos = nuevoApellido;

                                break;
                            case "3":
                                Console.WriteLine("Nuevo DNI");
                                string nuevoDNI = Console.ReadLine();
                                item.DNI = nuevoDNI;
                                break;
                            case "4":
                                Console.WriteLine("Nuevo departamento");
                                string nuevaDepartamento = Console.ReadLine();
                                ((JefeOficina)item).departamento = nuevaDepartamento;
                                break;
                            case "5":
                                Console.WriteLine("Actualizar años de experiencia");
                                int nuevoAnhos = int.Parse(Console.ReadLine());
                                ((JefeOficina)item).anhosExperiencia = nuevoAnhos;
                                break;
                            case "6":
                                terminar = true;
                                break;
                        }
                    } while (terminar == true);
                }
            }
        }
        public void actualizaEmplOfi()
        {
            Console.WriteLine("DNI del empleado de oficina a modificar");
            string dniEmpleadoAmodificar = Console.ReadLine();
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "EmpleadoOficina" && ((EmpleadoOficina)item).DNI != dniEmpleadoAmodificar)
                {
                    Console.WriteLine("DNI incorrecto");
                }

                if (item.GetType().Name == "EmpleadoOficina" && ((EmpleadoOficina)item).DNI == dniEmpleadoAmodificar)
                {
                    string opcionMod;
                    bool terminar = false;
                    do
                    {
                        Console.WriteLine("1-Cambiar nombre");
                        Console.WriteLine("2-Cambiar apellidos");
                        Console.WriteLine("3-Cambiar DNI");
                        Console.WriteLine("4-Cambiar departamento");
                        Console.WriteLine("5-Cambiar Estudios");
                        Console.WriteLine("6-Salir");
                        opcionMod = Console.ReadLine();

                        switch (opcionMod)
                        {
                            case "1":
                                Console.WriteLine("Nuevo nombre");
                                string nuevoNombre = Console.ReadLine();
                                item.nombre = nuevoNombre;
                                break;
                            case "2":
                                Console.WriteLine("Nuevos Apellidos");
                                string nuevoApellido = Console.ReadLine();
                                item.apellidos = nuevoApellido;

                                break;
                            case "3":
                                Console.WriteLine("Nuevo DNI");
                                string nuevoDNI = Console.ReadLine();
                                item.DNI = nuevoDNI;
                                break;
                            case "4":
                                Console.WriteLine("Nueva seccion");
                                string nuevoDepartamento = Console.ReadLine();
                                ((EmpleadoOficina)item).departamento = nuevoDepartamento;
                                break;
                            case "5":
                                Console.WriteLine("Cambio de estudios");
                                string nuevosEstudios = Console.ReadLine();
                                ((EmpleadoOficina)item).estudiosSuperiores = nuevosEstudios;
                                break;
                            case "6":
                                terminar = true;
                                break;
                        }
                    } while (terminar == true);
                }
            }
        }
        public void buscarJefeOfiPorNombre()
        {
            Console.WriteLine("Nombre del Jefe de oficina que desea buscar");
            string nombreABuscar = Console.ReadLine();
            bool encontrado = false;
            foreach (Trabajador item in ListaTrabajadores)
            {
                if (item.GetType().Name == "JefeOficina" && ((JefeOficina)item).nombre == nombreABuscar)
                {
                    encontrado = true;
                    item.mostrarInformacion();
                }
            }
            if (encontrado==false)
            {
                Console.WriteLine("Nombre no encontrado");
            }
        }

        public void buscarEmplOfiPornombre()
        {
            Console.WriteLine("Nombre del Empleado de oficina que desea buscar");
            string nombreEmpleadoABuscar = Console.ReadLine();
           bool encontrado = false;
            foreach (Trabajador item in ListaTrabajadores)
            {

                if (item.GetType().Name == "EmpleadoOficina" && ((EmpleadoOficina)item).nombre == nombreEmpleadoABuscar)
                {
                    encontrado = true;
                    item.mostrarInformacion();
                }
            }
            if (encontrado==false)
            {
                Console.WriteLine("Nombre no encontrado");
            }
        }
        public void mostrarJefeOfi()
        {
            List<Trabajador> jefesOficina = ListaTrabajadores.Where(x => x.ToString().Contains("JefeOficina")).ToList();
            if (jefesOficina.Count() == 0)
            {
                Console.WriteLine("No hay trabajadores disponibles");
            }

            foreach (Trabajador item in jefesOficina)
            {
                item.mostrarInformacion();
            }
        }

        public void mostrarTodosEmplOfi()
        {
            List<Trabajador> empleadosOficina = ListaTrabajadores.Where(x => x.ToString().Contains("EmpleadoOficina")).ToList();
            if (empleadosOficina.Count() == 0)
            {
                Console.WriteLine("No hay trabajadores disponibles");
            }

            foreach (Trabajador item in empleadosOficina)
            {
                item.mostrarInformacion();
            }
        }
        public void MostrarEmplOfiPorEstudios()
        {
            Console.WriteLine("Escribe los estudios por los que quiere  filtrar");
            string estudios = Console.ReadLine();
            if (estudios == "Grado Superior" || estudios == "Grado Medio" || estudios == "Carrera Universitaria" || estudios == "Curso Inaem")
            {
                ListaTrabajadores.ForEach(x =>
                {

                    if (x.GetType().Name == "EmpleadoOficina" && ((EmpleadoOficina)x).estudiosSuperiores == estudios)
                    {
                        x.mostrarInformacion();
                    }
                });
            }
            else
            {
                Console.WriteLine("¡Error!, Escriba Grado superior, Grado medio, Carrera universitaria o Curso inaem");
            }


        }

        public void mostrarJefeOfiPorDept()
        {
            Console.WriteLine("Indique el departamento por que el quiere filtrar a los jefes de oficina");
            string departamentos;
            departamentos = Console.ReadLine();

            ListaTrabajadores.ForEach(x =>
            {
                if (x.GetType().Name == "JefeOficina" && departamentos != ((JefeOficina)x).departamento)
                {
                    Console.WriteLine("No hay Jefes que mostrar");
                }
                if (x.GetType().Name == "JefeOficina" && ((JefeOficina)x).departamento == departamentos)
                {
                    x.mostrarInformacion();
                }
            });
        }
        public void gestionOficina()
        {
            bool finalizar = false;
            do
            {
                
                Console.WriteLine("1-Crear un Jefe de Oficina");
                Console.WriteLine("2-Crear un Empleado de Oficina");
                Console.WriteLine("3-Actualizar un Jefe de Oficina");
                Console.WriteLine("4-Actualizar un Empleado de Oficina");
                Console.WriteLine("5-Buscar un Jefe de Oficina por nombre");
                Console.WriteLine("6-Buscar un Empleado de Oficina por nombre");
                Console.WriteLine("7-Mostrar todos los Jefes de Oficina");
                Console.WriteLine("8-Mostrar todos los Empleados de Oficina");
                Console.WriteLine("9-Mostrar todos los Empleados de Oficina por estudios");
                Console.WriteLine("10-Mostrar todos los Jefes de Oficina por departamento");
                Console.WriteLine("11-Volver atrás");

                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.Clear();
                        creaJefeOfi();

                        break;
                    case "2":
                        Console.Clear();
                        creaEmplOfi();
                        break;
                        
                    case "3":
                        Console.Clear();
                        actualizaJefeOfi();
                        break;
                    case "4":
                        Console.Clear();
                        actualizaEmplOfi();
                        break;
                    case "5":
                        Console.Clear();
                        buscarJefeOfiPorNombre();
                        break;
                    case "6":
                        Console.Clear();
                        buscarEmplOfiPornombre();
                        break;
                    case "7":
                        Console.Clear();
                        mostrarJefeOfi();
                        break;
                    case "8":
                        Console.Clear();
                        mostrarTodosEmplOfi();

                        break;
                    case "9":
                        Console.Clear();
                        MostrarEmplOfiPorEstudios();
                        break;
                    case "10":
                        Console.Clear();
                        mostrarJefeOfiPorDept();
                        break;
                    case "11":
                        Console.Clear();
                        menuGen();
                        finalizar = true;
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

                if (finalizar == false)
                {
                    Console.Write("(Pulse cualquier tecla para volver al menú principal)");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (finalizar == false);
        }
        public void datosBase()
        {
            ListaTrabajadores = new List<Trabajador>()
            {
                new JefeLogistica()
                {
                    DNI="73029044F",
                    nombre="Javi",
                    apellidos="Perales Bona",
                    fechaNac= new DateTime(1995,1,7),
                    seccion="Transporte",
                    anhosExperiencia=2
                },

               new EmpleadoLogistica()
               {
                   DNI="73015032F",
                    nombre="Eva",
                    apellidos="Pascual Veamonte",
                    fechaNac= new DateTime(1994,3,14),
                    seccion="Picking",
                    tipoContratacion="Empresa"

               },
                  new EmpleadoLogistica()
               {
                   DNI="72098743T",
                    nombre="Maria",
                    apellidos="Campos Jimenez",
                    fechaNac= new DateTime(1995,3,1),
                    seccion="Entradas",
                    tipoContratacion="ETT"

               },
                  new JefeOficina()
                  {
                      DNI="25667890Y",
                      nombre="Pablo",
                      apellidos="Bona Romero",
                      fechaNac = new DateTime(1999,5,4),
                      departamento="TIC",
                      anhosExperiencia=3

                  },
                  new JefeLogistica()
                  {
                    DNI="73029055F",
                    nombre="Javier",
                    apellidos="Perales",
                    fechaNac= new DateTime(1995,1,7),
                    seccion="Transporte",
                    anhosExperiencia=2,
                    fechaBaja= new DateTime(2020,1,7)
                  }
                
            };
            
        }

    }//class
}
