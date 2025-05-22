using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2, nombre3;
            int N1, N2, N3;

            Console.WriteLine("Ingrese los 3 nombres ");
            nombre1= Console.ReadLine();
            nombre2 = Console.ReadLine();
            nombre3 = Console.ReadLine();

            Console.WriteLine($"Ingrese la nota de {nombre1}");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese la nora  de {nombre2}");
            N2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese la nota  de {nombre3}");
            N3 = Convert.ToInt32(Console.ReadLine());





            if (N1 > N2 && N2 > N3)
            {
                Console.WriteLine($"{nombre1}  {N1}");
                Console.WriteLine($"{nombre2}  {N2}");
                Console.WriteLine($"{nombre3}  {N3}");


            }
            else 
            {
                if (N1 > N3 && N3 > N2)
                {
                    Console.WriteLine($"{nombre1}  {N1}");
                    Console.WriteLine($"{nombre3}  {N3}");
                    Console.WriteLine($"{nombre2}  {N2}");

                }

                else
                {
                    if (N2>N1 && N1>N3)
                    {
                        Console.WriteLine($"{nombre2}  {N2}");
                        Console.WriteLine($"{nombre1}  {N1}");
                        Console.WriteLine($"{nombre3}  {N3}");

                    }
                    else
                    {
                        if (N2>N3 && N3 > N1)
                        {
                            Console.WriteLine($"{nombre2} {N2}");
                            Console.WriteLine($"{nombre3} {N3}");
                            Console.WriteLine($"{nombre1} {N1}");
                        }
                        else
                        {
                            if (N3 > N1 && N1 > N2)
                            {
                                Console.WriteLine($"{nombre3}  {N3}");
                                Console.WriteLine($"{nombre1}  {N1}");
                                Console.WriteLine($"{nombre2}  {N2}");
                            }
                            else 
                            {
                                if (N3>N2 && N2 > N1)
                                {
                                    Console.WriteLine($"{nombre3}  {N3}");
                                    Console.WriteLine($"{nombre2}  {N2}");
                                    Console.WriteLine($"{nombre3}  {N3}");
                                }
                            }
                        }
                    }
                }

            }


        }
    }
}
