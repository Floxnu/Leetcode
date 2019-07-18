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
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root.val == val)
        {
            return root;
        }
        else
        {
            if(val < root.val)
            {
                if (root.left == null) return null;
                return SearchBST(root.left, val);
            }
            if (root.right == null) return null;
            return SearchBST(root.right, val);
        }
    }
}