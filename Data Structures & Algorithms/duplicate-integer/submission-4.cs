public class Solution {
    public bool hasDuplicate(int[] nums) {
        // create a hashmap/set
        // loop through nums
        // if set contains num return true
        // add num if set doesn't contain it
        // return false if the loop ends

        HashSet<int> uniques = new HashSet<int>();
        foreach (var num in nums) {
            if (uniques.Contains(num)) {
                return true;
            } else {
                uniques.Add(num);
            }
        }
        return false;
    }
}