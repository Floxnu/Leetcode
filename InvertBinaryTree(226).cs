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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null){
            return null;
        }
        InvertTree(root.right);
        InvertTree(root.left);
        TreeNode temp = root.right;
        root.right = root.left;
        root.left = temp;
        
        return root;
    }
}