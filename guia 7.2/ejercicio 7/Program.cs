using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bis;
            Console.WriteLine("Ingrese año a verificar si es bisisesto");
            bis = Convert.ToInt32(Console.ReadLine());

            if (bis % 400 == 0)
            {
                Console.WriteLine("El año es bisiesto ");

            }
            else
            {
                if (bis % 100 == 0)
                {
                    Console.WriteLine("El año es bisiesto ");
                }
                else
                {
                    if (bis % 4 == 0) 
                    {
                        Console.WriteLine("El año es bisiesto");

                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto ");
                    }
                }
            }


        }   
    }
}
