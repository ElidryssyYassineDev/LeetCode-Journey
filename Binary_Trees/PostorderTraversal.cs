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
public class Solution
{
    // List to store the result of postorder traversal
    private List<int> result = new List<int>();

    public IList<int> PostorderTraversal(TreeNode root)
    {
        PerformPostorderDFS(root);
        return result;
    }

    // Recursive helper method
    private void PerformPostorderDFS(TreeNode node)
    {
        // Base case
        if (node == null)
        {
            return;
        }

        // Traverse left subtree
        PerformPostorderDFS(node.left);

        // Traverse right subtree
        PerformPostorderDFS(node.right);

        // Process current node
        result.Add(node.val);
    }
}

