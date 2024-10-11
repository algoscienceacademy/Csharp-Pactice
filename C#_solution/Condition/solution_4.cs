/*using System;
namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            *//* if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
             {
                 Console.WriteLine("leap year");
             }
             else
             {
                 Console.WriteLine("not leap year");
              }*//*

            Console.WriteLine((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0) ? "leap year" : "not leap year");
        }
    }
}*/