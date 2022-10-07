using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMax
{
    public class FindMax<T> where T : IComparable<T>
    {
        public T first, second, third;

        public FindMax(T first,T second,T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T Max (T first, T second, T third) 
        {
            if (first.CompareTo(second)>= 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }

        public T MaxMethod()
        {
            T max = FindMax<T>.Max(this.first,this.second,this.third);
            return max;
        }

        
    }
}
