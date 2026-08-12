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
    
    IList<int> result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        performInorderBFS(root);
        return result;
    }
    
    public void performInorderBFS(TreeNode node){
        if(node == null) {
            return;
        }
        
        performInorderBFS(node.left);
        result.Add(node.val);
        performInorderBFS(node.right);
    }
}