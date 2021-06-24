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
