
using System.Numerics;

public class Problem048{
    public string Run(){
        BigInteger sum = BigInteger.Zero;

        for(int i = 1; i<=1000;i++){
            sum = BigInteger.Add(sum, BigInteger.Pow(i,i));
        }

        return sum.ToString().Substring(sum.ToString().Length-10);
    }
}