using System.Numerics;
using ProjectEuler.Lib;

public class Problem043
{
    public List<string> Permutations { get; set; }
    public List<string> PermutationWithProperty { get; set; }

    public Problem043()
    {
        Permutations = new List<string>();
        PermutationWithProperty = new List<string>();
    }
    
    private void findPermutationsWithProperty()
    {
        int[] dividends = { 2, 3, 5, 7, 11, 13, 17 };
        foreach (string permutation in Permutations)
        {
            bool ok = true;
            for (int i = 1; i < permutation.Length - 3; i++)
            {
                int portionNumber = Int32.Parse(permutation.Substring(i, 3));
                ok = portionNumber % dividends[i-1] == 0;

                if(!ok) break;
            }

            if(ok) PermutationWithProperty.Add(permutation);
        }
    }

    BigInteger sumPermutationWithProperty(){
        BigInteger sum = BigInteger.Zero;

        foreach(string number in PermutationWithProperty){
            sum = BigInteger.Add(sum, BigInteger.Parse(number));
        }

        return sum;
    }

    public string Run()
    {
        string str = "0123456789";
        StringExtensions.FindPermutations(Permutations, str.ToCharArray(), 0, str.Length);
        findPermutationsWithProperty();
        return sumPermutationWithProperty().ToString();
    }
}