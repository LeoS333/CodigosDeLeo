using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimo = 0;
            Console.WriteLine("Ingrese desde que numero quiere contar");
            int.Parse(Console.ReadLine());
            int maximo = 0;
            Console.WriteLine("Ingrese hasta que numero quiere contar");
            int.Parse(Console.ReadLine());
            for (int n = minimo; n < maximo; n++)
            {
                Console.WriteLine("Numeros: " + n);
            }
            Console.ReadKey();
        }
    }
}