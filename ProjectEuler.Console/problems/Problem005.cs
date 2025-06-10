using System.Numerics;

public class Problem005{	
	private BigInteger lowestCommonMultiple(BigInteger x, BigInteger y) {
        return BigInteger.Divide(BigInteger.Multiply(x, y), BigInteger.GreatestCommonDivisor(x, y));
	}

    public long Run(){
		BigInteger allLcm = BigInteger.One;
		for (int i = 1; i <= 20; i++)
			allLcm = lowestCommonMultiple(new BigInteger(i), allLcm);
		return (long) allLcm;
    }
}