class Solution {
    var uniquePathsToNode: [[Int]] = [[Int]](repeating: [Int](repeating: 0, count: 100), count: 100)
    func uniquePaths(_ m: Int, _ n: Int) -> Int {
        uniquePathsToNode[0][0] = 1
        for y in 0..<n {
            for x in 0..<m {
                if uniquePathsToNode[y][x] == 0{
                    if(y > 0){
                        uniquePathsToNode[y][x] += uniquePathsToNode[y - 1][x]
                    }
                    if (x>0){
                        uniquePathsToNode[y][x] += uniquePathsToNode[y][x-1]
                    }
                }
            }
        }
        return uniquePathsToNode[n-1][m-1]
    }
}