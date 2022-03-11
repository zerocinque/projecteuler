
public class Problem043
{
    public List<string> Permutations { get; set; }
    public List<string> PermutationWithProperty { get; set; }

    public Problem043()
    {
        Permutations = new List<string>();
        PermutationWithProperty = new List<string>();
    }

    static bool shouldSwap(char[] str, int start, int curr)
    {
        for (int i = start; i < curr; i++)
            if (str[i] == str[curr])
                return false;
        return true;
    }

    void findPermutations(char[] str, int index, int n)
    {
        if (index >= n)
        {
            Permutations.Add(new string(str));
            return;
        }

        for (int i = index; i < n; i++)
        {
            bool check = shouldSwap(str, index, i);
            if (check)
            {
                swap(str, index, i);
                findPermutations(str, index + 1, n);
                swap(str, index, i);
            }
        }
    }

    static void swap(char[] str, int i, int j)
    {
        char c = str[i];
        str[i] = str[j];
        str[j] = c;
    }

    async void findPermutationsWithProperty()
    {
        int[] dividends = { 2, 3, 5, 7, 11, 13, 17 };
        foreach (string permutation in Permutations)
        {
            bool ok = true;
            for (int i = 1; i < permutation.Length - 4; i++)
            {
                int portionNumber = Int32.Parse(permutation.Substring(i, 3));
                ok = portionNumber % dividends[i-1] == 0;

                if(!ok) break;
            }

            if(ok) PermutationWithProperty.Add(permutation);
        }
    }

    long sumPermutationWithProperty(){
        return PermutationWithProperty.Sum(x => Convert.ToInt64(x));
    }

    public long Run()
    {
        string str = "0123456789";
        findPermutations(str.ToCharArray(), 0, str.Length);
        findPermutationsWithProperty();
        return sumPermutationWithProperty();
    }
}