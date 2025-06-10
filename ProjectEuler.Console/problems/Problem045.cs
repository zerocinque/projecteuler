public class Problem045
{

    ulong triangleNumber(ulong n)
    {
        return n * (n + 1) / 2;
    }
    ulong pentagonalNumber(ulong n)
    {
        return n * (3 * n - 1) / 2;
    }
    ulong hexagonalNumber(ulong n)
    {
        return n * (2 * n - 1);
    }

    public ulong Run(ulong minimumCommonNumber = 40755, ulong startTriangleNumber = 1, ulong startPentagonalNumber = 1, ulong startHexagonalNumber = 1)
    {
        ulong commonNumber = 0;

        ulong i = startTriangleNumber;
        ulong j = startPentagonalNumber;
        ulong k = startHexagonalNumber;

        ulong currentTriangleNumber = 0;
        ulong currentPentagonalNumber = 0;
        ulong currentHexagonalNumber = 0;

        while (true)
        {
            currentTriangleNumber = triangleNumber(i);
            currentPentagonalNumber = pentagonalNumber(j);
            currentHexagonalNumber = hexagonalNumber(k);

            ulong min = Math.Min(currentTriangleNumber, Math.Min(currentPentagonalNumber, currentHexagonalNumber));

            if (currentTriangleNumber == currentPentagonalNumber && currentTriangleNumber == currentHexagonalNumber)
                commonNumber = currentTriangleNumber;

            if (commonNumber > minimumCommonNumber)
                return commonNumber;

            if (currentTriangleNumber == min) i++;
            if (currentPentagonalNumber == min) j++;
            if (currentHexagonalNumber == min) k++;
        }
    }
}