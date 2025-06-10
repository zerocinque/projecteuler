public class Problem067
{
    public int[][] Data { get; set; }

    public Problem067()
    {
        // Read the text file
        var text = File.ReadAllLines(@"data/problem067data.txt");

        Data = text.Select(x => (x.Split(' ').Select(Int32.Parse).ToArray())).ToArray();
    }

    public string Run()
    {

        for (int i = Data.Length - 2; i >= 0; i--)
            for (int j = 0; j < Data[i].Length; j++)
                Data[i][j] += Math.Max(Data[i + 1][j], Data[i + 1][j + 1]);

        return Data[0][0].ToString();
    }
}