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
            List<int> intArray = new List<int>();
            int area = lng * wdth;
            int decrement = (int)Math.Ceiling(Math.Sqrt(area));

            for (int i = decrement; i > 0; i--)
            {
                if (lng == wdth)
                {
                    return null;
                }

                if (area - Math.Pow(i, 2) > 0)
                {
                    area -= (int)Math.Pow(i, 2);
                    intArray.Add(i);
                }
                else if (area - Math.Pow(i, 2) == 0)
                {
                    return intArray;
                }
                if (area == 1)
                {
                    area -= 1;
                    intArray.Add(1);
                }

            }
            return intArray;
        }





    }
}
