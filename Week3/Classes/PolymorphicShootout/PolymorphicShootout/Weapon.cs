namespace PolymorphicShootout;

public abstract class Weapon: IShootable
{
    private string _brand;

    public Weapon(string brand)
    {
        _brand = brand;
    }

    public abstract string Shoot();

    public override string ToString()
    {
        return $"Weapon brand: {_brand}";
    }
}
