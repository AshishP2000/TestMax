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

            Console.WriteLine("1.Maximum Integer\n2.Maximum Float/Double\n3.Maximum String");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int[] arr = { 112, 34, 2324, 456, 23 };
                    FindMax<int> findmaxint = new FindMax<int>(arr);
                    findmaxint.PrintMaxValue();
                    break;
                case 2:
                    double[] arr1 = { 12.12, 34.34, 232.24, 456.45, 233.44 };
                    FindMax<double> findmaxdouble = new FindMax<double>(arr1);
                    findmaxdouble.PrintMaxValue();
                    break;
                case 3:
                    string[] arr2 = { "peach", "apple", "banana", "sugercane", "dragonfruit" };
                    FindMax<string> findmaxstring = new FindMax<string>(arr2);
                    findmaxstring.PrintMaxValue();
                    break;
            }

            

            Console.ReadLine();
        }
    }
}
