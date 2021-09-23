using System;

namespace PrimeList
{
    public class PrimeGenerator
    {
        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if(maxValue >= 2)
            {
                int s = maxValue + 1; //array size
                bool[] f = new bool[s];
                int i;

                for(i = 0; i < s; i++)
                {
                    f[i] = true;
                }

                //discards known not primes
                f[0] = f[1] = false;

                int j;
                for(i = 2; i < Math.Sqrt (s) + 1; i++)
                {
                    if(f[i])
                    {
                        for(j = 2 * i; j < s; j +=i)
                        {
                            f[j] = false; //the multiple is not a prime
                        }
                    }
                }


                //how many prime numbers exists?
                int count = 0;
                for(i = 0; i < s; i++)
                {
                    if(f[i])
                    {
                        count++; //increments count
                    }
                }

                int[] primes = new int[count];

                //moves prime numbers to result
                for(i = 0, j = 0; i < s; i++)
                {
                    if(f[i]) //if is prime
                    {
                        primes[j++] = i;
                    }
                }

                return primes;
            }
            else
            {
                return new int[0]; //returns null array if invalid input
            }
        }
    }
}