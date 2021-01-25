using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indsæt et heltal");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < userInput; i++)
            {
                int isPrime = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                        isPrime++;

                    if (isPrime == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(i);
                        break;
                    }
                }
                if (isPrime != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
