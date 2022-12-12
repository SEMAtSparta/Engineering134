namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        //int timeOfDay = 21;
        //Console.WriteLine(GetGreeting(timeOfDay));
    }

    public static string GetGreeting(int timeOfDay)
    {
        string message;
        if(timeOfDay > 23 || timeOfDay < 0)
        {
            throw new ArgumentOutOfRangeException("Time of day cannot be negative.");
        }

        if (timeOfDay >= 5 && timeOfDay < 12)
        {
            message = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            message = "Good afternoon!";
        }
        else
        {
            message = "Good evening!";
        }

        return message; 
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        if(ageOfViewer < 0)
        {
            throw new ArgumentOutOfRangeException("Age of viewer cannot be negative.");
        }
        string result;
        if(ageOfViewer < 4)
        {
            result = "No films are available.";
        }
        else if (ageOfViewer < 12)
        {
            result = "U & PG films are available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer < 18)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}