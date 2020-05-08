using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
    
    class Graph
    {
        Node[] nodes;
        int count;
            public Graph(int max) {
            nodes = new Node[max];
            count = 0;
        }
        public void AddNode(char value) {
            nodes[count] = new Node(value);
        }
    }
}
