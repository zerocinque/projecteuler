using Library;

public class Problem047
{
    private int DISTINCT_PRIME_FACTORS { get; }
    private int CONSECUTIVE_NUMBERS { get; }

    public Problem047()
    {
        DISTINCT_PRIME_FACTORS = 4;
        CONSECUTIVE_NUMBERS = 4;
    }

    public string Run()
    {
        int consecutiveNumbers = 0;
        int firstNumberOfTheSerie = -1;

        for (int i = 1; true; i++)
        {
            var factors = i.PrimeFactors();
            factors = factors.Distinct().ToList();
            bool factorsArePrime = true;

            if (factors.Count == DISTINCT_PRIME_FACTORS)
            {
                foreach (var factor in factors)
                {
                    if (!factor.IsPrime())
                    {
                        factorsArePrime = false;
                        break;
                    }
                }

                if (factorsArePrime)
                    consecutiveNumbers++;
                else consecutiveNumbers = 0;

                if (consecutiveNumbers == 1) firstNumberOfTheSerie = i;
                if (consecutiveNumbers == CONSECUTIVE_NUMBERS) return firstNumberOfTheSerie.ToString();
            }
            else
                consecutiveNumbers = 0;
        }
    }
}