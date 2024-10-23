using System;
namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Alphabet ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is Uppercase");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + " is Lowercase");
            }
            else
            {
                Console.WriteLine(ch + " is  Not Alphabet ");
            }
            Console.ReadKey();
        }
    }
}