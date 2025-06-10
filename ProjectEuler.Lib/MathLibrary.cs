
using System.Numerics;

namespace ProjectEuler.Lib
{
    public static class MathLibrary
    {
        public static bool IsPrime(this int n)
        {
            return ((BigInteger)n).IsPrime();
        }
        public static bool IsPrime(this long n)
        {
            return ((BigInteger)n).IsPrime();
        }
        public static bool IsPrime(this ulong n)
        {
            return ((BigInteger)n).IsPrime();
        }
        public static bool IsPrime(this BigInteger n)
        {
            if (n == 1) return false;
            else if (n < 4) return true;  //2 and 3 are prime
            else if (n % 2 == 0) return false;
            else if (n < 9) return true;    //we have already excluded 4,6 and 8.
            else if (n % 3 == 0) return false;
            else
            {
                var r = Math.Floor(Math.Sqrt((double)n)); // n rounded to the greatest integer r so that r*r<=n f=5
                int f = 5;
                while (f <= r)
                {
                    if (n % f == 0) return false;
                    if (n % (f + 2) == 0) return false;
                    f = f + 6;
                }
            }
            return true;
        }


        public static List<BigInteger> PrimeFactors(this int n)
        {
            return ((BigInteger)n).PrimeFactors();
        }
        public static List<BigInteger> PrimeFactors(this long n)
        {
            return ((BigInteger)n).PrimeFactors();
        }
        public static List<BigInteger> PrimeFactors(this ulong n)
        {
            return ((BigInteger)n).PrimeFactors();
        }
        public static List<BigInteger> PrimeFactors(this BigInteger n)
        {
            List<BigInteger> factors = new List<BigInteger>();
            // Print the number of 2s that divide n
            while (n % 2 == 0)
            {
                factors.Add(2);
                n /= 2;
            }

            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt((double)n); i += 2)
            {
                // While i divides n, print i and divide n
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            // This condition is to handle the case whien
            // n is a prime number greater than 2
            if (n > 2)
                factors.Add(n);

            return factors;
        }

        public static int FactorialNumber(this int n)
        {
            return (int)((BigInteger)n).FactorialNumber();
        }

        public static BigInteger FactorialNumber(this BigInteger n){
            if(n==0) return BigInteger.One;
            
            BigInteger factorial = n;

            for(BigInteger i = n-1; i>1; i--)
                factorial *= i;
            
            return factorial;
        }
    }
}