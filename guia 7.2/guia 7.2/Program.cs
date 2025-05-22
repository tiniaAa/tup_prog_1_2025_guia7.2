using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int prom;
            double n1, n2, n3, promedio;
            Console.WriteLine("Ingrese las 3 notas a evaluar ");

            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("Ingrese nota para promocionar ");
            prom = Convert.ToInt32(Console.ReadLine());

            if (promedio >= prom)
            {
                Console.WriteLine("Promociona la materia ");
            }
            else {
                Console.WriteLine("Rinde final ");
                    }

        }
    }
}
