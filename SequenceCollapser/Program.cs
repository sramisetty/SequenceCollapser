using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceCollapser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var number=int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                int j = i;
                int pItem = -1;
                List<int> items = new List<int>();
                while (j > 0)
                {
                    int item = (int)(j % 10);
                    if (pItem != item)
                    {
                        items.Insert(0, item);
                        pItem = item;
                    }
                    j = j / 10;
                }
                Console.WriteLine(i + " : " + string.Join("", items));
            }
           
        }
    }
}
