using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingsOfDefault
    {
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingsOfDefault()
        {
            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}