class Solution:
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:
        res=[]
        nums_list=set(nums)
        count=1
        for i in range(len(nums)):
            if count not in nums_list:
                res.append(count)
            count+=1
        return res
        