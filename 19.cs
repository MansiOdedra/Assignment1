using System;
using System.Collections.Generic;
using System.Text;

namespace assignment19
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
            if (a > b)
            {
                c = (a - b)*2;
                if (c < 0)
                {
                    c=-(c);
                }
                Console.WriteLine("{0}", c);
            }
            else
            {
                c = a + b;
                if (c < 0)
                {
                    c = -(c);
                }
                Console.WriteLine("{0}",c);
            }
        }
    }
}
