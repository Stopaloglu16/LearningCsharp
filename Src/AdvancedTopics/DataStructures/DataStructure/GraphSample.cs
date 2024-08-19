namespace DataStructures.DataStructure;

internal class GraphSample
{

    public static void GetSample()
    {
        Graph graph = new Graph();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);

        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(3, 4);

        graph.PrintGraph();
    }

    class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Add a vertex to the graph
        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }
        }

        // Add an edge between two vertices
        public void AddEdge(int vertex1, int vertex2)
        {
            if (adjacencyList.ContainsKey(vertex1))
            {
                adjacencyList[vertex1].Add(vertex2);
            }

            if (adjacencyList.ContainsKey(vertex2))
            {
                adjacencyList[vertex2].Add(vertex1); // For an undirected graph
            }
        }

        // Print the graph
        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList)
            {
                Console.Write(vertex.Key + ": ");
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
