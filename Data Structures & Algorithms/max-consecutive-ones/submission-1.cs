public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxConsecutiveOnes = 0;
        int onesCount = 0;
        for (int i = 0; i< nums.Length; i++)
        {
            if (nums[i] == 1) {
                onesCount++;
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, onesCount);
            }
            else
            {
                
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, onesCount);
                onesCount = 0;
            }
        }
        return maxConsecutiveOnes;
    }
}