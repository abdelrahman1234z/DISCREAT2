using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter the first number");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("pls enter the Second number");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int x = start; x <= end; x++)
            {
                sum = 0;
                for (int i = 1; i <= x / 2; i++)
                {
                    if (x % i == 0)
                        sum++;
                }
                if (sum == x)
                    Console.WriteLine(x + "is aperfect number");


             }       

        }
    }
}
