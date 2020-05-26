using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> ingresos1 = new List<decimal>();
            List<decimal> ingresos2 = new List<decimal>();
            List<decimal> retiradas1 = new List<decimal>();
            List<decimal> retiradas2 = new List<decimal>();
            List<decimal> movimientos1 = new List<decimal>();
            List<decimal> movimientos2 = new List<decimal>();
            List<decimal> SaldosPorCliente = new List<decimal>();
            List<List<decimal>> ListaIngresosPorCliente = new List<List<decimal>>();
            List<List<decimal>> ListaRetiradasPorCliente = new List<List<decimal>>();
            List<List<decimal>> ListaMovimientosPorCliente = new List<List<decimal>>();
            List<string> NumerosDeCuentaPorCliente = new List<string>();
            List<int> NumerosPinPorCliente = new List<int>();
            decimal saldo1 = 100;
            SaldosPorCliente.Add(saldo1);
            decimal saldo2 = 200;
            SaldosPorCliente.Add(saldo2);
            string numeroCuenta1 = "123456789";
            string numeroCuenta2 = "987654321";
            NumerosDeCuentaPorCliente.Add(numeroCuenta1);
            NumerosDeCuentaPorCliente.Add(numeroCuenta2);
            int pin1 = 1234;
            int pin2 = 4321;
            NumerosPinPorCliente.Add(pin1);
            NumerosPinPorCliente.Add(pin2);
            string cuentaIntroducida;
            int pinIntroducido;
            string opc = "", opc2 = "";
            decimal cantidad;
            Console.WriteLine("Introduce el numero de cuenta bancaria al que desea acceder");
            cuentaIntroducida = Console.ReadLine();

           if(cuentaIntroducida == numeroCuenta1  || cuentaIntroducida == numeroCuenta2)
            {
                Console.WriteLine("Introduce el pin");
                pinIntroducido = int.Parse(Console.ReadLine());

                if(cuentaIntroducida == numeroCuenta1 && pinIntroducido== pin1 || cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                {
                    do
                    {
                        Console.WriteLine("1-Ingreso de efectivo");
                            Console.WriteLine("2-Retirada de efectivo");
                            Console.WriteLine("3-Lista de todos movimientos");
                            Console.WriteLine("4-Lista de todos los ingresos de efectivo");
                            Console.WriteLine("5-Lista de todas retiradas de efectivo");
                            Console.WriteLine("6-Mostrar saldo actual");
                            Console.WriteLine("7-Salir");
                            Console.WriteLine("Escoja una opcion");
                            opc = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("");

                        switch (opc)
                          {
                    case "1":
                        Console.WriteLine("Ingrese cantidad de dinero que desea ingresar");
                       cantidad = decimal.Parse(Console.ReadLine());
                                if (cuentaIntroducida == numeroCuenta1 && pinIntroducido == pin1)
                                {
                                    saldo1 += cantidad;
                                    ingresos1.Add(cantidad);
                                    Console.WriteLine("su saldo actual es: " +saldo1);
                                }
                                if(cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                                {
                                    saldo2 += cantidad;
                                    ingresos2.Add(cantidad);
                                    Console.WriteLine("su saldo actual es: " + saldo2);
                                }
                                ListaIngresosPorCliente.Add(ingresos1);
                                ListaIngresosPorCliente.Add(ingresos2);

                                movimientos1.Add(cantidad);
                                movimientos2.Add(cantidad);
                                ListaMovimientosPorCliente.Add(movimientos1);
                                ListaMovimientosPorCliente.Add(movimientos2);
                               

                                   break;

                               case "2":
                                Console.WriteLine("Ingrese cantidad de dinero que desea retirar");
                                cantidad = decimal.Parse(Console.ReadLine());
                                if (cuentaIntroducida == numeroCuenta1 && pinIntroducido == pin1)
                                {
                                    saldo1 -= cantidad;

                                    retiradas1.Add(cantidad);
                                    Console.WriteLine("su saldo actual es: " + saldo1);
                                }
                                if (cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                                {
                                    saldo2 -= cantidad;
                                    retiradas2.Add(cantidad);
                                    Console.WriteLine("su saldo actual es: " + saldo2);
                                }
                                ListaRetiradasPorCliente.Add(retiradas1);
                                ListaRetiradasPorCliente.Add(retiradas2);

                                movimientos1.Add(cantidad);
                                movimientos2.Add(cantidad);
                                ListaMovimientosPorCliente.Add(movimientos1);
                                ListaMovimientosPorCliente.Add(movimientos2);

                                break;
                               case "3":
                                    Console.WriteLine("Lista de movimientos");
                                    
                                if (cuentaIntroducida == numeroCuenta1 && pinIntroducido == pin1)
                                {
                                    foreach (decimal cliente1 in movimientos1)
                                    {
                                        Console.WriteLine(cliente1);
                                    }


                                }

                                if (cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                                {
                                    foreach (decimal cliente2 in movimientos2)
                                    {
                                        Console.WriteLine(cliente2);
                                    }
                                }
                                break;
                                case "4":
                                    Console.WriteLine("Ingresos");
                                if(cuentaIntroducida == numeroCuenta1 && pinIntroducido == pin1)
                                {
                                    foreach (decimal ing1 in ingresos1)
                                    {
                                        Console.WriteLine("Lista de ingresos " + ing1);
                                    }
                                }
                                if (cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                                {
                                    foreach (decimal ing2 in ingresos2)
                                    {
                                        Console.WriteLine("Lista de ingresos " + ing2);
                                    }
                                }


                                break;
                                case "5":
                                Console.WriteLine("Retiradas");
                                if (cuentaIntroducida == numeroCuenta1 && pinIntroducido == pin1)
                                {
                                    foreach (decimal ret1 in retiradas1)
                                    {
                                        Console.WriteLine("Lista de retiradas " + ret1);
                                    }
                                }
                                if (cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                                {
                                    foreach (decimal ret2 in retiradas2)
                                    {
                                        Console.WriteLine("Lista de retiradas " + ret2);
                                    }
                                }
                                break;
                                case "6":
                                   if(cuentaIntroducida == numeroCuenta1 && pinIntroducido == pin1)
                                {
                                    Console.WriteLine(saldo1);
                                }
                                    if(cuentaIntroducida == numeroCuenta2 && pinIntroducido == pin2)
                                {
                                    Console.WriteLine(saldo2);
                                }
                                    break;
                                case "7":
                                    
                                    Console.WriteLine("Pulse para salir");
                                    break;
                                default:
                                    Console.WriteLine("Error en la opcion introducida");       
                                break;
                            }
                                                } while (opc != "7");
                }
                else
                {
                    Console.WriteLine("El  pin no es correcto");
                }

               
            }
            else
            {
                Console.WriteLine("La cuenta no existe");
            }

            Console.ReadKey();


        }
    }
}
