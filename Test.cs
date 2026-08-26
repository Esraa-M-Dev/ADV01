using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Test<T> where T:IPrinter
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}
