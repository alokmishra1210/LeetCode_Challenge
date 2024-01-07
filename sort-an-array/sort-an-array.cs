public class Solution {
    public int[] SortArray(int[] nums) {
        if (nums.Length <= 1) {
            return nums;
        }

        // Divide the array into two halves
        int mid = nums.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[nums.Length - mid];

        Array.Copy(nums, 0, left, 0, mid);
        Array.Copy(nums, mid, right, 0, nums.Length - mid);

        // Recursively sort both halves
        SortArray(left);
        SortArray(right);

        // Merge the sorted halves
        Merge(nums, left, right);

        return nums;
    }

    private void Merge(int[] nums, int[] left, int[] right) {
        int i = 0, j = 0, k = 0;

        // Merge arrays while there are elements in both
        while (i < left.Length && j < right.Length) {
            if (left[i] < right[j]) {
                nums[k++] = left[i++];
            } else {
                nums[k++] = right[j++];
            }
        }

        // Copy remaining elements of left array if any
        while (i < left.Length) {
            nums[k++] = left[i++];
        }

        // Copy remaining elements of right array if any
        while (j < right.Length) {
            nums[k++] = right[j++];
        }
     
        
        
    }
}