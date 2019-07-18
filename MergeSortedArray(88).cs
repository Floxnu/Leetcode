public class Solution {
       public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0) return;
        int[] result = new int[m + n];
        int i = 0;
        int j = 0;
        int k = 0;
        while(i < m || j < n)
        {
            if(i == m)
            {
                result[k] = nums2[j];
                j++;
                k++;
            } else if (j == n){
                result[k] = nums1[i];
                i++;
                k++;
            }
            else if(nums1[i] < nums2[j])
            {
                result[k] = nums1[i];
                i++;
                k++;
            } else
            {
                result[k] = nums2[j];
                j++;
                k++;
            }
        }
        for(int x = 0; x < result.Length; x++)
        {
            nums1[x] = result[x];
        }
       
    }
}