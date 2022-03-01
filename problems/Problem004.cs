public class Problem004{

    bool isPalindromic(long number){
        char[] charArray = number.ToString().ToCharArray();
        Array.Reverse(charArray);
        return string.Equals(new string(charArray), number.ToString());
    }

    public long Resolve(int digitNumber = 3){
        var temp = string.Empty;
        long product = 0;
        long maxPalindrome = 0;

        for(int i = 0; i < digitNumber; i++)
            temp = string.Concat(temp, '9');

        long hightestNumber = Int64.Parse(temp);

        for(long i = hightestNumber; i>=0; i--){
            for(long j = hightestNumber; j>=0; j--){
                product = i * j;

                if(product < maxPalindrome)
                    break;

                if(isPalindromic(product)){
                    maxPalindrome = Math.Max(product, maxPalindrome);
                }
            }
        }

        return maxPalindrome;
    }
}