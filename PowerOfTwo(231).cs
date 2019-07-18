public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n == 1) return true;
        if (n % 2 != 0 || n == 0 || n < 0) return false;
        int currentTotal = n;
        while (currentTotal > 1)
        {
            if(currentTotal % 2 != 0)
            {
                return false;
            }
            currentTotal = currentTotal / 2;

        }
        return true;
    }
}