using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBC_Day10
{
    public class Home
    {
        public Home (string address, string city)
        {
            Address = address;
            City = city;
        }   

        public string Address { get; set; }
        public string City { get; set; }


    }
}
