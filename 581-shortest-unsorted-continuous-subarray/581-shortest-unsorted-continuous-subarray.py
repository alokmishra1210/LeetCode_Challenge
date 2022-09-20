class Solution:
    def findUnsortedSubarray(self, nums: List[int]) -> int:
        srt=sorted(nums)
        strt=0
        end=len(nums)-1
        
        while (end <= (len(nums)-1)) and srt[end]==nums[end] and end>=0:
            end=end-1
        while  (strt < (len(nums)-1)) and srt[strt]==nums[strt] and strt>=0:
            strt=strt+1
        
        if end==0 or strt==len(nums)-1: 
            return 0
        else:
            return ((end-strt)+1)
      
        
            
        