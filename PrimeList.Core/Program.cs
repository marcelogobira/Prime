using System;

namespace PrimeList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var primes = PrimeGenerator.GeneratePrimeNumbers(100);

            for(var i = 0; i < primes.Length; i++)
            {
                Console.WriteLine(primes[i]);
            }

            Console.Read();

        }
    }
}
