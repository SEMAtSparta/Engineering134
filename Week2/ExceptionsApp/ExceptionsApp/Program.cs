using System.IO;

namespace ExceptionsApp;

public class Program
{
    static void Main(string[] args)
    {
        string textFile;
        try 
        {
            textFile = File.ReadAllText("SuperSecretDiary.txt");
        }
        catch
        {
            Console.WriteLine("Sorry, I can't find the file :(");
        }
    }
}