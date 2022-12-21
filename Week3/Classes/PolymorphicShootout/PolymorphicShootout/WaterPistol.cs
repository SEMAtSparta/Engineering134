namespace PolymorphicShootout;

public class WaterPistol : Weapon
{
    public WaterPistol(string brand) : base(brand) { }

    public override string Shoot()
    {
        return $"Splash!!";
    }

    public override string ToString()
    {
        return "Water Pistol " + base.ToString();
    }
}
