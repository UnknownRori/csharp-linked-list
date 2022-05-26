using System;

namespace LinkedList
{
    class Program {
        public static void Main() 
        {
            Node head = new Node(10);
            Node first = new Node(20);
            Node second = new Node(30);

            head.next = first;
            first.next = second;

            head.find(20);
            head.printList();
        }
    }

    class Node{
        public int value { set; get; }
        public Node? next { set; get; }

        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

        public void printList()
        {
            Node? n = next;

            Console.WriteLine(value);

            while(n != null){
                Console.WriteLine(n.value);
                n = n.next;
            }
        }

        public void find(int target)
        {
            Node? n = next;
            int i = 0;

            if(this.value != target) {
                while (n != null)
                {
                    i++;
                    if (n.value == target) break;
                    n = n.next;
                }
            }

            Console.WriteLine(string.Format("Value found in index {0}", i));
        }
    }
}