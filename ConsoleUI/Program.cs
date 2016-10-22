using System;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
            int[] array = { 1, 100, 50, -51, 1, 1 };
            int[] array1 = { 5, 7, 6, 2, 4, 3, 1, 7, 3 };

            Console.WriteLine(Tasks.FindArrayCenter(arr));
            Console.WriteLine(Tasks.FindArrayCenter(array));
            Console.WriteLine(Tasks.FindArrayCenter(array1));

            string a = "xyaabbbccccdefww", b = "xxxxyyyyabklmopq", c = "abcdefjhijklmnopqrstuvwxyz";

            Console.WriteLine(Tasks.SimpleLexicographicalConcatination(a, b));
            Console.WriteLine(Tasks.SimpleLexicographicalConcatination(c, c));
            Console.WriteLine(Tasks.LexicographicalConcatination(a, b));
            Console.WriteLine(Tasks.LexicographicalConcatination(c, c));

            Console.WriteLine(Tasks.BinaryInsertion(8, 15, 0, 0));
            Console.WriteLine(Tasks.BinaryInsertion(0, 15, 30, 30));
            Console.WriteLine(Tasks.BinaryInsertion(0, 15, 0, 30));
            Console.WriteLine(Tasks.BinaryInsertion(15, -15, 0, 4));
            Console.WriteLine(Tasks.BinaryInsertion(15, int.MaxValue, 3, 5));
            Console.ReadKey();
        }
    }
}
