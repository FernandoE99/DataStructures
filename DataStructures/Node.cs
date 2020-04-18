using System;

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

       public Node(object data, Node Next)
        {
            this.data = data;
            this.next = this;
        }

        object information()
        {
            return data;
        }

        Node next()
        {
            return next;
        }

    }
}
