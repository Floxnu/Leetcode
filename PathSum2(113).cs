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
   public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
       if(root == null) return new List<IList<int>>();
        IList<IList<int>> sums = new List<IList<int>>();
        findSumDFSII(root, new List<int>(), 0, sum, ref sums);
        return sums;
    }

      public void findSumDFSII(TreeNode rootNode, IList<int> currentValues, int currentTotal, int sumTarget, ref IList<IList<int>> allSums)
    {
        List<int> newList = new List<int>(currentValues);
        newList.Add(rootNode.val);
        if (rootNode.left == null && rootNode.right == null)
        {
            if (currentTotal + rootNode.val == sumTarget)
            {
                 allSums.Add(newList);
            }
            return;
        }
        if (rootNode.left != null)
        {
            findSumDFSII(rootNode.left, newList, currentTotal + rootNode.val, sumTarget, ref allSums);
        }
        if (rootNode.right != null)
        {
            findSumDFSII(rootNode.right, newList, currentTotal + rootNode.val, sumTarget, ref allSums);
        }

    }
}