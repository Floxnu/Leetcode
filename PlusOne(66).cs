public class Solution {
    public int[] PlusOne(int[] digits) {
                 if(digits.Length == 0)
        {
            return digits;
        }
        if(digits.Length == 1)
        {
            digits[0] = digits[0] + 1;
            if(digits[0] > 9)
            {
               int[] biggerDigits = { 1, 0 };
                return biggerDigits;
            }
            return digits;
        }
        int numToAdd = 1;
        List<int> newDigits = new List<int>(digits);
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            newDigits[i] = digits[i] + numToAdd;
            if(newDigits[i] > 9)
            {
                newDigits[i] = 0;
                numToAdd = 1;
            } else
            {
                numToAdd = 0;
            }
        }
        if(numToAdd == 1)
        {
            newDigits.Insert(0, 1);
        }
        return newDigits.ToArray();
    }
}