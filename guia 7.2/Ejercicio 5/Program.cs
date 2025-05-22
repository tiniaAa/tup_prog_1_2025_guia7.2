using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menor, n;
            int orden;

            Console.WriteLine("Ingrese el primer numero");
            n=Convert.ToDouble(Console.ReadLine());
            menor = n;
            orden = 1;

            Console.WriteLine("Ingrese el segundo numero ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < menor)
            {
                menor = n;
                orden = 2;
            }
            Console.WriteLine("Ingrese el tercer numero ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < menor)
            {
                menor = n;
                orden = 3;
            }
            Console.WriteLine("Ingrese el cuarto numero ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < menor)
            {
                menor = n;
                orden = 4;
            }
            Console.WriteLine("Ingrese el quinto numero ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < menor)
            {
                menor = n;
                orden = 5;
            }
            Console.WriteLine($"El numero menor es {menor} Fue ingresado {orden}");

        }
    }
}
