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
public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        bool isEven = true;
        findDepthsDFS(root, ref isEven, 0);

        return isEven;
    }

    public int findDepthsDFS(TreeNode rootNode, ref bool even, int currentDepth)
    {
        int leftEnd = currentDepth;
        int rightEnd = currentDepth;
        if (rootNode.left != null)
        {
            leftEnd = findDepthsDFS(rootNode.left,ref even, currentDepth + 1);
        }
        if (rootNode.right != null)
        {
            rightEnd = findDepthsDFS(rootNode.right, ref even, currentDepth + 1);
        }
        if(System.Math.Abs(leftEnd - rightEnd) > 1)
        {
            even = false;
        }
        return leftEnd > rightEnd ? leftEnd : rightEnd;
    }
}