using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
    {
        public List<Libro> libros { get; set; }

        public void CreaLibro()
        {
            Libro nuevoLibro = new Libro();
            Console.WriteLine("Nombre del libro");
            string nombreLibro = Console.ReadLine();
            nuevoLibro.titulo = nombreLibro;
            Console.WriteLine("Autor del libro");
            string autorLibro = Console.ReadLine();
            nuevoLibro.autor = autorLibro;
            Console.WriteLine("Año del libro");
            string anho = Console.ReadLine();
            nuevoLibro.anho = anho;
            Console.WriteLine("Genero literario");
            string generoLibro = Console.ReadLine();
            nuevoLibro.genero = generoLibro;

            libros.Add(nuevoLibro);
        }

        public void LibrosBase()
        {
            Libro libroBase = new Libro();
            Libro libroBase1 = new Libro();
            Libro libroBase2 = new Libro();

            libroBase.titulo = "Juego de tronos";
            libroBase1.titulo = "SAW";
            libroBase2.titulo = "Antes de que se abra el paracaidas";

            libroBase.autor = "George R.R Martin";
            libroBase1.autor = "El de SAW";
            libroBase2.autor = "Defreds";

            libroBase.anho = "1995";
            libroBase1.anho = "2008";
            libroBase2.anho = "2016";

            libroBase.genero = "terror";
            libroBase1.genero = "terror";
            libroBase2.genero = "poesia";

            libros.Add(libroBase);
            libros.Add(libroBase1);
            libros.Add(libroBase2);
        }

        public void BuscarPorTitulo()
        {
            Console.WriteLine("Escriba el Titulo: ");
            string tituloABuscar = Console.ReadLine();
            Libro LibroEncontrado = libros.Find(x => x.titulo == tituloABuscar);
            if (LibroEncontrado == null)
            {
                //codigo para cuando no se encuentra una persona
                Console.WriteLine("El libro no existe o no se ha encontrado");
            }
            else
            {
                if (LibroEncontrado.alquiler == false)
                {
                    Console.WriteLine("El libro está disponible");
                }
                else
                {
                    Console.WriteLine("El libro no está disponible");
                }
                Console.WriteLine(LibroEncontrado.titulo + " " + LibroEncontrado.autor + " " + LibroEncontrado.anho + " " + LibroEncontrado.genero);

            }

        }

        public void BuscarPorGenero()
        {
            Console.WriteLine("Escriba el Genero que desea buscar: ");
            string GeneroABuscar = Console.ReadLine();
            Libro LibroEncontrado = libros.Find(x => x.genero == GeneroABuscar);
            if (LibroEncontrado == null)
            {
                //codigo para cuando no se encuentra una persona
                Console.WriteLine("El genero no existe o no se ha encontrado");
            }
            else
            {
                // List  <Libro > librosEncontrados = new List <Libro>();

                //librosEncontrados = librosEncontrados libros.Where(x => x.genero == GeneroABuscar).ToList();

                foreach (Libro item in libros.Where(x => x.genero == GeneroABuscar).ToList())
                {

                    Console.WriteLine(item.titulo + " " + item.autor + " " + item.anho + " " + item.genero);


                }


            }
        }

        public void ListaLibros()
        {
            Console.WriteLine("Listado de libros disponibles");
            foreach (Libro item in libros)
            {
                if (item.alquiler == false)
                {
                    Console.WriteLine(item.codigoLibro + "- " + item.titulo);
                }

            }
        }

        public bool ListaLibrosAlquilados()
        {
            Console.WriteLine("Listado de libros Alquilados");
            foreach (Libro item in libros)
            {
                if (item.alquiler != false)
                {
                    Console.WriteLine(item.codigoLibro + "- " + item.titulo);
                }
            }//for
            return true;
        }
        public void Ejecutar()
        {
            string opc = "";
            libros = new List<Libro>();
            bool terminar = false;
            LibrosBase();
            do
            {
                Console.WriteLine("1-Añadir nuevo libro");
                Console.WriteLine("2-Alquilar libro");
                Console.WriteLine("3-Buscar Libro");
                Console.WriteLine("4-Mostrar todos los libros de un determinado género");
                Console.WriteLine("5-Mostrar listado de libros alquilados");
                Console.WriteLine("6-Mostrar listado de libros disponibles(no alquilados");
                Console.WriteLine("7-Devolver un libro");
                Console.WriteLine("8-Salir");
                Console.WriteLine("Elija una opcion");
                opc = Console.ReadLine();
                Console.Clear();
                switch (opc)
                {
                    case "1":
                        CreaLibro();
                        break;

                    case "2":


                        ListaLibros();
                        Console.WriteLine("Escribe el codigo del libro que quiere alquilar,pulse  0 para salir");
                        string opcAlquiler = Console.ReadLine();
                        int opcAlnum = Int32.Parse(opcAlquiler);

                        foreach (Libro item in libros)
                        {

                            if (item.alquiler == false)
                            {

                                if (item.codigoLibro == opcAlnum && item.alquiler == false)
                                {
                                    item.alquiler = true;
                                    Console.WriteLine("Has alquilado " + item.titulo);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Libro no disponible o codigo erroneo");
                            }
                        }
                        break;
                    case "3":

                        BuscarPorTitulo();
                        break;
                    case "4":

                        BuscarPorGenero();
                        break;

                    case "5":

                        if (ListaLibrosAlquilados() != true)
                        {
                            Console.WriteLine("No hay Libros alquilados");
                        }

                        break;
                    case "6":
                        ListaLibros();
                        break;
                    case "7":
                        ListaLibrosAlquilados();
                        Console.WriteLine("Escriba el codigo del libro que desea devolver");
                        string CodigoLibro = Console.ReadLine();
                        int CodNum = Int32.Parse(CodigoLibro);

                        foreach (Libro item in libros)
                        {
                            if (item.codigoLibro == CodNum && item.alquiler == true)
                            {
                                item.alquiler = false;
                                Console.WriteLine("Has devuelto el libro" + item.titulo);
                                
                            }
                        }

                        break;
                }

            } while (opc != "8" && terminar == false);
        }

    }//biblioteca


}
