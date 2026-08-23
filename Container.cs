using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Container<T> where T:struct
    {
        public T Value { get; set; }

    }
}
