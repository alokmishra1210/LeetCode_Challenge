#724. Find Pivot Index

class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        length_list=len(nums)
        sum_left=0
        s=sum(nums)
        for i in range (length_list):
            if sum_left==(s-sum_left-nums[i]):
                return i
            sum_left+=nums[i]
        return -1
