// Problem 014: Longest Collatz sequence
// The Collatz conjecture states that for any positive integer n, the sequence defined as follows will eventually reach 1:
// - If n is even, divide it by 2.
// - If n is odd, multiply it by 3 and add 1.
// For example, starting with 13, the sequence is:
// 13, 40, 20, 10, 5, 16, 8, 4, 2, 1
// The conjecture is that no matter what value of n, the sequence will always reach 1.
// The task is to find the starting number under one million that produces the longest chain.
// The answer is 837799, which produces a chain of length 525.
// This code is a solution to Project Euler Problem 014.
public class Problem014
{
    public long Run()
    {
        var million = 1000000;
        long maxLength = 0;
        int numberWithMaxCollatzLength = 0;
        for (int i = 1; i < million; i++)
        {
            long length = CollatzLength(i);
            if (length > maxLength)
            {
                maxLength = length;
                numberWithMaxCollatzLength = i;
            }
        }
        return numberWithMaxCollatzLength;
    }

    private long CollatzLength(long number)
    {
        long length = 1; // Start with the initial number
        while (number != 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number = 3 * number + 1;
            }
            length++;
        }
        return length;
    }
}