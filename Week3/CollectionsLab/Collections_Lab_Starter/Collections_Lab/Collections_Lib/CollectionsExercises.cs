using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string output = "";
            num = num > queue.Count ? queue.Count : num;

            for(int i = 0; i < num; i++)
            {
                output += queue.Dequeue();
                output += ", ";
            }
            if(output.Length > 0)
            {
                output = output.Substring(0, output.Length - 2);
            }
            return output;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] reverse = new int[original.Length];
            Stack<int> stackInts = new();
            foreach(int i in original)
            {
                stackInts.Push(i);
            }

            for (int i = 0; i < reverse.Length; i++)
            {
                reverse[i] = stackInts.Pop();
            }

            return reverse;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            char[] inputChars = input.ToCharArray();
            Dictionary<int, int> intCount = new();

            foreach(char c in inputChars)
            {
                if (int.TryParse(c.ToString(), out int cToInt))
                {
                    if (intCount.ContainsKey(cToInt))
                    {
                        intCount[cToInt]++;
                    }
                    else
                    {
                        intCount[cToInt] = 1;
                    }
                }
            }

            int[] keyArray = intCount.Keys.ToArray();
            string output = "";
            foreach(var key in keyArray)
            {
                output += $"[{key}, {intCount[key]}]";
            }
            return output;
        }
    }
}
