using System;
using System.ComponentModel;

namespace DataStructures
{
    public class LinkedList<T>
    {
        public Node<T> start;
        public Node<T> end;

        public void AddLast(T data) {
            
            Node<T> newNode = new Node<T>(data);
            if (start != null)
            {
                end.Next = newNode;
                end = end.Next;
            }
            else {
                start = newNode;
                end = newNode;
            }
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = start;
                start = newNode;
        }

        public void printNodes() {
            Node<T> currentNode = start;
            while (currentNode != null) {
                Console.Write(currentNode.Data + "--> ");
                currentNode = currentNode.Next;
            }
            Console.Write("null");
        }
        
    }
}
