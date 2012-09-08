using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem003
{
    class Program
    {
        static void Main(string[] args)
        {
            long largeNumber = 600851475143L;
            long start = 3;
            long max = 0;

            while (largeNumber > max)
            {
                while (largeNumber % start == 0)
                {
                    largeNumber /= start;
                    max = start;
                }

                start += 2;
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
