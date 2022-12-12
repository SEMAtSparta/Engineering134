using System;
using System.Collections.Generic;

namespace TestFirstExercises
{
    public class Methods
    {
        // implement this method so that it returns true if x is greater than or equal to y
        public static bool GreaterEqual(int x, int y)
        {
            return x >= y;
        }

        // Implement this method so that it take an int as an input,
        // squares it, adds 101, divides the result by 7, then subtracts 4.  
        // Return a double rounded to 3 decimal places.
        public static double BODMAS(int inputNumber)
        {
            double total = 0;
            total = ((inputNumber * inputNumber) + 101) / 7f - 4;
            
            
            return Math.Round(total, 3);
        }

        // implement this method so that it returns true if num is even, otherwise false
        public static bool EvenOdd(int num)
        {
            return (num % 2) == 0;
        }

        // implement this method so that it returns 
        // the sum of all numbers between 1 and n inclusive 
        // that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int total = 0;
            for(int i = 0; i <= max; i++)
            {
                if((i % 2 == 0)||(i % 5 == 0))
                {
                    try
                    {
                        total += i;
                    }
                    catch(OverflowException e)
                    {
                        throw (e);
                    }
                }
            }
            return total;
        }

        // implement this method so it returns true if input is "password"
        // regardless of case
        public static bool CheckInput(string input)
        {
            string inputLower = input.ToLower();
            return inputLower == "password";
        }

        // implement this method so it returns the sum
        // of all the numbers in the list
        public static int SumList(List<int> list)
        {
            int total = 0;
            foreach(int num in list)
            {
                total += num;
            }
            return total;
        }
    }
}