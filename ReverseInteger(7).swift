class Solution {
    func reverse(_ x: Int) -> Int {
        let isNegative = x < 0
        let stringInt = String(abs(x))
        var reversedNumber = String(stringInt.reversed())
        if(isNegative){
            reversedNumber = "-" + reversedNumber
        }
        let output = Int(reversedNumber)!
        return abs(output) > Int32.max ? 0 : output
    }
}