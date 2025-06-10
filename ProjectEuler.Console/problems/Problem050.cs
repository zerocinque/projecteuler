using ProjectEuler.Lib;

public class Problem050
{
    private static int MAX_VALUE = 1000000;

    private List<int> primes { get; set; }

    public Problem050()
    {
        primes = new List<int>();
    }

    public string Run()
    {
        List<int> sums = new List<int>();
        int maxPrime = 0;
        int maxTerms = 0;

        for (int i = 2; ; i++)
        {
            if (i.IsPrime())
                primes.Add(i);

            if (primes.Any())
                if (primes.Last() > MAX_VALUE - primes.Last())
                    break;
        }

        for (int i = 0; i < primes.Count; i++)
        {
            int sum = 0;
            for (int j = i; j < primes.Count; j++)
            {
                sum += primes[j];

                if (sum > MAX_VALUE) break;

                if (sum.IsPrime() && sum >= maxPrime && (j - i + 1) >= maxTerms)
                {
                    maxPrime = sum;
                    maxTerms = j - i + 1;
                }
            }
        }

        return maxPrime.ToString();
    }

}