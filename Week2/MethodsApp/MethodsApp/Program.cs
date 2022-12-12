using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace MethodsApp;

public class Program
{
    static void Main(string[] args)
    {
        //optional parameters
        //DoThis(4);

        //named parameter
        //DoThis(x: 5, y: "sleepy");
        //string pizza = OrderPizza(mushrooms: true, anchovies: false, pepperoni : true, ham : true);
        //Console.WriteLine(pizza);

        ////out keyword
        //string outVariable = "I'm feeling hungry.";
        //int result3 = DoThisOut(1, "blue", out outVariable);
        //Console.WriteLine(outVariable);

        //tuples
        (string, string, int) person = ("John", "Doe", 25);
        Console.WriteLine($"{person.Item1} {person.Item2} is {person.Item3} years old.");

        var student = (fName: "John", lName: "Doe", age: 24);
        Console.WriteLine($"{student.fName} {student.lName} is {student.age} years old");

        var weight = ConvertPoundsToStonesAndPounds(156);
        Console.WriteLine(weight.stones + " " + weight.lbs);
    }

    public static int DoThis(int x, string y = "blue")
    {
        Console.WriteLine($"I'm feeling {y}.");
        return x;
    }

    public static int DoThisOut(int x, string y, out string result)
    {
        result = $"I'm feeling {y}.";
        return x;
    }

    public static string OrderPizza(bool anchovies,  bool pepperoni, bool ham, bool pineapple = false, bool mushrooms = false)
    {
        var pizza = "Pizza with tomato sauce, cheese";
        if (anchovies) pizza += ", anchovies";
        if (pineapple) pizza += ", pineapple";
        if (mushrooms) pizza += ", mushrooms";
        if (pepperoni) pizza += ", pepperoni";
        if (ham) pizza += ", ham";

        pizza += ".";
        return pizza;
    }

    public static (int stones, int lbs) ConvertPoundsToStonesAndPounds(int pounds)
    {
        const int poundsInAStone = 14;
        int outStones = pounds / poundsInAStone;
        int outLbs = pounds % poundsInAStone;

        return (outStones, outLbs);
    }
}