using System;

namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search progarm");
            BinarySearch binary = new BinarySearch();
            binary.Insert(56);
            binary.Insert(30);
            binary.Insert(70);
            binary.Display();
        }
    }
}
