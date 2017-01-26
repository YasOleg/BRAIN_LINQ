using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    class Task1_3
    {
        public static int[] masInt = { 14, 12, 23, 20, 33, 32 };

        IEnumerable<Int32> rez3_1 = masInt.OrderBy(s => s);
        IEnumerable<Int32> rez3_2 = masInt.OrderByDescending(s => s);

        public void Print()
        {
            Console.Write("\nOrderBy elements: ");
            foreach (var item in rez3_1)
            {
                Console.Write(item + "; ");
            }

            Console.Write("\nOrderByDescending elements: ");
            foreach (var item in rez3_2)
            {
                Console.Write(item + "; ");
            }
        }
      
    }
}
