// Task 1

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string vText = RemoveVowels(input);
        Console.WriteLine("Removed text: " +vText);

        int vCount = CountVowels(input);
        Console.WriteLine("Count of Vowels: " + vCount);
    }
    static string RemoveVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        string result = "";

        foreach (char c in input)
        {
            if (!vowels.Contains(c))
            {
                result = result + c;
            }
        }

        return result;
    }
    static int CountVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        int count = 0;

        foreach (char c in input)
        {
            if (!vowels.Contains(c))
            {
                count++;
            }
        }

        return count;

    }
}
*/

// Task 2 

/*using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            Txt();
        }
        static void Txt()
        {
            char[] word = { 'H', 'e', 'l', 'l', 'o' };
            Array.Reverse(word);

            foreach (char c in word)
            {
                Console.WriteLine(c);
            }

        }
    }
}*/

// Task 3

/*using System;

namespace Start
{
    public class Program
    {
        static void Main(string[] args)
        {
            text("HELLO");
        }
        static void text(string input)
        {
            foreach (char str in input)
            {
                Console.Write(str + " ");
            }
        }
    }
}*/