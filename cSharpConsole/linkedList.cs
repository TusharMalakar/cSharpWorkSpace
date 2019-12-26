using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpConsole{

    public class Node 
    {

        public Node next;
        public Object data;

    }
    public class linkedList{

        private Node head;
        public void insert(Object data) 
        {

            Node current = new Node();
            current.data = data;
            current.next = null;

        }

        public void print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
