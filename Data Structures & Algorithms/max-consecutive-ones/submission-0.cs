public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        // we will loop through the entire array to find the maximum number of consecutive 1's in the array
        // we will keep track of max consecutive 1's (starting with zero) and current consecutive 1's
        // each time we encounter a 1, we will increment the current consecutive 1's count and check if it is greater than the max consecutive 1's count, if it is, we will update the max consecutive 1's count
        // if we encounter n != 1, we will reset the current consecutive 1's count to zero
        // we return max consecutive 1's count at the end of the loop

        int max = 0, count = 0;

        for (int i = 0; i  < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                if (count > max)
                {
                    max = count;
                }
            } else
            {
                
                count = 0;
            }
        }

        return max;
    }
}