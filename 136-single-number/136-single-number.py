class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        
        if len(nums)==1:
            return nums[0]        
        visited=set()        
        for i in range(len(nums)):
            if nums[i] in visited:
                visited.remove(nums[i])
            else:
                visited.add(nums[i])
        return list(visited)[0]