using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal interface IProducer<out T> where T:Animal
    {
        T Produce();
    }
}
