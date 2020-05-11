using DataStructures;
using System;

namespace testGraph
{
    class Program
    {
         static void Main(string[] args)
        {
            //UndirectedGraph<string, string> graph = new UndirectedGraph<string, string>();
            ////DirectedGraph<string, string> graph = new DirectedGraph<string, string>();

            //graph.AddVertices(new[] { "A", "B", "C", "D", "F" });
            //graph.AddEdge(null, "C", "label1");
            //graph.AddEdge("B", "C", "label2");
            //graph.AddEdge("C", "D", "label2");
            //foreach (string v in graph.GetVertexSet())
            //    Console.WriteLine(v);

            //foreach (var p in graph.GetEdgesSet())
            //    Console.WriteLine(p.GetFirst() + " -> " + p.GetSecond());

            //Console.WriteLine("\n" + "Se borra la arista B-C");
            //graph.DeleteEdge("B", "C");

            //foreach (var p in graph.GetEdgesSet())
            //    Console.WriteLine(p.GetFirst() + " -> " + p.GetSecond());

            LinkedList<string> blist = new LinkedList<string>();
            
            blist.AddLast("2");
            blist.AddLast("3");
            blist.AddLast("4");
            blist.AddLast("5");
            blist.AddLast("6");
            blist.AddLast("7");
            blist.AddFirst("1");

            blist.printNodes();
        }
    }
}
