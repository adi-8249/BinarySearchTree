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
       
        public int Search(int data)
        {
            TreeNode currentNode = this;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return currentNode.data;
                }
                else
                {
                    if (data > currentNode.data)
                    {
                        currentNode = currentNode.rightNode;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }
                }
            }
            return 0;
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
