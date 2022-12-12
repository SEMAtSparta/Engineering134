namespace MemoryModelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caner = new Person { FirstName = "Caner", LastName = "Dursun", age = 24 };
            double ikra = 4.2;
            string scot = DemoMethod(caner, ikra);
        }

        public static string DemoMethod(Person alex, double maajid)
        {
            Random rnd = new((int)maajid);
            maajid = rnd.NextDouble();
            string jasser = alex.FirstName + " " + alex.LastName + " " + maajid;
            return jasser;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int age { get; set;}
        public override string ToString()
        {
            return $"${FirstName} {LastName}, {Age}";
        }
    }
}