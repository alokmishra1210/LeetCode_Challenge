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
    private int count = 0;
    public int CountUnivalSubtrees(TreeNode root) {
        IsUnival(root, 0);
        return count;
    }

    private bool IsUnival(TreeNode node, int parentValue) {
        // Base case: A null node is considered uni-value for the purpose of this algorithm.
        if (node == null) {
            return true;
        }

        // Recursively check if left and right subtrees are uni-value.
        bool leftIsUnival = IsUnival(node.left, node.val);
        bool rightIsUnival = IsUnival(node.right, node.val);

        // If either left or right subtree is not uni-value, then this subtree can't be uni-value.
        if (!leftIsUnival || !rightIsUnival) {
            return false;
        }

        // Increment count as this node is the root of a uni-value subtree.
        count++;

        // Return true if the current node value is equal to its parent's value (for the purpose of its parent's evaluation).
        return node.val == parentValue;
    }
}