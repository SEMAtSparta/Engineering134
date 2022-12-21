namespace SafariParkApp;


public class Person : IMoveable
{
    public string FirstName;
    public string LastName;
    //private readonly string _eyecolour;
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
        return FirstName + " " + LastName;
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FullName()}, Person Object";
    }

    public string Move()
    {
        return $"{FirstName} takes a leisurely stroll.";
    }

    public string Move(int times)
    {
        return $"{FirstName} briskly moves {times} times.";
    }
}
