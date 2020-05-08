using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Node
    {

        private object data;
        Node next;


        Node()
        {
            next = this; 
        }

       public Node(object data)
        {
            this.data = data;
            this.next = null;
        }

        public object Data {
            get { return this.data;}
            set { this.data = value; }
        }

        public Node Next {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
