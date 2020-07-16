using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1 \nPlease enter the text: ");
            string text = Console.ReadLine().ToLower();

            StringCount stringCount = new StringCount();
            stringCount.CountSymbol(text);

            foreach (var countSymbol in stringCount.Items)
            {
                Console.WriteLine($"{countSymbol.Symbol}, {countSymbol.Count}");
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
