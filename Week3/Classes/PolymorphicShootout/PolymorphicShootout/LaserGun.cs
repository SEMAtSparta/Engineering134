namespace PolymorphicShootout;

public class LaserGun : Weapon
{
    public LaserGun(string brand) : base(brand) { }

    public override string Shoot()
    {
        return $"Zing!!";
    }

    public override string ToString()
    {
        return "Laser gun " + base.ToString();
    }
}
