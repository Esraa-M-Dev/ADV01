using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Person()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
