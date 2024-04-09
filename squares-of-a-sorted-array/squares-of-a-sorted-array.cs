public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] results = new int[nums.Length];
        for(int i=0; i<nums.Length; i++){
            results[i]=nums[i]*nums[i];
        }
        
        Array.Sort(results);
        
        return results;
    }
}