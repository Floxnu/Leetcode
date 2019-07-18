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
        public TreeNode SortedArrayToBST(int[] nums)
    {
        if(nums.Length < 1)
        {
            return null;
        }
        if(nums.Length > 1)
        {
            int midPoint = nums.Length / 2;
            TreeNode head = new TreeNode(nums[midPoint]);
            int arrayIndexLeft = midPoint - 1;
            int arrayIndexRight = midPoint + 1;
            TreeNode currentNode = head;
            currentNode.left = SortArrayHelper(nums, 0, arrayIndexLeft);
            currentNode.right = SortArrayHelper(nums, arrayIndexRight, nums.Length - 1);
            return head;
        }
        return new TreeNode(nums[0]);

    }
    public TreeNode SortArrayHelper(int[] nums, int leftIndex, int rightIndex)
    {
        if(rightIndex == 0)
        {
            return new TreeNode(nums[0]);
        } else if (leftIndex == rightIndex)
        {
            return new TreeNode(nums[rightIndex]);
        } else if(rightIndex < 0 || leftIndex > rightIndex){
            return null;
        }
        int midpoint = (leftIndex + rightIndex) / 2;
        TreeNode newNode = new TreeNode(nums[midpoint]);
        newNode.left = SortArrayHelper(nums, leftIndex, midpoint - 1); 
        newNode.right = SortArrayHelper(nums, midpoint + 1, rightIndex);
        return newNode;
    }
}