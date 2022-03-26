using Library;

public class Problem034
{
    private List<int> factorials { get; set; }

    public Problem034()
    {
        factorials = new List<int>();
        for (int i = 0; i < 10; i++)
            factorials.Add(i.FactorialNumber());
    }

    public string Run(){
        long sum = 0;
        for(int i = 3; i<100000000; i++)
            if(factorialDigitNumber(i) == i)
                sum += i;

        return sum.ToString();
    }

    private int factorialDigitNumber(int n){
        string number = n.ToString();
        int sum = 0;

        for(int i = 0; i<number.Length;i++)
            sum += factorials[number[i]-'0'];

        return sum;
    }
}