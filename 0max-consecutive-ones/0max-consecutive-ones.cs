public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConsecutiveLength=0;
        int count=0;
        
       for(int i=0; i<nums.Length; i++){
            if(nums[i]==1){
                count++;
            }else{
                maxConsecutiveLength=Math.Max(maxConsecutiveLength, count);
                count=0;
            }
       }
       return Math.Max(maxConsecutiveLength, count);
    }
}