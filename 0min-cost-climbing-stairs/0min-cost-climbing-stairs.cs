public class Solution {
    Dictionary <int, int> memo = new Dictionary<int, int>();
    public int MinCostClimbingStairs(int[] cost) {
        
        return Math.Min(MinimumCost(cost, 0), MinimumCost(cost,1));
        
    }
    
    private int MinimumCost(int[] cost, int currentIndex){
        
        if(currentIndex>=cost.Length){
            return 0;
        }
        
        if(memo.ContainsKey(currentIndex)){
           return memo[currentIndex];
        }
        
              // Cost of taking one step
        int takeOneStep = (currentIndex < cost.Length ? cost[currentIndex] : 0) + MinimumCost(cost, currentIndex + 1);

        // Cost of taking two steps
        int takeTwoSteps = (currentIndex < cost.Length ? cost[currentIndex] : 0) + MinimumCost(cost, currentIndex + 2);

        
        memo[currentIndex]= Math.Min(takeOneStep, takeTwoSteps);
        
        return memo[currentIndex];
             
    }
}