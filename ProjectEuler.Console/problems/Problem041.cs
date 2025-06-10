using ProjectEuler.Lib;
public class Problem041
{
    public string Run(){
        char[] digits = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        ulong maxPrime = 0;

        for(int i = 1; i<digits.Length; i++){
            List<string> pandigitalNumbers = new List<string>();
            StringExtensions.FindPermutations(pandigitalNumbers, digits.Take(i+1).ToArray(), 0, i+1);
            foreach(string panNumber in pandigitalNumbers){
                maxPrime = UInt64.Parse(panNumber).IsPrime() ? Math.Max(maxPrime, UInt64.Parse(panNumber)) : maxPrime;
            }
        }
        return maxPrime.ToString();
    }
}