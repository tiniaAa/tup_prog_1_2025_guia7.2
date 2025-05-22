using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, Mnum;

            Console.WriteLine("Ingrese un numero ");
            num=Convert.ToDouble(Console.ReadLine());
            Mnum = num;

            Console.WriteLine("Ingrese otro numero");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > Mnum)
            { Mnum = num; }
            
            Console.WriteLine("Ingrese otro numero");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > Mnum)
            { Mnum = num; }

            Console.WriteLine("Ingrese otro numero");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > Mnum)
            { Mnum = num; }

            Console.WriteLine("Ingrese otro numero");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > Mnum)
            { Mnum = num; }

            Console.WriteLine($"El numero mayor es {Mnum}");

        }
    }
}
