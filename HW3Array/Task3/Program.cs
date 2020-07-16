using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task3 \nPlease enter array: ");
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out var arr);
                array[i] = arr;
            }

            ArraySumMultiply arraySumMultiply = new ArraySumMultiply();
            var rez = arraySumMultiply.GetArraySumMulti(array);
            Console.WriteLine($"{rez.Multiply} {rez.Sum}");
        }
    }
}
