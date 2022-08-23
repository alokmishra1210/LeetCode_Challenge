class Solution:
    def search(self, nums: List[int], target: int) -> int:        
        l_p=0
        r_p=len(nums)-1
        while l_p<=r_p:
            mid=(r_p+l_p)//2
            if target>nums[mid]:
                l_p=mid+1
            elif target<nums[mid]:
                r_p=mid-1
            else:
                return mid
        return -1
            
            
            
        
        