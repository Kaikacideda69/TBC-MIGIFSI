using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBC_Day10
{
    public class Person
    {
        public Person (string name, int age, string id, Home home)
        {
            Name = name;
            Age = age;
            Id = id;
            this.home = home;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id  { get; set; }

        public Home home { get; set; }

    
    }
}
