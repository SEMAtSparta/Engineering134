namespace SafariParkApp;

internal class Program
{
    static void Main(string[] args)
    {
        //SpottingList list = new() { Hyena = true, Baboon = true };

        Hunter h = new Hunter("Gary", "Kasparov", "Nikon FXD850"); //object initialisation has access to init
        //Console.WriteLine(h.Shoot());
        //Console.WriteLine(h);

        Hyena hyena = new Hyena("Jeff");
        //Console.WriteLine(hyena);
        //Console.WriteLine(hyena.Call());

        List<IMoveable> safariObjects = new()
        {
            hyena,
            h,
            new Airplane(12, 100, "British Airways"){NumPassengers = 6 }
        };

        foreach(var obj in safariObjects)
        {
            if(obj is Person)
            {
                var person = (Person)obj;
                Console.WriteLine(person.FirstName);
            }
            Console.WriteLine(obj.Move());
        }

        IMoveable mover = h;
    }
}

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
        return $"{base.ToString()} {FirstName} {LastName}";
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