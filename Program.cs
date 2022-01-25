// See https://aka.ms/new-console-template for more information
using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to calculate a binary gap:");
            int i = Convert.ToInt32(Console.ReadLine());
            
            string binary = Convert.ToString(i, 2);

            //tracks the gaps
            int maxGap = 0;
            int currentGap = 0;

            if (i == 0)
            {
                Console.WriteLine(0);
            }

            while (i % 2 == 0)
            {
                //intrinsically reads a number as binary and shifts through the bits by one
                i = i >> 1;
            }

            while (i > 0)
            {
                if (i % 2 == 0)
                {
                    currentGap++;
                }
                else
                {
                    maxGap = Math.Max(currentGap, maxGap);
                    currentGap = 0;
                }
                i = i >> 1;
            }
            Console.WriteLine("The binary gap is: " + maxGap);
            Console.ReadLine();
        }
    }
}

