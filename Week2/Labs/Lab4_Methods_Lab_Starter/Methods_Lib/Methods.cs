using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if(totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            const int daysInAWeek = 7;
            (int Weeks, int Days) output = (0, 0);
            output.Weeks = totalDays / daysInAWeek;
            output.Days = totalDays % daysInAWeek;

            return output;

        }

        public static (int square, int cube, double sqrt) PowersRoot(int input)
        {
            if(input < 0)
            {
                throw new ArgumentOutOfRangeException("Input cannot be negative.");
            }

            (int square, int cube, double sqrt) output;
            checked
            {
                output.square = input * input;
                output.cube = (int)Math.Pow(input, 3);
            }
            output.sqrt = Math.Sqrt(input);

            return output;
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
