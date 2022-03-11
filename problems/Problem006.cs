public class Problem006
{

    public long Run()
    {
        long sumOfSquares = 0;
        long squareOfSums = 0;
        for (int i = 1; i <= 100; i++)
        {
            sumOfSquares += i*i;
            squareOfSums += i;
        }

        squareOfSums = squareOfSums * squareOfSums;

        return squareOfSums - sumOfSquares;
    }
}