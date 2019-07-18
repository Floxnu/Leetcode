public class Solution {
public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int[,] pathsGrid = new int[obstacleGrid.Length, obstacleGrid[0].Length];
        pathsGrid[0,0] = 1;
        
        if(obstacleGrid[0][0] == 1) { return 0; }
        if(obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1){return 0;}
    
        for(int y = 0; y < obstacleGrid.Length; y++)
        {
            for(int x = 0; x < obstacleGrid[0].Length; x++)
            {
                if(x - 1 >= 0)
                {
                    if(obstacleGrid[y][x - 1] != 1)
                    {
                        pathsGrid[y, x] += pathsGrid[y, x - 1];
                    }
                }
                if (y - 1 >= 0)
                {
                    if (obstacleGrid[y - 1][x] != 1)
                    {
                        pathsGrid[y, x] += pathsGrid[y - 1, x];
                    }
                }
            }
        }
        return pathsGrid[obstacleGrid.Length - 1, obstacleGrid[0].Length - 1];
    }
}