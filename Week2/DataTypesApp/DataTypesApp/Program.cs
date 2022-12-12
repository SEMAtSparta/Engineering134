namespace DataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        #region basic types
        var greeting = "Hello there";
        var age = 33;
        var height = 182.5f;
        var ageOfTheUniverse = 13_128_347_125uL;
        var makesSense = true;
        var grade = 'A';

        List<int> nums;
        List<decimal> prices = new List<decimal>(); //decimal has higher precision, so is used for money.
        #endregion

        #region floating point precision

        float sum = 0;
        for (int i = 0; i < 700_000; i++)
        {
            sum += 1 / 7f;
        }

        if(700_000 * (1/7f) == 100_000f)
        {
            Console.WriteLine("700,000 is divisible by 7!");
        }
        else
        {
            Console.WriteLine("700,000 is not divisible by 7!");
        }
        //the issue with floating point precision becomes accurate

        double pi = 3.14159265359;
        float piFloat = (float)pi;
        Console.WriteLine("pi: " + pi + "\npiFloat: " + piFloat);

        #endregion

        #region overflow and casting

        int balance = -2;
        uint newBalance = (uint)balance;
        Console.WriteLine(balance + " becomes: " + newBalance);

        string five = "5";
        var numberFive = Convert.ToInt32(five);
        Console.WriteLine(numberFive);

        #endregion

    }
}