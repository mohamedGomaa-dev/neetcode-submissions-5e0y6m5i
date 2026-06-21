public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        // [0,1,2,2,3,0,4,2], val = 2
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k++] = nums[i];
            } else
            {
                continue;
            }
        }
        return k;
    }
}