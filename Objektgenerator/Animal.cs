using System;
using System.Collections.Generic;
using System.Text;

namespace Objektgenerator
{
    class Animal
    {
        public string species { get; set; }
        public string name { get; set; }

        public Animal(string species, string name)
        {
            this.species = species;
            this.name = name;
        }
    }
}
