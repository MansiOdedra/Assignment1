using System;
using System.Collections.Generic;
using System.Text;

namespace assignment18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("enter number a ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
            }
            else
            {
                c = (a + b) * 3;
                Console.WriteLine("{0}", c);
            }
        }
    }
}
