using System;
using System.Collections.Generic;
using System.Text;

namespace training_april
{
   
    class Node <D>
    {
        public D data;
        public Node<D> next;
        public static Node<int> BuildNode (int data)
        {
            Node<int> node = new Node<int>();
            node.data = data;
            return node;
        }
       public static void PrintLinkedList( Node<D> head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data + ", ");
                head= head.next;
            }
            Console.WriteLine("END");
        }

        public static void DeleteMiddleNode(Node<D> head)
        {
            if (head== null || head.next == null)
            {
                return;
            }
            Node<D> slow = head;
            Node<D> fast = head;
            Node<D> prev = null;
            while(fast !=null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = slow.next;
        }

       

    }
     
}
