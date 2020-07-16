using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task2 \nPlease enter the number month: ");
            int month = Int32.Parse(Console.ReadLine());
            int days = DateTime.DaysInMonth(DateTime.Now.Year, month);
            Console.WriteLine($"Month have a {days} day");
        }
    }
}
