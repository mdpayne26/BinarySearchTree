using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class LinkedList
    {
        Node start = null;
        
        public void Insert(int data)
        {
            Node node;
            Node temp = new Node(data);
            if(start == null)
            {
                start = temp;
            }
            node = start;
            while(node.link != null)
            {
                node = node.link;
            }
            node.link = temp;
        }
    }
}
