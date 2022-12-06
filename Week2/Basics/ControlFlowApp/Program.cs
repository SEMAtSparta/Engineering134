using System.Security.Cryptography.X509Certificates;

namespace ControlFlowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int mark = 35;
            var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail"; //? operator performs an inline if statement where: bool ? ifTrue : ifFalse;*/

            List<int> nums = new List<int> { 22, 6,  -17, 3, 10 };

            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));

            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
        }

        /*public static string Priority(int level)
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
        }*/
    }
}