using ProjectEuler.Lib;

public class Problem046
{
    public string Run()
    {

        for (ulong i = 4; true; i++)
        {
            if (!isOddCompositeNumber(i)) continue;

            if (!goldbachConjecture(i)) return i.ToString();
        }
    }

    private bool isOddCompositeNumber(ulong n)
    {
        return !n.IsPrime() && isOdd(n);
    }

    private bool isOdd(ulong n)
    {
        return n % 2 == 1;
    }

    private bool goldbachConjecture(ulong n)
    {

        for (ulong i = n - 2; i > 1; i--)
        {
            if (!i.IsPrime()) continue;

            for (ulong j = 1; (2 * j * j) <= (n - i); j++)
            {
                if (((2 * j * j) + i) == n) return true;
            }
        }

        return false;
    }
}