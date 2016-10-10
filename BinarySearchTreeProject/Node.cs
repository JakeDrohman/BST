using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Node
    {
        public Node RightNode;
        public Node LeftNode;
        private int value;

        public Node(int input)
        {
            value = input;
        }
        public void SetValue(int value)
        {
            if (this.value > value)
            {
                if(LeftNode == null)
                {
                    LeftNode = new Node(value);
                }
                else
                {
                    LeftNode.SetValue(value);
                }
            }
            else if(this.value < value)
            {
                if (RightNode == null)
                {
                    RightNode = new Node(value);
                }
                else
                {
                    RightNode.SetValue(value);
                }
            }
        }
        public bool Search(int value)
        {
            if(value == this.value)
            {
                return true;
            }
            else if (value > this.value)
            {
                return RightNode.Search(value);
            }
            else if (value < this.value)
            {
                return LeftNode.Search(value);
            }
            else
            {
                return false;
            }
        }
    }
}
