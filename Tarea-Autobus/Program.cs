using System;
using System.Collections.Generic;

namespace ConsoleApp4_OJO_
{

    class Menu
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.desplegar();
        }
        private int opcion;
        private List<Autobus> ListaVehiculos;

        public void desplegar()
        {
            ListaVehiculos = new List<Autobus>();

            do
            {
                do
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("1-Crear Autobus");
                    Console.WriteLine("2-Editar Autobus");
                    Console.WriteLine("3-Listar Autobus");
                    Console.WriteLine("4-Eliminar Autobus");
                    Console.WriteLine("5-Salir");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Digite la opcion:");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("Ingrese una opcion valida {1-5}");

                    }

                } while (opcion < 1 || opcion > 5);
                switch (opcion)
                {
                    case 1:
                        {
                            /*Crear Autobus*/
                            Autobus Nuevobus = new Autobus();


                            Console.Write("Marca del Autobus: ");
                            Nuevobus.Marca = Console.ReadLine();

                            Console.Write("Modelo del Autobus: ");
                            Nuevobus.Modelo = Console.ReadLine();

                            Console.Write("Capacidad del Autobus: ");
                            Nuevobus.Capacidad = Console.ReadLine();
                            ListaVehiculos.Add(Nuevobus);
                            break;

                        }

                    case 2:
                        {
                            /*Editar autobus*/

                            break;
                        }

                    case 3:
                        {
                            /*Listar todos los  Autobus*/
                            /* Listar Autobus */
                            foreach (Autobus b in ListaVehiculos)
                            {
                                Console.WriteLine("--------------------");
                                Console.WriteLine("Marca:" + b.Marca);
                                Console.WriteLine("Modelos:" + b.Modelo);
                                Console.WriteLine("Capacidad:" + b.Capacidad);
                            }

                            break;
                        }

                    case 4:
                        {
                            /*Eliminar Autobus*/
                           
                            int MarcaEliminar;


                            Console.WriteLine("Ingrese el Autobus que desee eliminar: ");
                            MarcaEliminar = Convert.ToInt32(Console.ReadLine());

                           
                          

                            break;
                        }

                    case 5:
                        {
                            /*Salir*/
                            Console.WriteLine("Gracias por usar nuestros sevircicios");
                            Console.ReadLine();

                            break;
                        }


                }





            } while (opcion != 5);


        }

        
        

    }
}



  
