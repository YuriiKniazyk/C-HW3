using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Array
{
    class StringCount
    {
        public List<CountSymbol> Items { get; set; } = new List<CountSymbol>
        {
            new CountSymbol('a'),
            new CountSymbol('o'),
            new CountSymbol('i'),
            new CountSymbol('e')
        };

        public void CountSymbol(string text)
        {
            foreach (var symbol in text)
            {
                foreach (var item in Items)
                {
                    if (symbol == item.Symbol)
                    {
                        item.Count ++;
                        break;
                    }
                }
            }

        }
    }
}
