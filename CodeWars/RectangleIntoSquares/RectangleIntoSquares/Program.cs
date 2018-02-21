using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntoSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intarray = new List<int>();
            intarray = sqInRect(5, 3);
            foreach (int integer in intarray)
            {
                Console.WriteLine(integer);
            }
            Console.ReadKey();

        }
        public static List<int> sqInRect(int lng, int wdth)
        {
            int size = 0;
            int rectangleSize = lng * wdth;
            bool isFound = false;
            int increment = 1;
            int i = 0;
            List<int> intArray = new List<int>();

            while (!isFound)
            {
                if (lng < wdth && increment != 0)
                {
                    increment = lng - i;
                    if (size < rectangleSize)
                    {
                        size += (int)Math.Pow(increment, 2);
                        intArray.Add(increment);
                        increment--;
                        i++;
                    }
                    else if (size == rectangleSize)
                    {
                        isFound = true;
                    }
                    else
                    {
                        increment--;

                    }

                }
                else if (wdth < lng)
                {
                    increment = wdth - i;
                    if (size < rectangleSize)
                    {
                        size += (int)Math.Pow(increment, 2);
                        intArray.Add(increment);
                        increment--;
                        i++;
                    }
                    else if (size == rectangleSize)
                    {
                        isFound = true;
                    }
                    else
                    {
                        increment--;
                    }
                }
            }
            return intArray;
        }
    




}
}
