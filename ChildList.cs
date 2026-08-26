using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class ChildList<T>:ParentList<int> 
    {
        public T ChildProperty { get; set; }
    }
}
