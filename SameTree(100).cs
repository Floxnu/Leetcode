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
       public bool IsSameTree(TreeNode p, TreeNode q)
    {
        int[] treeOne = getTreeValuesAsArray(p);
        int[] treeTwo = getTreeValuesAsArray(q);
           
        if (treeOne.Length != treeTwo.Length) return false;
           
        for(int i = 0; i< treeOne.Length; i++)
        {
            if(treeOne[i] != treeTwo[i])
            {
                return false;
            }
        }
           
        return true;
    }
    public int[] getTreeValuesAsArray(TreeNode root)
    {
        if (root == null)
        {
            int[] result = { 0 };
            return result;
        }

        List<int> values = new List<int>();
        Queue<TreeNode> dfsQueue = new Queue<TreeNode>();
        dfsQueue.Enqueue(root);

        while (dfsQueue.Count > 0)
        {
            TreeNode currentNode = dfsQueue.Dequeue();
            values.Add(currentNode.val);
            if(currentNode.left != null)
            {
                dfsQueue.Enqueue(currentNode.left);
            } else
            {
                values.Add(0);
            }
            if (currentNode.right != null)
            {
                dfsQueue.Enqueue(currentNode.right);
            }
            else
            {
                values.Add(-1);
            }

        }

        return values.ToArray();
    }
}