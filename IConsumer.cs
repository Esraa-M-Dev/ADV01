using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal interface IConsumer<in T> where T:Animal
    {
        void Consume(T animal);
    }
}
