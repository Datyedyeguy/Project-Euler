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
            // Initial setup, let's start counting with 3 already incremented once.
            int three = 0;
            int five = 0;
            int total = 0;
            int max = 10;

            while (true)
            {
                // Break when we hit max
                if (three >= max && five >= max)
                    break;

                if (three < five)
                {
                    // Increment 3 since it's lower
                    three += 3;

                    // Skip if we match as five has already counted it
                    if (three == five)
                        three += 3;

                    // If we're max, don't add to total
                    if (three >= max)
                        continue;

                    // Add to total
                    total += three;
                }
                else
                {
                    // Increment 5 since it's lower
                    five += 5;

                    // SKip if we match as three has already counted it
                    if (five == three)
                        five += 5;

                    // If we're max, dont' add to total
                    if (five >= max)
                        continue;

                    // Add to total
                    total += five;
                }
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
