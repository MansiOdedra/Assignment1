using System;
using System.Collections.Generic;
using System.Text;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("enter number a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number c ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number d ");
            int d = Convert.ToInt32(Console.ReadLine());
            int e;
            e = a + b + c + d / 4;
            Console.WriteLine("{0}", e);
        }
    }
}
