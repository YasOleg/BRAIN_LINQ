using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    public class Task2_1
    {
        static int[] twodigits = {72, 44, 67, 5, 25, 98, 1, 24, 32, 53, 33, 73, 2};

        int sum = twodigits.Aggregate(0, (result, next) => result + next);
       
        int countR = twodigits.Aggregate(0, (result, next) => result + 1);
        
        int max = twodigits.Aggregate(0, (result, next) => result < next ? next : result);
        
        double averageR = twodigits.Select(integ => (double) integ).Aggregate((result, current) => (result + current)) /
                          twodigits.Count();
        public void Print()
        {
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Count: " + countR);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + averageR);
        }

    }
}
