
namespace SafariParkApp;

public abstract class Animal : IMoveable
{
    public string Name { get; set; }

    public virtual string Call()
    {
        return "ah";
    }

    public abstract string Move();

    public abstract string Move(int times);
}
//cannot derive from a sealed class
public sealed class Cat: Animal
{
    //cannot override a sealed method
    public sealed override string Call()
    {
        return "meow";
    }

    public override string Move()
    {
        return "saunters";
    }

    public override string Move(int times)
    {
        return $"Takes {times} quick leaps.";
    }
}

public class Hyena : Animal
{
    public override string Call()
    {
        return "heh heh heh";
    }

    

    public Hyena(string name = "Hyena")
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Hyena named {Name}";
    }
    public override string Move()
    {
        return "stalks";
    }

    public override string Move(int times)
    {
        return $"Goes in for the kill, moving {times} times";
    }
}
