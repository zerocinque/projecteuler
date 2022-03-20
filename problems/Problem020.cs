using System.Numerics;

public class Problem020{
    public string Run(){
        BigInteger factorial = BigInteger.One;
        for(int n = 100; n>1; n--){
            factorial = BigInteger.Multiply(factorial, n);
        }

        long sum = factorial.ToString().Sum(x => x - '0');

        return sum.ToString();
    }
}