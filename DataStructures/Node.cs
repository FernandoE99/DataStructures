using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Node<T>
    {

        private T data;
        Node<T> next;


        Node()
        {
            next = this; 
        }

       public Node(T data)
        {
            this.data = data;
            this.next = null;
        }

        public T Data {
            get { return this.data;}
            set { this.data = value; }
        }

        public Node<T> Next {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
