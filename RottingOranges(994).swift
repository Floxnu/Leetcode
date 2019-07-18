class Solution {
 func orangesRotting(_ grid: [[Int]]) -> Int {
    var gridCopy = grid
    var changes = 1
    var steps = 0
    
    var numOfOne = 0
    for rows in gridCopy {
        for oranges in rows {
            if oranges == 1{
                numOfOne += 1
            }
        }
    }
    if numOfOne == 0 {
        return 0
    }
    
    while changes > 0 {
        var visited: [[Bool]] = [[Bool]](repeating: [Bool](repeating: false, count: gridCopy[0].count), count: gridCopy.count)
        changes = 0
        for y in 0..<gridCopy.count {
            for x in 0..<gridCopy[y].count {
                if(gridCopy[y][x] == 1){
                    if(x > 0) {
                        if(gridCopy[y][x - 1] == 2 && !visited[y][x - 1]){
                            gridCopy[y][x] = 2
                            visited[y][x] = true
                            changes += 1
                        }
                    }
                    if(x < gridCopy[y].count - 1){
                        if(gridCopy[y][x + 1] == 2 && !visited[y][x + 1]){
                            gridCopy[y][x] = 2
                            visited[y][x] = true
                            changes += 1
                        }
                    }
                    if(y > 0){
                        if(gridCopy[y - 1][x] == 2 && !visited[y - 1][x]){
                            gridCopy[y][x] = 2
                            visited[y][x] = true
                            changes += 1
                        }
                    }
                    if(y < gridCopy.count - 1){
                        if(gridCopy[y + 1][x] == 2 && !visited[y + 1][x]){
                            gridCopy[y][x] = 2
                            visited[y][x] = true
                            changes += 1
                        }
                    }
                }
            }
        }
        if(changes > 0){
            
            steps += 1
        }
    }
    for rows in gridCopy {
        for oranges in rows {
            if oranges == 1{
                return -1
            }
        }
    }
    return steps
}



}