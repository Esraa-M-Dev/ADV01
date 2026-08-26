using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class DogProducer : IProducer<Dog>
    {
        public Dog Produce()
        {
            return new Dog();
        }
    }
}
