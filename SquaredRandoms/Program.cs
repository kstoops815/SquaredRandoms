using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumberGenerator = new Random();
            // Create a list
            var randomNumbers = new List<int>();
            var squaredNumbers = new List<int>();
            var evenOnlyNumbers = new List<int>();

            Console.WriteLine("Random Number List");
            for (int i = 0; i < 20; i++)
            {
                var newNumber = randomNumberGenerator.Next(1, 51);
                randomNumbers.Add(newNumber);
                Console.WriteLine(newNumber);
            }

            Console.WriteLine("Number Squared List");
            foreach (var number in randomNumbers)
            {
                var squaredNumber = number * number;
                squaredNumbers.Add(squaredNumber);
                Console.WriteLine(squaredNumber);
            }

            Console.WriteLine("Even Only List");

            foreach (var number in squaredNumbers)
            {
                if (number % 2 == 0)
                {
                    evenOnlyNumbers.Add(number);
                    Console.WriteLine(number);
                }
            }
           
            Console.Read();
                       

        }
    }
}
