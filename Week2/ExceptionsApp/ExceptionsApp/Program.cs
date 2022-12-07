using System.IO;

namespace ExceptionsApp;

public class Program
{
    static void Main(string[] args)
    {
        #region Try/Catch demo
        /* string textFile;
         try 
         {
             textFile = File.ReadAllText("SuperSecretDiary.txt");
         }
         catch(FileNotFoundException e)
         {
             Console.WriteLine("Sorry, I can't find the file :(");
         }
         catch
         {
             Console.WriteLine("I find ANY exception");
         }
         finally
         {
             Console.WriteLine("I always run.");
         }*/
        #endregion

        Console.WriteLine(Grade(67));
        Console.WriteLine(Grade(-67));

    }

    public static string Grade(int mark)
    {
        if(mark < 0 || mark > 100)
        {
            throw new ArgumentOutOfRangeException("Mark cannot be out of the range 1-100.");
        }

        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}