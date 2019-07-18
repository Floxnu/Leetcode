class Solution {
    func addDigits(_ num: Int) -> Int {
        var numString = String(num)
        while numString.count > 1 {
            let strArray = Array(numString).map {String($0)}
            let numArray = strArray.map {Int($0)!}
            var newTotal = 0
            for num in numArray {
                newTotal += num
            }
            numString = String(newTotal)
        }
        return Int(numString)!
    }
}