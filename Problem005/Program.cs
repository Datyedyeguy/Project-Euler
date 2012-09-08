using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem005
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 20;
            int test = 0;
            bool solved = false;

            while (solved == false)
            {
                solved = true;
                test += max;

                for (int i = max; i > 2 && solved; i--)
                {
                    if (test % i != 0)
                        solved = false;
                }
            }

            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
