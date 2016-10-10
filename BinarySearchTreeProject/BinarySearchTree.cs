using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        private Node baseNode;
        private int count;

        public BinarySearchTree(int rootvalue)
        {
            baseNode = new Node(rootvalue);
            count = 1;
        }
        public void InsertValue(int value)
        {
            baseNode.SetValue(value);
            count++;
        }
        public bool Search(int value)
        {
            return baseNode.Search(value);
        }
    }
}
