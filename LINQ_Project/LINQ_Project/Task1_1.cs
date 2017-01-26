using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    class Task1_1
    {
        public static List<Books> bookList = new List<Books>()
            {
                new Books() {Name = "Harry Potter 1", Year = 2000},
                new Books() {Name = "LINQ TODAY", Year = 2016},
                new Books() {Name = "Lord of the rings", Year = 1972},
                new Books() {Name = "Lord of LINQ", Year = 1973}
            };
        IEnumerable<Books> rez = bookList.Where(t => t.Name.Contains("LINQ")).Where(y => y.Year % 4 == 0 && y.Year % 100 != 0 || y.Year % 400 == 0);

        public void Print()
        {
            foreach (var item in rez)
            {
                Console.WriteLine(item.Name + " - " + item.Year + " visokosnyi year");
            }
        }

    }
}
