using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem002
{
    class Program
    {
        static void Main(string[] args)
        {
            long first = 1;
            long second = 2;
            long temp = 0;
            long total = 0;

            while (second < 4000000)
            {
                if ((second & 1) != 1)
                    total += second;

                temp = first + second;
                first = second;
                second = temp;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
