using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome to Find Maximum problem using Genrics
            //UC-4 Extend max method 


            int[] arr = {112,34,2324,456,23};
            FindMax<int> findmax = new FindMax<int>(arr);
            findmax.PrintMaxValue();

            Console.ReadLine();
        }
    }
}
