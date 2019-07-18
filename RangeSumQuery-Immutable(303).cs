public class NumArray
{

    public int[] numArray;
    public NumArray(int[] nums)
    {
        numArray = nums;
    }

    public int SumRange(int i, int j)
    {
        int sum = 0;
        for(int x = i; i <= j; i++)
        {
            sum += numArray[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */