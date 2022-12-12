using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MoreDataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        var myString = " C# list fundamentals";

        //StringInterpolation("Scot");

        //OneDArrays();
        //MultiDArrays();
        //JaggedArrays();

        DateTimeMethods();
        Enums();
    }
    #region Strings


    public static string StringExercise(string myString)
    {
        string newString = myString;

        #region bootleg trim
        /*while (newString[0] == ' ')
        {
            newString = newString.Substring(1, newString.Length - 1);
        }
        while (newString[newString.Length-1] == ' ')
        {
            newString.Remove(newString.Length, 1);
        }*/
        #endregion

        
        //newString = newString.Trim();
        //newString = newString.ToUpper();
        //newString = newString.Replace('L', '*');
        //newString = newString.Replace('T', '*');
        //this can all be shortened to 

        newString = newString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
        int position = newString.IndexOf('N');
        newString = newString.Remove(position + 1);
        return newString;
    }

    public static string StringBuilderExercise(string myString)
    {
        var trimmedUpperString = myString.Trim().ToUpper();
        int nPos = trimmedUpperString.IndexOf('N');
        StringBuilder sb = new StringBuilder(trimmedUpperString);
        sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
        return sb.ToString();
    }

    public static void StringInterpolation(string str)
    {
        Console.WriteLine("My name is :" + str + " Using +");
        Console.WriteLine($"My name is :{str} using interpolation");

        int num1 = 14;
        int num2 = 7;


        Console.WriteLine($"{num1} to the power of {num2} is {Math.Pow(num1, num2)}");
        Console.WriteLine($"Log to base {num2} of {num1} is {Math.Log(num2,num1):0.####}");
        Console.WriteLine($"That will be {num2/3.0:C} please");
    }

    //public static void ParsingStrings()
    //{
    //    Console.WriteLine("How many apples?");
    //    string input = Console.ReadLine();
    //    //int numApples = Int32.Parse(input);
    //    var success = Int32.TryParse(input, out int parsedApples);
    //}

    #endregion
    #region Arrays

    public static void OneDArrays()
    {
        int[] myIntArray = { 12, 23, 34, 45, 56 };
        Array.Reverse(myIntArray);
        foreach(var element in myIntArray)
        {
            Console.WriteLine(element);
        }
    }

    public static void MultiDArrays()
    {
        int[,] grid = new int[2, 4];
        grid[0, 1] = 6;
        grid[1, 0] = 8;
        grid[1, 3] = 10;

        char[,] gridTwo =
        {
            { 'a', 'b'
            },
            { 'c', 'd'
            },
            { 'e', 'f'
            },
            { 'g', 'h'
            },
            { 'i', 'j'
            }
        };

        //prints the whole array
        //Console.WriteLine("All of gridTwo:");
        //foreach (int element in gridTwo)
        //{
        //    Console.WriteLine(element);
        //}

        Console.WriteLine("GridTwo row by row:");
        for(int i = gridTwo.GetLowerBound(0); i <= gridTwo.GetUpperBound(0); i++)
        {
            for (int j = gridTwo.GetLowerBound(1); j <= gridTwo.GetUpperBound(1); j++)
            {
                Console.WriteLine($"({i},{j}) {gridTwo[i,j]}");
            }
        }

        
        
    }
    public static void JaggedArrays()
    {
        int[][] intJArray = new int[2][];
        intJArray[0] = new int[4];
        intJArray[1] = new int[2];

        intJArray[0][2] = 3;
        intJArray[1][0] = 5;

        string[][] animalJArray = new string[][]
        {
            new string[]{"Hyena", "Lion", "Cheetah", "Panda"},
            new string[]{"Peacock", "Canary"}
        };
    }
    #endregion
    #region Date/Time and Enums
    public static void DateTimeMethods()
    {
        var original = DateTime.Now;
        var now = DateTime.Now;
        var tomorrow = now.AddDays(1);
        Console.WriteLine($"The time is now {now}");
        Console.WriteLine($"The time in ticks is now {now.Ticks}");

        Console.WriteLine($"Tomorrow it will be {tomorrow}");
        Console.WriteLine($"The amount of time it took to run this function is {(DateTime.Now.Ticks - original.Ticks)/10000}ms");
    }

    public static void Enums()
    {
        Suit theSuit = Suit.HEARTS;
        if(theSuit == Suit.SPADES)
        {
            Console.WriteLine($"Suit is {Suit.SPADES}");
        }
        else
        {
            Console.WriteLine($"Suit is {theSuit} not {Suit.SPADES}");
        }

        var anotherSuit = Enum.Parse(typeof(Suit), "CLUBS");

        var mediumValue = (int)Size.MEDIUM;
        var mySize = (Size)50;
    }

    #endregion
}
public enum Suit
{
    HEARTS, CLUBS, DIAMONDS, SPADES
}

public enum Size
{
    SMALL = 10, LARGE = 50, MEDIUM = 25
}