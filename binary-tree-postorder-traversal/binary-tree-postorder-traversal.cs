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
    public IList<int> PostorderTraversal(TreeNode root) {
        List <int> results = new List<int>();
        
        Postorder(root, results);
        return results;
        
        
    }
    
    private void Postorder(TreeNode node, List<int> results){
        if(node == null) return;
        Postorder(node.left, results);
        Postorder(node.right, results);
        results.Add(node.val);
        
        
        
    }
}