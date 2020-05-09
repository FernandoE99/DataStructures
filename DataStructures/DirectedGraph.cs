using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class DirectedGraph<T, K> : AbstractGraph<T, K>
    {
        public override bool AddEdge(T v1, T v2, K weight)
        {
            if (v1 is null)
                throw new ArgumentNullException(nameof(v1));

            if (v2 is null)
                throw new ArgumentNullException(nameof(v2));

            if (weight is null)
                throw new ArgumentNullException(nameof(weight));

            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2)) 
                return false;
            
            IPairValue<T> pair = new PairValueI<T>(v1, v2);
            if (EdgeSet.Contains(pair)) 
                return false;
            
            EdgeSet.Add(pair);
            Weights[pair] = weight;
            return true;
        }

        public override K GetWeight(T v1, T v2)
        {
            if (v1 is null)
                throw new ArgumentNullException(nameof(v1));

            if (v2 is null)
                throw new ArgumentNullException(nameof(v2));

            IPairValue<T> pair = new PairValueI<T>(v1, v2);
            if (!Weights.ContainsKey(pair)) 
                throw new ArgumentException();
            
            return Weights[pair];
        }

        public override bool DeleteEdge(T v1, T v2)
        {
            if (v1 is null)
                throw new ArgumentNullException(nameof(v1));

            if (v2 is null)
                throw new ArgumentNullException(nameof(v2));

            IPairValue<T> pair = new PairValueI<T>(v1, v2);
            if (EdgeSet.Contains(pair)) {
                EdgeSet.Remove(pair);
                Weights.Remove(pair);
                return true;
            }
            return false;
        }

        public override bool AreAdjacent(T v1, T v2)
        {
            if (v1 is null)
                throw new ArgumentNullException(nameof(v1));

            if (v2 is null)
                throw new ArgumentNullException(nameof(v2));

            if (!VertexSet.Contains(v1) || !VertexSet.Contains(v2)) 
                throw new ArgumentException();
            
            return EdgeSet.Contains(new PairValueI<T>(v1, v2));
        }

        public override int Degree(T vertex)
        {
            if (vertex == null) 
                throw new ArgumentNullException(nameof(vertex));
            
            if (!VertexSet.Contains(vertex)) 
                throw new ArgumentException();
            
            return InDegree(vertex) + OutDegree(vertex);
        }

        public override int InDegree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));
            
            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();
            
            int counter = 0;
            foreach (var pair in EdgeSet)
                if (pair.GetSecond().Equals(vertex))
                    counter++;

            return counter;
        }

        public override int OutDegree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();

            int counter = 0;
            foreach (var pair in EdgeSet) 
                if (pair.GetFirst().Equals(vertex)) 
                    counter++;

            return counter;
        }
        public override IEnumerable<T> AdjacentVertices(T vertex)
        {
            foreach (IPairValue<T> p in EdgeSet) 
                if (p.GetFirst().Equals(vertex)) 
                    yield return p.GetSecond();

            
        }
    }
}
