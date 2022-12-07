using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
            //returns false if num1 == num2 or num1 is not a multiple of num2.
            //returns true only if num1 is a non-identical multiple of num2
            
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (!nums.Any())
            {
                return 0;
            }

            double total = 0;

            for(int i = 0; i < nums.Count; ++i)
            {
                total += nums[i];
            }
            return total / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            switch (age)
            {
                case > 59:
                    ticketType = "OAP";
                    break;
                case > 17:
                    ticketType = "Standard";
                    break;
                case > 12:
                    ticketType = "Student";
                    break;
                case >= 5:
                    ticketType = "Child";
                    break;
                case >= 0:
                    ticketType = "Free";
                    break;
                default:
                    System.Console.WriteLine("Negative age is not permitted or possible.");
                    break;
            }
            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";

            if(100 >= mark && mark > 74)
            {
                grade = "Pass with Distinction";
            }
            else if(75 > mark && mark > 59)
            {
                grade = "Pass with Merit";
            }
            else if(60 > mark && mark > 39)
            {
                grade = "Pass";
            }
            else if(40 > mark && mark >= 0)
            {
                grade = "Fail";
            }
            else
            {
                grade = "Negative marks not permitted.";
            }

            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch (covidLevel)
            {
                case 0:
                    return 200;
                case 1:
                    return 100;
                case 2:
                    return 50;
                case 3:
                    return 50;
                case 4:
                    return 20;
                default:
                    System.Console.WriteLine("Negative covid level not permitted.");
                    return -1;
            }
        }
    }
}
