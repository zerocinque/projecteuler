public class Problem045{

    long triangleNumber(int n){
        return n * (n + 1) / 2;
    }
    long pentagonalNumber(int n){
        return n * (3 * n - 1) / 2;
    }
    long hexagonalNumber(int n){
        return n * (2 * n - 1);
    }

    public long Run(long minimumCommonNumber, int startTriangleNumber = 0, int startPentagonalNumber = 0, int startHexagonalNumber = 0){
        bool flag = true;
        long commonNumber = 0;
        
        int i = startTriangleNumber;
        int j = startPentagonalNumber;
        int k = startHexagonalNumber;

        long currentTriangleNumber = triangleNumber(i);
        long currentPentagonalNumber = pentagonalNumber(j);
        long currentHexagonalNumber = hexagonalNumber(k);

        while(true){

            currentTriangleNumber = triangleNumber(i);

            // if(currentTriangleNumber > currentPentagonalNumber)
            currentPentagonalNumber = pentagonalNumber(j);

            // if(currentTriangleNumber > currentHexagonalNumber)
            currentHexagonalNumber = hexagonalNumber(k);
            
            long min = Math.Min(currentTriangleNumber, Math.Min(currentPentagonalNumber, currentHexagonalNumber));

            if(currentTriangleNumber == currentPentagonalNumber && currentTriangleNumber == currentHexagonalNumber)
                // commonNumber = currentTriangleNumber;
                return currentTriangleNumber;
            
            if(commonNumber> minimumCommonNumber)
                return commonNumber;

            if(currentTriangleNumber == min) i++;
            if(currentPentagonalNumber == min) j++;
            if(currentHexagonalNumber == min) k++;
        }
    }
}