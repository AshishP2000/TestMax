using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMax
{
    public class FindMax
    {
        public static void MaxInt(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum Number between {1} and {2}", first, second, third);
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum Number between {1} and {2}", second, first, third);
            }
            else
            {
                Console.WriteLine("{0} is Maximum Number between {1} and {2}", third, first, second);
            }
        }
        public static void MaxFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum Number between {1} and {2}", first, second, third);
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum Number between {1} and {2}", second, first, third);
            }
            else
            {
                Console.WriteLine("{0} is Maximum Number between {1} and {2}", third, first, second);
            }
        }
    }
}
