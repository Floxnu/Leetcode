public class Solution {
    public int ClimbStairs(int n)
    {
        if (n < 4)
        {
            return n;
        }
        List<int> stepsToStairs = new List<int>();

        for(int i = 0; i <= n; i++)
        {
            if (i < 4)
            {
                stepsToStairs.Add(i);
            } else
            {
                stepsToStairs.Add( (stepsToStairs[i-1] + stepsToStairs[i-2]) );
            }
        }

        return stepsToStairs[n];
    }
}