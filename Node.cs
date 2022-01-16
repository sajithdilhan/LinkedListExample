using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class Node
    {
        public int data;

        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
