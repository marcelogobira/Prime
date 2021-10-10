using System;

namespace PrimeList
{
    public class PrimeGenerator
    {
        private static int s;
        private static bool[] f;
        private static int[] primes;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if(maxValue < 2)
            {
                return new int[0];
            }

            InitializeSieve(maxValue);
            Sieve();
            LoadPrimes();
            return primes;
        }

        private static void LoadPrimes()
        {
            int i;
            int j;

            //How many prime numbers exists?
            int count = 0;

            for(i = 0; i < s; i++)
            {
                if(f[i])
                {
                    count++; //increase count
                }
            }

            primes = new int[count];

            for(i = 0, j = 0; i < s; i++)
            {
                if(f[i])
                {
                    primes[j++] = i;
                }
            }
        }

        private void InitializeSieve(int maxValue)
        {
            s = maxValue + 1;
            f = new bool[s];
            int i;

            for(i = 0; i < s; i++)
            {
                f[i] = true;
            }

            //discard known primes
            f[0] = f[1] = false;
        }
    }
}