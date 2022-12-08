using System.Text;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundamentals";
            //Console.WriteLine(StringExercise(myString));
            //Console.WriteLine(StringBuilderExercise(myString));
            //Console.WriteLine("1." + "2." + "3." + "4." + "5." + "6." + "7." + "8." + "9." + 
            //    "10." + "11." + "12." + "13." + "14." + "15." + "16." + "17." + "18." + "19." +
            //    "20." + "21." + "22." + "23." + "24." + "25." + "26." + "27." + "28." + "29." +
            //    "30." + "31." + "32." + "33." + "34." + "35." + "36." + "37." + "38." + "39." + 
            //    "40." + "41.");
            StringInterpolation("Scot");

        }

        public static string StringExercise(string myString)
        {
            string newString = myString;

            #region bootleg trim
            /*while (newString[0] == ' ')
            {
                newString = newString.Substring(1, newString.Length - 1);
            }
            while (newString[newString.Length-1] == ' ')
            {
                newString.Remove(newString.Length, 1);
            }*/
            #endregion

            
            //newString = newString.Trim();
            //newString = newString.ToUpper();
            //newString = newString.Replace('L', '*');
            //newString = newString.Replace('T', '*');
            //this can all be shortened to 

            newString = newString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
            int position = newString.IndexOf('N');
            newString = newString.Remove(position + 1);
            return newString;
        }

        public static string StringBuilderExercise(string myString)
        {
            var trimmedUpperString = myString.Trim().ToUpper();
            int nPos = trimmedUpperString.IndexOf('N');
            StringBuilder sb = new StringBuilder(trimmedUpperString);
            sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
            return sb.ToString();
        }

        public static void StringInterpolation(string str)
        {
            Console.WriteLine("My name is :" + str + " Using +");
            Console.WriteLine($"My name is :{str} using interpolation");

            int num1 = 14;
            int num2 = 7;


            Console.WriteLine($"{num1} to the power of {num2} is {Math.Pow(num1, num2)}");
            Console.WriteLine($"Log to base {num2} of {num1} is {Math.Log(num2,num1):0.####}");
            Console.WriteLine($"That will be {num2/3.0:C} please");
        }

        public static void ParsingStrings()
        {
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine();
            //int numApples = Int32.Parse(input);
            var success = Int32.TryParse(input, out int parsedApples);
        }
    }
}