using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] MaxTargets(int[][] edges1, int[][] edges2) {
        // Input validation
        int n = edges1.Max(edge => Math.Max(edge[0], edge[1])) + 1;
        int m = edges2.Max(edge => Math.Max(edge[0], edge[1])) + 1;
        
        if (n < 2 || n > 100000 || m < 2 || m > 100000)
            throw new ArgumentException("Number of nodes must be between 2 and 10^5");
        if (edges1.Length != n - 1 || edges2.Length != m - 1)
            throw new ArgumentException("Invalid number of edges");
        if (edges1.Any(edge => edge.Length != 2) || edges2.Any(edge => edge.Length != 2))
            throw new ArgumentException("All edges must be pairs of nodes");
        if (edges1.Any(edge => edge[0] < 0 || edge[0] >= n || edge[1] < 0 || edge[1] >= n))
            throw new ArgumentException("Invalid node numbers in edges1");
        if (edges2.Any(edge => edge[0] < 0 || edge[0] >= m || edge[1] < 0 || edge[1] >= m))
            throw new ArgumentException("Invalid node numbers in edges2");
        
        // Build adjacency lists for both trees
        var tree1 = BuildGraph(edges1);
        var tree2 = BuildGraph(edges2);
        
        // For each node in tree2, find distances to all other nodes
        var tree2Distances = new Dictionary<int, Dictionary<int, int>>();
        for (int node = 0; node < m; node++) {
            tree2Distances[node] = GetDistances(node, tree2);
        }
        
        var answer = new int[n];
        
        // For each node in first tree
        for (int i = 0; i < n; i++) {
            // Get distances in first tree
            var tree1Distances = GetDistances(i, tree1);
            
            // Count initial targets in first tree
            int initialTargets = tree1Distances.Values.Count(dist => dist % 2 == 0);
            
            int maxTargets = initialTargets;
            
            // Try connecting to each node in second tree
            for (int j = 0; j < m; j++) {
                // For each node in second tree, check if it would be a target
                int newTargets = 0;
                for (int k = 0; k < m; k++) {
                    // Distance from i to j in first tree + 1 + distance from j to k in second tree
                    int totalDist = tree1Distances[i] + 1 + tree2Distances[j][k];
                    if (totalDist % 2 == 0) {
                        newTargets++;
                    }
                }
                
                maxTargets = Math.Max(maxTargets, initialTargets + newTargets);
            }
            
            answer[i] = maxTargets;
        }
        
        return answer;
    }
    
    private Dictionary<int, List<int>> BuildGraph(int[][] edges) {
        var graph = new Dictionary<int, List<int>>();
        foreach (var edge in edges) {
            int u = edge[0], v = edge[1];
            if (!graph.ContainsKey(u)) graph[u] = new List<int>();
            if (!graph.ContainsKey(v)) graph[v] = new List<int>();
            graph[u].Add(v);
            graph[v].Add(u);
        }
        return graph;
    }
    
    private Dictionary<int, int> GetDistances(int start, Dictionary<int, List<int>> graph) {
        var distances = new Dictionary<int, int> { { start, 0 } };
        var queue = new Queue<int>();
        queue.Enqueue(start);
        
        while (queue.Count > 0) {
            int node = queue.Dequeue();
            foreach (int neighbor in graph[node]) {
                if (!distances.ContainsKey(neighbor)) {
                    distances[neighbor] = distances[node] + 1;
                    queue.Enqueue(neighbor);
                }
            }
        }
        
        return distances;
    }
}

// Test cases
class Program {
    static void Main() {
        var solution = new Solution();
        
        // Test Case 1 (Original)
        Console.WriteLine("Test Case 1 (Original):");
        int[][] edges1 = new int[][] {
            new int[] {0,1}, new int[] {0,2}, new int[] {2,3}, new int[] {2,4}
        };
        int[][] edges2 = new int[][] {
            new int[] {0,1}, new int[] {0,2}, new int[] {0,3}, new int[] {2,7},
            new int[] {1,4}, new int[] {4,5}, new int[] {4,6}
        };
        Console.WriteLine($"Input: edges1={string.Join(",", edges1.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Input: edges2={string.Join(",", edges2.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Output: [{string.Join(",", solution.MaxTargets(edges1, edges2))}]\n");
        
        // Test Case 2 (Smallest trees)
        Console.WriteLine("Test Case 2 (Smallest trees):");
        edges1 = new int[][] { new int[] {0,1} };
        edges2 = new int[][] { new int[] {0,1} };
        Console.WriteLine($"Input: edges1={string.Join(",", edges1.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Input: edges2={string.Join(",", edges2.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Output: [{string.Join(",", solution.MaxTargets(edges1, edges2))}]\n");
        
        // Test Case 3 (Linear trees)
        Console.WriteLine("Test Case 3 (Linear trees):");
        edges1 = new int[][] {
            new int[] {0,1}, new int[] {1,2}, new int[] {2,3}
        };
        edges2 = new int[][] {
            new int[] {0,1}, new int[] {1,2}
        };
        Console.WriteLine($"Input: edges1={string.Join(",", edges1.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Input: edges2={string.Join(",", edges2.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Output: [{string.Join(",", solution.MaxTargets(edges1, edges2))}]\n");
        
        // Test Case 4 (Star-shaped trees)
        Console.WriteLine("Test Case 4 (Star-shaped trees):");
        edges1 = new int[][] {
            new int[] {0,1}, new int[] {0,2}, new int[] {0,3}
        };
        edges2 = new int[][] {
            new int[] {0,1}, new int[] {0,2}, new int[] {0,3}, new int[] {0,4}
        };
        Console.WriteLine($"Input: edges1={string.Join(",", edges1.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Input: edges2={string.Join(",", edges2.Select(e => $"[{e[0]},{e[1]}]"))}");
        Console.WriteLine($"Output: [{string.Join(",", solution.MaxTargets(edges1, edges2))}]\n");
        
        // Test Case 5 (Invalid input)
        Console.WriteLine("Test Case 5 (Invalid input - should raise error):");
        try {
            edges1 = new int[][] {
                new int[] {0,1}, new int[] {0,2}, new int[] {2,3},
                new int[] {2,4}, new int[] {4,5}
            };
            edges2 = new int[][] {
                new int[] {0,1}, new int[] {0,2}
            };
            Console.WriteLine($"Input: edges1={string.Join(",", edges1.Select(e => $"[{e[0]},{e[1]}]"))}");
            Console.WriteLine($"Input: edges2={string.Join(",", edges2.Select(e => $"[{e[0]},{e[1]}]"))}");
            Console.WriteLine($"Output: [{string.Join(",", solution.MaxTargets(edges1, edges2))}]");
        }
        catch (Exception e) {
            Console.WriteLine($"Error caught: {e.Message}");
        }
    }
}
