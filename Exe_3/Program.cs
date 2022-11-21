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
    }
}