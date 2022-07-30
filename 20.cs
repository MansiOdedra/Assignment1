using System;
using System.Collections.Generic;
using System.Text;

namespace assignment20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter number a ");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b ");
             b = Convert.ToInt32(Console.ReadLine());
             c = a + b;
             if (a == 20 || b == 20 || c == 20)
             {
                 Console.WriteLine("true"); 
             }
             else
             {
                 Console.WriteLine("{0}",c);
             }
        }
    }
}
