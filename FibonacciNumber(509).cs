public class Solution {
    public int Fib(int N)
    {
        if(N < 2)
        {
            if(N < 0)
            {
                return 0;
            }
            return N;
        }
        return Fib(N - 1) + Fib(N - 2);
    }
}