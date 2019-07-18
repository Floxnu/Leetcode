public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!uniqueNumbers.Add(nums[i]))
            {
                return nums[i];
            }
        }
        return -1;
    }
}