using System.Text;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundamentals";
            //Console.WriteLine(StringExercise(myString));
            Console.WriteLine(StringBuilderExercise(myString));
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
    }
}