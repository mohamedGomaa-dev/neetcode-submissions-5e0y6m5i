public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLen = 0;
        int l = 0;
        HashSet<char> set = new();
        for (int r = 0; r < s.Length; r++) {
            while (set.Contains(s[r])) {
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            int len = r - l + 1;
            maxLen = Math.Max(maxLen, len);
        }
        return maxLen;
    }
}
