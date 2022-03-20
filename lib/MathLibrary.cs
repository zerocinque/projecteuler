
using System.Numerics;

namespace Library
{
    public static class MathLibrary
    {
        public static bool IsPrime(this int n){
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

        public static bool IsPrime(this BigInteger n){
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

    }
}