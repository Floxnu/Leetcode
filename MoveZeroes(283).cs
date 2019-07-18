public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums.Length < 2) return;
        for(int i = 1; i < nums.Length; i++)
        {
            int currentIndex = i;
            while (currentIndex - 1 >= 0 && nums[currentIndex - 1] == 0)
            {
                nums[currentIndex - 1] = nums[currentIndex];
                nums[currentIndex] = 0;
                currentIndex = currentIndex - 1;
            }
        }
    }
}