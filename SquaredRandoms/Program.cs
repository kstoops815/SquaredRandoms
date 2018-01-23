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

            for (int i = 0; i < 20; i++)
            {
                var newNumber = randomNumberGenerator.Next(1, 51);
                randomNumbers.Add(newNumber);
                Console.WriteLine(newNumber);
            }


            // Populate the list
            //randomNumbers.Add
        }
    }
}
