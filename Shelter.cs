using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Shelter<T> where T:Animal,new() //multiple constraint
    {
        public void Feed(T animal)
        {
            animal.Eat();
        }
    }
}
