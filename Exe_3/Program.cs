using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3
{
    class Node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber088;
        public string nameDivaNafisyah;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        /*Search for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber088)
                    return (true); /*returns true if the node is found*/
            }
            /*if the node is present at the end*/
            if (rollNo == LAST.rollNumber088)
                return true;
            else
                return (false); /*returns false if the node is not found*/
        }

        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }

        /*Traverses all the nodes of the list*/
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber088 + "    " + currentNode.nameDivaNafisyah + "\n");
                }
            }

            public void firstNode()
            {
                if (listEmpty())
                    Console.WriteLine("List is empty");
                else
                    Console.WriteLine("\nThe first record in the list is:\n\n" + LAST.next.rollNumber088 + "   " + LAST.next.nameDivaNafisyah);
            }
            class program
        {
            static void Main(string[] args)
            {
                CircularList obj = new CircularList();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nMenu");
                        Console.WriteLine("1. View all the records in the list");
                        Console.WriteLine("2.Search for a record in the list");
                        Console.WriteLine("3. Display the first record in the list");
                        Console.WriteLine("4. Exit");
                        Console.Write("\nEnter your choice (1-4):");
                    }
                }
            }
        }
    }
}