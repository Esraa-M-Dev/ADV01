using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Utility
    {
        //Q4:Swap
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //Q5:FindMax
        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            if (items is not null && items.Length > 0)
            {
                T maxvalue = items[0];
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i].CompareTo(maxvalue) > 0)
                        maxvalue = items[i];
                }
                return maxvalue;
            }
            return default;
        }
    }
}
