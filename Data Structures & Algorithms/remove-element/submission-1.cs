public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        // initialize a pointer k to keep track of last valid position
        // iterate through the array with another pointer i
        // if (nums[i] != val), we copy nums[i] to nums[k] and increment k
        // we return k
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}