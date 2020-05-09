using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class UndirectedGraph<T, K> : AbstractGraph<T, K>
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

            IPairValue<T> pair_1 = new PairValueI<T>(v1, v2);
            IPairValue<T> pair_2 = new PairValueI<T>(v2, v1);

            if (EdgeSet.Contains(pair_1) || EdgeSet.Contains(pair_2))
                return false;
            
            EdgeSet.Add(pair_1);
            EdgeSet.Add(pair_2);
            Weights[pair_1] = weight;
            Weights[pair_2] = weight;
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

            IPairValue<T> pair_1 = new PairValueI<T>(v1, v2);
            IPairValue<T> pair_2 = new PairValueI<T>(v2, v1);
            if (EdgeSet.Contains(pair_1) || EdgeSet.Contains(pair_2))
            {
                EdgeSet.Remove(pair_1);
                Weights.Remove(pair_1);

                EdgeSet.Remove(pair_2);
                Weights.Remove(pair_2);
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

            int counter = 0;
            foreach (IPairValue<T> pair in EdgeSet)
                if (pair.GetFirst().Equals(vertex))
                    counter++;
            return counter;
        }

        public override int InDegree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();

            return Degree(vertex);
        }

        public override int OutDegree(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();

            return Degree(vertex);
        }
        public override IEnumerable<T> AdjacentVertices(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException(nameof(vertex));

            if (!VertexSet.Contains(vertex))
                throw new ArgumentException();

            foreach (IPairValue<T> p in EdgeSet)
                if (p.GetFirst().Equals(vertex))
                    yield return p.GetSecond();
        }
    }
}
