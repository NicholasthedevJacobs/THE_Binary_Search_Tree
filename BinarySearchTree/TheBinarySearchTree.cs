using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TheBinarySearchTree
    {
        //member variables
        public Node RootNode;
        public Node LastNode;

        //constructor

        //member methods
        public void Add(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                {
                    if (nodeToAdd.data > currentNode.data)
                    {
                        currentNode = currentNode.RightNode;
                    }
                    else if (nodeToAdd.data < currentNode.data)
                    {
                        currentNode = currentNode.LeftNode;
                    }
                    else
                    {
                        currentNode = null;
                        currentNode = nodeToAdd;
                    }
                }
            }

        }
        public bool Search(Node nodeToSearch)
        {
            Node currentNode = RootNode;
            //bool goLeft = true;
            while (true)
            {
                if (nodeToSearch.data > currentNode.data)
                {
                    currentNode = currentNode.RightNode;

                }
                else if (nodeToSearch.data < currentNode.data)
                {
                    currentNode = currentNode.LeftNode;
                    //goLeft = true;                
                }
                else
                {
                    nodeToSearch = currentNode;
                    return true;

                }
            }
        }
    }
}
