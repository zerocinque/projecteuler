using Library;
public class Problem010
{
    private const long MAX_VALUE = 2000000;

    public string Run(){
        long sum = 0;

        for (int i = 2; true; i++)
        {
            if(i.IsPrime()){
                if(i>=MAX_VALUE) break;
                sum += i;
            }
        }

        return sum.ToString();
    }
}