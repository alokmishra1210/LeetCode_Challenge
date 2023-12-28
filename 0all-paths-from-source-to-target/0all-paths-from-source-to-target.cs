public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        var path = new List<int>();

        void Dfs(int node) {
            path.Add(node);

            if (node == graph.Length - 1) {
                // Reached the target node, add the current path to the result
                result.Add(new List<int>(path));
            } else {
                // Explore the neighbors
                foreach (var neighbor in graph[node]) {
                    Dfs(neighbor);
                }
            }

            // Backtrack
            path.RemoveAt(path.Count - 1);
        }

        Dfs(0); // Start DFS from node 0
        return result;
    }
}