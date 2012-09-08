using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem004
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 999;
            int second = 999;
            int maxTotal = first * second;
            int maxTotalBest = 0;

            while (true)
            {
                if (IsPalindrome(maxTotal))
                {
                    if (maxTotalBest < maxTotal)
                        maxTotalBest = maxTotal;
                }

                second--;

                if (second < 100)
                {
                    second = first;
                    first--;

                    if (second * first < maxTotalBest)
                        break;
                }

                maxTotal = first * second;
            }

            Console.WriteLine("FOUND: {0}", maxTotalBest);
            Console.ReadLine();
        }

        private static bool IsPalindrome(int value)
        {
            string strValue = value.ToString();

            for (int i = 0; i < strValue.Length / 2; i++)
            {
                if (strValue[i] != strValue[strValue.Length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
