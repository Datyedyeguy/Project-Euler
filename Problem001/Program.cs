using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem001
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int five = 0;
            int total = 3;
            int max = 1000;

            while (true)
            {
                if (three >= max && five >= max)
                    break;

                if (three < five)
                {
                    three += 3;

                    if (three == five)
                        three += 3;

                    if (three >= max)
                        continue;

                    total += three;
                }
                else
                {
                    five += 5;

                    if (five == three)
                        five += 5;

                    if (five >= max)
                        continue;

                    total += five;
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
