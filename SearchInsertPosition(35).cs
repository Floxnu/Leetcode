public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Length == 0) return 0;
        for(int i = 0; i < nums.Length; i++){
            if(target <= nums[i]){
                return i;
            }
        }
        return nums.Length;
    }
}