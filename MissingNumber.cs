public class Solution {
    public int MissingNumber(int[] nums)
    {
        if(nums.Length < 1){return 0;}
        bool[] numsUsed = new bool[nums.Length+1];
        for(int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            numsUsed[currentNum] = true;
        }
        for (int i = 0; i < numsUsed.Length; i++)
        {
            if(numsUsed[i] == false)
            {
                return i;
            }
        }
        return -1;
    }
}