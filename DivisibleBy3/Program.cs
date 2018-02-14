using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 to 100, find divisible by 3 with 0 remainder

            //int[] numbers = Enumerable.Range(1, 100).ToArray();

            int count = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Total Count: " + count);
            Console.ReadLine();

        }
    }
}
