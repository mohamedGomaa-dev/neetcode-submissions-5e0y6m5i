public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // create a dictionary for saving indexes of the arr
        // loop through the arr
        // sub target from current element
        // see if the current element exists in the hashmap
        // return the value of the element in the hashmap and i if it exists
        // else add current element to the hashmap
        // return arr any ways
        int[] result = new int[2];
        Dictionary<int, int> map = new Dictionary<int,int>();
        for (int i = 0; i< nums.Length; i++) {
            int diff = target - nums[i];
            if (map.ContainsKey(diff)) {
                result[0] = map[diff];
                result[1] = i;
                return result;
            }
            map[nums[i]] = i;
        }
        return result;
    }
}
