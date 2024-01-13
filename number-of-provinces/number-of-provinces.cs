public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        bool[] visited = new bool[n];
        int provinceCount=0;

        for(int i=0; i<n; i++){
            if(!visited[i]){
                visited[i]=true;
                Dfs(i);
                provinceCount++;
            }
        }

        void Dfs(int city){
            for(int i=0; i<n; i++){
                if(isConnected[city][i]==1 && !visited[i]){
                    visited[i]=true;
                    Dfs(i);
                }
            }
        }

        return provinceCount;
 
    }
}