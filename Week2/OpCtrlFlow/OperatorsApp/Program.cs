using System;

namespace OperatorsApp
{
      class Program
      {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;

            x++;
            ++y;

            int a = x++;
            int b = ++y;

            /*for (int i = 1; i <= 5; ++i)
            {
                Console.WriteLine(i);
            }*/

            var c = 5 / 2;      //truncated as 5 and 2 are type integers, so assigns c = 2.
            var d = 5.0 / 2;    //not truncated as 5.0 is type float, so assigns d = 2.5f
            double f = 5 / 2;   //still truncated before assignment happens, so assigns f = 2.

            var mod = 5 % 2;    //assigns mod = 1;

            LbsToStone(152);
            MysteryCode();

            int z = 5;
            Console.WriteLine(z++ + z);
        }

        bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static void LbsToStone(int x)
        {
            if(x < 0)
            {
                throw new ArgumentOutOfRangeException("Argument to LbsToStone must not be negative.");
            }
            int stone = x / 14;
            int remainder = x % 14;
            Console.WriteLine(x + "lbs is " + stone + " stone and " + remainder  + " ounces.");
        }

        static void MysteryCode()
        {
            int j = 5, k = 3, m = 4;

            m += +j++ + ++k;
            //m = 13
            //+j++: the prefix + appears to do nothing at all. This value is added before increment
            //+ ++k: this value is added after increment
        }


    }
}
