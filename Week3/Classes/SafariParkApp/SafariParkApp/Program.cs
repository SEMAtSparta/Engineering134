namespace SafariParkApp;

internal class Program
{
    static void Main(string[] args)
    {
        //SpottingList list = new() { Hyena = true, Baboon = true };

        //Hunter h = new Hunter("Gary", "Kasparov", "Nikon FXD850"); //object initialisation has access to init
        //Console.WriteLine(h.Shoot());
        //Console.WriteLine(h);

        //Hyena hyena = new Hyena("Jeff");
        //Console.WriteLine(hyena);
        //Console.WriteLine(hyena.Call());

        //List<IMoveable> safariObjects = new()
        //{
        //    hyena,
        //    h,
        //    new Airplane(12, 100, "British Airways"){NumPassengers = 6 }
        //};

        //foreach(var obj in safariObjects)
        //{
        //    if(obj is Person)
        //    {
        //        var person = (Person)obj;
        //        Console.WriteLine(person.FirstName);
        //    }
        //    Console.WriteLine(obj.Move());
        //}

        //IMoveable mover = h;

        #region Comparison operators
        //var bobOne = new Person("Bob", "Builder");
        //var bobTwo = bobOne;

        //Console.WriteLine(bobOne == bobTwo);

        //var cessna = new Airplane(5);
        //var bushPlane = new Airplane(5);
        //List<Airplane> listPlanes = new()
        //{
        //    new Airplane(5){Altitude = 2},
        //    new Airplane(5){Altitude = 5},
        //    new Airplane(5){Altitude = 1}
        //};

        //listPlanes.Sort();
        #endregion

        #region Collections
        #region Lists
        //List<Person> personList = new()
        //{
        //    new Person("Gary", "Kasparov"),
        //    new Person("Robert", "Fischer"),
        //    new Person("Anatoly", "Karpov")
        //};

        //foreach (Person p in personList)
        //{
        //    Console.WriteLine(p);
        //}
        //Console.WriteLine(personList[0]);

        //Person borisSpassky = new Person("Boris", "Spassky");
        //personList.Add(new Person("Boris", "Spassky"));
        //personList.Remove(new Person("Boris", "Spassky"));  // will not work as provided object must be equal to object present
        //personList.Remove(borisSpassky);                    // this will work as it is exactly equal

        //List<int> ints = new() { 5, 4, 3, 9, 0 };
        //ints.Add(8);
        //ints.Sort();
        //ints.RemoveRange(1,2);
        //ints.Insert(2,1);
        //ints.Reverse();
        //ints.Remove(9);
        //foreach (int i in ints)
        //{
        //    Console.Write(i);
        //}
        //Console.WriteLine("");
        #endregion

        #endregion
    }
}
