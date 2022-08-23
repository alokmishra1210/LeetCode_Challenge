class Solution:
    def search(self, nums: List[int], target: int) -> int:
        
        ln=len(nums)
        l_p=0
        r_p=ln-1
        
        while l_p<=r_p:
            mid=r_p+l_p
            mid=mid//2
            if target>nums[mid]:
                l_p=mid+1
            elif target<nums[mid]:
                r_p=mid-1
            else:
                return mid
        return -1
            
            
            
        
        