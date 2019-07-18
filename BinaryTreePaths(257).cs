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
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> allPaths = new List<string>();
        if (root == null) return allPaths;
        string stringStart = string.Format("{0}", root.val);
        GetPathsDFS(root, stringStart, ref allPaths, 0);
        return allPaths;
                
    }

    public void GetPathsDFS(TreeNode rootNode, string currentString, ref List<string> allPaths, int depth)
    {
        if(depth > 0)
        {
            currentString += string.Format("->{0}", rootNode.val);
        }
        if (rootNode.left == null && rootNode.right == null)
        {
            allPaths.Add(currentString);
            return;
        }
        if (rootNode.left != null)
        {
           GetPathsDFS(rootNode.left, currentString, ref allPaths, depth+1);
        }
        if (rootNode.right != null)
        {
            GetPathsDFS(rootNode.right, currentString, ref allPaths, depth+1);
        }
    }
}