using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TheBinarySearchTree thisTest = new TheBinarySearchTree();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            thisTest.Add(node1);
            thisTest.Add(node2);
            thisTest.Add(node3);
            thisTest.Add(node4);
            thisTest.Add(node5);
        }
    }
}
