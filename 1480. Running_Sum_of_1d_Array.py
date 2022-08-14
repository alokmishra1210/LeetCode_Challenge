#1480. Running Sum of 1d Array

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        length = len(nums)
        nums_new=[]
        sum=0
        for i in range (length):
            sum=sum+nums[i]
            nums_new.append(sum)
        return nums_new
