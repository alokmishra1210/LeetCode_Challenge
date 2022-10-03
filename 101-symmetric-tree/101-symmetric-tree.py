# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        if root is None:
            return True
        else:
            return self.isMirror(root.left, root.right)
        
    def isMirror(self, lf, rf):
        
        if lf is None and rf is None:
            return True
        if lf is None or rf is None:
            return False
        
        if lf.val==rf.val:
            outPair=self.isMirror(lf.left, rf.right)
            inPair=self.isMirror(lf.right, rf.left)
            return outPair and inPair
        else:
            return False