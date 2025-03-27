using System;

namespace Diagnostico3
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
                selec = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(selec)
                {
                    case 1:
                        string[] Canciones1 = new string[5];
                            int CancionesIngresadas = 0;
                            string Nombre;
                            while(CancionesIngresadas < 5)
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
                        while(NombresIngresados < 5)
                        {
                            Console.Write("Ingrese nombres: ");
                            no = Console.ReadLine();
                            Nombres1[NombresIngresados] = no;
                            NombresIngresados++;
                            Console.WriteLine(" ");
                        }
                             while(EdadesIngresadas < 5)
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
                        string[] Nombres = new string[5];
                        int[] Edad = new int[5];
                        {
                            for (int n = 0; n < 5; n++)
                            {
                                Console.Write("Ingrese nombres: ");
                                Nombres[n] = Console.ReadLine();
                                Console.WriteLine(" ");
                            }
                            for (int n = 0; n < 5; n++)
                            {
                                Console.WriteLine(Nombres[n]);
                            }
                            Console.WriteLine(" ");
                            for (int e = 0; e < 5; e++)
                            {
                                Console.Write("Ingrese sus edades: ");
                                Edad[e] = int.Parse(Console.ReadLine());
                                Console.WriteLine(" ");
                            }
                            for (int e = 0; e < 5; e++)
                            {
                                Console.WriteLine(Edad[e]);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        int[] N1 = new int[5];
                        int[] N2 = new int[5];
                        int[] N3 = new int[5];
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Ingrese cinco numeros: ");
                                N1[i] = int.Parse(Console.ReadLine());
                                Console.WriteLine(" ");
                            }



                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Ingrese otros cinco numeros: ");
                                N2[i] = int.Parse(Console.ReadLine());
                                Console.WriteLine(" ");
                            }



                            for (int i = 0; i < 5; i++)
                            {
                                N3[i] = N1[i] + N2[i];
                            }
                            for (int i = 0; i< 5; i++)
                            {
                                Console.WriteLine(N3[i] + " ");
                            }
                        }
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
