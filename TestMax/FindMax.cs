using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMax
{
    public class FindMax<T> where T : IComparable<T>
    {
        public T[] value;

        public FindMax(T[] value)
        {
            this.value = value;
        }

        public T[] sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values  = sort(values);
            return sorted_values[value.Length-1];
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is = "+max);
        }

        
    }
}
