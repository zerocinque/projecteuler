public class Problem008{
    public string Data { get; set; }

    public Problem008(){
        // Read the text file
        var text = File.ReadAllLines(@"data/problem8matrix.txt");

        Data = string.Join("", text);
    }

    public long Resolve(int adjacent){
        long maxValue = 0;
        for(int i = 0; i<=Data.Length-adjacent; i++){
            long product = 1;

            for(int j = 0; j<adjacent; j++)
                product *= Data.ElementAt(i+j) -'0';
 
            maxValue = Math.Max(maxValue, product);                           
        }

        return maxValue;
    }
}
