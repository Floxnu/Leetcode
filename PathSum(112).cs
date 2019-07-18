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
     public bool HasPathSum(TreeNode root, int sum)
    {
        if(root == null) return false;
        bool hasSum = false;
        findSumDFS(root, ref hasSum, 0, sum);

        return hasSum;
    }

    public void findSumDFS(TreeNode rootNode, ref bool hasSum, int currentTotal, int sumTarget)
    {
        if (rootNode.left == null && rootNode.right == null)
        {
            if(currentTotal + rootNode.val == sumTarget)
            {
                hasSum = true;
            }
            return;
        }
        if (rootNode.left != null)
        {
            findSumDFS(rootNode.left, ref hasSum, currentTotal + rootNode.val, sumTarget);
        }
        if (rootNode.right != null)
        {
            findSumDFS(rootNode.right, ref hasSum, currentTotal + rootNode.val, sumTarget);
        }
   
    }
}