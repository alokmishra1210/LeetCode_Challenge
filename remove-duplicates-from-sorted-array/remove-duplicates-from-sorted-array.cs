public class Solution {
    public int RemoveDuplicates(int[] nums) {
         if (nums.Length == 0) return 0;

        int PrevIndex = 0;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[PrevIndex] != nums[i]) {
                PrevIndex++;
                nums[PrevIndex] = nums[i];
            }
        }

        return PrevIndex + 1;
    }
}