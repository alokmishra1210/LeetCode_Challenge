public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        
        if(source==destination) return true;
        
        var  adjlist = new List<int>[n];
        
        for(int i =0; i<n; i++){
           adjlist[i] = new List<int>(); 
        }
        
        foreach(var edge in edges){
            adjlist[edge[0]].Add(edge[1]);
            adjlist[edge[1]].Add(edge[0]);
        }
        
        var visited = new HashSet<int>();
        var stack = new Stack<int>();
        stack.Push(source);

        while (stack.Count > 0) {
            int node = stack.Pop();
            if (node == destination) return true;

            visited.Add(node);

            foreach (var neighbour in adjlist[node]) {
                if (!visited.Contains(neighbour)) {
                    stack.Push(neighbour);
                }
            }
        }

        return false;
    }
}