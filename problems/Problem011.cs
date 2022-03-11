public class Problem011
{
    public int[][] Data { get; set; }

    public Problem011()
    {
        // Read the text file
        var text = File.ReadAllLines(@"data/problem011matrix.txt");

        Data = text.Select(x => (x.Split(' ').Select(Int32.Parse).ToArray())).ToArray();
    }

    public long Run()
    {
        long maxProduct = 0;

        for (int i = 0; i < Data.Length - 4; i++)
        {
            for (int j = 0; j < Data[i].Length - 1; j++)
            {
                maxProduct = Math.Max(maxProduct, Data[i][j] * Data[i + 1][j] * Data[i + 2][j] * Data[i + 3][j]);
                if (j + 3 < Data[i].Length - 1)
                {
                    maxProduct = Math.Max(maxProduct, Data[i][j] * Data[i][j + 1] * Data[i][j + 2] * Data[i][j + 3]);
                    maxProduct = Math.Max(maxProduct, Data[i][j] * Data[i + 1][j + 1] * Data[i + 2][j + 2] * Data[i + 3][j + 3]);
                }
                if (j - 3 >= 0)
                {
                    maxProduct = Math.Max(maxProduct, Data[i][j] * Data[i + 1][j - 1] * Data[i + 2][j - 2] * Data[i + 3][j - 3]);
                }
            }
        }

        return maxProduct;
    }
}