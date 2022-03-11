public class Problem007
{
    public long Run()
    {
        int count = 0;
        long lastPrime = 2;

        for (int i = 2; count != 10001; i++)
        {

            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if(i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime){
                count++;
                lastPrime = i;
            }
        }

        return lastPrime;
    }
}