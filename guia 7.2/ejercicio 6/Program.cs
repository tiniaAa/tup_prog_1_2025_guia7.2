using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int set1_j1,set1_j2,set2_j1,set2_j2,set3_j1,set3_j2,tot1,tot2;
            string jugador1,jugador2;

            Console.WriteLine("Ingrese el nombre del jugador 1 ");
            jugador1 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del jugador 2");
            jugador2 = Console.ReadLine();
            
            Console.WriteLine($"Ingrese resultado de los 3 sets de {jugador1}");
            set1_j1=Convert.ToInt32(Console.ReadLine());
            set2_j1 = Convert.ToInt32(Console.ReadLine());
            set3_j1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese resultado de los 3 sets de {jugador2}");
            set1_j2 = Convert.ToInt32(Console.ReadLine());
            set2_j2 = Convert.ToInt32(Console.ReadLine());
            set3_j2 = Convert.ToInt32(Console.ReadLine());

            tot1= set1_j1 +set2_j1 +set3_j1;
            tot2= set1_j2+set2_j2 +set3_j2;

            if (tot1 > tot2)
            {
                Console.WriteLine($"Ganó {jugador1}:{set1_j1},{set2_j1},{set3_j1}");
            }
            else
            {
                if (tot1<tot2)
                {
                    Console.WriteLine($"Ganó {jugador2}:{set1_j2},{set2_j2},{set3_j2}");
                }
                else
                {
                    Console.WriteLine("Ingresaste mal los resultados, los jugadores no pueden empatar ");
                }
            }


        }
    }
}
