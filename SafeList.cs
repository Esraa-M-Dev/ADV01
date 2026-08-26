using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class SafeList<T>
    {
        private List<T> items = [];
        public void AddToList(T item)
        {
            items.Add(item);
        }
        public T GetElementAt(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            //return null in case of reference types,nullable value types
            //return 0 in case of int,float,double,decimal
            //return false in case of boolean
            return default;
        }
    }
}
