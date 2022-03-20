using Library;

public class Problem049
{

    private static int MIN_VALUE = 1000;
    private static int MAX_VALUE = 9999;


    private bool isPermutation(int a, int b)
    {
        return isPermutation(a.ToString(), b.ToString());
    }
    private bool isPermutation(string a, string b)
    {
        for (int i = 0; i < 4; i++)
            if (a.IndexOf(b.ElementAt(i)) == -1 || b.IndexOf(a.ElementAt(i)) == -1)
                return false;

        return true;
    }

    public string Run()
    {
        bool flag = false;
        int firstElement = 0;
        int secondElement = 0;
        int thirdElement = 0;

        for (int i = MIN_VALUE; i <= MAX_VALUE && !flag; i++)
        {
            if (!i.IsPrime()) continue;

            firstElement = i;
            for (int j = 1; i + j + j <= MAX_VALUE && !flag; j++)
            {
                if(i==1487 && j ==3330) continue;

                secondElement = i + j;
                thirdElement = i + j + j;
                if (secondElement.IsPrime() && thirdElement.IsPrime()
                        && isPermutation(firstElement, secondElement) && isPermutation(secondElement, thirdElement))
                    flag = true;
            }
        }

        return $"{firstElement}{secondElement}{thirdElement}";
    }
}