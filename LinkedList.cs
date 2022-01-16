using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class LinkedList
    {
        private Node head = null;

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                head.next = null;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
        }

        public IEnumerable<int> PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.next;

            }

        }
    }
}
