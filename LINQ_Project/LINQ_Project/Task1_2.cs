using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    class Task1_2
    {
        public int count = 0;
        public static string[] teams =
           {
                "Бавария", "Боруссия", "Реал", "Манчестер", "ПСЖ", "Барселона", "ПАОК",
                "Арсенал", "Челси"
            };
        IEnumerable<Char> rez2 = teams.SelectMany(s => s.ToLower().Trim().ToCharArray()).Distinct();

        public void Print()
        {
          foreach (var VARIABLE in rez2)
                    {
                        count++;
                        Console.Write(VARIABLE + " ");
                    }
            Console.WriteLine("\nThere {0} words are used", count);
        }

        //Second variant
        
        //List<char> charList = new List<char>();
        //int count = 0;
        //for (int i = 0; i < rez2.Count(); i++)
        //{

        //    if (charList.Contains(rez2.ElementAt(i)) != true)
        //        {
        //            charList.Add(rez2.ElementAt(i));
        //            count++;
        //        }
        // }

        //foreach (var item in charList)
        //{
        //    Console.Write(item);
        //}

        //Console.WriteLine("\nThere {0} words are used", count);
    }
}
