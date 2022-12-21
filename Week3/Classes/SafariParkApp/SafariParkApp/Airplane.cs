namespace SafariParkApp;

public class Airplane : Vehicle, IEquatable<Airplane?>, IComparable<Airplane>
{
    private string _airline = "";
    private int _altitude = 0;

    public int Altitude{
        get
        { 
            return _altitude; 
        }
        set
        {
            if (value >= 0)
            {
                _altitude = value;
            }
            else
            {
                throw new ArgumentException("Cannot have a negative altitude");
            }
        }    
        }

    public Airplane(int capacity) : base(capacity)
    {
    }

    public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
    {
        _airline = airline;
    }

    public override string Move() 
    {
        base.Move();
        return $"Airplane flying with {_airline} is flying along, containing {NumPassengers} passengers.";
    }

    public override string Move(int times)
    {
        base.Move(times);
        return $"Flying along {times} times";
    }

    public void Ascend(int distance)
    {
        Altitude += distance;
    }

    public void Descend(int distance)
    {
        Altitude -= distance;
        if(Altitude <= 0)
        {
            throw new Exception("Plane has crashed into the ground, killing hundreds on board");
        }
    }

    public override string ToString()
    {
        return $"Airplane flying with {_airline}";
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Airplane);
    }

    public bool Equals(Airplane? other)
    {
        return other is not null &&
               NumPassengers == other.NumPassengers &&
               Speed == other.Speed;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(NumPassengers, Speed);
    }

    public int CompareTo(Airplane? other)
    {
        if(other is null)
        {
            throw new ArgumentException($"Comparison between {this.ToString()} and an incompatible object.");
        }

        if (other.Altitude > this.Altitude)
        {
            return 1;
        }
        else if (other.Altitude == this.Altitude)
        {
            return 0;
        }
        else return -1;
        
    }

    public static bool operator ==(Airplane left, Airplane right)
    {
        return EqualityComparer<Airplane>.Default.Equals(left, right);
    }
    public static bool operator !=(Airplane left, Airplane right)
    {
        return !(left == right);
    }
}
