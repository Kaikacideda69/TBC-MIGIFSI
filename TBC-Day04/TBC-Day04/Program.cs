using System;

namespace Day4
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Task 1

            /* int number = 11;*/
            /* int sum = 0;

             for (int i = 0; i < 11; i++)
             {
                 int num = i;
                 sum = sum + num;

             }
             Console.WriteLine(sum);*/


            // Task 3
            /*  int num = Convert.ToInt32(Console.ReadLine());

              for (int i = 0; i < num; i++)
              {
                  Console.WriteLine(Math.Pow(i, 3));
              }
  */
            // Task 4

            /*  int GetNum = Convert.ToInt32(Console.ReadLine());

              int sum = 0;

              for (int i = 0; i <= GetNum; i++)
              {
                  int num = i;

                  if (num % 2 == 0)
                  {

                  }
                  else
                  {
                      sum += num;
                      Console.WriteLine(sum);
                  }


              }*/

            // Task 5

            /*Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
            int Rownum = Convert.ToInt32(Console.ReadLine());

            int i, j, k= 1;
            
            for (i = 1; i <= Rownum; i++)
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write(k + " ");
                }

                Console.Write("\n");
            }*/

            // Task 6

            /*  Console.WriteLine("Enter a number: ");
              string input = Console.ReadLine();

              if (int.TryParse(input, out int num))
              {
                  Console.WriteLine($"Divisors of {num}:");
                  for (int i = 1; i <= num; i++)
                  {
                      if (num % i == 0)
                      {
                          Console.WriteLine(i);
                      }
                  }
              }
              else
              {
                  Console.WriteLine("Invalid");
              }*/

            // Task 8
            // bozebis jinaze


           /* int Decimalnum = Convert.ToInt32(Console.ReadLine());

            string binary = Convert.ToString(Decimalnum, 2);

            Console.WriteLine(binary);*/






        }
    
    }
}


