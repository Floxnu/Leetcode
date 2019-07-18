class Solution {
    var maxToHouse : [Int] = [Int]()
    func rob(_ nums: [Int]) -> Int {
        if(nums.count < 1){
           return 0
        } else if nums.count < 3 {
            if nums.count == 1 {
                return nums [0]
            }
            return nums[0] > nums [1] ? nums[0] : nums [1]
        }
        maxToHouse = [Int](repeating: 0, count: nums.count)
        maxToHouse[0] = nums[0]
        maxToHouse[1] = nums[1]
        maxToHouse[2] = nums[0] + nums[2]
        var i = 3
        var currentMax = maxToHouse[2] > maxToHouse[1] ? maxToHouse[2] : maxToHouse [1]
        while i < nums.count {
            maxToHouse[i] = maxToHouse[i - 2] > maxToHouse [i - 3] ? maxToHouse[i - 2] + nums[i] : maxToHouse [i - 3] + nums[i]
            if maxToHouse[i] > currentMax{
                currentMax = maxToHouse[i]
            }
            i += 1
        }
        return currentMax
    }
}