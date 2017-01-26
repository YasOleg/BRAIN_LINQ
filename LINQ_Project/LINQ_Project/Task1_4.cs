using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Project
{
    public class Task1_4
    {
        Books[] bksArray = 
            {
                new Books{Name = "Lord of the rings", Author = "Tolkien"},
                new Books{Name = "Harry Potter 1", Author = "Rouling"},
                new Books{Name = "LINQ TODAY", Author = "Rihter"},
                new Books{Name = "Lord of LINQ", Author = "Tolkien"}
            };

      
        public void Print()
        {
            var rez = bksArray.GroupBy(p => p.Author).Select(g => new { Name = g.Key, Count = g.Count() });
            foreach (var  group in rez)
            {
                Console.WriteLine("{0} : {1}", group.Name, group.Count);
            }
        }


    }
}
