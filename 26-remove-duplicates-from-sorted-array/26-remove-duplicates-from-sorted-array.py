class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        visited=set()
        count=0
        for i in range(len(nums)):
            if nums[i] not in visited:         
                visited.add(nums[i])
                nums[count]=nums[i]
                count=count+1
        return count
            
                
                