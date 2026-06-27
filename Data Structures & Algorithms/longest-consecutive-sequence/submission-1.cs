public class Solution {
    public int LongestConsecutive(int[] nums) {
        // [0,3,2,5,4,6,1,1]
        // [0, 1, 1, 2, 3, 4, 5 ,6]
        // 
        if (nums.Length == 0) return 0;
        List<int> list = new List<int>(nums);
        list.Sort();
        int longest = 1;
        int current = 1;
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == list[i -1] + 1)
            {
                current++;
                longest = Math.Max(current, longest);

            } else if (list[i] == list[i-1])
            {
                continue;
            } else
            {
                longest = Math.Max(current, longest);
                current = 1;
            }
        }
        return longest;
    }
}
