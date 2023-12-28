public class Solution {
    HashSet<int> nums = new HashSet<int>();
    public bool IsHappy(int n) {
        return recursion(n, nums);
    }
    
    public bool recursion(int n, HashSet<int> nums ){
        
        if(nums.Contains(n)){
            return false;
        }else if(n==1){
            return true;
        }
        nums.Add(n);
       int totalSum = 0;
        while (n > 0) {
            int digit = n % 10;
            n = n / 10;
            totalSum += digit * digit;
        }
        return recursion(totalSum, nums);
    }
}