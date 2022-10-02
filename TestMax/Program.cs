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
            //UC-2 Given 3 Floats find Maximum

            //FindMax.MaxInt(40,30,20);//maximum at first position
            //FindMax.MaxInt(30, 40, 20);//maximum at second position
            //FindMax.MaxInt(30, 20, 40);//maximum at third position

            FindMax.MaxFloat(40.40f,30.30f,20.20f);//maximum at first position
            FindMax.MaxFloat(30.30f, 40.40f, 20.20f);//maximum at second position
            FindMax.MaxFloat(30.30f, 20.20f, 40.40f);//maximum at third position

            Console.ReadLine();
        }
    }
}
