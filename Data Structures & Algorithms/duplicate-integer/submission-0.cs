public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniques = new HashSet<int>();

foreach (var num in nums)
{
    if (uniques.Contains(num))
    {
        return true;
    } else
    {
        uniques.Add(num);
    }
}

return false;
    }
}