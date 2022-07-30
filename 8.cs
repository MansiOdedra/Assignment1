using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i=0 ; i<11 ; i++)
            {
                int b;
                b = a * i;
                Console.WriteLine("{0}*{1}={2}",a,i,b);
            }
        }
    }
}
