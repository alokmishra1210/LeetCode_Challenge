public class Solution {
    
    Dictionary <int, int> memo = new Dictionary<int, int>();
    public int Tribonacci(int n) {
        
        if(n == 0 || n == 1){
            return n;
        }
        if(n==2){
            return 1;
        }
        
        if(memo.ContainsKey(n)){
            return memo[n];
        }
        
        memo[n] = Tribonacci(n-1)+Tribonacci(n-2)+Tribonacci(n-3);
        
        return memo[n];
    }
}