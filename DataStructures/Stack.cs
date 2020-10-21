using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack<T>
    {
        private Node<T> head;

        public void push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = head;
            head = newNode;
        }

        public T pop() {
            if (head == null) { throw new ArgumentNullException("There is no value to Pop"); }
            T data = head.Data;
            head = head.Next;
            return data;
        }

        public T peek() { 
            if(head == null) { throw new ArgumentNullException("There is no value to peek"); }
            return head.Data;
        }

        public bool isEmpty() {
            return head == null;
        }

        public void clear() { 
            if(isEmpty()) { throw new ArgumentNullException("There is no values to clear"); }
            while (!isEmpty()) {
                head = head.Next;
            }
        }
    }
}
