using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec = 1;
            while (selec != 0)
            {
                Console.WriteLine("Opcion 0");
                Console.WriteLine("Opcion 1");
                Console.WriteLine("Opcion 2");
                Console.WriteLine("Opcion 3");
                Console.WriteLine("Opcion 4");
                Console.WriteLine("Opcion 5");
                Console.WriteLine("Opcion 6");
                Console.WriteLine("Opcion 7");
                Console.WriteLine("Opcion 8");
                Console.WriteLine("Opcion 9");
                selec = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (selec)
                {
                    case 1:
                        string[] Canciones1 = new string[5];
                        int CancionesIngresadas = 0;
                        string Nombre;
                        while (CancionesIngresadas < 5)
                        {
                            Console.WriteLine("Ingrese cinco canciones: ");
                            Nombre = Console.ReadLine();
                            Canciones1[CancionesIngresadas] = Nombre;
                            CancionesIngresadas++;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Los datos han sido guardados!");

                        Console.ReadKey();
                        break;

                    case 2:
                        string[] Canciones = new string[5];
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("Ingrese cinco canciones: ");
                                Canciones[i] = Console.ReadLine();
                            }
                            Console.WriteLine(" ");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine(Canciones[i]);
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        string[] Nombres1 = new string[5];
                        int[] Edad1 = new int[5];
                        string no;
                        int NombresIngresados = 0;
                        int ed;
                        int EdadesIngresadas = 0;
                        while (NombresIngresados < 5)
                        {
                            Console.Write("Ingrese nombres: ");
                            no = Console.ReadLine();
                            Nombres1[NombresIngresados] = no;
                            NombresIngresados++;
                            Console.WriteLine(" ");
                        }
                        while (EdadesIngresadas < 5)
                        {
                            Console.Write("Ingrese sus edades: ");
                            ed = int.Parse(Console.ReadLine());
                            Edad1[EdadesIngresadas] = ed;
                            EdadesIngresadas++;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Los datos han sido cargados!");
                        Console.ReadKey();
                        break;

                    case 4:
                        for (int i = 1; i < 51; i++)
                        {
                            Console.WriteLine("Numeros: " + i);
                        }

                        Console.ReadKey();
                        break;
                    case 7:
                        int Semana;
                        do
                        {
                            Console.WriteLine("Ingrese un numero del 1 al 7");
                            Semana = int.Parse(Console.ReadLine());
                            switch (Semana)
                            {
                                case 1:
                                    Console.WriteLine("Lunes");
                                    break;
                                case 2:
                                    Console.WriteLine("Martes");
                                    break;
                                case 3:
                                    Console.WriteLine("Miercoles");
                                    break;
                                case 4:
                                    Console.WriteLine("Jueves");
                                    break;
                                case 5:
                                    Console.WriteLine("Viernes");
                                    break;
                                case 6:
                                    Console.WriteLine("Sabado");
                                    break;
                                case 7:
                                    Console.WriteLine("Domingo");
                                    break;
                            }
                        } while (Semana != 0);
                        
                        Console.ReadKey();
                        break;
                    case 8:
                        int Mes;
                        do
                        {
                            Console.WriteLine("Ingrese un numero entre 0 y 12 (el 0 finaliza)");
                            Mes = int.Parse(Console.ReadLine());
                            switch (Mes)
                            {
                                case 1:
                                    Console.WriteLine("Enero");
                                    break;
                                case 2:
                                    Console.WriteLine("Febrero");
                                    break;
                                case 3:
                                    Console.WriteLine("Marzo");
                                    break;
                                case 4:
                                    Console.WriteLine("Abril");
                                    break;
                                case 5:
                                    Console.WriteLine("Mayo");
                                    break;
                                case 6:
                                    Console.WriteLine("Junio");
                                    break;
                                case 7:
                                    Console.WriteLine("Julio");
                                    break;
                                case 8:
                                    Console.WriteLine("Agosto");
                                    break;
                                case 9:
                                    Console.WriteLine("Septiembre");
                                    break;
                                case 10:
                                    Console.WriteLine("Octubre");
                                    break;
                                case 11:
                                    Console.WriteLine("Noviembre");
                                    break;
                                case 12:
                                    Console.WriteLine("Diciembre");
                                    break;
                            }
                        } while (Mes != 0);
                        Console.ReadKey();
                        break;
                    case 9:

                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
