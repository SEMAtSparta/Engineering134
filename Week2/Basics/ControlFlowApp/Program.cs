using System.Security.Cryptography.X509Certificates;

namespace ControlFlowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark = 35;
            var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail"; //? operator performs an inline if statement where: bool ? ifTrue : ifFalse;
        }

        public static string Priority(int level)
        {
            string priority = "Code ";
            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                    
                case 0:
                    priority = priority + "Green";
                    break;     
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }
    }
}