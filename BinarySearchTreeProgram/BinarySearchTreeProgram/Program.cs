using System;

namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search progarm");
            //UC1- Inserting these elements
            BinarySearch binary = new BinarySearch();
            binary.Insert(56);
            binary.Insert(30);
            binary.Insert(70);
            binary.Display();
            Console.WriteLine();
            //UC2-inserting element of given elements with Insert method
            binary.Insert(30);
            binary.Insert(70);
            binary.Insert(22);
            binary.Insert(40);
            binary.Insert(11);
            binary.Insert(3);
            binary.Insert(16);
            binary.Insert(60);
            binary.Insert(95);
            binary.Insert(65);
            binary.Insert(63);
            binary.Insert(67);
            binary.Display();
            Console.WriteLine("size of binary search tree is : " + binary.Size());//Displaying the size of tree
            //
            //UC3- finding the element in 63 from the binary tree
            Console.WriteLine("element " + binary.Search(63) + " found in binary search tree");
        }
    }
}
