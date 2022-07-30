using System;
using System.Collections.Generic;
using System.Text;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter number x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number z");
            z = Convert.ToInt32(Console.ReadLine());
            int a,b;
            a=(x+y)*z;
            b=x*y+y*z;
            Console.WriteLine("{0},{1}",a,b);
        }
    }
}
