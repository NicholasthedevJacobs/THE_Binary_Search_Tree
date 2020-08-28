using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        //member variables
        public int data;
        public Node NextNode;
        public Node LeftNode;
        public Node RightNode;

        //constructor
        public Node(int data)
        {
            this.data = data;
        }

        //member methods
    }
}
