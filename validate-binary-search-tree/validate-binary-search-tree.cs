/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return ValidBst(root, long.MinValue, long.MaxValue);   
    }

    public bool ValidBst(TreeNode root, long low, long high){
        if(root == null){
            return true;
        }

        if(root.val<=low || root.val>=high){
            return false;
        }

        return ValidBst(root.right, root.val, high) && ValidBst(root.left, low, root.val);
    }
}