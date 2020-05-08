using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public interface DGraph <T, K>
    {
        bool AddVertex(T vertex); //Adds a vertex to the graph, if it doesnt exist it returns rue
        void AddVertex(IEnumerable<T> vertexSet); //Adds to the graph the vertices contained in a set, if it exist already it is skipped
        bool DeleteVertex(T vertex); //Deletes a vertex from the graph

        void DeleteVertex(IEnumerable<T> vertexSet); //Deletes every vertex of the set existing also in the graph

        bool AddEdge(T v1, T v2, K w); //Adds an edge in between two vertices, with weight w

        K GetWeight(T v1, T v2); //Gets the weight of an edge

        bool DeleteEdge(T v1, T v2); //Deletes an edge between two vertices

        bool AreAdjacent(T v1, T v2); //Checks if v1 is adjacent to v2

        int Degree(T vertex); //Computes the degree of the specified vertex

        int OutDegree(T vertex); //Computes the outgoing degree of the specified vertex

        int InDegree(T vertex); //Computes the ingoing degree of the specified vertex

        int VerticesNumber(); //Returns the number of vertices in the graph

        int EdgesNumber(); //Returns the number of edges in the graph

        IEnumerable<T> AdjacentVertices(T vertex); //Returns a set of adjacent vertices to the one specified as argument
        IEnumerable<T> GetVertexSet(); //Returns an IEnumerable containing the vertex set of the graph
        IEnumerable<IPairValue<T>> GetEdgesSet(); //Returns an IEnumerable containing the dges set of the graph, represented by couples of vertices

        
    }

    public interface IPairValue<T> {

        T GetFirst(); //Returns first vertex
        T GetSecond(); //Returns second vertex

        bool Contains(T value); //Returns true if the given value is stored in the data structure
    }

}
