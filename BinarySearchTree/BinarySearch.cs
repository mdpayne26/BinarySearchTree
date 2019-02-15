using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearch
    {
        Node root = null;
        public BinarySearch(List<int> list)
        {
            for(int i = 0; i < 8; i++)
            {
                
            }
        }
        
        public void Insert(int data)
        {
            Node node;
            Node temp = new Node(data);

            
            if (root == null)
            {
                root = temp;
            }
            node = root;
            
            if(root.left == null)
            {
                root.left = temp;
                return;
            }
            else
            {
                node = node.left;
            }

            if (root.right == null)
            {
                root.right = temp;
                return;
            }
            else
            {
                node = node.right;
            }
        }
    }
}
            
