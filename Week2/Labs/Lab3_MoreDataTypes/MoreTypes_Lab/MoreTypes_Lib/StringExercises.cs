using System;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            StringBuilder sb = new StringBuilder(input.Trim().ToUpper());
            for(int i = 0; i < num; i++)
            {
                sb.Append(i);
            }
            return sb.ToString();
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(number + " " + street + ", " + city + " " + postcode + ".");
            return sb.ToString();
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {(((float)score / outOf)*100):##.#}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            bool success = double.TryParse(numString, out double parsedNumber);
            if (success)
            {
                return parsedNumber;
            }
            else
            {
                return -999;
            }
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int[] letterCounts = { 0, 0, 0, 0 };
            foreach(char c in input)
            {
                switch (c)
                {
                    case 'A':
                        letterCounts[0]++;
                        break;
                    case 'B':
                        letterCounts[1]++;
                        break;
                    case 'C':
                        letterCounts[2]++;
                        break;
                    case 'D':
                        letterCounts[3]++;
                        break;
                    default:
                        break;
                }
            }
            return $"A:{letterCounts[0]} B:{letterCounts[1]} C:{letterCounts[2]} D:{letterCounts[3]}";

        }
    }
}
