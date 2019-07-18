public class Solution {
    public int FindComplement(int num) {
        List<int> bits = new List<int>();
        while(num != 0)
        {
            bits.Add(num % 2);
            num = num / 2;
        }
        int newTotal = 0;
        for(int i = 0; i < bits.Count; i++)
        {
            bits[i] = bits[i] == 1 ? 0 : 1;
            newTotal += (int)(System.Math.Pow(2, i)) * bits[i]; 
        }
        return newTotal;
    }
}