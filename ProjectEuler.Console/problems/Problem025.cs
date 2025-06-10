using System.Numerics;

public class Problem025
{
    public string Run()
    {
        int i = 2;
        BigInteger secondLastFibonacciNumber = BigInteger.One;
        BigInteger lastFibonacciNumber = BigInteger.One;
        BigInteger nextFibonacciNumber = BigInteger.One;

        while (lastFibonacciNumber.ToString().Length < 1000)
        {
            nextFibonacciNumber = BigInteger.Add(secondLastFibonacciNumber, lastFibonacciNumber);
            secondLastFibonacciNumber = lastFibonacciNumber;
            lastFibonacciNumber = nextFibonacciNumber;
            i++;
        }

        return i.ToString();
    }

}