namespace SafariParkApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Person
{
    private string _firstName;
    private string _lastName;
    public int Age { get; set; } = 18;

    private int _height = 0;
    public int Height 
    { 
        get
        {
            return _height;
        }
        set
        {
            if (value < 0) _height = value;
        }
    }

    public string FullName()
    {
        return _firstName + " " + _lastName;
    }

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        Age = age;
    }
    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}