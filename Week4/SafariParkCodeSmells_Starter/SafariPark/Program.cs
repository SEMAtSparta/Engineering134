using System;
using System.Collections.Generic;

namespace ClassesApp
{
    class Program
    {
        static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot());
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("Katie", "King");
            Hunter h = new Hunter("Marion", "Jones", new Camera("Leica")) { Age = 32 };

            Console.WriteLine();
            var theWeapons = new List<IShootable>();
            theWeapons.Add(new LaserGun("ToysRUs"));
            theWeapons.Add(new WaterPistol("Supersoaker"));
            theWeapons.Add(new LaserGun("ZippaZap"));
            theWeapons.Add(new Hunter("Cathy", "French", new Camera("Minolta")));
            theWeapons.Add(new Camera("Pentax"));
            foreach (var w in theWeapons)
            {
                Console.WriteLine(w.Shoot());
            }
            Console.WriteLine();
            Console.WriteLine("Polymorphic shootout");
            Camera pentax = new Camera("Pentax");
            var pistol = new WaterPistol( "Supersoaker");
            var laserGun = new LaserGun( "ZippaZap");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());

        }

    }
}
