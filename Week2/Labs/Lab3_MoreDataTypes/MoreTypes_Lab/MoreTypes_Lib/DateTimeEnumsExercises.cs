using System;
using System.Net.Http;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            int age = date.Year - birthDate.Year;
            if(date < birthDate)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }

            if(date.Month < birthDate.Month || (date.Month == birthDate.Month)&&(date.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return $"{date.Year}/{date.Day}/{date.Month}###";
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            var month = date.Month;
            string output = "";

            switch (month)
            {
                case 1:
                    output = "January";
                    break;
                case 2:
                    output = "February";
                    break;
                case 3:
                    output = "March";
                    break;
                case 4:
                    output = "April";
                    break;
                case 5:
                    output = "May";
                    break;
                case 6:
                    output = "June";
                    break;
                case 7:
                    output = "July";
                    break;
                case 8:
                    output = "August";
                    break;
                case 9:
                    output = "September";
                    break;
                case 10:
                    output = "October";
                    break;
                case 11:
                    output = "November";
                    break;
                case 12:
                    output = "December";
                    break;

            }
            return output;
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            string message = "";
            switch (suit)
            {
                case Suit.CLUBS:
                    message = "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.DIAMONDS:
                    message = "Diamonds are a girls best friend";
                    break;
                case Suit.HEARTS:
                    message = "You've broken my heart";
                    break;
                case Suit.SPADES:
                    message = "Bucket and spade";
                    break;
            }

            return message;
        }
    }
}
