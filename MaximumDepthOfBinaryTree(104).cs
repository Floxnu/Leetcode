/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
       public int MaxDepth(TreeNode root)
    {
        if(root == null) return 0;
        int maxDepth = 1;
        maxDepthBFS(root, 1, ref maxDepth);
        return maxDepth;
    }
    public void maxDepthBFS(TreeNode rootNode, int depth, ref int max)
    {

        if (rootNode.left == null && rootNode.right == null)
        {
            if(depth > max)
            {
                max = depth;
            }
            return;
        }
        if (rootNode.left != null)
        {
            maxDepthBFS(rootNode.left, depth + 1, ref max);
        }
        if (rootNode.right != null)
        {
            maxDepthBFS(rootNode.right, depth + 1, ref max);
        }
    }
}