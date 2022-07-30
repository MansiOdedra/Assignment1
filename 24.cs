using System;
using System.Collections.Generic;
using System.Text;

namespace assignment24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int s = 0;
            for (int i = 2; i < 500; i++)
            {
                if (isPrime(n))
                {
                    s += n;
                }
                n++;
                Console.WriteLine("{0}", s);
            }
        }
    }
}
