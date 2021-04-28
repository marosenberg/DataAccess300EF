using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NORTHWNDEntities ent = new NORTHWNDEntities())
            {
                foreach(var item in ent.Categories.ToList())
                {
                    Console.WriteLine(item.CategoryName);
                }
                Console.ReadLine();

            }
        }
    }
}
