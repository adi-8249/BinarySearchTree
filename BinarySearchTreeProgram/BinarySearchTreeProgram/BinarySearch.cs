using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProgram
{
    class BinarySearch
    {
        TreeNode root;
        int treeSize = 0;
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                treeSize++;
            }
            else
            {
                root.Insert(data);
                treeSize++;
            }
        }
        /// <summary>
        /// displaying size of tree
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            return treeSize;
        }
        /// <summary>
        /// here we are searching for the given element 63 from the binary search tree
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Search(int data)
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
                return 0;
            }
            else
            {
                return root.Search(data);
            }
        }
        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                root.InOrderTraversal();
            }
        }
    }
}
