using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7Ex3
{
    class Graph
    {
        private int N;
        private int[,] graph;
        private bool[] visited;
        private static int INFINITY = int.MaxValue;
        public Graph(int N)
        {
            graph = new int[N, N];
            // initialise the matrix to INFINITY
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    graph[i, j] = INFINITY;
                }
                graph[i, i] = 0;
            }

            visited = new bool[N];

        }

        /// Destructor dealloctes the adjacency matrix
        ~Graph()
        {
            graph = null;
            visited = null;
        }

        /// Adds an undirected edge to the graph between the source and destination vertices.
        public void addEdge(int src, int dst, int weight)
        {
            graph[src, dst] = weight;
            graph[dst, src] = weight;
        }


        /// Produces a string representation of the graph.
        public static void write(Graph graph)
        {
            
        }



        /// Performs initialisation for the DFS algorithm
        public void dfsRecursive(int start)
        {
            
        }

        /// Private implementation of the recursive depth first search algorithm
        private void dfsRec(int current)
        {
           
        }

        /// Implementation of the iterative depth first search algorithm
        public void dfs(int current)
        {
            
        }

        /// Implementation of the iterative breadth first search algorithm
        public void bfs(int current)
        {
        }
    }
}
