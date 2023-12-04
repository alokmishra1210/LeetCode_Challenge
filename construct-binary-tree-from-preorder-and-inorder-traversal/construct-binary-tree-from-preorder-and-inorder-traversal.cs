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
    private Dictionary <int, int> inorderindexmap;
    private int preindex;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        preindex =0;
        inorderindexmap = new Dictionary<int, int>();
        for(int i=0; i<inorder.Length; i++){
            inorderindexmap[inorder[i]]=i;
        }
        return BuildTreeRecursively(preorder, 0, inorder.Length-1);
    }
    
    private TreeNode BuildTreeRecursively(int[] preorder,int left, int right){
        
        if(left>right) return null;
        int rootvalue = preorder[preindex++];
        TreeNode root = new TreeNode(rootvalue);
        
        root.left = BuildTreeRecursively(preorder, left, inorderindexmap[rootvalue]-1);
        root.right = BuildTreeRecursively(preorder, inorderindexmap[rootvalue]+1, right);
        
        return root;
        
        
    }
    
}