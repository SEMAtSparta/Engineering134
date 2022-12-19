namespace FizzBuzzApp;

public class Program
{
    public static string FizzBuzz(int maxValue)
    {
        string output = "";
        for(int i = 1; i <= maxValue; i++)
        {
            output += i % 3 == 0 ? i%5 == 0 ? "FizzBuzz" : "Fizz" : i % 5 == 0? "Buzz" : i.ToString();
            output += " ";
        }
        return output.Trim();
    }

    public static string FizzBuzz(int maxValue, int fizz, int buzz)
    {
        string output = "";
        for (int i = 1; i <= maxValue; i++)
        {
            output += i % fizz == 0 ? i % buzz == 0 ? "FizzBuzz" : "Fizz" : i % buzz == 0 ? "Buzz" : i.ToString();
            output += " ";
        }
        return output.Trim();
    }

    static void Main(string[] args)
    {
        Console.WriteLine(FizzBuzz(30, 2, 6)); 
    }

}