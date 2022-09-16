class Solution:
    def maxArea(self, height: List[int]) -> int:
        maxarea=0
        left=0
        right=len(height)-1
        
        while left<right:
            
            currentArea=min(height[left], height[right])*(right-left)
            maxarea=max(currentArea,maxarea)
            if height[left]<height[right]:
                left=left+1
            else:
                right=right-1
        return maxarea
        