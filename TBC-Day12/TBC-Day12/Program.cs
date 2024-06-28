// Task 1
/*using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine(Diskriminant(7, 12, 5))
        }
        static double Diskriminant(int b, int a, int c)
        {
            double D = Math.Pow(b, 2) - (4 * (a * c));

            return D;
        }
        static double Fesvi(int b, int a, int c)
        {
            double X1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            return X1;
        }
    }
}
*/


// Task 2

/*using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array: ");

            int size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[size];

            Console.WriteLine("Enter Numbers for array: ");
            for (int i = 0; i < size; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of positions to rotate:");
            int step = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 'L' for left rotation or 'R' for right rotation: ");
            char direction = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Original Array: " + string.Join(", ", Arr));

            if (direction == 'L')
            {
                RotateLeft(Arr, step);
            }
            else if (direction == 'R')
            {
                RotateRight(Arr, step);
            }
            else
            {
                Console.WriteLine("INVALID");              
            }

            Console.WriteLine("Rotated array: " + string.Join(", ", Arr));

        }
        static void RotateLeft(int[] array, int step)
        {
            int length = array.Length;
            step = step % length;

            Reverse(array, 0, length - 1);
            Reverse(array, 0, length - step - 1);
            Reverse(array, length - step, length - 1);
        }
        static void RotateRight(int[] array, int step)
        {
            int length = array.Length;
            step = step % length;

            Reverse(array, 0, length - 1);
            Reverse(array, 0, step - 1);
            Reverse(array, step, length - 1);

        }
        static void Reverse(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}*/

// Task 3 // es ra yleooba cma MIGIFSIT TBC

/*using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("To turn off the program type 'exit', otherwise enter the directory path:");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (Directory.Exists(input))
            {
                PrintAllFiles(input);
            }
            else
            {
                Console.WriteLine($"The directory {input} does not exist!");
            }
        }
    }

    static void PrintAllFiles(string path)
    {
        try
        {
            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine(file);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {
                PrintAllFiles(directory);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}*/


// Task 4

/*using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Enter First Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Second Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Operator: ");
                string Operator = Console.ReadLine();

                if (Operator == "+")
                {
                    Console.WriteLine("Result: " + (num1 + num2));
                }
                else if (Operator == "-")
                {
                    Console.WriteLine("Result: " + (num1 - num2));
                }
                else if (Operator == "*")
                {
                    Console.WriteLine("Result: " + (num1 * num2));
                }
                else if (Operator == "/")
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Nig");
                }
                Console.WriteLine("Wanna Continue? Press H");

            } while (Console.ReadLine().ToUpper() == "H");
        }
    }
}*/