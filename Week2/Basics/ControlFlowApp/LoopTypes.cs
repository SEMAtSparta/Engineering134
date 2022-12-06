using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int i = 0, highest = nums[0];
            do
            {
                highest = highest < nums[i] ? nums[i] : highest;
                i++;
            }
            while (i < nums.Count);
            return highest;
        }

        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];
            foreach(int i in nums)
            {
                highest = highest < i ? i : highest;
            }
            return highest;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];
            for(int i = 0; i < nums.Count; i++)
            {
                highest = highest < nums[i] ? nums[i] : highest;
            }
            return highest;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {
            int i = 0, highest = nums[0];
            while(i < nums.Count) { 
                highest = highest < nums[i] ? nums[i] : highest;
                i++;
            }
            return highest;
        }
    }
}
