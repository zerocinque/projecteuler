using System.Numerics;

public class Problem013{
    public string Run(){
        var text = File.ReadAllLines(@"data/problem013data.txt");
        BigInteger sum = new BigInteger();

        foreach(string number in text)
            sum += BigInteger.Parse(number);
        
        return sum.ToString().Substring(0,10);
    }
}