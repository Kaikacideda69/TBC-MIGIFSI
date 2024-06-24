using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBC_Day09
{
    public class Cat
    {

        public string Name { get; set; }

        public string Breed { get; set; }
        public int Age { get; set; }

        public string sex { get; set; }

        public void Meow(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meowing ...");
            }
        }

        



    }
}
