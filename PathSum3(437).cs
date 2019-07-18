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
    public int PathSum(TreeNode root, int sum)
    {
        if (root == null) return 0;
        int numberOfSums = 0;
        findSumDFSIII(root, new List<int>(), 0, sum, ref numberOfSums);
        return numberOfSums;
    }

    public void findSumDFSIII(TreeNode rootNode, IList<int> currentValues, int currentTotal, int sumTarget, ref int numOfSums)
    {
        List<int> newList = new List<int>(currentValues);
        newList.Add(rootNode.val);
        for(int i = 0; i < newList.Count; i++)
        {
            if(newList.Count > 1 && i < newList.Count - 1)
            {
                newList[i] = newList[i] + rootNode.val;
            }
            
           if(newList[i] == sumTarget)
           {
                numOfSums += 1;
           }
        }
        if (rootNode.left == null && rootNode.right == null)
        {
            return;
        }
        if (rootNode.left != null)
        {
            findSumDFSIII(rootNode.left, newList, currentTotal + rootNode.val, sumTarget, ref numOfSums);
        }
        if (rootNode.right != null)
        {
            findSumDFSIII(rootNode.right, newList, currentTotal + rootNode.val, sumTarget, ref numOfSums);
        }

    }
}