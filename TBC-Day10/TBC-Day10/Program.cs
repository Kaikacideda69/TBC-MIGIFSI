using System;
using TBC_Day10;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[3];

            Home home1 = new Home("123 Main St", "Springfield");
            people[0] = new Person("Alice", 30, "PID123", home1);

         
            Home home2 = new Home("456 Oak Ave", "Rivertown");
            people[1] = new Person("Bob", 25, "PID456", home2);

    
            Home home3 = new Home("789 Elm Rd", "Lakeview");
            people[2] = new Person("Charlie", 40, "PID789", home3);

            for (int i = 0; i < people.GetLength(0); i++)
            {
                Person person = people[i];
            }


        }
    }
}