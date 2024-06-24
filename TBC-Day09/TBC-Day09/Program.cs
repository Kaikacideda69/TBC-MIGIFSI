// Task 1

/*using System;
using System.Transactions;
using TBC_Day09;

class Program
{
    static void Main()
    {
        Program myProgram = new Program();
        myProgram.StartMethod();
    }
    public void StartMethod()
    {
        Cat cat = new Cat();
            
        Console.WriteLine("Enter Name: ");
        cat.Name = Console.ReadLine();

        Console.WriteLine("Enter Breed: ");
        cat.Breed = Console.ReadLine();

        Console.WriteLine("Enter Age: ");
        cat.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Sex: ");
        cat.sex = Console.ReadLine();

        Console.WriteLine("Cat object created: ");

        eat();
        Console.WriteLine("Enter meowing count: ");
        int times = int.Parse(Console.ReadLine());
        cat.Meow(times);
    }
   
    public void eat ()
    {
        int gramsEaten = 0;

        Console.WriteLine("Enter food in weight in grams: ");
        int grams = int.Parse(Console.ReadLine());

        int unit = grams / 10;

        if (unit == 0 && unit > 10)
        {
            unit = 1;
        }
        gramsEaten += grams;
        Console.WriteLine("Cat starts eating");
        for (int i = 0; i < unit; i++)
        {
            Console.WriteLine("Eating ... ");
        }
    }
}*/

// Task 2

/*using System;
using TBC_Day09;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.StartMethod();

        }
        public void StartMethod()
        {
            Console.Write("Enter side 1: ");
            Triangle triangle1 = new Triangle();
            int SideA = triangle1.Side = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            Triangle triangle2 = new Triangle();
            int SideB = triangle2.Side = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            Triangle triangle3 = new Triangle();
            int SideC = triangle3.Side = int.Parse(Console.ReadLine());

            Console.WriteLine("Triangle Perimeter: ");
            CalcPerimeter(SideA, SideB, SideC);

            Console.WriteLine("Trinagle Area: ");
            Console.WriteLine(CalcTriangleArea(SideA, SideB, SideC));


        }
        public void CalcPerimeter(int i, int b, int c)
        {
            Console.WriteLine(i + b + c);
        }
         public double CalcTriangleArea(int i, int b, int c)
        {
            double s = (i + b + c) / 2;
            return Math.Sqrt(s * (s - i) * (s - b) * (s - c));
        }
    }
}*/

// Task 3

using System;
using TBC_Day09;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.StartMethod();

        }
        public void StartMethod()
        {

            Console.Write("Enter hours (0-23): ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes (0-59): ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Enter seconds (0-59): ");
            int seconds = int.Parse(Console.ReadLine());

            Clock currentTime = new Clock();
            currentTime.Minutes = minutes;
            currentTime.Seconds = seconds;
            currentTime.Hours = hours;

            currentTime.DisplayTime();

            currentTime.increaseTime();
            Console.WriteLine("After incresed time ");
            currentTime.DisplayTime();
        }
    }
}
