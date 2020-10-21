using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void push(T value) {
            Node<T> newNode = new Node<T>(value);
            if (tail != null) {
                tail.Next = newNode;
            }
            tail = newNode;
            if (head == null) {
                head = tail;
            }
        }
        public T pop() {
            if (head == null) { throw new ArgumentNullException("There is no value to Pop"); }
            T data = head.Data;

            head = head.Next;
            if (head == null) tail = null;
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
            if(head==null) { throw new ArgumentNullException("The queue is already empty"); }
            while (!isEmpty()) {
                head = head.Next;
                if (head == null) tail = null;
            }
        }
    }
}
