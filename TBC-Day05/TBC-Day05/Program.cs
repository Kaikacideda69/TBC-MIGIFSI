using System;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LashaBoldHaHa
{
    class Program
    {
        static void Main(string[] args)
        {

            // TASK 1-2

            /*Console.WriteLine("Enter array size: ");

            int SizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[SizeOfArray];
           

            for (int i = 0; i < Arr.Length; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    Arr[i] = number;
                    
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            Array.Reverse(Arr);

            Console.WriteLine("Here is ur array: ");
            // for (int i = 0; i < Arr.Length; i++)
            // {
            //     Console.WriteLine(Arr[i]);
            // }
            
            foreach (int length in Arr)
            {
                
                Console.WriteLine(length);
            }*/

            // Task 3

            /*Console.WriteLine("Enter array size: ");

            int SizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[SizeOfArray];


            for (int i = 0; i < Arr.Length; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    Arr[i] = number;

                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            int sum = 0;
            foreach (int length in Arr)
            {

                sum += length; 
            }
            Console.WriteLine("Sum of array: " + sum);*/

            // TASK 4

            /*int SizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[SizeOfArray];

            for (int i = 0; i < Arr.Length; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    Arr[i] = number;
                }else
                {
                    Console.WriteLine("INVALID");
                }
  
            }

            int sum = 1;
            foreach (int length in Arr)
            {
                sum = sum * length;
            }
            Console.WriteLine("Product: " + sum);*/

            // Task 5

            /*int SizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[SizeOfArray];

            for (int i = 0; i <  Arr.Length; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    Arr[i] = number;
                }else
                {
                    Console.Write("Invalid");
                }
          
            }

            bool[] seen = new bool[1001];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (!seen[Arr[i]])
                {
                    seen[Arr[i]] = true;
                    Console.WriteLine("uniq elements: " + Arr[i] + " ");
                }
            }*/

            // Task 6

            /* Console.WriteLine("Enter Array Row Size: ");

             int RowSize = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Array Column Size: ");

             int ColumnSize = Convert.ToInt32(Console.ReadLine());



             int[,] Arr = new int[RowSize, ColumnSize];


             for (int i = 0; i < RowSize; i++)
             {
                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }

             Console.WriteLine("Here is your Array: ");
             for (int i = 0; i < RowSize; i++)
             {

                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Console.Write(Arr[i, j] + " ");
                 }
                 Console.WriteLine();
             }*/

            // Task 7

            /* Console.WriteLine("Enter Array Row Size: ");

             int RowSize = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Array Column Size: ");

             int ColumnSize = Convert.ToInt32(Console.ReadLine());



             int[,] Arr = new int[RowSize, ColumnSize];

             // first 2d Array
             for (int i = 0; i < RowSize; i++)
             {
                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }


             for (int i = 0; i < RowSize; i++)
             {
                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Console.Write(Arr[i, j] + " ");
                 }
                 Console.WriteLine();
             }

             Console.WriteLine("Fill the second matrix");

             int[,] Arr2 = new int[RowSize, ColumnSize];


             // second 2d Array
             for (int i = 0; i < RowSize; i++)
             {
                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }

             for (int i = 0; i < RowSize; i++)
             {
                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Console.Write(Arr2[i, j] + " ");
                 }
                 Console.WriteLine();
             }

             // sum of arrays
             Console.WriteLine("Sum of Arrays: ");
             for (int i = 0; i < RowSize; i++)
             {
                 for (int j = 0; j < ColumnSize; j++)
                 {
                     Console.Write((Arr[i, j] + Arr2[i, j]) + " ");
                 }
                 Console.WriteLine();
             }*/

            // LASHAAAA IM TIREDDDDDDDDDDDDD  MAAAANNNN


            // Task 8 - agi mtla ver gevige

            /*int[,] araminda =
        {
            {0, 1, 1, 1, 1, 1, 1, 1},
            {0, 0, 1, 1, 1, 1, 1, 1},
            {0, 0, 0, 1, 1, 1, 1, 1},
            {0, 0, 0, 0, 1, 1, 1, 1},
            {0, 0, 0, 0, 0, 1, 1, 1},
            {0, 0, 0, 0, 0, 0, 1, 1},
            {0, 0, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 0, 0}
        };

            int rows = araminda.GetLength(0);
            int columns = araminda.GetLength(1);

            for (int col = 0; col < columns; col++)
            {
                int writeIndex = rows - 1;

                for (int row = rows - 1; row >= 0; row--)
                {
                    if (araminda[row, col] == 1)
                    {
                        // Swap current element with element at writeIndex
                        int temp = araminda[row, col];
                        araminda[row, col] = araminda[writeIndex, col];
                        araminda[writeIndex, col] = temp;

                        // Move writeIndex upwards
                        writeIndex--;
                    }
                }
            }

            Console.WriteLine("Rearranged Array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(araminda[i, j] + " ");
                }
                Console.WriteLine();
            }*/



        }
    }
}