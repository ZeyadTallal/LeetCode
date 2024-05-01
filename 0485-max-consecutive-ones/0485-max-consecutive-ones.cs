public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count =0 ;
        int max = 0 ;
        for(int i =0 ; i < nums.Length ; i++)
        {
            if(nums[i] == 1)
            {
                count++;
            }
            else
            {
                if(max < count)
                {
                    max = count;
                }
                count = 0;

            }
        }
        return Math.Max(max,count);
    }
}