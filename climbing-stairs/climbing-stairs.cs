public class Solution {
    private  Dictionary <int, int> cache = new Dictionary<int, int>();
    public int ClimbStairs(int n) {
        
        if(cache.ContainsKey(n)){
            return cache[n];
        }
        
        int result;
        if(n<=2){
            result = n;
        
        }else{
            result=ClimbStairs(n-1)+ClimbStairs(n-2);
        }
        
        cache[n] = result;
        return result;
        
    }
}