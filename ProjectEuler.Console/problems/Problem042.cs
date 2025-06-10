public class Problem042
{
    public List<long> TriangularNumbers { get; set; }
    public List<string> Words { get; set; }

    public Problem042()
    {
        TriangularNumbers = new List<long>();
        Words = File.ReadAllLines(@"data/problem042data.txt").First().Split(',').ToList();
    }

    public string Run()
    {
        int count = 0;
        foreach (string word in Words)
            if (isTriangularWord(word))
                count++;

        return count.ToString();
    }

    private bool isTriangularWord(string word)
    {
        int sum = 0;

        foreach (char c in word)
            sum += c - 'A' + 1;

        return isTriangularNumber(sum);
    }

    private bool isTriangularNumber(int n)
    {
        for (int i = 1; true; i++)
        {
            ulong t = triangleNumber((ulong)i);
            if (t > (ulong)n) return false;
            if (t == (ulong)n) return true;
        }
    }

    ulong triangleNumber(ulong n)
    {
        return n * (n + 1) / 2;
    }
}