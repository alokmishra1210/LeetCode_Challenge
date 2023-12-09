public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int, int>();
    public int Rob(int[] nums) {
        
        return RobHouses(nums, 0);
        
    }
    
    private int RobHouses(int[] nums, int currentIndex) {
        // Base case: when currentIndex is out of bounds
        if (currentIndex >= nums.Length) {
            return 0;
        }

        // Check memoization
        if (memo.ContainsKey(currentIndex)) {
            return memo[currentIndex];
        }

        // Choose to rob the current house
        int robThisHouse = nums[currentIndex] + RobHouses(nums, currentIndex + 2);

        // Choose not to rob the current house
        int skipThisHouse = RobHouses(nums, currentIndex + 1);

        // Store the result in memoization table
        memo[currentIndex] = Math.Max(robThisHouse, skipThisHouse);

        return memo[currentIndex];
    }
}