using System;
using System.Linq;

namespace SeriesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int[] numbersArray = null;

            Console.WriteLine("Enter a series of number separated by a comma:");
            input = Console.ReadLine();

            try
            {
                // see: https://www.dotnetperls.com/exception
                // This try catch helps in handling exceptions, we can display messages in the catch block when the user forgets to provide the correct input
                numbersArray = Array.ConvertAll(input.Split(','), int.Parse); // see: https://www.dotnetperls.com/array-convertall for `Array.ConvertAll`
                int maxValue = numbersArray.Max();
                Console.WriteLine("The max value is: " + maxValue);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("***Did you forget to only include numbers?***");
            }

            Console.ReadLine();

        }
    }
}
