using System.ComponentModel.DataAnnotations;

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
        #region Queues and Stacks
        //Queue<Person> personQueue = new();

        //personQueue.Enqueue(new Person("Gary", "Kasparov"));
        //personQueue.Enqueue(new Person("Robert", "Fischer"));
        //personQueue.Enqueue(new Person("Anatoly", "Karpov"));

        //Console.WriteLine(personQueue.Dequeue()); 

        //Stack<Person> personStack = new();

        //personStack.Push(new Person("Gary", "Kasparov"));
        //personStack.Push(new Person("Robert", "Fischer"));
        //personStack.Push(new Person("Anatoly", "Karpov"));

        //Console.WriteLine(personStack.Pop());

        //int[] original = new int[] { 1, 2, 3, 4, 5 };
        //int[] reversed = new int[original.Length];
        //Stack<int> nums = new();
        //foreach(int i in original)
        //{
        //    nums.Push(i);
        //}

        //int l = nums.Count;
        //for (int i = 0; i < l; i++)
        //{
        //    reversed[i] = nums.Pop();
        //}

        //foreach (int i in reversed)
        //{
        //    Console.Write($"{i},");
        //}
        //Console.WriteLine();

        #endregion
        #region HashSet and Dictionary

        //var planeSet = new HashSet<Airplane>
        //{
        //    new Airplane(5) {Speed = 20, Altitude = 1},
        //    new Airplane(2) {Speed = 60, Altitude = 6},
        //    new Airplane(10) {Speed = 10, Altitude = 2},
        //    new Airplane(10) {Speed = 10, Altitude = 2} // will not be added to the set, as it is identical to another element.
        //};

        //Dictionary<string, Person> personDict = new()
        //{
        //    {"Kasparov", new Person("Gary", "Kasparov")},
        //    {"Karpov", new Person("Anatoly", "Karpov") },
        //    {"Fischer", new Person("Robert", "Fischer") }
        //};

        //Console.WriteLine(personDict["Karpov"]);

        //var keys = personDict.Keys.ToArray();
        //this is how you get all the key/value pairs

        string input = "The cat in the hat comes back";
        input = input.ToLower().Replace(" ", "");

        var countDict = new Dictionary<char, int>();

        foreach (char c in input.ToCharArray())
        {
            if (countDict.ContainsKey(c))
            {
                countDict[c]++;
            }
            else
            {
                countDict[c] = 1;
            }
        }
        var countKeys = countDict.Keys.ToArray();
        foreach (char key in countKeys)
        {
            Console.WriteLine($"{key} : {countDict[key]}");
        }

        #endregion
        #endregion
    }
}
