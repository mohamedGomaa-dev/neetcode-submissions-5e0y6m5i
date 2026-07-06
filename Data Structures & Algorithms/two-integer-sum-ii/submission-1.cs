public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            if (target == numbers[left] + numbers[right])
            {
                result[0] = left + 1;
                result[1] = right + 1;
                return result;
            } else if (target < numbers[left] + numbers[right])
            {
                right--;
            } else
            {
                left++;
            }
        }
        return result;
    }
}
