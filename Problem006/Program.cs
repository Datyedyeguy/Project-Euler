using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem006
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong max = 100;
            ulong sumOfSquares = 0;
            ulong squareOfSum = 0;

            for (ulong i = 1; i <= max; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;
            Console.WriteLine(squareOfSum - sumOfSquares);
            Console.ReadLine();
        }
    }
}
