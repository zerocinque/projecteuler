
public class Problem003
{

    bool isDivisibleBy(long number, long divisor)
    {
        return number % divisor == 0;
    }


    public long Run()
    {
        long[] primeFactors = findPrimeFactors(600851475143);
        return primeFactors.Max();
    }
    
    private long[] findPrimeFactors(long number)
    {
        if (number == 1)
            return new long[0];

        long divisor = 2;
        long[] primeFactors = new long[0];

        while (divisor <= number)
        {
            if (isDivisibleBy(number, divisor))
            {
                primeFactors = primeFactors.Append(divisor).ToArray();
                number /= divisor;
            }
            else
            {
                divisor++;
            }
        }
        return primeFactors;
    }
}