namespace StringCalculator;

public class Program
{
    static void Main(string[] args)
    {
        
    }

    public static int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        numbers = numbers.Replace("\n", ",");

        string[] inputArray = numbers.Split(",");
        int[] inputIntArray = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            inputIntArray[i] = Int32.Parse(inputArray[i]);
        }

        int sum = 0;
        foreach(int num in inputIntArray)
        {
            sum += num;
        }
        return sum;
    }
}