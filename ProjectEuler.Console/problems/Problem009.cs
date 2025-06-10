public class Problem009
{
    // a^2 + b^2 = c^2
    // a < b < c
    // a + b + c = 1000
    public long Run()
    {
        int sum = 1000;
        int a, b, c;
        for (a = 1; a < sum / 3; a++)
        {
            for (b = a + 1; b < sum / 2; b++)
            {
                c = sum - a - b;
                if (a * a + b * b == c * c)
                {
                    return a * b * c;
                }
            }
        }
        return -1; // No solution found
    }
}
