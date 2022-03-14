using System;

public class Problem010
{
    private const long MAX_VALUE = 2000000;


    private bool isPrime(long n)
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



    public string Run(){
        long sum = 0;

        for (int i = 2; true; i++)
        {
            if(isPrime(i)){
                if(i>=MAX_VALUE) break;
                sum += i;
            }
        }

        return sum.ToString();
    }
}