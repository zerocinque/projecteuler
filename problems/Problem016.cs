using System.Numerics;

public class Problem016{
    public string Run(){
        var pow = BigInteger.One << 1000;

        long sum = pow.ToString().Sum(x => x - '0');

        return sum.ToString();
    }
}