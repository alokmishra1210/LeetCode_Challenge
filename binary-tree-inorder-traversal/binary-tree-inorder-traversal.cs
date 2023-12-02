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
    public IList<int> InorderTraversal(TreeNode root) {
        
        List<int> results = new List<int>();
        Inorder(root, results);
        return results;
        
    }
    
    private void Inorder(TreeNode node, List<int> results){
        
        if(node == null) return;
        Inorder(node.left, results);
        results.Add(node.val);
        Inorder(node.right, results);
        
        
    }
}