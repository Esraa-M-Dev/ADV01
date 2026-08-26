using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine("animal consume...."); ;
        }
    }
}
