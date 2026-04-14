public class Solution
{
    public int Search(int[] nums, int target)
    {
        // Init a left pointer to the index 0
        // Init a right pointer to index Length - 1
        // Init a mid pointer (left + right) / 2
        // if target == nums[mid] return mid
        // else if target > nums[mid] then left = mid + 1
        // else if target < nums[mid] then right = mid - 1
        // reverse the loop and init the mid again and stop when left > right

        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            } else if (nums[mid] > target)
            {
                right = mid - 1;
            }else
            {
                left = mid + 1;
            }
        }

        return -1;
    }
}
