/*using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NumberArr(4));

        }
        
        static int NumberArr(int index)
        {
            int[] Arr = { 1, 3, 4, 15, 13, 23, 98 };
            return Arr[index];
        }
    }
}*/

// Task 1

// Task 2

/*using System;
using System.Reflection;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 3, 123, 15, 23, 98 };

            
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < Arr.Length)
            {
                int SumOfDigits = SumOfNums(Arr, index);
                Console.WriteLine("The sum of the digits of a number at index " + index + " is " + SumOfDigits); 
            }else
            {
                Console.WriteLine("INVALID");
            }
        }
        static int SumOfNums(int[] nums, int index)
        {
            int number = nums[index];
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}*/


// Task 3

/*using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArr();

            if (array.Length > 0)
            {
                int[] minMax = FindMinMax(array);

                Console.WriteLine("Minimum number in the array: " + minMax[0]);
                Console.WriteLine("Maximum number in the array: " + minMax[1]);
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }
        static int[] CreateArr()
        {

            int size = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[size];

            for (int i = 0; i < Arr.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out Arr[i]))
                {
                    
                    return new int[0];
                }
            }
            return Arr;

        }

        static int[] FindMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return new int[] { min, max };
        }

    }
}*/

// Task 4

/*sing System;
using System.Diagnostics.CodeAnalysis;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = CreateArr();

            Console.WriteLine("Ur Array");
            foreach (int num in numbers)
            {
                
                Console.Write(num + " ");
            }

            double average = CalcAvg(numbers);
            Console.WriteLine("Average: " + average);
        }

        static int[] CreateArr()
        {
            int size = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[size];

            for (int i = 0; i < Arr.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out Arr[i]))
                {
                    return new int[0];
                }
            }
            return Arr;
        }
        static double CalcAvg(int[] array)
        {
            int sum = 0;
            foreach (int arr in array)
            {
                sum += arr;
            }
            return (double)sum / array.Length;
        }
    }
}*/

// Task 5
/*using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArr();

            if (array.Length > 0)
            {
                Console.Write("Enter a number to find its factorial in the array: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    int result = FindToFactorialNumber(array, number); // Find and calculate factorial

                    if (result != -1)
                    {
                        Console.WriteLine($"Factorial of {number} found in the array: {result}");
                    }else
                    {
                        Console.WriteLine("invalid");
                    }
                }

            }
            static int[] CreateArr()
            {
                Console.WriteLine("Enter Size Of Array: ");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] Arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    if (!int.TryParse(Console.ReadLine(), out Arr[i]))
                    {
                        return new int[0];
                    }
                }
                return Arr;
            }
            static int FindToFactorialNumber(int[] array, int number)
            {

                bool found = false;

                foreach (int num in array)
                {
                    if (num == number)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"Number {number} not found in the array.");
                }

                return CalcFactorial(number);
            }
            static int CalcFactorial(int num)
            {
                int factorial = 1;

                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                return factorial;

            }
        }
    }
}*/

// Task 6

/*using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] array = CreateArr();

            Console.Write("Enter the symbol to search for: ");
            char symbol = Console.ReadLine()[0];

            int count = FindChar(array, symbol);
            DisplayResult(symbol, count);


        }
        static char[] CreateArr()
        {
            Console.Write("Enter the number of characters in the array: ");
            int size = Convert.ToInt32 (Console.ReadLine());
            char[] charArray = new char[size];

            Console.WriteLine($"Enter {size} characters (one per line):");
            for (int i = 0; i < size; i++)
            {
                charArray[i] = Console.ReadKey().KeyChar; 
                Console.WriteLine();
            }

            return charArray;
        }
        static int FindChar(char[] array, char symbol)  
        {
            int count = 0;

            foreach (char c in array)
            {
                if (c == symbol)
                {
                    count++;
                }
            }
            return count;
        }
        static void DisplayResult(char symbol, int count)
        {
            Console.WriteLine("{0} was found {1} times", symbol, count);
        }
    }
}*/
using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Array: ");
            int[,] Arr1 = CreateArr(rows, columns);

            Console.WriteLine("Second Array: ");
            int[,] Arr2 = CreateArr(rows, columns);

            Console.WriteLine("Sum of Arrays: ");
            int[,] sumArrs = SumArrs(Arr1, Arr2);

            DisplayArr(sumArrs);


        }
        static int[,] CreateArr(int rows, int columns)
        {

            int[,] Arr = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    Arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return Arr;
        }
        static int[,] SumArrs(int[,] Arr1, int[,] Arr2)
        {
            int rows = Arr1.GetLength(0);
            int columns = Arr2.GetLength(1);
            int[,] sumArray = new int [rows, columns];
            
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumArray[i,j] = Arr1[i, j] + Arr2[i, j];
                }
            }
            return sumArray;
        }
        static void DisplayArr(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
