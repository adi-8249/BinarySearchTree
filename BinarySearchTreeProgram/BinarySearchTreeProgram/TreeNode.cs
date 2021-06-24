using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeProgram
{
    class TreeNode
    {

        public int data;
        public TreeNode leftNode;
        public TreeNode rightNode;
        public TreeNode(int data)//initialising the data using constructor
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
        public void Insert(int data)//inserting data through Insert method
        {
            int rootData = this.data;
            if (data >= rootData)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(data);
                }
                else
                {
                    rightNode.Insert(data);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(data);
                }
                else
                {
                    leftNode.Insert(data);
                }
            }
        }
        //Displaying as leftNode -> rootNode -> rightNode
        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.Write(data + " ");
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }

    }
}
