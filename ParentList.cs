using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class ParentList<T>
    {
        protected List<T> list = new List<T>();

        public void AddToList(T item)
        {
            list.Add(item);
        }
    }
}
