public class Problem001
{  
    int sumMultipleValue(int factor, int multipleMaxValue = 1000){
        int sum =0;
        int multiple = 0;
        for(var i = 1; multiple<multipleMaxValue; i++){
            sum += multiple;
            Console.WriteLine($"{i} - {multiple} = {sum}");
            multiple = factor * i;
            
        }
        return sum;
    }
    public int Resolve(int multipleMaxValue = 1000){
        int sum = 0;

        for(int i=0; i<multipleMaxValue; i++)
            if(i % 3 == 0 || i % 5 == 0)
                sum += i;

        return sum;
    }
}