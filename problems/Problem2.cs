public class Problem002{
    
    long isEven(long number){
        return number % 2 == 0 ? number : 0;
    }

    long fibonacciSeriesSum(long a = 1, long b = 2){
        long sum = 0;
        long next = a + b;
        if(next >= 4000000)
            return b % 2 == 0 ? b : 0;
        sum = isEven(b) + fibonacciSeriesSum(b, next);
        return sum;
    }

    public long Resolve(){
        return fibonacciSeriesSum(1,2);
    }
}