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
            //Refactor Given 3 Generics find Maximum
            

            Console.WriteLine(FindMax<int>.Max(40, 30, 20) + " is Maximum");
            Console.WriteLine(FindMax<float>.Max(40.40f, 30.30f, 20.20f) + " is Maximum");
            Console.WriteLine(FindMax<string>.Max("Peach", "Apple", "Banana") + " is Maximum");
            

            Console.ReadLine();
        }
    }
}
