namespace SafariParkApp;

public abstract class Vehicle : IMoveable, IEquatable<Vehicle?>
{
    private int _capacity;
    private int _numPassengers;

    public int NumPassengers
    {
        get
        {
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

    public virtual string Move()
    {
        Position += Speed;
        return $"Moving along";
    }

    public virtual string Move(int times)
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

    public override bool Equals(object? obj)
    {
        return Equals(obj as Vehicle);
    }

    public bool Equals(Vehicle? other)
    {
        return other is not null &&
               _capacity == other._capacity &&
               Speed == other.Speed;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_capacity, Speed);
    }
}
