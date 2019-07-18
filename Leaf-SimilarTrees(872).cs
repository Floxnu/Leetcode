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
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        if((root1 == null && root2 != null) || (root1 != null && root2 == null)){
            return false;
        }
        List<int> firstTreeValues = new List<int>();
        List<int> secondTreeValues = new List<int>();
        addLeafsDFS(ref firstTreeValues, root1);
        addLeafsDFS(ref secondTreeValues, root2);
        int i = 0;
        int j = 0;
        while (i < firstTreeValues.Count && j < secondTreeValues.Count)
        {
            if (firstTreeValues[i] != secondTreeValues[i]) {return false;}
            i++;
            j++;
        }
        return true;

    }
    public void addLeafsDFS(ref List<int> nodes, TreeNode rootNode)
    {
        if(rootNode.left == null && rootNode.right == null)
        {
            nodes.Add(rootNode.val);
            return;
        }
        if(rootNode.left != null)
        {
            addLeafsDFS(ref nodes, rootNode.left);
        }
        if(rootNode.right != null)
        {
            addLeafsDFS(ref nodes, rootNode.right);
        }
    }
}