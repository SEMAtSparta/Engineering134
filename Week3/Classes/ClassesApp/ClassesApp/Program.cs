namespace ClassesApp;

public class Program
{
    public static void Main()
    {

    }
}

public class Vehicle
{
    private int _capacity;
    private int _numPassengers;

    public int NumPassengers { 
        get {
            return _numPassengers;
        } 
        set
        {
            if (value < 0 || value > _capacity)
            {
                throw new ArgumentException();
            }
            _capacity = value;
        } 
    }

    public int Position { get; set; }
    public int Speed { get; }

    public string Move()
    {
        Position += Speed;
        return $"Moving along";
    }

    public string Move(int times)
    {
        Position += Speed * times;
        return $"Moving along {times} times";
    }

    public Vehicle()
    {
        _capacity = 0;
        Speed = 10;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;
    }
}