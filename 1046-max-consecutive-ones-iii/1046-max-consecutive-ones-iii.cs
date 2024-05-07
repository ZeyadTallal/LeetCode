using System;

public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int max = 0;
        int zc = 0;
        int p1 = 0;

        for(int p2 = 0 ; p2 < nums.Length ; p2++) 
        {
            if(nums[p2] == 0)
            {
                zc++;
            } 

            while(zc > k)
            {
                if(nums[p1] == 0)
                {
                    zc--;
                }
                p1++;
            }
            
            max = Math.Max(max, p2 - p1 + 1);
        }
        return max;
    }
}
