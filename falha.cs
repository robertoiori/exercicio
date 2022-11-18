using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = new string[5];
            int[] pontos = new int[5];
            int tp = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome de um time de futebol");
                times[i] = Console.ReadLine();
                Console.WriteLine(" e quantos pontos o {0} tem", times[i]);
                pontos[i] = int.Parse(Console.ReadLine());
                tp++;
            }
            for (int i = 0; i < tp; i++)
            {
                Console.WriteLine("{0} \t\t {1} pontos", times[i], pontos[i]);
            }
            Console.ReadKey();
            {

            }
        }
    }
}
