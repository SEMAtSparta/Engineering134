
namespace PolymorphicShootout;

public class Camera : IShootable
{
    string _brand;

    public Camera(string brand)
    {
        _brand = brand;
    }
    public string Shoot()
    {
        return "Click";
    }

    public override string ToString()
    {
        return $"{_brand} camera";
    }
}
