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
    public IList<int> PreorderTraversal(TreeNode root) {
        
        List<int> results = new List<int>();
        
        Preorder(root, results);
        return results;
        
    }
    
    private void Preorder(TreeNode node, List<int> results){
        
        if(node == null){
            return;
        }
        
        results.Add(node.val);
        Preorder(node.left, results);
        Preorder(node.right, results);
        
    }
}