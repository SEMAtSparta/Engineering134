namespace PolymorphicShootout;
public class Hunter : Person
{
    public IShootable Shooter;

    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;
    }
    public string Shoot()
    {
        return Shooter.Shoot();
    }

    public override string ToString()
    {
        return $"{base.ToString()} {Shooter}";
    }
}