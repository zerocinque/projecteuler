
public class Problem044
{
    long pentagonalNumber(int n)
    {
        return n * (3 * n - 1) / 2;
    }

    List<long> incrementPentagonalNember(List<long> pentagonalNumbers, int range = 1000)
    {
        int listDimension = pentagonalNumbers.Count + 1;
        for (int i = listDimension; i < listDimension + range; i++)
            pentagonalNumbers.Add(pentagonalNumber(i));

        return pentagonalNumbers;
    }

    public long Run()
    {
        List<long> pentagonalNumbers = new List<long>();
        long sumPentagonalNumber = 0;
        long diffPentagonalNumber = 0;
        long jPentagonalNumber = 0;
        long kPentagonalNumber = 0;

        bool found = false;

        while (!found)
        {
            incrementPentagonalNember(pentagonalNumbers);

            for (int j = 0; j < pentagonalNumbers.Count - 1 && !found; j++)
            {
                jPentagonalNumber = pentagonalNumbers.ElementAt(j);
                for (int k = 0; k < pentagonalNumbers.Count - 1 && !found; k++)
                {
                    kPentagonalNumber = pentagonalNumbers.ElementAt(k);

                    if (jPentagonalNumber == kPentagonalNumber) continue;

                    sumPentagonalNumber = pentagonalNumbers.Find(x => x == jPentagonalNumber + kPentagonalNumber);
                    diffPentagonalNumber = pentagonalNumbers.Find(x => x == jPentagonalNumber - kPentagonalNumber);

                    if (sumPentagonalNumber != 0 && diffPentagonalNumber != 0)
                        found = true;

                }
            }
        }

        return Math.Abs(kPentagonalNumber - jPentagonalNumber);
    }
}