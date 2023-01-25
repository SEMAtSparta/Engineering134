using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;
        public Weapon(string brand)
        {
            _brand = brand;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }

        public abstract string Shoot();
    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand) { }

        public override string Shoot()
        {
            return $"Splash!! Shooting a Water Pistol.";
        }
    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand) { }

        public override string Shoot()
        {
            return $"Zing!! Shooting a Laser Gun";
        }
    }
}


