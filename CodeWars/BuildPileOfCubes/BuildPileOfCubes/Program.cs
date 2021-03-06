﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPileOfCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = Console.Read();

            long m = findNb(number);
            Console.WriteLine(m);
            Console.ReadKey();
        }

        /*
         * Takes a long m, which represents the volume of a cube and finds the sum of n^3 + (n-1)^3 down to 1^3 and returns the number of times it has been completed.
         */

        public static long findNb(long m)
        {
            long result = 0;
            int n = 1;

            for (int i = 0; i < n; i++)
            {
                result += (long)Math.Pow(n, 3);
                if (result < m)
                {
                    n++;
                }
                else if (result == m)
                {
                    break;
                }
                else
                {
                    return -1;
                }
            }
            return n;
        }
    }
}
