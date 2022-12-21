﻿using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> output = new();
            int outputSize = max / 5;

            for (int i = 1; i <= outputSize; i++)
            {
                output.Add(i * 5);
            }

            return output;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> output = new();
            if(sourceList.Count == 0)
            {
                return output;
            }

            foreach (string str in sourceList) 
            {
                if (str.ToLower().StartsWith('a'))
                {
                    output.Add(str);
                }
            }

            return output;
        }
    }
}
