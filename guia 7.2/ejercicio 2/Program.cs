using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese numero a verificar ");
            num=Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("El numero es negativo ");
            }
            else if (num == 0) 
            {
                Console.WriteLine("El numero es 0");
            }
            else
            {
                Console.WriteLine("El numero es positivo");
            }
            Console.ReadKey();
              
        }
    }
}
